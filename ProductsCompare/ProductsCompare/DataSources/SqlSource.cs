using System.Collections.Generic;

namespace ProductsCompare.DataSources
{
	public class SqlSource : IDataSource
	{
		private readonly string _connectionString;

		public SqlSource(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IList<ProductWrapper> GetAll()
		{
			var results = new List<ProductWrapper>();

			return results;
		}
	}
}
