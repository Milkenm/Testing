namespace Fatorial
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
			this.textBox_numero = new System.Windows.Forms.TextBox();
			this.label_resultado = new System.Windows.Forms.Label();
			this.listBox_calculo = new System.Windows.Forms.ListBox();
			this.button_calcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_numero
			// 
			this.textBox_numero.Location = new System.Drawing.Point(20, 13);
			this.textBox_numero.Name = "textBox_numero";
			this.textBox_numero.Size = new System.Drawing.Size(143, 20);
			this.textBox_numero.TabIndex = 0;
			// 
			// label_resultado
			// 
			this.label_resultado.AutoSize = true;
			this.label_resultado.Location = new System.Drawing.Point(20, 69);
			this.label_resultado.Name = "label_resultado";
			this.label_resultado.Size = new System.Drawing.Size(58, 13);
			this.label_resultado.TabIndex = 1;
			this.label_resultado.Text = "Resultado:";
			// 
			// listBox_calculo
			// 
			this.listBox_calculo.FormattingEnabled = true;
			this.listBox_calculo.Location = new System.Drawing.Point(23, 101);
			this.listBox_calculo.Name = "listBox_calculo";
			this.listBox_calculo.Size = new System.Drawing.Size(140, 199);
			this.listBox_calculo.TabIndex = 2;
			// 
			// button_calcular
			// 
			this.button_calcular.Location = new System.Drawing.Point(20, 39);
			this.button_calcular.Name = "button_calcular";
			this.button_calcular.Size = new System.Drawing.Size(143, 27);
			this.button_calcular.TabIndex = 3;
			this.button_calcular.Text = "Calcular";
			this.button_calcular.UseVisualStyleBackColor = true;
			this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 313);
			this.Controls.Add(this.button_calcular);
			this.Controls.Add(this.listBox_calculo);
			this.Controls.Add(this.label_resultado);
			this.Controls.Add(this.textBox_numero);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fatorial";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_numero;
		private System.Windows.Forms.Label label_resultado;
		private System.Windows.Forms.ListBox listBox_calculo;
		private System.Windows.Forms.Button button_calcular;
	}
}

