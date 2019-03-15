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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroupa", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroupb", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "fs",
            "a",
            "b"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("fsa");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("gas");
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.checkBoxSqlServer = new System.Windows.Forms.CheckBox();
			this.textBoxSqlServer = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.checkBoxCsvFile = new System.Windows.Forms.CheckBox();
			this.textBoxCsvFile = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkBoxXmlFile = new System.Windows.Forms.CheckBox();
			this.textBoxXmlFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCompare = new System.Windows.Forms.Button();
			this.buttonFetch = new System.Windows.Forms.Button();
			this.listViewProducts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.buttonFetch);
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listViewProducts);
			this.splitContainer1.Panel2.Controls.Add(this.buttonCompare);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(523, 450);
			this.splitContainer1.SplitterDistance = 217;
			this.splitContainer1.TabIndex = 0;
			// 
			// checkBoxSqlServer
			// 
			this.checkBoxSqlServer.AutoSize = true;
			this.checkBoxSqlServer.Location = new System.Drawing.Point(3, 3);
			this.checkBoxSqlServer.Name = "checkBoxSqlServer";
			this.checkBoxSqlServer.Size = new System.Drawing.Size(81, 17);
			this.checkBoxSqlServer.TabIndex = 0;
			this.checkBoxSqlServer.Text = "SQL Server";
			this.checkBoxSqlServer.UseVisualStyleBackColor = true;
			this.checkBoxSqlServer.CheckedChanged += new System.EventHandler(this.checkBoxSqlServer_CheckedChanged);
			// 
			// textBoxSqlServer
			// 
			this.textBoxSqlServer.Location = new System.Drawing.Point(0, 28);
			this.textBoxSqlServer.Name = "textBoxSqlServer";
			this.textBoxSqlServer.Size = new System.Drawing.Size(197, 20);
			this.textBoxSqlServer.TabIndex = 1;
			this.textBoxSqlServer.Text = "data source=localhost\\sqlexpress; initial catalog=Product-Compare;persist securit" +
    "y info=True; Integrated Security=SSPI;";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.textBoxSqlServer);
			this.panel1.Controls.Add(this.checkBoxSqlServer);
			this.panel1.Location = new System.Drawing.Point(10, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 50);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBoxCsvFile);
			this.panel2.Controls.Add(this.checkBoxCsvFile);
			this.panel2.Location = new System.Drawing.Point(10, 58);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 50);
			this.panel2.TabIndex = 1;
			// 
			// checkBoxCsvFile
			// 
			this.checkBoxCsvFile.AutoSize = true;
			this.checkBoxCsvFile.Location = new System.Drawing.Point(3, 3);
			this.checkBoxCsvFile.Name = "checkBoxCsvFile";
			this.checkBoxCsvFile.Size = new System.Drawing.Size(66, 17);
			this.checkBoxCsvFile.TabIndex = 0;
			this.checkBoxCsvFile.Text = "CSV File";
			this.checkBoxCsvFile.UseVisualStyleBackColor = true;
			this.checkBoxCsvFile.CheckedChanged += new System.EventHandler(this.checkBoxCsvFile_CheckedChanged);
			// 
			// textBoxCsvFile
			// 
			this.textBoxCsvFile.Location = new System.Drawing.Point(1, 28);
			this.textBoxCsvFile.Name = "textBoxCsvFile";
			this.textBoxCsvFile.Size = new System.Drawing.Size(197, 20);
			this.textBoxCsvFile.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBoxXmlFile);
			this.panel3.Controls.Add(this.checkBoxXmlFile);
			this.panel3.Location = new System.Drawing.Point(10, 116);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 50);
			this.panel3.TabIndex = 2;
			// 
			// checkBoxXmlFile
			// 
			this.checkBoxXmlFile.AutoSize = true;
			this.checkBoxXmlFile.Location = new System.Drawing.Point(3, 3);
			this.checkBoxXmlFile.Name = "checkBoxXmlFile";
			this.checkBoxXmlFile.Size = new System.Drawing.Size(67, 17);
			this.checkBoxXmlFile.TabIndex = 0;
			this.checkBoxXmlFile.Text = "XML File";
			this.checkBoxXmlFile.UseVisualStyleBackColor = true;
			this.checkBoxXmlFile.CheckedChanged += new System.EventHandler(this.checkBoxXmlFile_CheckedChanged);
			// 
			// textBoxXmlFile
			// 
			this.textBoxXmlFile.Location = new System.Drawing.Point(1, 28);
			this.textBoxXmlFile.Name = "textBoxXmlFile";
			this.textBoxXmlFile.Size = new System.Drawing.Size(198, 20);
			this.textBoxXmlFile.TabIndex = 1;
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
			// buttonCompare
			// 
			this.buttonCompare.Location = new System.Drawing.Point(7, 412);
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(85, 23);
			this.buttonCompare.TabIndex = 3;
			this.buttonCompare.Text = "Compare";
			this.buttonCompare.UseVisualStyleBackColor = true;
			this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
			// 
			// buttonFetch
			// 
			this.buttonFetch.Location = new System.Drawing.Point(10, 411);
			this.buttonFetch.Name = "buttonFetch";
			this.buttonFetch.Size = new System.Drawing.Size(75, 23);
			this.buttonFetch.TabIndex = 3;
			this.buttonFetch.Text = "Fetch";
			this.buttonFetch.UseVisualStyleBackColor = true;
			this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
			// 
			// listViewProducts
			// 
			this.listViewProducts.CheckBoxes = true;
			this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			listViewGroup1.Header = "ListViewGroupa";
			listViewGroup1.Name = "listViewGroup1";
			listViewGroup2.Header = "ListViewGroupb";
			listViewGroup2.Name = "listViewGroup2";
			this.listViewProducts.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			listViewItem1.Group = listViewGroup1;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.Group = listViewGroup2;
			listViewItem2.StateImageIndex = 0;
			listViewItem3.Group = listViewGroup1;
			listViewItem3.StateImageIndex = 0;
			this.listViewProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.listViewProducts.Location = new System.Drawing.Point(3, 24);
			this.listViewProducts.Name = "listViewProducts";
			this.listViewProducts.Size = new System.Drawing.Size(287, 382);
			this.listViewProducts.TabIndex = 4;
			this.listViewProducts.UseCompatibleStateImageBehavior = false;
			this.listViewProducts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			// 
			// ProductSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ProductSelectionForm";
			this.Text = "ProductSelectionForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxCsvFile;
		private System.Windows.Forms.CheckBox checkBoxCsvFile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxSqlServer;
		private System.Windows.Forms.CheckBox checkBoxSqlServer;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBoxXmlFile;
		private System.Windows.Forms.CheckBox checkBoxXmlFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCompare;
		private System.Windows.Forms.Button buttonFetch;
		private System.Windows.Forms.ListView listViewProducts;
		private System.Windows.Forms.ColumnHeader columnHeader1;
	}
}