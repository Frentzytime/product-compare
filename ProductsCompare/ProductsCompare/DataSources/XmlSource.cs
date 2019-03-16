using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductsCompare.DataSources
{
	public class XmlSource : IDataSource
	{
		private readonly string _filePath;

		public XmlSource(string filePath)
		{
			_filePath = filePath;
		}

		public bool TestConnection()
		{
			try
			{
				var reader = new StreamReader(_filePath);
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public IList<ProductWrapper> GetAll()
		{
			var results = new List<ProductWrapper>();

			try
			{
				var xdoc = XDocument.Load(_filePath);

				results = (from product in xdoc.Root.Elements("product")
						   select
							new ProductWrapper(
								new Product(
									(
										from section in product.Elements("sections").Elements("section")
										select new Section(
											(
												from property in section.Elements("properties").Elements("property")
												select new Property(
													attribute: (string)property.Element("attribute"),
													value: (string)property.Element("value")
												)
											).ToList(),
											(string)section.Element("name")
										)
									).ToList(),
									id: (int)product.Element("id"),
									name: (string)product.Element("name"),
									category: (string)product.Element("category")
								),
								SourceType.Xml
							)
						   ).ToList();
			}
			catch (Exception)
			{

				throw;
			}

			return results;
		}
	}
}
