using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProductsCompare.Extensions;

namespace ProductsCompare.DataSources
{
	public class SqlSource : IDataSource
	{
		private readonly string _connectionString;

		public SqlSource(string connectionString)
		{
			_connectionString = connectionString;
		}

		public bool TestConnection()
		{
			try
			{
				using (var connection = new SqlConnection(_connectionString))
				{
					connection.Open();
				}
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

			using (var connection = new SqlConnection(_connectionString))
			{
				var commandText = @"SELECT [Products].[Id] AS 'Id', [Products].[Name] AS 'Name', [Categories].[Name] AS 'Category'
					FROM [Products]
					JOIN Categories ON CategoryId = Categories.Id
				";
				var command = new SqlCommand(commandText, connection);

				try
				{
					connection.Open();

					var reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							var productId = 0; if (!reader.IsDBNull("Id")) { productId = reader.GetInt32("Id"); }
							var productName = ""; if (!reader.IsDBNull("Name")) { productName = reader.GetString("Name"); }
							var productCategory = ""; if (!reader.IsDBNull("Category")) { productCategory = reader.GetString("Category"); }


							var product = new Product(productName, productCategory);
							product.AddRange(GetSections(productId));


							results.Add(new ProductWrapper(product, SourceType.Sql));
						}
					}
					reader.Close();
				}
				catch (Exception)
				{
					throw;
				}
			}

			return results;
		}

		private IList<Section> GetSections(int productId)
		{
			var results = new List<Section>();

			using (var connection = new SqlConnection(_connectionString))
			{
				var commandText = @"SELECT [Sections].[Id] AS 'Id', [Sections].[Name] AS 'Name'
					FROM [Properties]
					JOIN [Sections] ON [SectionId] = [Sections].[Id]
					WHERE [ProductId] = @productId
					GROUP BY [Sections].[Name], [Sections].[Id]
				";
				var command = new SqlCommand(commandText, connection);
				command.AddParameter("@productId", SqlDbType.Int, productId);

				try
				{
					connection.Open();

					var reader = command.ExecuteReader();

					while (reader.Read())
					{
						var sectionId = 0; if (!reader.IsDBNull("Id")) { sectionId = reader.GetInt32("Id"); }
						var sectionName = ""; if (!reader.IsDBNull("Name")) { sectionName = reader.GetString("Name"); }

						var section = new Section(sectionName);
						section.AddRange(GetProperties(productId, sectionId));

						results.Add(section);
					}
				}
				catch (Exception)
				{
					throw;
				}
			}

			return results;
		}

		private IList<Property> GetProperties(int productId, int sectionId)
		{
			var results = new List<Property>();

			using (var connection = new SqlConnection(_connectionString))
			{
				var commandText = @"SELECT [Attributes].[Name] AS 'Attribute', [Properties].[Value] AS 'Value'
					FROM [Properties]
					JOIN [Attributes] ON [AttributeId] = [Attributes].[Id]
					WHERE [ProductId] = @productId AND [SectionId] = @sectionId
				";
					var command = new SqlCommand(commandText, connection);
				command.AddParameter("@productId", SqlDbType.Int, productId);
				command.AddParameter("@sectionId", SqlDbType.Int, sectionId);

				try
				{
					connection.Open();

					var reader = command.ExecuteReader();

					while (reader.Read())
					{
						var attribute = ""; if (!reader.IsDBNull("Attribute")) { attribute = reader.GetString("Attribute"); }
						var value = ""; if (!reader.IsDBNull("Value")) { value = reader.GetString("Value"); }

						results.Add(new Property(attribute, value));
					}
				}
				catch (Exception)
				{
					throw;
				}
			}

			return results;
		}
	}
}
