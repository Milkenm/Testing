namespace Testing
{
	partial class Launcher
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
			this.groupBox_lineGraph = new System.Windows.Forms.GroupBox();
			this.button_lineGraph_testing = new System.Windows.Forms.Button();
			this.button_lineGraph_concept = new System.Windows.Forms.Button();
			this.groupBox_riotApi = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox_lineGraph.SuspendLayout();
			this.groupBox_riotApi.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_lineGraph
			// 
			this.groupBox_lineGraph.Controls.Add(this.button_lineGraph_testing);
			this.groupBox_lineGraph.Controls.Add(this.button_lineGraph_concept);
			this.groupBox_lineGraph.Location = new System.Drawing.Point(12, 12);
			this.groupBox_lineGraph.Name = "groupBox_lineGraph";
			this.groupBox_lineGraph.Size = new System.Drawing.Size(173, 85);
			this.groupBox_lineGraph.TabIndex = 0;
			this.groupBox_lineGraph.TabStop = false;
			this.groupBox_lineGraph.Text = "Line Graph";
			// 
			// button_lineGraph_testing
			// 
			this.button_lineGraph_testing.Location = new System.Drawing.Point(6, 48);
			this.button_lineGraph_testing.Name = "button_lineGraph_testing";
			this.button_lineGraph_testing.Size = new System.Drawing.Size(161, 23);
			this.button_lineGraph_testing.TabIndex = 1;
			this.button_lineGraph_testing.Text = "Testing";
			this.button_lineGraph_testing.UseVisualStyleBackColor = true;
			this.button_lineGraph_testing.Click += new System.EventHandler(this.button_lineGraph_testing_Click);
			// 
			// button_lineGraph_concept
			// 
			this.button_lineGraph_concept.Location = new System.Drawing.Point(6, 19);
			this.button_lineGraph_concept.Name = "button_lineGraph_concept";
			this.button_lineGraph_concept.Size = new System.Drawing.Size(161, 23);
			this.button_lineGraph_concept.TabIndex = 0;
			this.button_lineGraph_concept.Text = "Concept";
			this.button_lineGraph_concept.UseVisualStyleBackColor = true;
			this.button_lineGraph_concept.Click += new System.EventHandler(this.button_lineGraph_concept_Click);
			// 
			// groupBox_riotApi
			// 
			this.groupBox_riotApi.Controls.Add(this.button1);
			this.groupBox_riotApi.Location = new System.Drawing.Point(12, 103);
			this.groupBox_riotApi.Name = "groupBox_riotApi";
			this.groupBox_riotApi.Size = new System.Drawing.Size(173, 54);
			this.groupBox_riotApi.TabIndex = 2;
			this.groupBox_riotApi.TabStop = false;
			this.groupBox_riotApi.Text = "Riot API";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Testing";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 168);
			this.Controls.Add(this.groupBox_riotApi);
			this.Controls.Add(this.groupBox_lineGraph);
			this.Name = "Launcher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Launcher";
			this.groupBox_lineGraph.ResumeLayout(false);
			this.groupBox_riotApi.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_lineGraph;
		private System.Windows.Forms.Button button_lineGraph_testing;
		private System.Windows.Forms.Button button_lineGraph_concept;
		private System.Windows.Forms.GroupBox groupBox_riotApi;
		private System.Windows.Forms.Button button1;
	}
}