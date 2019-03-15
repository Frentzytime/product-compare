namespace ProductsCompare
{
	public class Property
	{
		public string Attribute { get; private set; }
		public string Value { get; private set; }

		public Property(string attribute = "", string value = "")
		{
			Attribute = attribute;
			Value = value;
		}
	}
}
