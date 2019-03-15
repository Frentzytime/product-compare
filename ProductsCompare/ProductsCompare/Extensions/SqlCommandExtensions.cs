using System.Data;
using System.Data.SqlClient;

namespace ProductsCompare.Extensions
{
	public static class SqlCommandExtensions
	{
		public static void AddParameter(this SqlCommand sqlCommand, string name, SqlDbType type, object value)
		{
			sqlCommand.Parameters.Add(name, type).Value = value;
		}
	}
}
