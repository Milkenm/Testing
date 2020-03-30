namespace ThousandsSeparator
{
	partial class Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.button_format = new System.Windows.Forms.Button();
			this.textBox_number = new System.Windows.Forms.TextBox();
			this.textBox_formatedNumber = new System.Windows.Forms.TextBox();
			this.label_number = new System.Windows.Forms.Label();
			this.label_formatedNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_format
			// 
			this.button_format.Location = new System.Drawing.Point(43, 95);
			this.button_format.Name = "button_format";
			this.button_format.Size = new System.Drawing.Size(223, 23);
			this.button_format.TabIndex = 0;
			this.button_format.Text = "Format";
			this.button_format.UseVisualStyleBackColor = true;
			this.button_format.Click += new System.EventHandler(this.button_format_Click);
			// 
			// textBox_number
			// 
			this.textBox_number.Location = new System.Drawing.Point(116, 20);
			this.textBox_number.Name = "textBox_number";
			this.textBox_number.Size = new System.Drawing.Size(178, 20);
			this.textBox_number.TabIndex = 1;
			this.textBox_number.Text = "123456789.12";
			this.textBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_formatedNumber
			// 
			this.textBox_formatedNumber.Location = new System.Drawing.Point(116, 46);
			this.textBox_formatedNumber.Name = "textBox_formatedNumber";
			this.textBox_formatedNumber.ReadOnly = true;
			this.textBox_formatedNumber.Size = new System.Drawing.Size(178, 20);
			this.textBox_formatedNumber.TabIndex = 2;
			this.textBox_formatedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_number
			// 
			this.label_number.AutoSize = true;
			this.label_number.Location = new System.Drawing.Point(60, 23);
			this.label_number.Name = "label_number";
			this.label_number.Size = new System.Drawing.Size(50, 13);
			this.label_number.TabIndex = 3;
			this.label_number.Text = "Number :";
			// 
			// label_formatedNumber
			// 
			this.label_formatedNumber.AutoSize = true;
			this.label_formatedNumber.Location = new System.Drawing.Point(15, 49);
			this.label_formatedNumber.Name = "label_formatedNumber";
			this.label_formatedNumber.Size = new System.Drawing.Size(95, 13);
			this.label_formatedNumber.TabIndex = 4;
			this.label_formatedNumber.Text = "Formated number :";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 139);
			this.Controls.Add(this.label_number);
			this.Controls.Add(this.textBox_number);
			this.Controls.Add(this.button_format);
			this.Controls.Add(this.label_formatedNumber);
			this.Controls.Add(this.textBox_formatedNumber);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thousands Separator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_format;
		private System.Windows.Forms.TextBox textBox_number;
		private System.Windows.Forms.TextBox textBox_formatedNumber;
		private System.Windows.Forms.Label label_number;
		private System.Windows.Forms.Label label_formatedNumber;
	}
}

