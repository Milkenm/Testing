namespace ImageToBase64
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
			this.button_encode = new System.Windows.Forms.Button();
			this.pictureBox_encode = new System.Windows.Forms.PictureBox();
			this.pictureBox_decode = new System.Windows.Forms.PictureBox();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_encode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_decode)).BeginInit();
			this.SuspendLayout();
			// 
			// button_encode
			// 
			this.button_encode.Location = new System.Drawing.Point(18, 282);
			this.button_encode.Name = "button_encode";
			this.button_encode.Size = new System.Drawing.Size(518, 33);
			this.button_encode.TabIndex = 0;
			this.button_encode.Text = "Encode to Base64";
			this.button_encode.UseVisualStyleBackColor = true;
			this.button_encode.Click += new System.EventHandler(this.button_encode_Click);
			// 
			// pictureBox_encode
			// 
			this.pictureBox_encode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_encode.Location = new System.Drawing.Point(18, 20);
			this.pictureBox_encode.Name = "pictureBox_encode";
			this.pictureBox_encode.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_encode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_encode.TabIndex = 1;
			this.pictureBox_encode.TabStop = false;
			// 
			// pictureBox_decode
			// 
			this.pictureBox_decode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_decode.Location = new System.Drawing.Point(280, 20);
			this.pictureBox_decode.Name = "pictureBox_decode";
			this.pictureBox_decode.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_decode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_decode.TabIndex = 2;
			this.pictureBox_decode.TabStop = false;
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 335);
			this.Controls.Add(this.pictureBox_decode);
			this.Controls.Add(this.button_encode);
			this.Controls.Add(this.pictureBox_encode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image to Base64";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_encode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_decode)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_encode;
		private System.Windows.Forms.PictureBox pictureBox_encode;
		private System.Windows.Forms.PictureBox pictureBox_decode;
		private System.Windows.Forms.OpenFileDialog fileDialog;
	}
}

