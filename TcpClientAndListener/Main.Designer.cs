namespace TcpClientAndListener
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
			this.groupBox_client = new System.Windows.Forms.GroupBox();
			this.listBox_client = new System.Windows.Forms.ListBox();
			this.label_serverIp = new System.Windows.Forms.Label();
			this.textBox_serverIp = new System.Windows.Forms.TextBox();
			this.button_connect = new System.Windows.Forms.Button();
			this.groupBox_listener = new System.Windows.Forms.GroupBox();
			this.listBox_listener = new System.Windows.Forms.ListBox();
			this.button_sendPacket = new System.Windows.Forms.Button();
			this.groupBox_client.SuspendLayout();
			this.groupBox_listener.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_client
			// 
			this.groupBox_client.Controls.Add(this.listBox_client);
			this.groupBox_client.Controls.Add(this.label_serverIp);
			this.groupBox_client.Controls.Add(this.textBox_serverIp);
			this.groupBox_client.Controls.Add(this.button_sendPacket);
			this.groupBox_client.Controls.Add(this.button_connect);
			this.groupBox_client.Location = new System.Drawing.Point(14, 13);
			this.groupBox_client.Name = "groupBox_client";
			this.groupBox_client.Size = new System.Drawing.Size(301, 215);
			this.groupBox_client.TabIndex = 0;
			this.groupBox_client.TabStop = false;
			this.groupBox_client.Text = "Client";
			// 
			// listBox_client
			// 
			this.listBox_client.FormattingEnabled = true;
			this.listBox_client.Location = new System.Drawing.Point(6, 19);
			this.listBox_client.Name = "listBox_client";
			this.listBox_client.Size = new System.Drawing.Size(289, 95);
			this.listBox_client.TabIndex = 0;
			// 
			// label_serverIp
			// 
			this.label_serverIp.AutoSize = true;
			this.label_serverIp.Location = new System.Drawing.Point(3, 123);
			this.label_serverIp.Name = "label_serverIp";
			this.label_serverIp.Size = new System.Drawing.Size(54, 13);
			this.label_serverIp.TabIndex = 2;
			this.label_serverIp.Text = "Server IP:";
			// 
			// textBox_serverIp
			// 
			this.textBox_serverIp.Location = new System.Drawing.Point(63, 120);
			this.textBox_serverIp.Name = "textBox_serverIp";
			this.textBox_serverIp.Size = new System.Drawing.Size(232, 20);
			this.textBox_serverIp.TabIndex = 1;
			// 
			// button_connect
			// 
			this.button_connect.Location = new System.Drawing.Point(207, 186);
			this.button_connect.Name = "button_connect";
			this.button_connect.Size = new System.Drawing.Size(88, 23);
			this.button_connect.TabIndex = 3;
			this.button_connect.Text = "Connect";
			this.button_connect.UseVisualStyleBackColor = true;
			this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
			// 
			// groupBox_listener
			// 
			this.groupBox_listener.Controls.Add(this.listBox_listener);
			this.groupBox_listener.Location = new System.Drawing.Point(321, 13);
			this.groupBox_listener.Name = "groupBox_listener";
			this.groupBox_listener.Size = new System.Drawing.Size(301, 215);
			this.groupBox_listener.TabIndex = 1;
			this.groupBox_listener.TabStop = false;
			this.groupBox_listener.Text = "Listener";
			// 
			// listBox_listener
			// 
			this.listBox_listener.FormattingEnabled = true;
			this.listBox_listener.Location = new System.Drawing.Point(6, 19);
			this.listBox_listener.Name = "listBox_listener";
			this.listBox_listener.Size = new System.Drawing.Size(289, 186);
			this.listBox_listener.TabIndex = 1;
			// 
			// button_sendPacket
			// 
			this.button_sendPacket.Location = new System.Drawing.Point(100, 186);
			this.button_sendPacket.Name = "button_sendPacket";
			this.button_sendPacket.Size = new System.Drawing.Size(101, 23);
			this.button_sendPacket.TabIndex = 4;
			this.button_sendPacket.Text = "Send Packet";
			this.button_sendPacket.UseVisualStyleBackColor = true;
			this.button_sendPacket.Click += new System.EventHandler(this.button_sendPacket_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 241);
			this.Controls.Add(this.groupBox_client);
			this.Controls.Add(this.groupBox_listener);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TCP Client & Listener";
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBox_client.ResumeLayout(false);
			this.groupBox_client.PerformLayout();
			this.groupBox_listener.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_client;
		private System.Windows.Forms.GroupBox groupBox_listener;
		private System.Windows.Forms.ListBox listBox_client;
		private System.Windows.Forms.ListBox listBox_listener;
		private System.Windows.Forms.Button button_connect;
		private System.Windows.Forms.Label label_serverIp;
		private System.Windows.Forms.TextBox textBox_serverIp;
		private System.Windows.Forms.Button button_sendPacket;
	}
}

