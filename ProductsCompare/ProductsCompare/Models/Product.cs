using System.Collections.Generic;

namespace ProductsCompare
{
	public class Product
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Category { get; private set; }
		public IList<Section> Sections { get; private set; }

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
	}
}
