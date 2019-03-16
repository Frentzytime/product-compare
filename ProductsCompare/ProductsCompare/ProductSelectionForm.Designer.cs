namespace ProductsCompare
{
	partial class ProductSelectionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonFetch = new System.Windows.Forms.Button();
			this.panelXml = new System.Windows.Forms.Panel();
			this.buttonBrowseXml = new System.Windows.Forms.Button();
			this.textBoxXmlFile = new System.Windows.Forms.TextBox();
			this.checkBoxXmlFile = new System.Windows.Forms.CheckBox();
			this.panelCsv = new System.Windows.Forms.Panel();
			this.buttonBrowseCsv = new System.Windows.Forms.Button();
			this.textBoxCsvFile = new System.Windows.Forms.TextBox();
			this.checkBoxCsvFile = new System.Windows.Forms.CheckBox();
			this.panelSql = new System.Windows.Forms.Panel();
			this.textBoxSqlServer = new System.Windows.Forms.TextBox();
			this.checkBoxSqlServer = new System.Windows.Forms.CheckBox();
			this.listViewProducts = new System.Windows.Forms.ListView();
			this.buttonCompare = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panelXml.SuspendLayout();
			this.panelCsv.SuspendLayout();
			this.panelSql.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.buttonFetch);
			this.splitContainer.Panel1.Controls.Add(this.panelXml);
			this.splitContainer.Panel1.Controls.Add(this.panelCsv);
			this.splitContainer.Panel1.Controls.Add(this.panelSql);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.listViewProducts);
			this.splitContainer.Panel2.Controls.Add(this.buttonCompare);
			this.splitContainer.Panel2.Controls.Add(this.label1);
			this.splitContainer.Size = new System.Drawing.Size(523, 450);
			this.splitContainer.SplitterDistance = 217;
			this.splitContainer.TabIndex = 0;
			// 
			// buttonFetch
			// 
			this.buttonFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonFetch.Location = new System.Drawing.Point(10, 415);
			this.buttonFetch.Name = "buttonFetch";
			this.buttonFetch.Size = new System.Drawing.Size(75, 23);
			this.buttonFetch.TabIndex = 3;
			this.buttonFetch.Text = "Fetch";
			this.buttonFetch.UseVisualStyleBackColor = true;
			this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
			// 
			// panelXml
			// 
			this.panelXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelXml.Controls.Add(this.buttonBrowseXml);
			this.panelXml.Controls.Add(this.textBoxXmlFile);
			this.panelXml.Controls.Add(this.checkBoxXmlFile);
			this.panelXml.Location = new System.Drawing.Point(10, 112);
			this.panelXml.Name = "panelXml";
			this.panelXml.Size = new System.Drawing.Size(200, 50);
			this.panelXml.TabIndex = 2;
			// 
			// buttonBrowseXml
			// 
			this.buttonBrowseXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBrowseXml.Location = new System.Drawing.Point(131, 27);
			this.buttonBrowseXml.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBrowseXml.Name = "buttonBrowseXml";
			this.buttonBrowseXml.Size = new System.Drawing.Size(66, 22);
			this.buttonBrowseXml.TabIndex = 3;
			this.buttonBrowseXml.Text = "Browse";
			this.buttonBrowseXml.UseVisualStyleBackColor = true;
			this.buttonBrowseXml.Click += new System.EventHandler(this.buttonBrowseXml_Click);
			// 
			// textBoxXmlFile
			// 
			this.textBoxXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxXmlFile.Location = new System.Drawing.Point(1, 28);
			this.textBoxXmlFile.Name = "textBoxXmlFile";
			this.textBoxXmlFile.Size = new System.Drawing.Size(127, 20);
			this.textBoxXmlFile.TabIndex = 1;
			// 
			// checkBoxXmlFile
			// 
			this.checkBoxXmlFile.AutoSize = true;
			this.checkBoxXmlFile.Checked = true;
			this.checkBoxXmlFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxXmlFile.Location = new System.Drawing.Point(3, 8);
			this.checkBoxXmlFile.Name = "checkBoxXmlFile";
			this.checkBoxXmlFile.Size = new System.Drawing.Size(67, 17);
			this.checkBoxXmlFile.TabIndex = 0;
			this.checkBoxXmlFile.Text = "XML File";
			this.checkBoxXmlFile.UseVisualStyleBackColor = true;
			this.checkBoxXmlFile.CheckedChanged += new System.EventHandler(this.checkBoxXmlFile_CheckedChanged);
			// 
			// panelCsv
			// 
			this.panelCsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCsv.Controls.Add(this.buttonBrowseCsv);
			this.panelCsv.Controls.Add(this.textBoxCsvFile);
			this.panelCsv.Controls.Add(this.checkBoxCsvFile);
			this.panelCsv.Location = new System.Drawing.Point(10, 56);
			this.panelCsv.Name = "panelCsv";
			this.panelCsv.Size = new System.Drawing.Size(200, 50);
			this.panelCsv.TabIndex = 1;
			// 
			// buttonBrowseCsv
			// 
			this.buttonBrowseCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.buttonBrowseCsv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonBrowseCsv.Location = new System.Drawing.Point(131, 27);
			this.buttonBrowseCsv.Margin = new System.Windows.Forms.Padding(0);
			this.buttonBrowseCsv.Name = "buttonBrowseCsv";
			this.buttonBrowseCsv.Size = new System.Drawing.Size(66, 22);
			this.buttonBrowseCsv.TabIndex = 2;
			this.buttonBrowseCsv.Text = "Browse";
			this.buttonBrowseCsv.UseVisualStyleBackColor = true;
			this.buttonBrowseCsv.Click += new System.EventHandler(this.buttonBrowseCsv_Click);
			// 
			// textBoxCsvFile
			// 
			this.textBoxCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCsvFile.Location = new System.Drawing.Point(1, 28);
			this.textBoxCsvFile.Name = "textBoxCsvFile";
			this.textBoxCsvFile.Size = new System.Drawing.Size(127, 20);
			this.textBoxCsvFile.TabIndex = 1;
			// 
			// checkBoxCsvFile
			// 
			this.checkBoxCsvFile.AutoSize = true;
			this.checkBoxCsvFile.Location = new System.Drawing.Point(3, 7);
			this.checkBoxCsvFile.Name = "checkBoxCsvFile";
			this.checkBoxCsvFile.Size = new System.Drawing.Size(66, 17);
			this.checkBoxCsvFile.TabIndex = 0;
			this.checkBoxCsvFile.Text = "CSV File";
			this.checkBoxCsvFile.UseVisualStyleBackColor = true;
			this.checkBoxCsvFile.CheckedChanged += new System.EventHandler(this.checkBoxCsvFile_CheckedChanged);
			// 
			// panelSql
			// 
			this.panelSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelSql.BackColor = System.Drawing.SystemColors.Control;
			this.panelSql.Controls.Add(this.textBoxSqlServer);
			this.panelSql.Controls.Add(this.checkBoxSqlServer);
			this.panelSql.Location = new System.Drawing.Point(10, 2);
			this.panelSql.Name = "panelSql";
			this.panelSql.Size = new System.Drawing.Size(200, 50);
			this.panelSql.TabIndex = 0;
			// 
			// textBoxSqlServer
			// 
			this.textBoxSqlServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSqlServer.Location = new System.Drawing.Point(0, 28);
			this.textBoxSqlServer.Name = "textBoxSqlServer";
			this.textBoxSqlServer.Size = new System.Drawing.Size(197, 20);
			this.textBoxSqlServer.TabIndex = 1;
			this.textBoxSqlServer.Text = "data source=localhost\\sqlexpress; initial catalog=Product-Compare;persist securit" +
    "y info=True; Integrated Security=SSPI;";
			// 
			// checkBoxSqlServer
			// 
			this.checkBoxSqlServer.AutoSize = true;
			this.checkBoxSqlServer.Checked = true;
			this.checkBoxSqlServer.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSqlServer.Location = new System.Drawing.Point(3, 8);
			this.checkBoxSqlServer.Name = "checkBoxSqlServer";
			this.checkBoxSqlServer.Size = new System.Drawing.Size(81, 17);
			this.checkBoxSqlServer.TabIndex = 0;
			this.checkBoxSqlServer.Text = "SQL Server";
			this.checkBoxSqlServer.UseVisualStyleBackColor = true;
			this.checkBoxSqlServer.CheckedChanged += new System.EventHandler(this.checkBoxSqlServer_CheckedChanged);
			// 
			// listViewProducts
			// 
			this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewProducts.CheckBoxes = true;
			this.listViewProducts.FullRowSelect = true;
			this.listViewProducts.Location = new System.Drawing.Point(3, 24);
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(287, 385);
			this.listViewProducts.TabIndex = 4;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			this.listViewProducts.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewProducts_ItemChecked);
			// 
			// buttonCompare
			// 
			this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCompare.Location = new System.Drawing.Point(3, 415);
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(85, 23);
			this.buttonCompare.TabIndex = 3;
			this.buttonCompare.Text = "Compare";
			this.buttonCompare.UseVisualStyleBackColor = true;
			this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select products for comparison";
			// 
			// ProductSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 450);
			this.Controls.Add(this.splitContainer);
			this.Name = "ProductSelectionForm";
			this.Text = "ProductSelectionForm";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panelXml.ResumeLayout(false);
			this.panelXml.PerformLayout();
			this.panelCsv.ResumeLayout(false);
			this.panelCsv.PerformLayout();
			this.panelSql.ResumeLayout(false);
			this.panelSql.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Panel panelCsv;
		private System.Windows.Forms.TextBox textBoxCsvFile;
		private System.Windows.Forms.CheckBox checkBoxCsvFile;
		private System.Windows.Forms.Panel panelSql;
		private System.Windows.Forms.TextBox textBoxSqlServer;
		private System.Windows.Forms.CheckBox checkBoxSqlServer;
		private System.Windows.Forms.Panel panelXml;
		private System.Windows.Forms.TextBox textBoxXmlFile;
		private System.Windows.Forms.CheckBox checkBoxXmlFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCompare;
		private System.Windows.Forms.Button buttonFetch;
		private System.Windows.Forms.ListView listViewProducts;
		private System.Windows.Forms.Button buttonBrowseXml;
		private System.Windows.Forms.Button buttonBrowseCsv;
	}
}