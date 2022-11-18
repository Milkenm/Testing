namespace ServerTesting
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
			this.label_client = new System.Windows.Forms.Label();
			this.label_server = new System.Windows.Forms.Label();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.listBox_client = new System.Windows.Forms.ListBox();
			this.listBox_server = new System.Windows.Forms.ListBox();
			this.button_connectToServer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_client
			// 
			this.label_client.AutoSize = true;
			this.label_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_client.Location = new System.Drawing.Point(173, 15);
			this.label_client.Name = "label_client";
			this.label_client.Size = new System.Drawing.Size(55, 15);
			this.label_client.TabIndex = 0;
			this.label_client.Text = "CLIENT";
			// 
			// label_server
			// 
			this.label_server.AutoSize = true;
			this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_server.Location = new System.Drawing.Point(167, 15);
			this.label_server.Name = "label_server";
			this.label_server.Size = new System.Drawing.Size(62, 15);
			this.label_server.TabIndex = 1;
			this.label_server.Text = "SERVER";
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.label_client);
			this.splitContainer.Panel1.Controls.Add(this.listBox_client);
			this.splitContainer.Panel1.Controls.Add(this.button_connectToServer);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.label_server);
			this.splitContainer.Panel2.Controls.Add(this.listBox_server);
			this.splitContainer.Size = new System.Drawing.Size(800, 450);
			this.splitContainer.SplitterDistance = 400;
			this.splitContainer.TabIndex = 2;
			// 
			// listBox_client
			// 
			this.listBox_client.FormattingEnabled = true;
			this.listBox_client.Location = new System.Drawing.Point(12, 59);
			this.listBox_client.Name = "listBox_client";
			this.listBox_client.Size = new System.Drawing.Size(373, 251);
			this.listBox_client.TabIndex = 1;
			// 
			// listBox_server
			// 
			this.listBox_server.FormattingEnabled = true;
			this.listBox_server.Location = new System.Drawing.Point(14, 59);
			this.listBox_server.Name = "listBox_server";
			this.listBox_server.Size = new System.Drawing.Size(370, 251);
			this.listBox_server.TabIndex = 2;
			// 
			// button_connectToServer
			// 
			this.button_connectToServer.Location = new System.Drawing.Point(12, 415);
			this.button_connectToServer.Name = "button_connectToServer";
			this.button_connectToServer.Size = new System.Drawing.Size(110, 23);
			this.button_connectToServer.TabIndex = 2;
			this.button_connectToServer.Text = "Connect to Server";
			this.button_connectToServer.UseVisualStyleBackColor = true;
			this.button_connectToServer.Click += new System.EventHandler(this.button_connectToServer_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server Testing";
			this.Load += new System.EventHandler(this.Main_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_client;
		private System.Windows.Forms.Label label_server;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListBox listBox_client;
		private System.Windows.Forms.Button button_connectToServer;
		private System.Windows.Forms.ListBox listBox_server;
	}
}

