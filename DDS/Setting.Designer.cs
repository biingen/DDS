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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_csv_script = new System.Windows.Forms.TextBox();
            this.button_csv_script = new System.Windows.Forms.Button();
            this.OpenFileDialog_CSV = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_log_folder = new System.Windows.Forms.TextBox();
            this.button_log_folder = new System.Windows.Forms.Button();
            this.folderBrowserDialog_canbuslog = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label_kline = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "serialPort1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBox3.Location = new System.Drawing.Point(60, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(60, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ComA",
            "ComB",
            "ComC",
            "ComD",
            "ComE"});
            this.comboBox1.Location = new System.Drawing.Point(60, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(205, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "serialPort2";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 16);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Enable";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBox4.Location = new System.Drawing.Point(60, 95);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(60, 69);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "ComA",
            "ComB",
            "ComC",
            "ComD",
            "ComE"});
            this.comboBox6.Location = new System.Drawing.Point(60, 44);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 1;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baudrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Portname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.comboBox8);
            this.groupBox3.Controls.Add(this.comboBox9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(402, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "serialPort3";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 16);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBox7.Location = new System.Drawing.Point(60, 95);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 20);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(60, 69);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 20);
            this.comboBox8.TabIndex = 4;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "ComA",
            "ComB",
            "ComC",
            "ComD",
            "ComE"});
            this.comboBox9.Location = new System.Drawing.Point(60, 44);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 20);
            this.comboBox9.TabIndex = 1;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Baudrate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Portname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Type:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 65;
            this.label10.Text = "Spider status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 12);
            this.label11.TabIndex = 66;
            this.label11.Text = "Comport status";
            // 
            // textBox_log_folder
            // 
            this.textBox_log_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_log_folder.Location = new System.Drawing.Point(11, 42);
            this.textBox_log_folder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.textBox_log_folder.Name = "textBox_log_folder";
            this.textBox_log_folder.Size = new System.Drawing.Size(496, 21);
            this.textBox_log_folder.TabIndex = 68;
            this.textBox_log_folder.TextChanged += new System.EventHandler(this.textBox_log_folder_TextChanged);
            // 
            // button_log_folder
            // 
            this.button_log_folder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_log_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_log_folder.Location = new System.Drawing.Point(516, 40);
            this.button_log_folder.Margin = new System.Windows.Forms.Padding(2);
            this.button_log_folder.Name = "button_log_folder";
            this.button_log_folder.Size = new System.Drawing.Size(77, 23);
            this.button_log_folder.TabIndex = 67;
            this.button_log_folder.Text = "Log Folder";
            this.button_log_folder.UseVisualStyleBackColor = true;
            this.button_log_folder.Click += new System.EventHandler(this.button_log_folder_Click);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(462, 79);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 20);
            this.comboBox10.TabIndex = 8;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.ComboBox10_SelectedIndexChanged);
            // 
            // label_kline
            // 
            this.label_kline.AutoSize = true;
            this.label_kline.Location = new System.Drawing.Point(407, 82);
            this.label_kline.Name = "label_kline";
            this.label_kline.Size = new System.Drawing.Size(55, 12);
            this.label_kline.TabIndex = 7;
            this.label_kline.Text = "Kline port:";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 256);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.textBox_log_folder);
            this.Controls.Add(this.label_kline);
            this.Controls.Add(this.button_log_folder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_csv_script);
            this.Controls.Add(this.button_csv_script);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_csv_script;
        private System.Windows.Forms.Button button_csv_script;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_CSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_log_folder;
        private System.Windows.Forms.Button button_log_folder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_canbuslog;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label_kline;
    }
}