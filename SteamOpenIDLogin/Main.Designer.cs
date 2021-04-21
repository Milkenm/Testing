
namespace SteamOpenIDLogin
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
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.panel_webBrowser = new System.Windows.Forms.Panel();
			this.button_goToSteam = new System.Windows.Forms.Button();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.label_id = new System.Windows.Forms.Label();
			this.panel_webBrowser.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.Size = new System.Drawing.Size(1180, 663);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
			// 
			// panel_webBrowser
			// 
			this.panel_webBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_webBrowser.Controls.Add(this.webBrowser);
			this.panel_webBrowser.Location = new System.Drawing.Point(14, 14);
			this.panel_webBrowser.Name = "panel_webBrowser";
			this.panel_webBrowser.Size = new System.Drawing.Size(1182, 665);
			this.panel_webBrowser.TabIndex = 1;
			// 
			// button_goToSteam
			// 
			this.button_goToSteam.Location = new System.Drawing.Point(510, 685);
			this.button_goToSteam.Name = "button_goToSteam";
			this.button_goToSteam.Size = new System.Drawing.Size(104, 22);
			this.button_goToSteam.TabIndex = 2;
			this.button_goToSteam.Text = "Go to Steam";
			this.button_goToSteam.UseVisualStyleBackColor = true;
			this.button_goToSteam.Click += new System.EventHandler(this.button_goToSteam_Click);
			// 
			// textBox_id
			// 
			this.textBox_id.Location = new System.Drawing.Point(35, 686);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(469, 20);
			this.textBox_id.TabIndex = 3;
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Location = new System.Drawing.Point(8, 689);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(21, 13);
			this.label_id.TabIndex = 4;
			this.label_id.Text = "ID:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1208, 718);
			this.Controls.Add(this.label_id);
			this.Controls.Add(this.textBox_id);
			this.Controls.Add(this.button_goToSteam);
			this.Controls.Add(this.panel_webBrowser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Steam OpenID Login";
			this.panel_webBrowser.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Panel panel_webBrowser;
		private System.Windows.Forms.Button button_goToSteam;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.Label label_id;
	}
}

