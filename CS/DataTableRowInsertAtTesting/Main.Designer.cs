namespace DataTableRowInsertAtTesting
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.button_insertAt = new System.Windows.Forms.Button();
			this.numeric_index = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_index)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(12, 12);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(577, 426);
			this.dataGrid.TabIndex = 0;
			// 
			// button_insertAt
			// 
			this.button_insertAt.Location = new System.Drawing.Point(595, 382);
			this.button_insertAt.Name = "button_insertAt";
			this.button_insertAt.Size = new System.Drawing.Size(193, 56);
			this.button_insertAt.TabIndex = 2;
			this.button_insertAt.Text = "Insert At";
			this.button_insertAt.UseVisualStyleBackColor = true;
			this.button_insertAt.Click += new System.EventHandler(this.button_insertAt_Click);
			// 
			// numeric_index
			// 
			this.numeric_index.Location = new System.Drawing.Point(595, 356);
			this.numeric_index.Name = "numeric_index";
			this.numeric_index.Size = new System.Drawing.Size(193, 20);
			this.numeric_index.TabIndex = 3;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.numeric_index);
			this.Controls.Add(this.button_insertAt);
			this.Controls.Add(this.dataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "DataTable Row InsertAt";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_index)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Button button_insertAt;
		private System.Windows.Forms.NumericUpDown numeric_index;
	}
}

