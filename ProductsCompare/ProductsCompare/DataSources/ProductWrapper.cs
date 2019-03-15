namespace ProductsCompare.DataSources
{
	public enum SourceType
	{
		InMemory,
		Sql,
		Csv,
		Xml
	}

	public class ProductWrapper
	{
		public SourceType Source { get; set; }

		public Product Product { get; set; }

		public ProductWrapper(Product product, SourceType source = SourceType.InMemory)
		{
			Product = product;
			Source = source;
		}
	}
}
