﻿using ProductsCompare.DataSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsCompare
{
	public partial class ProductSelectionForm : Form
	{
		private IList<IDataSource> _dataSources;
		private IList<ProductWrapper> _wrappers;

		public ProductSelectionForm()
		{
			InitializeComponent();
			PrepareInterface();

			_dataSources = new List<IDataSource>();
			_wrappers = new List<ProductWrapper>();
		}

		private void PrepareInterface()
		{
			textBoxSqlServer.Enabled = checkBoxSqlServer.Checked;
			
			textBoxCsvFile.Enabled = checkBoxCsvFile.Checked;
			buttonBrowseCsv.Enabled = checkBoxCsvFile.Checked;
			
			textBoxXmlFile.Enabled = checkBoxXmlFile.Checked;
			buttonBrowseXml.Enabled = checkBoxXmlFile.Checked;
		}

		#region Events
		private void checkBoxSqlServer_CheckedChanged(object sender, EventArgs e)
		{
			textBoxSqlServer.Enabled = checkBoxSqlServer.Checked;
		}

		private void checkBoxCsvFile_CheckedChanged(object sender, EventArgs e)
		{
			textBoxCsvFile.Enabled = checkBoxCsvFile.Checked;
			buttonBrowseCsv.Enabled = checkBoxCsvFile.Checked;
		}

		private void buttonBrowseCsv_Click(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
				dialog.Title = "Browse for CSV files";
				dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					textBoxCsvFile.Text = dialog.FileName;
				}
			}
		}

		private void checkBoxXmlFile_CheckedChanged(object sender, EventArgs e)
		{
			textBoxXmlFile.Enabled = checkBoxXmlFile.Checked;
			buttonBrowseXml.Enabled = checkBoxXmlFile.Checked;
		}

		private void buttonBrowseXml_Click(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
				dialog.Title = "Browse for XML files";
				dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					textBoxXmlFile.Text = dialog.FileName;
				}
			}
		}

		private void buttonFetch_Click(object sender, EventArgs e)
		{
			CreateDataSources();

			if (_dataSources.Count < 1)
			{
				MessageBox.Show("No data sources selected!", "Warning");
			}
			else
			{
				try
				{
					_wrappers.Clear();
					listViewProducts.Groups.Clear();
					listViewProducts.Columns.Clear();
					listViewProducts.Items.Clear();

					foreach (var source in _dataSources)
					{
						(_wrappers as List<ProductWrapper>).AddRange(source.GetAll());
					}

					PopulateListView();
				}
				catch (Exception)
				{
					throw;
				}
			}
		}

		private void buttonCompare_Click(object sender, EventArgs e)
		{
			Hide();
			var compare = new ProductsComparationForm();
			compare.FormClosed += (s, args) => Show();
			compare.Feed(_wrappers.Where(x => x.Selected).ToList());
			compare.Show();
		}
		#endregion

		private void CreateDataSources()
		{
			_dataSources.Clear();

			if (checkBoxSqlServer.Checked)
			{
				var sqlSource = new SqlSource(textBoxSqlServer.Text);
				if (!sqlSource.TestConnection())
				{
					MessageBox.Show("Could not connect to database. Please check the connection string.", "Error");
				}
				else
				{
					_dataSources.Add(sqlSource);
				}
			}

			if (checkBoxCsvFile.Checked)
			{
				var csvSource = new CsvSource(textBoxCsvFile.Text);
				if (!csvSource.TestConnection())
				{
					MessageBox.Show("Could not find the CSV file. Please check the path to the file.", "Error");
				}
				else
				{
					_dataSources.Add(csvSource);
				}
			}

			if (checkBoxXmlFile.Checked)
			{
				var xmlSource = new XmlSource(textBoxXmlFile.Text);
				if (!xmlSource.TestConnection())
				{
					MessageBox.Show("Could not find the XML file. Please check the path to the file.", "Error");
				}
				else
				{
					_dataSources.Add(xmlSource);
				}
			}
		}

		private void PopulateListView()
		{
			var colName = new ColumnHeader
			{
				Text = "Name",
				Width = 80
			};
			listViewProducts.Columns.Add(colName);

			var colModel = new ColumnHeader
			{
				Text = "Model",
				Width = 140
			};
			listViewProducts.Columns.Add(colModel);

			var colOther = new ColumnHeader
			{
				Text = "Other"
			};
			listViewProducts.Columns.Add(colOther);

			var colSource = new ColumnHeader
			{
				Text = "Source"
			};
			listViewProducts.Columns.Add(colSource);

			foreach (var item in _wrappers)
			{
				var group = new ListViewGroup();
				var found = false;
				foreach (ListViewGroup gr in listViewProducts.Groups)
				{
					if (gr.Name == item.Product.Category.ToLower())
					{
						found = true;
						group = gr;
						break;
					}
				}
				if (!found)
				{
					group = new ListViewGroup(item.Product.Category.ToLower(), item.Product.Category);
					listViewProducts.Groups.Add(group);
				}


				var lvi = new ListViewItem(item.Product.Name, group);
				lvi.Tag = item.Product.Id.ToString();

				var atr = item.Product.Properties.Where(
						x => x.Attribute.ToLower() == "model" ||
						x.Attribute.ToLower() == "tip procesor" ||
						x.Attribute.ToLower() == "putere" ||
						x.Attribute.ToLower() == "volum total"
					).Take(2);
				for (int i = 0; i < 2; i++)
				{
					var prop = i < atr.Count() ? atr.ElementAt(i) : null;
					if (prop != null)
					{
						lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, prop.Value));
					}
					else
					{
						lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, ""));
					}
				}
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, item.Source.ToString()));
				listViewProducts.Items.Add(lvi);

				group.Header = $"{item.Product.Category} ({group.Items.Count})";
			}
		}

		private void listViewProducts_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (e.Item != null && _wrappers != null && _wrappers.Count > 0)
			{
				var prod = _wrappers.First(x => x.Product.Id.ToString() == e.Item.Tag.ToString());
				if (prod != null)
				{
					prod.Selected = e.Item.Checked;
				}
			}
		}
	}
}
