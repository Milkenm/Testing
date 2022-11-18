namespace DiamondDataTableSavingTesting
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
			this.dataGrid_dataTable = new System.Windows.Forms.DataGridView();
			this.dataGrid_rrMessages = new System.Windows.Forms.DataGridView();
			this.button_load = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_dataTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_rrMessages)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid_dataTable
			// 
			this.dataGrid_dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_dataTable.Location = new System.Drawing.Point(12, 12);
			this.dataGrid_dataTable.Name = "dataGrid_dataTable";
			this.dataGrid_dataTable.Size = new System.Drawing.Size(392, 227);
			this.dataGrid_dataTable.TabIndex = 0;
			// 
			// dataGrid_rrMessages
			// 
			this.dataGrid_rrMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_rrMessages.Location = new System.Drawing.Point(410, 12);
			this.dataGrid_rrMessages.Name = "dataGrid_rrMessages";
			this.dataGrid_rrMessages.Size = new System.Drawing.Size(392, 227);
			this.dataGrid_rrMessages.TabIndex = 1;
			// 
			// button_load
			// 
			this.button_load.Location = new System.Drawing.Point(12, 245);
			this.button_load.Name = "button_load";
			this.button_load.Size = new System.Drawing.Size(790, 23);
			this.button_load.TabIndex = 2;
			this.button_load.Text = "Load";
			this.button_load.UseVisualStyleBackColor = true;
			this.button_load.Click += new System.EventHandler(this.button_load_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 280);
			this.Controls.Add(this.dataGrid_dataTable);
			this.Controls.Add(this.dataGrid_rrMessages);
			this.Controls.Add(this.button_load);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Diamond DataTable Saving Testing";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_dataTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_rrMessages)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid_dataTable;
		private System.Windows.Forms.DataGridView dataGrid_rrMessages;
		private System.Windows.Forms.Button button_load;
	}
}

