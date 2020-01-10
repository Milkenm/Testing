namespace Testing.RiotAPI
{
	partial class RiotAPITesting
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
			this.button_get = new System.Windows.Forms.Button();
			this.textBox_apiKey = new System.Windows.Forms.TextBox();
			this.button_saveApiKey = new System.Windows.Forms.Button();
			this.label_apiKey = new System.Windows.Forms.Label();
			this.panel_apiKey = new System.Windows.Forms.Panel();
			this.textBox_summoner = new System.Windows.Forms.TextBox();
			this.label_summoner = new System.Windows.Forms.Label();
			this.panel_summonerName = new System.Windows.Forms.Panel();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tab_summonerInfo = new System.Windows.Forms.TabPage();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.label_summonerLevel = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.textBox_summonerLevel = new System.Windows.Forms.TextBox();
			this.textBox_accountId = new System.Windows.Forms.TextBox();
			this.label_revisionDate = new System.Windows.Forms.Label();
			this.label_accountId = new System.Windows.Forms.Label();
			this.textBox_revisionDate = new System.Windows.Forms.TextBox();
			this.textBox_puuid = new System.Windows.Forms.TextBox();
			this.label_profileIconId = new System.Windows.Forms.Label();
			this.label_puuid = new System.Windows.Forms.Label();
			this.textBox_profileIconid = new System.Windows.Forms.TextBox();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label4_name = new System.Windows.Forms.Label();
			this.pictureBox_icon = new System.Windows.Forms.PictureBox();
			this.panel_apiKey.SuspendLayout();
			this.panel_summonerName.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tab_summonerInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
			this.SuspendLayout();
			// 
			// button_get
			// 
			this.button_get.Location = new System.Drawing.Point(343, 3);
			this.button_get.Name = "button_get";
			this.button_get.Size = new System.Drawing.Size(70, 22);
			this.button_get.TabIndex = 3;
			this.button_get.Text = "GET";
			this.button_get.UseVisualStyleBackColor = true;
			this.button_get.Click += new System.EventHandler(this.button_get_Click);
			// 
			// textBox_apiKey
			// 
			this.textBox_apiKey.Location = new System.Drawing.Point(57, 3);
			this.textBox_apiKey.Name = "textBox_apiKey";
			this.textBox_apiKey.Size = new System.Drawing.Size(636, 20);
			this.textBox_apiKey.TabIndex = 9;
			// 
			// button_saveApiKey
			// 
			this.button_saveApiKey.Location = new System.Drawing.Point(699, 2);
			this.button_saveApiKey.Name = "button_saveApiKey";
			this.button_saveApiKey.Size = new System.Drawing.Size(75, 22);
			this.button_saveApiKey.TabIndex = 10;
			this.button_saveApiKey.Text = "Save";
			this.button_saveApiKey.UseVisualStyleBackColor = true;
			this.button_saveApiKey.Click += new System.EventHandler(this.button_saveApiKey_Click);
			// 
			// label_apiKey
			// 
			this.label_apiKey.AutoSize = true;
			this.label_apiKey.Location = new System.Drawing.Point(3, 6);
			this.label_apiKey.Name = "label_apiKey";
			this.label_apiKey.Size = new System.Drawing.Size(48, 13);
			this.label_apiKey.TabIndex = 11;
			this.label_apiKey.Text = "API Key;";
			// 
			// panel_apiKey
			// 
			this.panel_apiKey.Controls.Add(this.label_apiKey);
			this.panel_apiKey.Controls.Add(this.button_saveApiKey);
			this.panel_apiKey.Controls.Add(this.textBox_apiKey);
			this.panel_apiKey.Location = new System.Drawing.Point(12, 431);
			this.panel_apiKey.Name = "panel_apiKey";
			this.panel_apiKey.Size = new System.Drawing.Size(776, 26);
			this.panel_apiKey.TabIndex = 12;
			// 
			// textBox_summoner
			// 
			this.textBox_summoner.Location = new System.Drawing.Point(69, 4);
			this.textBox_summoner.Name = "textBox_summoner";
			this.textBox_summoner.Size = new System.Drawing.Size(268, 20);
			this.textBox_summoner.TabIndex = 15;
			// 
			// label_summoner
			// 
			this.label_summoner.AutoSize = true;
			this.label_summoner.Location = new System.Drawing.Point(3, 7);
			this.label_summoner.Name = "label_summoner";
			this.label_summoner.Size = new System.Drawing.Size(60, 13);
			this.label_summoner.TabIndex = 16;
			this.label_summoner.Text = "Summoner:";
			// 
			// panel_summonerName
			// 
			this.panel_summonerName.Controls.Add(this.button_get);
			this.panel_summonerName.Controls.Add(this.label_summoner);
			this.panel_summonerName.Controls.Add(this.textBox_summoner);
			this.panel_summonerName.Location = new System.Drawing.Point(12, 8);
			this.panel_summonerName.Name = "panel_summonerName";
			this.panel_summonerName.Size = new System.Drawing.Size(416, 28);
			this.panel_summonerName.TabIndex = 15;
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tab_summonerInfo);
			this.tabs.Location = new System.Drawing.Point(12, 42);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(776, 386);
			this.tabs.TabIndex = 0;
			// 
			// tab_summonerInfo
			// 
			this.tab_summonerInfo.Controls.Add(this.textBox_id);
			this.tab_summonerInfo.Controls.Add(this.label_summonerLevel);
			this.tab_summonerInfo.Controls.Add(this.label_id);
			this.tab_summonerInfo.Controls.Add(this.textBox_summonerLevel);
			this.tab_summonerInfo.Controls.Add(this.textBox_accountId);
			this.tab_summonerInfo.Controls.Add(this.label_revisionDate);
			this.tab_summonerInfo.Controls.Add(this.label_accountId);
			this.tab_summonerInfo.Controls.Add(this.textBox_revisionDate);
			this.tab_summonerInfo.Controls.Add(this.textBox_puuid);
			this.tab_summonerInfo.Controls.Add(this.label_profileIconId);
			this.tab_summonerInfo.Controls.Add(this.label_puuid);
			this.tab_summonerInfo.Controls.Add(this.textBox_profileIconid);
			this.tab_summonerInfo.Controls.Add(this.textBox_name);
			this.tab_summonerInfo.Controls.Add(this.label4_name);
			this.tab_summonerInfo.Location = new System.Drawing.Point(4, 22);
			this.tab_summonerInfo.Name = "tab_summonerInfo";
			this.tab_summonerInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tab_summonerInfo.Size = new System.Drawing.Size(768, 360);
			this.tab_summonerInfo.TabIndex = 0;
			this.tab_summonerInfo.Text = "Summoner Info";
			this.tab_summonerInfo.UseVisualStyleBackColor = true;
			// 
			// textBox_id
			// 
			this.textBox_id.Location = new System.Drawing.Point(17, 25);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(718, 20);
			this.textBox_id.TabIndex = 14;
			// 
			// label_summonerLevel
			// 
			this.label_summonerLevel.AutoSize = true;
			this.label_summonerLevel.Location = new System.Drawing.Point(14, 309);
			this.label_summonerLevel.Name = "label_summonerLevel";
			this.label_summonerLevel.Size = new System.Drawing.Size(86, 13);
			this.label_summonerLevel.TabIndex = 27;
			this.label_summonerLevel.Text = "Summoner Level";
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Location = new System.Drawing.Point(14, 9);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(18, 13);
			this.label_id.TabIndex = 15;
			this.label_id.Text = "ID";
			// 
			// textBox_summonerLevel
			// 
			this.textBox_summonerLevel.Location = new System.Drawing.Point(17, 325);
			this.textBox_summonerLevel.Name = "textBox_summonerLevel";
			this.textBox_summonerLevel.Size = new System.Drawing.Size(718, 20);
			this.textBox_summonerLevel.TabIndex = 26;
			// 
			// textBox_accountId
			// 
			this.textBox_accountId.Location = new System.Drawing.Point(17, 75);
			this.textBox_accountId.Name = "textBox_accountId";
			this.textBox_accountId.Size = new System.Drawing.Size(718, 20);
			this.textBox_accountId.TabIndex = 16;
			// 
			// label_revisionDate
			// 
			this.label_revisionDate.AutoSize = true;
			this.label_revisionDate.Location = new System.Drawing.Point(14, 259);
			this.label_revisionDate.Name = "label_revisionDate";
			this.label_revisionDate.Size = new System.Drawing.Size(74, 13);
			this.label_revisionDate.TabIndex = 25;
			this.label_revisionDate.Text = "Revision Date";
			// 
			// label_accountId
			// 
			this.label_accountId.AutoSize = true;
			this.label_accountId.Location = new System.Drawing.Point(14, 59);
			this.label_accountId.Name = "label_accountId";
			this.label_accountId.Size = new System.Drawing.Size(61, 13);
			this.label_accountId.TabIndex = 17;
			this.label_accountId.Text = "Account ID";
			// 
			// textBox_revisionDate
			// 
			this.textBox_revisionDate.Location = new System.Drawing.Point(17, 275);
			this.textBox_revisionDate.Name = "textBox_revisionDate";
			this.textBox_revisionDate.Size = new System.Drawing.Size(718, 20);
			this.textBox_revisionDate.TabIndex = 24;
			// 
			// textBox_puuid
			// 
			this.textBox_puuid.Location = new System.Drawing.Point(17, 125);
			this.textBox_puuid.Name = "textBox_puuid";
			this.textBox_puuid.Size = new System.Drawing.Size(718, 20);
			this.textBox_puuid.TabIndex = 18;
			// 
			// label_profileIconId
			// 
			this.label_profileIconId.AutoSize = true;
			this.label_profileIconId.Location = new System.Drawing.Point(14, 209);
			this.label_profileIconId.Name = "label_profileIconId";
			this.label_profileIconId.Size = new System.Drawing.Size(74, 13);
			this.label_profileIconId.TabIndex = 23;
			this.label_profileIconId.Text = "Profile Icon ID";
			// 
			// label_puuid
			// 
			this.label_puuid.AutoSize = true;
			this.label_puuid.Location = new System.Drawing.Point(14, 109);
			this.label_puuid.Name = "label_puuid";
			this.label_puuid.Size = new System.Drawing.Size(41, 13);
			this.label_puuid.TabIndex = 19;
			this.label_puuid.Text = "PUUID";
			// 
			// textBox_profileIconid
			// 
			this.textBox_profileIconid.Location = new System.Drawing.Point(17, 225);
			this.textBox_profileIconid.Name = "textBox_profileIconid";
			this.textBox_profileIconid.Size = new System.Drawing.Size(718, 20);
			this.textBox_profileIconid.TabIndex = 22;
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(17, 175);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(718, 20);
			this.textBox_name.TabIndex = 20;
			// 
			// label4_name
			// 
			this.label4_name.AutoSize = true;
			this.label4_name.Location = new System.Drawing.Point(14, 159);
			this.label4_name.Name = "label4_name";
			this.label4_name.Size = new System.Drawing.Size(35, 13);
			this.label4_name.TabIndex = 21;
			this.label4_name.Text = "Name";
			// 
			// pictureBox_icon
			// 
			this.pictureBox_icon.Location = new System.Drawing.Point(805, 64);
			this.pictureBox_icon.Name = "pictureBox_icon";
			this.pictureBox_icon.Size = new System.Drawing.Size(300, 300);
			this.pictureBox_icon.TabIndex = 16;
			this.pictureBox_icon.TabStop = false;
			// 
			// RiotAPITesting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 469);
			this.Controls.Add(this.pictureBox_icon);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.panel_summonerName);
			this.Controls.Add(this.panel_apiKey);
			this.Name = "RiotAPITesting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Riot API";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RiotAPITesting_FormClosing);
			this.Load += new System.EventHandler(this.RiotAPI_Load);
			this.panel_apiKey.ResumeLayout(false);
			this.panel_apiKey.PerformLayout();
			this.panel_summonerName.ResumeLayout(false);
			this.panel_summonerName.PerformLayout();
			this.tabs.ResumeLayout(false);
			this.tab_summonerInfo.ResumeLayout(false);
			this.tab_summonerInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button_get;
		private System.Windows.Forms.TextBox textBox_apiKey;
		private System.Windows.Forms.Button button_saveApiKey;
		private System.Windows.Forms.Label label_apiKey;
		private System.Windows.Forms.Panel panel_apiKey;
		private System.Windows.Forms.TextBox textBox_summoner;
		private System.Windows.Forms.Label label_summoner;
		private System.Windows.Forms.Panel panel_summonerName;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tab_summonerInfo;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.Label label_summonerLevel;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.TextBox textBox_summonerLevel;
		private System.Windows.Forms.TextBox textBox_accountId;
		private System.Windows.Forms.Label label_revisionDate;
		private System.Windows.Forms.Label label_accountId;
		private System.Windows.Forms.TextBox textBox_revisionDate;
		private System.Windows.Forms.TextBox textBox_puuid;
		private System.Windows.Forms.Label label_profileIconId;
		private System.Windows.Forms.Label label_puuid;
		private System.Windows.Forms.TextBox textBox_profileIconid;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Label label4_name;
		private System.Windows.Forms.PictureBox pictureBox_icon;
	}
}