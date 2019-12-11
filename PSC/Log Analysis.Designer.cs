namespace PSC
{
    partial class Log_Analysis
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
            this.button_Generate = new System.Windows.Forms.Button();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(139, 111);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(103, 35);
            this.button_Generate.TabIndex = 5;
            this.button_Generate.Text = "Generate Report";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Location = new System.Drawing.Point(320, 38);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(75, 34);
            this.button_SelectFile.TabIndex = 4;
            this.button_SelectFile.Text = "Select File";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Path.Location = new System.Drawing.Point(25, 38);
            this.textBox_Path.Multiline = true;
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(274, 34);
            this.textBox_Path.TabIndex = 3;
            // 
            // Log_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 185);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.button_SelectFile);
            this.Controls.Add(this.textBox_Path);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Log_Analysis";
            this.Text = "Log_Analysis";
            this.Load += new System.EventHandler(this.Log_Analysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.TextBox textBox_Path;
    }
}