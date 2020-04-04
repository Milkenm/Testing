namespace GlobalExceptionCatchTest
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
			this.button_exception = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_exception
			// 
			this.button_exception.Location = new System.Drawing.Point(63, 12);
			this.button_exception.Name = "button_exception";
			this.button_exception.Size = new System.Drawing.Size(166, 51);
			this.button_exception.TabIndex = 0;
			this.button_exception.Text = "THROW EXCEPTION";
			this.button_exception.UseVisualStyleBackColor = true;
			this.button_exception.Click += new System.EventHandler(this.button_exception_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 75);
			this.Controls.Add(this.button_exception);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Global Exception";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_exception;
	}
}

