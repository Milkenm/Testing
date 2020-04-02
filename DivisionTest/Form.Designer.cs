namespace DivisionTest
{
	partial class Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.numeric_firstValue = new System.Windows.Forms.NumericUpDown();
			this.numeric_secondValue = new System.Windows.Forms.NumericUpDown();
			this.label_percentage = new System.Windows.Forms.Label();
			this.label_equals = new System.Windows.Forms.Label();
			this.textBox_result = new System.Windows.Forms.TextBox();
			this.timer_refresh = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numeric_firstValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_secondValue)).BeginInit();
			this.SuspendLayout();
			// 
			// numeric_firstValue
			// 
			this.numeric_firstValue.Location = new System.Drawing.Point(30, 37);
			this.numeric_firstValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_firstValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numeric_firstValue.Name = "numeric_firstValue";
			this.numeric_firstValue.Size = new System.Drawing.Size(120, 20);
			this.numeric_firstValue.TabIndex = 0;
			this.numeric_firstValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numeric_secondValue
			// 
			this.numeric_secondValue.Location = new System.Drawing.Point(177, 37);
			this.numeric_secondValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numeric_secondValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numeric_secondValue.Name = "numeric_secondValue";
			this.numeric_secondValue.Size = new System.Drawing.Size(120, 20);
			this.numeric_secondValue.TabIndex = 1;
			this.numeric_secondValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_percentage
			// 
			this.label_percentage.AutoSize = true;
			this.label_percentage.Location = new System.Drawing.Point(156, 40);
			this.label_percentage.Name = "label_percentage";
			this.label_percentage.Size = new System.Drawing.Size(15, 13);
			this.label_percentage.TabIndex = 2;
			this.label_percentage.Text = "%";
			// 
			// label_equals
			// 
			this.label_equals.AutoSize = true;
			this.label_equals.Location = new System.Drawing.Point(303, 39);
			this.label_equals.Name = "label_equals";
			this.label_equals.Size = new System.Drawing.Size(13, 13);
			this.label_equals.TabIndex = 3;
			this.label_equals.Text = "=";
			// 
			// textBox_result
			// 
			this.textBox_result.Location = new System.Drawing.Point(322, 37);
			this.textBox_result.Name = "textBox_result";
			this.textBox_result.ReadOnly = true;
			this.textBox_result.Size = new System.Drawing.Size(100, 20);
			this.textBox_result.TabIndex = 5;
			// 
			// timer_refresh
			// 
			this.timer_refresh.Enabled = true;
			this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 95);
			this.Controls.Add(this.numeric_firstValue);
			this.Controls.Add(this.label_percentage);
			this.Controls.Add(this.numeric_secondValue);
			this.Controls.Add(this.label_equals);
			this.Controls.Add(this.textBox_result);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form";
			this.Text = "Division Test";
			((System.ComponentModel.ISupportInitialize)(this.numeric_firstValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_secondValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numeric_firstValue;
		private System.Windows.Forms.NumericUpDown numeric_secondValue;
		private System.Windows.Forms.Label label_percentage;
		private System.Windows.Forms.Label label_equals;
		private System.Windows.Forms.TextBox textBox_result;
		private System.Windows.Forms.Timer timer_refresh;
	}
}

