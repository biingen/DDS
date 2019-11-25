namespace DDS
{
    partial class Setting
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
            this.textBox_csv_script = new System.Windows.Forms.TextBox();
            this.button_csv_script = new System.Windows.Forms.Button();
            this.OpenFileDialog_CSV = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_canbuslog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox_csv_script
            // 
            this.textBox_csv_script.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_csv_script.Location = new System.Drawing.Point(11, 11);
            this.textBox_csv_script.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.textBox_csv_script.Name = "textBox_csv_script";
            this.textBox_csv_script.Size = new System.Drawing.Size(496, 21);
            this.textBox_csv_script.TabIndex = 64;
            this.textBox_csv_script.TextChanged += new System.EventHandler(this.textBox_csv_script_TextChanged);
            // 
            // button_csv_script
            // 
            this.button_csv_script.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_csv_script.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_csv_script.Location = new System.Drawing.Point(516, 9);
            this.button_csv_script.Margin = new System.Windows.Forms.Padding(2);
            this.button_csv_script.Name = "button_csv_script";
            this.button_csv_script.Size = new System.Drawing.Size(77, 23);
            this.button_csv_script.TabIndex = 63;
            this.button_csv_script.Text = "CSV Script";
            this.button_csv_script.UseVisualStyleBackColor = true;
            this.button_csv_script.Click += new System.EventHandler(this.button_csv_script_Click);
            // 
            // OpenFileDialog_CSV
            // 
            this.OpenFileDialog_CSV.FileName = "OpenFileDialog_CSV";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 38);
            this.Controls.Add(this.textBox_csv_script);
            this.Controls.Add(this.button_csv_script);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_csv_script;
        private System.Windows.Forms.Button button_csv_script;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_CSV;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_canbuslog;
    }
}