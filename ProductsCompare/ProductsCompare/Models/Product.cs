using System.Collections.Generic;

namespace ProductsCompare
{
	public class Product
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Category { get; private set; }
		public IList<Section> Sections { get; private set; }
		public IList<Property> Properties => getProperties();

		public Product(int id = 0, string name = "", string category = "") : this(new List<Section>(), id, name, category)
		{
		}

		public Product(IList<Section> sections, int id = 0, string name = "", string category = "")
		{
			Id = id;
			Name = name;
			Category = category;
			Sections = sections;
		}

		public void Add(Section section)
		{
			Sections.Add(section);
		}

		public void AddRange(IList<Section> sections)
		{
			(Sections as List<Section>).AddRange(sections);
		}

		private IList<Property> getProperties()
		{
			var props = new List<Property>();

			foreach (var section in Sections)
			{
				props.AddRange(section.Properties);
			}

			return props;
		}

		public bool Contains(Property property)
		{
			foreach (var pro in Properties)
			{
				if (pro.Attribute == property.Attribute &&
					pro.Value == property.Value)
				{
					return true;
				}
			}
			return false;
		}

		public override string ToString() => $"{Category}/{Name} [{Sections.Count}]";
	}
}
