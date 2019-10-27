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
			this.button_lineGraph_concept = new System.Windows.Forms.Button();
			this.button_lineGraph_testing = new System.Windows.Forms.Button();
			this.groupBox_lineGraph.SuspendLayout();
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
			// Launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 107);
			this.Controls.Add(this.groupBox_lineGraph);
			this.Name = "Launcher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Launcher";
			this.groupBox_lineGraph.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_lineGraph;
		private System.Windows.Forms.Button button_lineGraph_testing;
		private System.Windows.Forms.Button button_lineGraph_concept;
	}
}