namespace PSC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.setting_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_MonitorID = new System.Windows.Forms.TextBox();
            this.comboBox_Serialport = new System.Windows.Forms.ComboBox();
            this.textBox_times = new System.Windows.Forms.TextBox();
            this.label_comport = new System.Windows.Forms.Label();
            this.label_monitorid = new System.Windows.Forms.Label();
            this.label_times = new System.Windows.Forms.Label();
            this.label_function = new System.Windows.Forms.Label();
            this.comboBox_function = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar_monitorID = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_button
            // 
            this.setting_button.Location = new System.Drawing.Point(660, 12);
            this.setting_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(79, 32);
            this.setting_button.TabIndex = 34;
            this.setting_button.Text = "Setting";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Remark});
            this.dataGridView1.Location = new System.Drawing.Point(831, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(61, 38);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Interface";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Com";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Control Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Command";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "> Initial > Freq_Initial";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "> Status_On > Freq_Min";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "> Remark_On > Freq_Max";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "> Status_Off > Freq_Step";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "> Remark_Off > Duty_Initial";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Duty_Min";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Duty_Max";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Duty_Step";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(844, 14);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(79, 32);
            this.button_Save.TabIndex = 36;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_MonitorID
            // 
            this.textBox_MonitorID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_MonitorID.Location = new System.Drawing.Point(248, 12);
            this.textBox_MonitorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MonitorID.Name = "textBox_MonitorID";
            this.textBox_MonitorID.Size = new System.Drawing.Size(85, 25);
            this.textBox_MonitorID.TabIndex = 37;
            // 
            // comboBox_Serialport
            // 
            this.comboBox_Serialport.FormattingEnabled = true;
            this.comboBox_Serialport.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox_Serialport.Location = new System.Drawing.Point(73, 14);
            this.comboBox_Serialport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Serialport.Name = "comboBox_Serialport";
            this.comboBox_Serialport.Size = new System.Drawing.Size(72, 23);
            this.comboBox_Serialport.TabIndex = 38;
            // 
            // textBox_times
            // 
            this.textBox_times.Location = new System.Drawing.Point(544, 14);
            this.textBox_times.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_times.Name = "textBox_times";
            this.textBox_times.Size = new System.Drawing.Size(85, 25);
            this.textBox_times.TabIndex = 39;
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comport.Location = new System.Drawing.Point(4, 18);
            this.label_comport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(66, 18);
            this.label_comport.TabIndex = 40;
            this.label_comport.Text = "Comport:";
            // 
            // label_monitorid
            // 
            this.label_monitorid.AutoSize = true;
            this.label_monitorid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monitorid.Location = new System.Drawing.Point(155, 19);
            this.label_monitorid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_monitorid.Name = "label_monitorid";
            this.label_monitorid.Size = new System.Drawing.Size(78, 18);
            this.label_monitorid.TabIndex = 41;
            this.label_monitorid.Text = "Monitor ID:";
            // 
            // label_times
            // 
            this.label_times.AutoSize = true;
            this.label_times.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_times.Location = new System.Drawing.Point(489, 18);
            this.label_times.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_times.Name = "label_times";
            this.label_times.Size = new System.Drawing.Size(49, 18);
            this.label_times.TabIndex = 42;
            this.label_times.Text = "Times:";
            // 
            // label_function
            // 
            this.label_function.AutoSize = true;
            this.label_function.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_function.Location = new System.Drawing.Point(337, 18);
            this.label_function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_function.Name = "label_function";
            this.label_function.Size = new System.Drawing.Size(65, 18);
            this.label_function.TabIndex = 43;
            this.label_function.Text = "Function:";
            // 
            // comboBox_function
            // 
            this.comboBox_function.FormattingEnabled = true;
            this.comboBox_function.Items.AddRange(new object[] {
            "R",
            "W"});
            this.comboBox_function.Location = new System.Drawing.Point(409, 14);
            this.comboBox_function.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_function.Name = "comboBox_function";
            this.comboBox_function.Size = new System.Drawing.Size(72, 23);
            this.comboBox_function.TabIndex = 44;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(747, 12);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 32);
            this.button_clear.TabIndex = 45;
            this.button_clear.Text = "Clear all";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hScrollBar_monitorID);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox_Serialport);
            this.panel1.Controls.Add(this.comboBox_function);
            this.panel1.Controls.Add(this.textBox_times);
            this.panel1.Controls.Add(this.label_comport);
            this.panel1.Controls.Add(this.textBox_MonitorID);
            this.panel1.Controls.Add(this.label_function);
            this.panel1.Controls.Add(this.label_monitorid);
            this.panel1.Controls.Add(this.setting_button);
            this.panel1.Controls.Add(this.label_times);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 86);
            this.panel1.TabIndex = 46;
            // 
            // hScrollBar_monitorID
            // 
            this.hScrollBar_monitorID.LargeChange = 1;
            this.hScrollBar_monitorID.Location = new System.Drawing.Point(159, 49);
            this.hScrollBar_monitorID.Minimum = 1;
            this.hScrollBar_monitorID.Name = "hScrollBar_monitorID";
            this.hScrollBar_monitorID.Size = new System.Drawing.Size(176, 17);
            this.hScrollBar_monitorID.TabIndex = 48;
            this.hScrollBar_monitorID.Value = 1;
            this.hScrollBar_monitorID.ValueChanged += new System.EventHandler(this.hScrollBar_monitorID_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(921, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 27);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "Version:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 47;
            this.button1.Text = "Log Analysis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 839);
            this.panel2.TabIndex = 47;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 875);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "PID Schedule Create";
            this.Load += new System.EventHandler(this.DDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_MonitorID;
        private System.Windows.Forms.ComboBox comboBox_Serialport;
        private System.Windows.Forms.TextBox textBox_times;
        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.Label label_monitorid;
        private System.Windows.Forms.Label label_times;
        private System.Windows.Forms.Label label_function;
        private System.Windows.Forms.ComboBox comboBox_function;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar_monitorID;
    }
}

