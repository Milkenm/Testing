namespace FormResizeTesting
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
			this.button_prevent = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_prevent
			// 
			this.button_prevent.Location = new System.Drawing.Point(212, 92);
			this.button_prevent.Name = "button_prevent";
			this.button_prevent.Size = new System.Drawing.Size(126, 66);
			this.button_prevent.TabIndex = 0;
			this.button_prevent.Text = "Prevent";
			this.button_prevent.UseVisualStyleBackColor = true;
			this.button_prevent.Click += new System.EventHandler(this.PreventResize);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 250);
			this.Controls.Add(this.button_prevent);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Form Resize Testing";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_prevent;
	}
}

