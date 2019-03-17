using System.Collections.Generic;

namespace ProductsCompare
{
	public class Section
	{
		public string Name { get; private set; }
		public IList<Property> Properties { get; private set; }

		public Section(string name = "") : this(new List<Property>(), name)
		{
		}

		public Section(IList<Property> properties, string name = "")
		{
			Properties = properties;
			Name = name;
		}

		public void Add(Property property)
		{
			Properties.Add(property);
		}

		public void AddRange(IList<Property> properties)
		{
			(Properties as List<Property>).AddRange(properties);
		}

		public override string ToString() => $"{Name} [{Properties.Count}]";
	}
}
