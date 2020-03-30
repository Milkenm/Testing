namespace XmrigRegex
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
			this.label_text = new System.Windows.Forms.Label();
			this.button_test = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_text
			// 
			this.label_text.AutoSize = true;
			this.label_text.Location = new System.Drawing.Point(35, 26);
			this.label_text.Name = "label_text";
			this.label_text.Size = new System.Drawing.Size(396, 13);
			this.label_text.TabIndex = 0;
			this.label_text.Text = "[2020-03-24 02:42:27.066] speed 10s/60s/15m 600.7 n/a n/a H/s max 634.2 H/s";
			// 
			// button_test
			// 
			this.button_test.Location = new System.Drawing.Point(196, 60);
			this.button_test.Name = "button_test";
			this.button_test.Size = new System.Drawing.Size(75, 23);
			this.button_test.TabIndex = 1;
			this.button_test.Text = "TEST";
			this.button_test.UseVisualStyleBackColor = true;
			this.button_test.Click += new System.EventHandler(this.button_test_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 109);
			this.Controls.Add(this.button_test);
			this.Controls.Add(this.label_text);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XMRig Regex";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_text;
		private System.Windows.Forms.Button button_test;
	}
}

