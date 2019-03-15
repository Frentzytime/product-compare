using System.Collections.Generic;

namespace ProductsCompare.DataSources
{
	public class XmlSource : IDataSource
	{
		private readonly string _filePath;

		public XmlSource(string filePath)
		{
			_filePath = filePath;
		}

		public IList<ProductWrapper> GetAll()
		{
			var results = new List<ProductWrapper>();

			return results;
		}
	}
}
