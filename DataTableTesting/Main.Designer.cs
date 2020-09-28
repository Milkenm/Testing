namespace DataTableTesting
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
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.button_addRecords = new System.Windows.Forms.Button();
			this.num_amount = new System.Windows.Forms.NumericUpDown();
			this.button_saveDataTable = new System.Windows.Forms.Button();
			this.button_readDataTable = new System.Windows.Forms.Button();
			this.button_select = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(12, 12);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGrid.Size = new System.Drawing.Size(375, 426);
			this.dataGrid.TabIndex = 0;
			// 
			// button_addRecords
			// 
			this.button_addRecords.Location = new System.Drawing.Point(393, 389);
			this.button_addRecords.Name = "button_addRecords";
			this.button_addRecords.Size = new System.Drawing.Size(140, 49);
			this.button_addRecords.TabIndex = 1;
			this.button_addRecords.Text = "Add Records";
			this.button_addRecords.UseVisualStyleBackColor = true;
			this.button_addRecords.Click += new System.EventHandler(this.button_addRecords_Click);
			// 
			// num_amount
			// 
			this.num_amount.Location = new System.Drawing.Point(393, 363);
			this.num_amount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.num_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_amount.Name = "num_amount";
			this.num_amount.Size = new System.Drawing.Size(140, 20);
			this.num_amount.TabIndex = 2;
			this.num_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button_saveDataTable
			// 
			this.button_saveDataTable.Location = new System.Drawing.Point(393, 12);
			this.button_saveDataTable.Name = "button_saveDataTable";
			this.button_saveDataTable.Size = new System.Drawing.Size(69, 49);
			this.button_saveDataTable.TabIndex = 3;
			this.button_saveDataTable.Text = "Save DataTable";
			this.button_saveDataTable.UseVisualStyleBackColor = true;
			this.button_saveDataTable.Click += new System.EventHandler(this.SaveDataTable);
			// 
			// button_readDataTable
			// 
			this.button_readDataTable.Location = new System.Drawing.Point(464, 12);
			this.button_readDataTable.Name = "button_readDataTable";
			this.button_readDataTable.Size = new System.Drawing.Size(69, 49);
			this.button_readDataTable.TabIndex = 4;
			this.button_readDataTable.Text = "Read DataTable";
			this.button_readDataTable.UseVisualStyleBackColor = true;
			this.button_readDataTable.Click += new System.EventHandler(this.ReadDataTable);
			// 
			// button_select
			// 
			this.button_select.Location = new System.Drawing.Point(393, 198);
			this.button_select.Name = "button_select";
			this.button_select.Size = new System.Drawing.Size(140, 45);
			this.button_select.TabIndex = 5;
			this.button_select.Text = "Select";
			this.button_select.UseVisualStyleBackColor = true;
			this.button_select.Click += new System.EventHandler(this.button_select_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 450);
			this.Controls.Add(this.button_select);
			this.Controls.Add(this.button_readDataTable);
			this.Controls.Add(this.button_saveDataTable);
			this.Controls.Add(this.num_amount);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.button_addRecords);
			this.Name = "Main";
			this.Text = "DataTable Testing";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Button button_addRecords;
		private System.Windows.Forms.NumericUpDown num_amount;
		private System.Windows.Forms.Button button_saveDataTable;
		private System.Windows.Forms.Button button_readDataTable;
		private System.Windows.Forms.Button button_select;
	}
}

