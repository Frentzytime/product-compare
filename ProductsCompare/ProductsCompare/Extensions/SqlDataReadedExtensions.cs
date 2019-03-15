using System;
using System.Data.SqlClient;

namespace ProductsCompare.Extensions
{
	public static class SqlDataReaderExtensions
	{
		public static bool IsDBNull(this SqlDataReader reader, string columnName)
		{
			return reader.IsDBNull(reader.GetOrdinal(columnName));
		}

		public static object GetValue(this SqlDataReader reader, string columnName)
		{
			return reader.GetValue(reader.GetOrdinal(columnName));
		}

		public static Int32 GetInt32(this SqlDataReader reader, string columnName)
		{
			return reader.GetInt32(reader.GetOrdinal(columnName));
		}

		public static Int64 GetInt64(this SqlDataReader reader, string columnName)
		{
			return reader.GetInt64(reader.GetOrdinal(columnName));
		}

		public static string GetString(this SqlDataReader reader, string columnName)
		{
			return reader.GetString(reader.GetOrdinal(columnName));
		}

		public static Boolean GetBoolean(this SqlDataReader reader, string columnName)
		{
			return reader.GetBoolean(reader.GetOrdinal(columnName));
		}
	}
}
