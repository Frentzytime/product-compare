using System.Collections.Generic;

namespace ProductsCompare
{
	public class Product
	{
		public string Name { get; private set; }
		public string Category { get; private set; }
		public IList<Section> Sections { get; private set; }

		public Product(string name = "", string category = "") : this(new List<Section>(), name, category)
		{
		
		}

		public Product(IList<Section> sections, string name = "", string category = "")
		{
			Sections = sections;
			Name = name;
			Category = category;
		}

		public void Add(Section section)
		{
			Sections.Add(section);
		}

		public void AddRange(IList<Section> sections)
		{
			(Sections as List<Section>).AddRange(sections);
		}
	}
}
