using ProductsCompare.DataSources;

using System;
using System.Collections.Generic;
using System.Drawing;
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
				var panel = new Panel
				{
					BackColor = Color.Transparent,
					Height = flowLayoutPanelProducts.Height - 18,
					Location = new Point(0, 0),
					Margin = Padding.Empty
				};

				var name = new Label()
				{
					Text = product.Product.Name,
					Height = 20
				};
				panel.Controls.Add(name);


				var tv = new TreeView
				{
					Location = new Point(0, name.Location.Y + 24),
					Width = panel.Width,
					Height = panel.Height - name.Height - 2,
					Margin = Padding.Empty,
					BorderStyle = BorderStyle.None,
					BackColor = Color.WhiteSmoke,
					Anchor = AnchorStyles.Bottom | AnchorStyles.Top
				};
				foreach (var section in product.Product.Sections)
				{
					var tn = new TreeNode(section.Name);
					foreach (var property in section.Properties)
					{
						if (!property.IsEmpty)
						{
							var tnp = new TreeNode(property.ToString());
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
				if (ctrl is Panel panel)
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
