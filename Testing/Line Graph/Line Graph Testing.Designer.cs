namespace Testing.LineGraph
{
	partial class LineGraphTesting
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
			this.button_draw = new System.Windows.Forms.Button();
			this.lineGraph = new Testing.LineGraph.LineGraph();
			this.button_increment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_draw
			// 
			this.button_draw.Location = new System.Drawing.Point(12, 12);
			this.button_draw.Name = "button_draw";
			this.button_draw.Size = new System.Drawing.Size(75, 33);
			this.button_draw.TabIndex = 1;
			this.button_draw.Text = "Draw";
			this.button_draw.UseVisualStyleBackColor = true;
			this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
			// 
			// lineGraph
			// 
			this.lineGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lineGraph.Location = new System.Drawing.Point(12, 68);
			this.lineGraph.Name = "lineGraph";
			this.lineGraph.Size = new System.Drawing.Size(200, 100);
			this.lineGraph.TabIndex = 0;
			// 
			// button_increment
			// 
			this.button_increment.Location = new System.Drawing.Point(93, 12);
			this.button_increment.Name = "button_increment";
			this.button_increment.Size = new System.Drawing.Size(75, 33);
			this.button_increment.TabIndex = 2;
			this.button_increment.Text = "Increment";
			this.button_increment.UseVisualStyleBackColor = true;
			this.button_increment.Click += new System.EventHandler(this.button_increment_Click);
			// 
			// LineGraphTesting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 180);
			this.Controls.Add(this.button_increment);
			this.Controls.Add(this.button_draw);
			this.Controls.Add(this.lineGraph);
			this.Name = "LineGraphTesting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LineGraphTesting";
			this.ResumeLayout(false);

		}

		#endregion

		private LineGraph lineGraph;
		private System.Windows.Forms.Button button_draw;
		private System.Windows.Forms.Button button_increment;
	}
}