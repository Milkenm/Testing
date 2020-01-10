namespace Testing.LineGraph
{
	partial class LineGraphConcept
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
			this.panel_graphic = new System.Windows.Forms.Panel();
			this.button_draw = new System.Windows.Forms.Button();
			this.numeric_lineXstart = new System.Windows.Forms.NumericUpDown();
			this.numeric_lineYstart = new System.Windows.Forms.NumericUpDown();
			this.numeric_lineXend = new System.Windows.Forms.NumericUpDown();
			this.numeric_lineYend = new System.Windows.Forms.NumericUpDown();
			this.label_xStart = new System.Windows.Forms.Label();
			this.label_yStart = new System.Windows.Forms.Label();
			this.label_yIncrement = new System.Windows.Forms.Label();
			this.label_xIncrement = new System.Windows.Forms.Label();
			this.button_drawTest = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineXstart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineYstart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineXend)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineYend)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_graphic
			// 
			this.panel_graphic.BackColor = System.Drawing.Color.White;
			this.panel_graphic.Location = new System.Drawing.Point(12, 69);
			this.panel_graphic.Name = "panel_graphic";
			this.panel_graphic.Size = new System.Drawing.Size(775, 512);
			this.panel_graphic.TabIndex = 0;
			this.panel_graphic.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_graphic_Paint);
			// 
			// button_draw
			// 
			this.button_draw.BackColor = System.Drawing.SystemColors.Control;
			this.button_draw.Location = new System.Drawing.Point(441, 11);
			this.button_draw.Name = "button_draw";
			this.button_draw.Size = new System.Drawing.Size(76, 32);
			this.button_draw.TabIndex = 1;
			this.button_draw.Text = "Draw";
			this.button_draw.UseVisualStyleBackColor = false;
			this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
			// 
			// numeric_lineXstart
			// 
			this.numeric_lineXstart.Location = new System.Drawing.Point(74, 12);
			this.numeric_lineXstart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_lineXstart.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numeric_lineXstart.Name = "numeric_lineXstart";
			this.numeric_lineXstart.ReadOnly = true;
			this.numeric_lineXstart.Size = new System.Drawing.Size(120, 20);
			this.numeric_lineXstart.TabIndex = 2;
			// 
			// numeric_lineYstart
			// 
			this.numeric_lineYstart.Location = new System.Drawing.Point(74, 38);
			this.numeric_lineYstart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_lineYstart.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numeric_lineYstart.Name = "numeric_lineYstart";
			this.numeric_lineYstart.ReadOnly = true;
			this.numeric_lineYstart.Size = new System.Drawing.Size(120, 20);
			this.numeric_lineYstart.TabIndex = 3;
			// 
			// numeric_lineXend
			// 
			this.numeric_lineXend.Location = new System.Drawing.Point(287, 12);
			this.numeric_lineXend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_lineXend.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numeric_lineXend.Name = "numeric_lineXend";
			this.numeric_lineXend.Size = new System.Drawing.Size(120, 20);
			this.numeric_lineXend.TabIndex = 4;
			// 
			// numeric_lineYend
			// 
			this.numeric_lineYend.Location = new System.Drawing.Point(287, 38);
			this.numeric_lineYend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_lineYend.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numeric_lineYend.Name = "numeric_lineYend";
			this.numeric_lineYend.Size = new System.Drawing.Size(120, 20);
			this.numeric_lineYend.TabIndex = 5;
			// 
			// label_xStart
			// 
			this.label_xStart.AutoSize = true;
			this.label_xStart.Location = new System.Drawing.Point(24, 15);
			this.label_xStart.Name = "label_xStart";
			this.label_xStart.Size = new System.Drawing.Size(44, 13);
			this.label_xStart.TabIndex = 4;
			this.label_xStart.Text = "Initial X:";
			// 
			// label_yStart
			// 
			this.label_yStart.AutoSize = true;
			this.label_yStart.Location = new System.Drawing.Point(24, 41);
			this.label_yStart.Name = "label_yStart";
			this.label_yStart.Size = new System.Drawing.Size(44, 13);
			this.label_yStart.TabIndex = 5;
			this.label_yStart.Text = "Initial Y:";
			// 
			// label_yIncrement
			// 
			this.label_yIncrement.AutoSize = true;
			this.label_yIncrement.Location = new System.Drawing.Point(214, 41);
			this.label_yIncrement.Name = "label_yIncrement";
			this.label_yIncrement.Size = new System.Drawing.Size(67, 13);
			this.label_yIncrement.TabIndex = 7;
			this.label_yIncrement.Text = "Y Increment:";
			// 
			// label_xIncrement
			// 
			this.label_xIncrement.AutoSize = true;
			this.label_xIncrement.Location = new System.Drawing.Point(214, 15);
			this.label_xIncrement.Name = "label_xIncrement";
			this.label_xIncrement.Size = new System.Drawing.Size(67, 13);
			this.label_xIncrement.TabIndex = 6;
			this.label_xIncrement.Text = "X Increment:";
			// 
			// button_drawTest
			// 
			this.button_drawTest.BackColor = System.Drawing.SystemColors.Control;
			this.button_drawTest.Location = new System.Drawing.Point(523, 11);
			this.button_drawTest.Name = "button_drawTest";
			this.button_drawTest.Size = new System.Drawing.Size(76, 32);
			this.button_drawTest.TabIndex = 8;
			this.button_drawTest.Text = "Draw Test";
			this.button_drawTest.UseVisualStyleBackColor = false;
			this.button_drawTest.Click += new System.EventHandler(this.button_drawTest_Click);
			// 
			// LineGraphConcept
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(799, 593);
			this.Controls.Add(this.button_drawTest);
			this.Controls.Add(this.button_draw);
			this.Controls.Add(this.label_yIncrement);
			this.Controls.Add(this.label_xIncrement);
			this.Controls.Add(this.numeric_lineYend);
			this.Controls.Add(this.numeric_lineXend);
			this.Controls.Add(this.label_yStart);
			this.Controls.Add(this.label_xStart);
			this.Controls.Add(this.numeric_lineYstart);
			this.Controls.Add(this.numeric_lineXstart);
			this.Controls.Add(this.panel_graphic);
			this.Name = "LineGraphConcept";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Line Graphic";
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineXstart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineYstart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineXend)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_lineYend)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel_graphic;
		private System.Windows.Forms.Button button_draw;
		private System.Windows.Forms.NumericUpDown numeric_lineXstart;
		private System.Windows.Forms.NumericUpDown numeric_lineYstart;
		private System.Windows.Forms.NumericUpDown numeric_lineXend;
		private System.Windows.Forms.NumericUpDown numeric_lineYend;
		private System.Windows.Forms.Label label_xStart;
		private System.Windows.Forms.Label label_yStart;
		private System.Windows.Forms.Label label_yIncrement;
		private System.Windows.Forms.Label label_xIncrement;
		private System.Windows.Forms.Button button_drawTest;
	}
}

