using ProductsCompare.DataSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsCompare
{
	public partial class ProductsComparationForm : Form
	{
		private IList<ProductWrapper> _wrappers;

		public ProductsComparationForm()
		{
			InitializeComponent();
		}

		public void Feed(IList<ProductWrapper> products)
		{
			_wrappers = products;
			Populate();
		}

		private void Populate()
		{
			foreach (var product in _wrappers)
			{
				var panel = new Panel();
				panel.BackColor = Color.Transparent;
				panel.Height = flowLayoutPanelProducts.Height - 18;
				panel.Location = new Point(0, 0);
				panel.Margin = Padding.Empty;

				var name = new Label() { Text = product.Product.Name };
				name.Height = 20;
				panel.Controls.Add(name);


				var tv = new TreeView();
				tv.Location = new Point(0, name.Location.Y + 24);
				tv.Width = panel.Width;
				tv.Height = panel.Height - name.Height - 2;
				tv.Margin = Padding.Empty;
				tv.BorderStyle = BorderStyle.None;
				tv.BackColor = Color.Empty;
				foreach (var section in product.Product.Sections)
				{
					var tn = new TreeNode(section.Name);
					foreach (var property in section.Properties)
					{
						tn.Nodes.Add(new TreeNode($"{property.Attribute}: {property.Value}"));
					}
					tv.Nodes.Add(tn);
				}
				tv.ExpandAll();
				panel.Controls.Add(tv);

				flowLayoutPanelProducts.Controls.Add(panel);
			}
		}
	}
}
