
namespace GetIconFromProcess
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
			this.pictureBox_icon = new System.Windows.Forms.PictureBox();
			this.textBox_processName = new System.Windows.Forms.TextBox();
			this.button_getIcon = new System.Windows.Forms.Button();
			this.label_processName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_icon
			// 
			this.pictureBox_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_icon.Location = new System.Drawing.Point(95, 13);
			this.pictureBox_icon.Name = "pictureBox_icon";
			this.pictureBox_icon.Size = new System.Drawing.Size(64, 64);
			this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_icon.TabIndex = 6;
			this.pictureBox_icon.TabStop = false;
			// 
			// textBox_processName
			// 
			this.textBox_processName.Location = new System.Drawing.Point(18, 118);
			this.textBox_processName.Name = "textBox_processName";
			this.textBox_processName.Size = new System.Drawing.Size(222, 20);
			this.textBox_processName.TabIndex = 5;
			this.textBox_processName.Text = "explorer";
			// 
			// button_getIcon
			// 
			this.button_getIcon.Location = new System.Drawing.Point(165, 144);
			this.button_getIcon.Name = "button_getIcon";
			this.button_getIcon.Size = new System.Drawing.Size(75, 23);
			this.button_getIcon.TabIndex = 4;
			this.button_getIcon.Text = "Get Icon";
			this.button_getIcon.UseVisualStyleBackColor = true;
			this.button_getIcon.Click += new System.EventHandler(this.button_getIcon_Click);
			// 
			// label_processName
			// 
			this.label_processName.AutoSize = true;
			this.label_processName.Location = new System.Drawing.Point(15, 102);
			this.label_processName.Name = "label_processName";
			this.label_processName.Size = new System.Drawing.Size(76, 13);
			this.label_processName.TabIndex = 7;
			this.label_processName.Text = "Process Name";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 181);
			this.Controls.Add(this.pictureBox_icon);
			this.Controls.Add(this.label_processName);
			this.Controls.Add(this.textBox_processName);
			this.Controls.Add(this.button_getIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_icon;
		private System.Windows.Forms.TextBox textBox_processName;
		private System.Windows.Forms.Button button_getIcon;
		private System.Windows.Forms.Label label_processName;
	}
}

