namespace ProductsCompare
{
	public class Property
	{
		public string Attribute { get; private set; }
		public string Value { get; private set; }
		public bool IsEmpty => Value.Length <= 0 && Attribute.Length <= 0;

		public Property(string attribute = "", string value = "")
		{
			Attribute = attribute;
			Value = value;
		}

		public override string ToString() => $"{Attribute}: {Value}";
	}
}
