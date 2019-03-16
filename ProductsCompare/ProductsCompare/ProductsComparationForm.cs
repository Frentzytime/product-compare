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
		private bool _highlightDifferences = true;

		public ProductsComparationForm()
		{
			InitializeComponent();
			checkBoxHighlightDifferences.Checked = _highlightDifferences;
		}

		public void Feed(IList<ProductWrapper> products)
		{
			_wrappers = products;
			Populate();
		}

		private void Populate()
		{
			flowLayoutPanelProducts.Controls.Clear();
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
				tv.BackColor = Color.WhiteSmoke;
				tv.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
				foreach (var section in product.Product.Sections)
				{
					var tn = new TreeNode(section.Name);
					foreach (var property in section.Properties)
					{
						var tnp = new TreeNode($"{property.Attribute}: {property.Value}");
						if (_highlightDifferences)
						{
							foreach (var pro in _wrappers)
							{
								if (!pro.Product.Contains(property))
								{
									tnp.BackColor = Color.Wheat;
									break;
								}
							}
						}
						tn.Nodes.Add(tnp);
					}
					tv.Nodes.Add(tn);
				}
				tv.ExpandAll();
				panel.Controls.Add(tv);

				flowLayoutPanelProducts.Controls.Add(panel);
			}
		}

		#region Events
		private void ProductsComparationForm_SizeChanged(object sender, EventArgs e)
		{
			foreach (var ctrl in flowLayoutPanelProducts.Controls)
			{
				var panel = ctrl as Panel;
				if (panel != null)
				{
					panel.Height = flowLayoutPanelProducts.Height - 18;
				}
			}
		}
		#endregion

		private void checkBoxHighlightDifferences_CheckedChanged(object sender, EventArgs e)
		{
			_highlightDifferences = checkBoxHighlightDifferences.Checked;
			updateProductDifferences();
		}

		private void updateProductDifferences()
		{
			Populate();
		}
	}
}
