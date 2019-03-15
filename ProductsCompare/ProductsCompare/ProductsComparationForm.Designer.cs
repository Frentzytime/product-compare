namespace ProductsCompare
{
	partial class ProductsComparationForm
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
			this.checkBoxHighlightDifferences = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanelProducts.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxHighlightDifferences
			// 
			this.checkBoxHighlightDifferences.AutoSize = true;
			this.checkBoxHighlightDifferences.Checked = true;
			this.checkBoxHighlightDifferences.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHighlightDifferences.Location = new System.Drawing.Point(12, 12);
			this.checkBoxHighlightDifferences.Name = "checkBoxHighlightDifferences";
			this.checkBoxHighlightDifferences.Size = new System.Drawing.Size(122, 17);
			this.checkBoxHighlightDifferences.TabIndex = 0;
			this.checkBoxHighlightDifferences.Text = "Highlight differences";
			this.checkBoxHighlightDifferences.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelProducts
			// 
			this.flowLayoutPanelProducts.AutoScroll = true;
			this.flowLayoutPanelProducts.Controls.Add(this.panel1);
			this.flowLayoutPanelProducts.Location = new System.Drawing.Point(13, 36);
			this.flowLayoutPanelProducts.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
			this.flowLayoutPanelProducts.Size = new System.Drawing.Size(775, 402);
			this.flowLayoutPanelProducts.TabIndex = 1;
			this.flowLayoutPanelProducts.WrapContents = false;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(0, 0);
			this.panel1.TabIndex = 0;
			// 
			// ProductsComparationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanelProducts);
			this.Controls.Add(this.checkBoxHighlightDifferences);
			this.Name = "ProductsComparationForm";
			this.Text = "ProductsComparationForm";
			this.flowLayoutPanelProducts.ResumeLayout(false);
			this.flowLayoutPanelProducts.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxHighlightDifferences;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
		private System.Windows.Forms.Panel panel1;
	}
}