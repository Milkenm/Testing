namespace Testing.TokenDB
{
	partial class TokenDBTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenDBTesting));
            this.button_createToken = new System.Windows.Forms.Button();
            this.label_token = new System.Windows.Forms.Label();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.button_decodeToken = new System.Windows.Forms.Button();
            this.textBox_tokenData = new System.Windows.Forms.TextBox();
            this.label_tokenData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_createToken
            // 
            this.button_createToken.Location = new System.Drawing.Point(348, 56);
            this.button_createToken.Name = "button_createToken";
            this.button_createToken.Size = new System.Drawing.Size(140, 23);
            this.button_createToken.TabIndex = 0;
            this.button_createToken.Text = "Create token";
            this.button_createToken.UseVisualStyleBackColor = true;
            this.button_createToken.Click += new System.EventHandler(this.button_createToken_Click);
            // 
            // label_token
            // 
            this.label_token.AutoSize = true;
            this.label_token.Location = new System.Drawing.Point(48, 33);
            this.label_token.Name = "label_token";
            this.label_token.Size = new System.Drawing.Size(41, 13);
            this.label_token.TabIndex = 1;
            this.label_token.Text = "Token:";
            // 
            // textBox_token
            // 
            this.textBox_token.Location = new System.Drawing.Point(95, 30);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.Size = new System.Drawing.Size(393, 20);
            this.textBox_token.TabIndex = 2;
            // 
            // button_decodeToken
            // 
            this.button_decodeToken.Location = new System.Drawing.Point(348, 160);
            this.button_decodeToken.Name = "button_decodeToken";
            this.button_decodeToken.Size = new System.Drawing.Size(140, 23);
            this.button_decodeToken.TabIndex = 3;
            this.button_decodeToken.Text = "Decode token";
            this.button_decodeToken.UseVisualStyleBackColor = true;
            this.button_decodeToken.Click += new System.EventHandler(this.button_decodeToken_Click);
            // 
            // textBox_tokenData
            // 
            this.textBox_tokenData.Location = new System.Drawing.Point(95, 134);
            this.textBox_tokenData.Name = "textBox_tokenData";
            this.textBox_tokenData.Size = new System.Drawing.Size(393, 20);
            this.textBox_tokenData.TabIndex = 4;
            // 
            // label_tokenData
            // 
            this.label_tokenData.AutoSize = true;
            this.label_tokenData.Location = new System.Drawing.Point(24, 137);
            this.label_tokenData.Name = "label_tokenData";
            this.label_tokenData.Size = new System.Drawing.Size(65, 13);
            this.label_tokenData.TabIndex = 5;
            this.label_tokenData.Text = "Token data:";
            // 
            // TokenDBTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 212);
            this.Controls.Add(this.label_tokenData);
            this.Controls.Add(this.textBox_tokenData);
            this.Controls.Add(this.button_decodeToken);
            this.Controls.Add(this.textBox_token);
            this.Controls.Add(this.label_token);
            this.Controls.Add(this.button_createToken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenDBTesting";
            this.Text = "Token DB Concept";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_createToken;
		private System.Windows.Forms.Label label_token;
		private System.Windows.Forms.TextBox textBox_token;
		private System.Windows.Forms.Button button_decodeToken;
		private System.Windows.Forms.TextBox textBox_tokenData;
		private System.Windows.Forms.Label label_tokenData;
	}
}