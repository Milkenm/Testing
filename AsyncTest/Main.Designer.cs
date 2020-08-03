namespace AsyncTest
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
            this.button_runTaskAsync = new System.Windows.Forms.Button();
            this.button_runTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_runTaskAsync
            // 
            this.button_runTaskAsync.Location = new System.Drawing.Point(49, 33);
            this.button_runTaskAsync.Name = "button_runTaskAsync";
            this.button_runTaskAsync.Size = new System.Drawing.Size(92, 47);
            this.button_runTaskAsync.TabIndex = 1;
            this.button_runTaskAsync.Text = "Run Task Async";
            this.button_runTaskAsync.UseVisualStyleBackColor = true;
            this.button_runTaskAsync.Click += new System.EventHandler(this.button_runTaskAsync_Click);
            // 
            // button_runTask
            // 
            this.button_runTask.Location = new System.Drawing.Point(186, 33);
            this.button_runTask.Name = "button_runTask";
            this.button_runTask.Size = new System.Drawing.Size(92, 47);
            this.button_runTask.TabIndex = 2;
            this.button_runTask.Text = "Run Task";
            this.button_runTask.UseVisualStyleBackColor = true;
            this.button_runTask.Click += new System.EventHandler(this.button_runTask_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 113);
            this.Controls.Add(this.button_runTaskAsync);
            this.Controls.Add(this.button_runTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Async Test";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_runTaskAsync;
        private System.Windows.Forms.Button button_runTask;
    }
}

