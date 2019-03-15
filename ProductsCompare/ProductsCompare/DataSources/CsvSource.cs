using System.Collections.Generic;

namespace ProductsCompare.DataSources
{
	public class CsvSource : IDataSource
	{
		private readonly string _filePath;

		public CsvSource(string filePath)
		{
			_filePath = filePath;
		}

		public IList<ProductWrapper> GetAll()
		{
			var results = new List<ProductWrapper>();

			return results;
		}

		public bool TestConnection()
		{
			return false;
		}
	}
}
