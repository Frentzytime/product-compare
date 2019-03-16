using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using ProductsCompare.Extensions;

namespace ProductsCompare.DataSources
{
	public class CsvSource : IDataSource
	{
		private readonly string _filePath;

		public CsvSource(string filePath)
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
				var parser = new TextFieldParser(_filePath);
				parser.TextFieldType = FieldType.Delimited;
				parser.SetDelimiters(",");

				var rows = new List<string[]>();
				while (!parser.EndOfData)
				{
					var row = parser.ReadFields();
					rows.Add(row);
				}
				rows.RemoveAt(0);

				foreach (var prod in rows)
				{
					var p = ParseProduct(prod);
					results.Add(new ProductWrapper(p, SourceType.Csv));
				}
			}
			catch (Exception)
			{
				throw;
			}

			return results;
		}

		private Product ParseProduct(string[] str)
		{
			if (str.Length < 4)
			{
				throw new InvalidDataException();
			}
			else
			{
				int.TryParse(str[0], out int prodId);
				var prodName = str[1];
				var prodCateg = str[2];

				int.TryParse(str[3], out int sec_count);
				var sections = ParseSections(str.SubArray(4, str.Length-4), sec_count);
				return new Product(sections, prodId, prodName, prodCateg);
			}
		}

		private IList<Section> ParseSections(string[] str, int count)
		{
			var sections = new List<Section>();
			int offset = 0;
			for (int i = 0; i < count; i++)
			{
				var secName = str[offset + 0];
				int.TryParse(str[offset + 1], out int prop_count);
				var properties = ParseProperties(str.SubArray(2, prop_count*2), prop_count);
				sections.Add(new Section(properties, secName));
				offset += 2 + prop_count * 2;
			}

			return sections;
		}

		private IList<Property> ParseProperties(string[] str, int count)
		{
			var properties = new List<Property>();

			for (int i = 0; i < count*2; i+=2)
			{
				var attr = str[i + 0];
				var val = str[i + 1];
				properties.Add(new Property(attr, val));
			}

			return properties;
		}
	}
}
