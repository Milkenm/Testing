namespace DataTableTesting
{
	partial class Main2
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
			this.button_sqliteInsert = new System.Windows.Forms.Button();
			this.button_sqliteSelect = new System.Windows.Forms.Button();
			this.button_datatableInsert = new System.Windows.Forms.Button();
			this.button_datatableSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_sqliteInsert
			// 
			this.button_sqliteInsert.Location = new System.Drawing.Point(31, 30);
			this.button_sqliteInsert.Name = "button_sqliteInsert";
			this.button_sqliteInsert.Size = new System.Drawing.Size(206, 72);
			this.button_sqliteInsert.TabIndex = 0;
			this.button_sqliteInsert.Text = "SQLite INSERT";
			this.button_sqliteInsert.UseVisualStyleBackColor = true;
			this.button_sqliteInsert.Click += new System.EventHandler(this.button_sqliteInsert_Click);
			// 
			// button_sqliteSelect
			// 
			this.button_sqliteSelect.Location = new System.Drawing.Point(31, 108);
			this.button_sqliteSelect.Name = "button_sqliteSelect";
			this.button_sqliteSelect.Size = new System.Drawing.Size(206, 72);
			this.button_sqliteSelect.TabIndex = 1;
			this.button_sqliteSelect.Text = "SQLite SELECT";
			this.button_sqliteSelect.UseVisualStyleBackColor = true;
			this.button_sqliteSelect.Click += new System.EventHandler(this.button_sqliteSelect_Click);
			// 
			// button_datatableInsert
			// 
			this.button_datatableInsert.Location = new System.Drawing.Point(365, 30);
			this.button_datatableInsert.Name = "button_datatableInsert";
			this.button_datatableInsert.Size = new System.Drawing.Size(206, 72);
			this.button_datatableInsert.TabIndex = 2;
			this.button_datatableInsert.Text = "DataTable INSERT";
			this.button_datatableInsert.UseVisualStyleBackColor = true;
			this.button_datatableInsert.Click += new System.EventHandler(this.button_datatableInsert_Click);
			// 
			// button_datatableSelect
			// 
			this.button_datatableSelect.Location = new System.Drawing.Point(365, 108);
			this.button_datatableSelect.Name = "button_datatableSelect";
			this.button_datatableSelect.Size = new System.Drawing.Size(206, 72);
			this.button_datatableSelect.TabIndex = 3;
			this.button_datatableSelect.Text = "DataTable SELECT";
			this.button_datatableSelect.UseVisualStyleBackColor = true;
			this.button_datatableSelect.Click += new System.EventHandler(this.button_datatableSelect_Click);
			// 
			// Main2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 210);
			this.Controls.Add(this.button_datatableSelect);
			this.Controls.Add(this.button_datatableInsert);
			this.Controls.Add(this.button_sqliteSelect);
			this.Controls.Add(this.button_sqliteInsert);
			this.Name = "Main2";
			this.Text = "Main2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_sqliteInsert;
		private System.Windows.Forms.Button button_sqliteSelect;
		private System.Windows.Forms.Button button_datatableInsert;
		private System.Windows.Forms.Button button_datatableSelect;
	}
}