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
		public SourceType Source { get; private set; }

		public Product Product { get; private set; }

		public bool Selected { get; set; }

		public ProductWrapper(Product product, SourceType source = SourceType.InMemory)
		{
			Product = product;
			Source = source;
			Selected = false;
		}
	}
}
