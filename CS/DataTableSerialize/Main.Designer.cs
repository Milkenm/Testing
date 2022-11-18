namespace DataTableSerialize
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
			this.button_save = new System.Windows.Forms.Button();
			this.button_read = new System.Windows.Forms.Button();
			this.button_clear = new System.Windows.Forms.Button();
			this.listBox_roles = new System.Windows.Forms.ListBox();
			this.button_getRoles = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(11, 12);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(467, 225);
			this.dataGrid.TabIndex = 0;
			// 
			// button_save
			// 
			this.button_save.Location = new System.Drawing.Point(11, 243);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(152, 49);
			this.button_save.TabIndex = 1;
			this.button_save.Text = "SAVE";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_read
			// 
			this.button_read.Location = new System.Drawing.Point(168, 243);
			this.button_read.Name = "button_read";
			this.button_read.Size = new System.Drawing.Size(152, 49);
			this.button_read.TabIndex = 2;
			this.button_read.Text = "READ";
			this.button_read.UseVisualStyleBackColor = true;
			this.button_read.Click += new System.EventHandler(this.button_read_Click);
			// 
			// button_clear
			// 
			this.button_clear.Location = new System.Drawing.Point(326, 243);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(152, 49);
			this.button_clear.TabIndex = 3;
			this.button_clear.Text = "CLEAR";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// listBox_roles
			// 
			this.listBox_roles.FormattingEnabled = true;
			this.listBox_roles.Location = new System.Drawing.Point(484, 12);
			this.listBox_roles.Name = "listBox_roles";
			this.listBox_roles.Size = new System.Drawing.Size(152, 225);
			this.listBox_roles.TabIndex = 4;
			// 
			// button_getRoles
			// 
			this.button_getRoles.Location = new System.Drawing.Point(484, 243);
			this.button_getRoles.Name = "button_getRoles";
			this.button_getRoles.Size = new System.Drawing.Size(152, 49);
			this.button_getRoles.TabIndex = 5;
			this.button_getRoles.Text = "GET ROLES";
			this.button_getRoles.UseVisualStyleBackColor = true;
			this.button_getRoles.Click += new System.EventHandler(this.button_getRoles_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 305);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.button_read);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.listBox_roles);
			this.Controls.Add(this.button_getRoles);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataTable Serialize";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Button button_read;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.ListBox listBox_roles;
		private System.Windows.Forms.Button button_getRoles;
	}
}

