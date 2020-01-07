namespace DDS
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
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.setting_button = new System.Windows.Forms.Button();
            this.SerialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SerialPort3 = new System.IO.Ports.SerialPort(this.components);
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
            this.Autokit_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label_autokit_status = new System.Windows.Forms.Label();
            this.Group_CAN_Reader = new System.Windows.Forms.GroupBox();
            this.Group_Driving_Status = new System.Windows.Forms.GroupBox();
            this.Value_Fuel_LPK = new System.Windows.Forms.TextBox();
            this.Value_Battery = new System.Windows.Forms.TextBox();
            this.Label_Battery = new System.Windows.Forms.Label();
            this.Value_RoomTemp = new System.Windows.Forms.TextBox();
            this.Value_Fuel = new System.Windows.Forms.TextBox();
            this.Label_RoomTemp = new System.Windows.Forms.Label();
            this.Label_Fuel = new System.Windows.Forms.Label();
            this.Value_WaterTemp = new System.Windows.Forms.TextBox();
            this.Label_WaterTemp = new System.Windows.Forms.Label();
            this.Value_AveSpeed = new System.Windows.Forms.TextBox();
            this.Value_FuelConsumption = new System.Windows.Forms.TextBox();
            this.Label_AveSpeed = new System.Windows.Forms.Label();
            this.Label_FuelConsumption = new System.Windows.Forms.Label();
            this.Value_MaxSpeed = new System.Windows.Forms.TextBox();
            this.Label_MaxSpeed = new System.Windows.Forms.Label();
            this.Value_EngineRPM = new System.Windows.Forms.TextBox();
            this.Value_TotalMileage = new System.Windows.Forms.TextBox();
            this.Label_EngineRPM = new System.Windows.Forms.Label();
            this.Label_TotalMileage = new System.Windows.Forms.Label();
            this.Value_Speed = new System.Windows.Forms.TextBox();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.Group_Car_Status_Indicator = new System.Windows.Forms.GroupBox();
            this.Status_RearTirePressure = new System.Windows.Forms.RadioButton();
            this.Status_FrontTirePressure = new System.Windows.Forms.RadioButton();
            this.Status_Maintenance = new System.Windows.Forms.RadioButton();
            this.Status_WaterTemp = new System.Windows.Forms.RadioButton();
            this.Status_ABS = new System.Windows.Forms.RadioButton();
            this.Status_Fuel = new System.Windows.Forms.RadioButton();
            this.Status_EngineOil = new System.Windows.Forms.RadioButton();
            this.Status_OnOff = new System.Windows.Forms.RadioButton();
            this.listBox_Info = new System.Windows.Forms.ListBox();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.label_canbus_status = new System.Windows.Forms.Label();
            this.Group_ABS_Error_Code = new System.Windows.Forms.GroupBox();
            this.Kline_ABS_0x5025 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5044 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5052 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5042 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5053 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5045 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5014 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5043 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5018 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5035 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5013 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5017 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5019 = new System.Windows.Forms.CheckBox();
            this.Kline_ABS_0x5055 = new System.Windows.Forms.CheckBox();
            this.Group_OBD_Error_Code = new System.Windows.Forms.GroupBox();
            this.Kline_OBD_U0486 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0426 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0122 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0121 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0002 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0140 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0001 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_U0128 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P2600 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P2158 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P1800 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P1607 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P1536 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P1310 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0620_PIN31 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P1300 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0620_PIN2 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0A0F = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0606 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0655 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0605 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0650 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0604 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0601 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0560 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0512 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0500 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0480 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0410 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0505 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0352 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0501 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0351 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0336 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0335 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0230 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0217 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0202 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0130 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0201 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0120 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0155 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0115 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0150 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0110 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0135 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0105 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_C0085 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_C0083 = new System.Windows.Forms.CheckBox();
            this.Kline_OBD_P0503 = new System.Windows.Forms.CheckBox();
            this.tmr_FetchingUARTInput = new System.Windows.Forms.Timer(this.components);
            this.rtbKLineData = new System.Windows.Forms.RichTextBox();
            this.Group_DTC_data_option = new System.Windows.Forms.GroupBox();
            this.DTC_option_all_in_turn = new System.Windows.Forms.RadioButton();
            this.DTC_option_first_six = new System.Windows.Forms.RadioButton();
            this.label_Kline_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Can_OBD_U0486 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0426 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0122 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0121 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0002 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0140 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0001 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_U0128 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P2600 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P2158 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P1800 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P1607 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P1536 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P1310 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0620_PIN31 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P1300 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0620_PIN2 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0A0F = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0606 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0655 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0605 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0650 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0604 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0601 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0560 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0512 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0500 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0480 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0410 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0505 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0352 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0501 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0351 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0336 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0335 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0230 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0217 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0202 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0130 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0201 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0120 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0155 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0115 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0150 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0110 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0135 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0105 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_C0085 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_C0083 = new System.Windows.Forms.RadioButton();
            this.Can_OBD_P0503 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Can_ABS_0x5025 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5044 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5052 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5042 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5053 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5045 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5014 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5043 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5018 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5035 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5013 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5017 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5019 = new System.Windows.Forms.RadioButton();
            this.Can_ABS_0x5055 = new System.Windows.Forms.RadioButton();
            this.button_canbus_calulate = new System.Windows.Forms.Button();
            this.button_canbus_write = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Group_CAN_Reader.SuspendLayout();
            this.Group_Driving_Status.SuspendLayout();
            this.Group_Car_Status_Indicator.SuspendLayout();
            this.Group_ABS_Error_Code.SuspendLayout();
            this.Group_OBD_Error_Code.SuspendLayout();
            this.Group_DTC_data_option.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_button
            // 
            this.setting_button.Location = new System.Drawing.Point(201, 9);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(59, 32);
            this.setting_button.TabIndex = 16;
            this.setting_button.Text = "Setting";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.settings_button_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(293, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(54, 32);
            this.dataGridView1.TabIndex = 20;
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
            // label_autokit_status
            // 
            this.label_autokit_status.AutoSize = true;
            this.label_autokit_status.Location = new System.Drawing.Point(12, 3);
            this.label_autokit_status.Name = "label_autokit_status";
            this.label_autokit_status.Size = new System.Drawing.Size(68, 12);
            this.label_autokit_status.TabIndex = 21;
            this.label_autokit_status.Text = "Autokit status";
            // 
            // Group_CAN_Reader
            // 
            this.Group_CAN_Reader.Controls.Add(this.Group_Driving_Status);
            this.Group_CAN_Reader.Controls.Add(this.Group_Car_Status_Indicator);
            this.Group_CAN_Reader.Controls.Add(this.listBox_Info);
            this.Group_CAN_Reader.Location = new System.Drawing.Point(973, 92);
            this.Group_CAN_Reader.Margin = new System.Windows.Forms.Padding(2);
            this.Group_CAN_Reader.Name = "Group_CAN_Reader";
            this.Group_CAN_Reader.Padding = new System.Windows.Forms.Padding(2);
            this.Group_CAN_Reader.Size = new System.Drawing.Size(340, 914);
            this.Group_CAN_Reader.TabIndex = 22;
            this.Group_CAN_Reader.TabStop = false;
            this.Group_CAN_Reader.Text = "CAN";
            // 
            // Group_Driving_Status
            // 
            this.Group_Driving_Status.Controls.Add(this.Value_Fuel_LPK);
            this.Group_Driving_Status.Controls.Add(this.Value_Battery);
            this.Group_Driving_Status.Controls.Add(this.Label_Battery);
            this.Group_Driving_Status.Controls.Add(this.Value_RoomTemp);
            this.Group_Driving_Status.Controls.Add(this.Value_Fuel);
            this.Group_Driving_Status.Controls.Add(this.Label_RoomTemp);
            this.Group_Driving_Status.Controls.Add(this.Label_Fuel);
            this.Group_Driving_Status.Controls.Add(this.Value_WaterTemp);
            this.Group_Driving_Status.Controls.Add(this.Label_WaterTemp);
            this.Group_Driving_Status.Controls.Add(this.Value_AveSpeed);
            this.Group_Driving_Status.Controls.Add(this.Value_FuelConsumption);
            this.Group_Driving_Status.Controls.Add(this.Label_AveSpeed);
            this.Group_Driving_Status.Controls.Add(this.Label_FuelConsumption);
            this.Group_Driving_Status.Controls.Add(this.Value_MaxSpeed);
            this.Group_Driving_Status.Controls.Add(this.Label_MaxSpeed);
            this.Group_Driving_Status.Controls.Add(this.Value_EngineRPM);
            this.Group_Driving_Status.Controls.Add(this.Value_TotalMileage);
            this.Group_Driving_Status.Controls.Add(this.Label_EngineRPM);
            this.Group_Driving_Status.Controls.Add(this.Label_TotalMileage);
            this.Group_Driving_Status.Controls.Add(this.Value_Speed);
            this.Group_Driving_Status.Controls.Add(this.Label_Speed);
            this.Group_Driving_Status.Location = new System.Drawing.Point(8, 186);
            this.Group_Driving_Status.Margin = new System.Windows.Forms.Padding(2);
            this.Group_Driving_Status.Name = "Group_Driving_Status";
            this.Group_Driving_Status.Padding = new System.Windows.Forms.Padding(2);
            this.Group_Driving_Status.Size = new System.Drawing.Size(322, 161);
            this.Group_Driving_Status.TabIndex = 13;
            this.Group_Driving_Status.TabStop = false;
            this.Group_Driving_Status.Text = "Driving Status";
            // 
            // Value_Fuel_LPK
            // 
            this.Value_Fuel_LPK.Location = new System.Drawing.Point(82, 86);
            this.Value_Fuel_LPK.Margin = new System.Windows.Forms.Padding(2);
            this.Value_Fuel_LPK.Name = "Value_Fuel_LPK";
            this.Value_Fuel_LPK.ReadOnly = true;
            this.Value_Fuel_LPK.Size = new System.Drawing.Size(84, 22);
            this.Value_Fuel_LPK.TabIndex = 29;
            this.Value_Fuel_LPK.Text = "No Data";
            this.Value_Fuel_LPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_Battery
            // 
            this.Value_Battery.Location = new System.Drawing.Point(254, 135);
            this.Value_Battery.Margin = new System.Windows.Forms.Padding(2);
            this.Value_Battery.Name = "Value_Battery";
            this.Value_Battery.ReadOnly = true;
            this.Value_Battery.Size = new System.Drawing.Size(54, 22);
            this.Value_Battery.TabIndex = 27;
            this.Value_Battery.Text = "No Data";
            this.Value_Battery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Battery
            // 
            this.Label_Battery.AutoSize = true;
            this.Label_Battery.Location = new System.Drawing.Point(181, 136);
            this.Label_Battery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Battery.Name = "Label_Battery";
            this.Label_Battery.Size = new System.Drawing.Size(39, 12);
            this.Label_Battery.TabIndex = 26;
            this.Label_Battery.Text = "Battery";
            // 
            // Value_RoomTemp
            // 
            this.Value_RoomTemp.Location = new System.Drawing.Point(82, 135);
            this.Value_RoomTemp.Margin = new System.Windows.Forms.Padding(2);
            this.Value_RoomTemp.Name = "Value_RoomTemp";
            this.Value_RoomTemp.ReadOnly = true;
            this.Value_RoomTemp.Size = new System.Drawing.Size(54, 22);
            this.Value_RoomTemp.TabIndex = 23;
            this.Value_RoomTemp.Text = "No Data";
            this.Value_RoomTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_Fuel
            // 
            this.Value_Fuel.Location = new System.Drawing.Point(254, 111);
            this.Value_Fuel.Margin = new System.Windows.Forms.Padding(2);
            this.Value_Fuel.Name = "Value_Fuel";
            this.Value_Fuel.ReadOnly = true;
            this.Value_Fuel.Size = new System.Drawing.Size(54, 22);
            this.Value_Fuel.TabIndex = 25;
            this.Value_Fuel.Text = "No Data";
            this.Value_Fuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_RoomTemp
            // 
            this.Label_RoomTemp.AutoSize = true;
            this.Label_RoomTemp.Location = new System.Drawing.Point(10, 136);
            this.Label_RoomTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_RoomTemp.Name = "Label_RoomTemp";
            this.Label_RoomTemp.Size = new System.Drawing.Size(64, 12);
            this.Label_RoomTemp.TabIndex = 22;
            this.Label_RoomTemp.Text = "Temperature";
            // 
            // Label_Fuel
            // 
            this.Label_Fuel.AutoSize = true;
            this.Label_Fuel.Location = new System.Drawing.Point(181, 112);
            this.Label_Fuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Fuel.Name = "Label_Fuel";
            this.Label_Fuel.Size = new System.Drawing.Size(25, 12);
            this.Label_Fuel.TabIndex = 24;
            this.Label_Fuel.Text = "Fuel";
            // 
            // Value_WaterTemp
            // 
            this.Value_WaterTemp.Location = new System.Drawing.Point(82, 111);
            this.Value_WaterTemp.Margin = new System.Windows.Forms.Padding(2);
            this.Value_WaterTemp.Name = "Value_WaterTemp";
            this.Value_WaterTemp.ReadOnly = true;
            this.Value_WaterTemp.Size = new System.Drawing.Size(54, 22);
            this.Value_WaterTemp.TabIndex = 21;
            this.Value_WaterTemp.Text = "No Data";
            this.Value_WaterTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_WaterTemp
            // 
            this.Label_WaterTemp.AutoSize = true;
            this.Label_WaterTemp.Location = new System.Drawing.Point(10, 114);
            this.Label_WaterTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_WaterTemp.Name = "Label_WaterTemp";
            this.Label_WaterTemp.Size = new System.Drawing.Size(63, 12);
            this.Label_WaterTemp.TabIndex = 20;
            this.Label_WaterTemp.Text = "Water Temp";
            // 
            // Value_AveSpeed
            // 
            this.Value_AveSpeed.Location = new System.Drawing.Point(254, 62);
            this.Value_AveSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.Value_AveSpeed.Name = "Value_AveSpeed";
            this.Value_AveSpeed.ReadOnly = true;
            this.Value_AveSpeed.Size = new System.Drawing.Size(54, 22);
            this.Value_AveSpeed.TabIndex = 19;
            this.Value_AveSpeed.Text = "No Data";
            this.Value_AveSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_FuelConsumption
            // 
            this.Value_FuelConsumption.Location = new System.Drawing.Point(82, 62);
            this.Value_FuelConsumption.Margin = new System.Windows.Forms.Padding(2);
            this.Value_FuelConsumption.Name = "Value_FuelConsumption";
            this.Value_FuelConsumption.ReadOnly = true;
            this.Value_FuelConsumption.Size = new System.Drawing.Size(54, 22);
            this.Value_FuelConsumption.TabIndex = 13;
            this.Value_FuelConsumption.Text = "No Data";
            this.Value_FuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_AveSpeed
            // 
            this.Label_AveSpeed.AutoSize = true;
            this.Label_AveSpeed.Location = new System.Drawing.Point(181, 64);
            this.Label_AveSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_AveSpeed.Name = "Label_AveSpeed";
            this.Label_AveSpeed.Size = new System.Drawing.Size(75, 12);
            this.Label_AveSpeed.TabIndex = 18;
            this.Label_AveSpeed.Text = "Average Speed";
            // 
            // Label_FuelConsumption
            // 
            this.Label_FuelConsumption.AutoSize = true;
            this.Label_FuelConsumption.Location = new System.Drawing.Point(10, 64);
            this.Label_FuelConsumption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_FuelConsumption.Name = "Label_FuelConsumption";
            this.Label_FuelConsumption.Size = new System.Drawing.Size(68, 12);
            this.Label_FuelConsumption.TabIndex = 12;
            this.Label_FuelConsumption.Text = "Consumption";
            // 
            // Value_MaxSpeed
            // 
            this.Value_MaxSpeed.Location = new System.Drawing.Point(254, 38);
            this.Value_MaxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.Value_MaxSpeed.Name = "Value_MaxSpeed";
            this.Value_MaxSpeed.ReadOnly = true;
            this.Value_MaxSpeed.Size = new System.Drawing.Size(54, 22);
            this.Value_MaxSpeed.TabIndex = 17;
            this.Value_MaxSpeed.Text = "No Data";
            this.Value_MaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_MaxSpeed
            // 
            this.Label_MaxSpeed.AutoSize = true;
            this.Label_MaxSpeed.Location = new System.Drawing.Point(181, 40);
            this.Label_MaxSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_MaxSpeed.Name = "Label_MaxSpeed";
            this.Label_MaxSpeed.Size = new System.Drawing.Size(57, 12);
            this.Label_MaxSpeed.TabIndex = 16;
            this.Label_MaxSpeed.Text = "Max Speed";
            // 
            // Value_EngineRPM
            // 
            this.Value_EngineRPM.Location = new System.Drawing.Point(82, 38);
            this.Value_EngineRPM.Margin = new System.Windows.Forms.Padding(2);
            this.Value_EngineRPM.Name = "Value_EngineRPM";
            this.Value_EngineRPM.ReadOnly = true;
            this.Value_EngineRPM.Size = new System.Drawing.Size(54, 22);
            this.Value_EngineRPM.TabIndex = 11;
            this.Value_EngineRPM.Text = "No Data";
            this.Value_EngineRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value_TotalMileage
            // 
            this.Value_TotalMileage.Location = new System.Drawing.Point(254, 14);
            this.Value_TotalMileage.Margin = new System.Windows.Forms.Padding(2);
            this.Value_TotalMileage.Name = "Value_TotalMileage";
            this.Value_TotalMileage.ReadOnly = true;
            this.Value_TotalMileage.Size = new System.Drawing.Size(54, 22);
            this.Value_TotalMileage.TabIndex = 15;
            this.Value_TotalMileage.Text = "No Data";
            this.Value_TotalMileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_EngineRPM
            // 
            this.Label_EngineRPM.AutoSize = true;
            this.Label_EngineRPM.Location = new System.Drawing.Point(10, 40);
            this.Label_EngineRPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_EngineRPM.Name = "Label_EngineRPM";
            this.Label_EngineRPM.Size = new System.Drawing.Size(72, 12);
            this.Label_EngineRPM.TabIndex = 10;
            this.Label_EngineRPM.Text = "Engine - RPM";
            // 
            // Label_TotalMileage
            // 
            this.Label_TotalMileage.AutoSize = true;
            this.Label_TotalMileage.Location = new System.Drawing.Point(181, 17);
            this.Label_TotalMileage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_TotalMileage.Name = "Label_TotalMileage";
            this.Label_TotalMileage.Size = new System.Drawing.Size(42, 12);
            this.Label_TotalMileage.TabIndex = 14;
            this.Label_TotalMileage.Text = "Mileage";
            // 
            // Value_Speed
            // 
            this.Value_Speed.Location = new System.Drawing.Point(82, 14);
            this.Value_Speed.Margin = new System.Windows.Forms.Padding(2);
            this.Value_Speed.Name = "Value_Speed";
            this.Value_Speed.ReadOnly = true;
            this.Value_Speed.Size = new System.Drawing.Size(54, 22);
            this.Value_Speed.TabIndex = 9;
            this.Value_Speed.Text = "No Data";
            this.Value_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(10, 17);
            this.Label_Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(68, 12);
            this.Label_Speed.TabIndex = 8;
            this.Label_Speed.Text = "Speed (km/h)";
            // 
            // Group_Car_Status_Indicator
            // 
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_RearTirePressure);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_FrontTirePressure);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_Maintenance);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_WaterTemp);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_ABS);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_Fuel);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_EngineOil);
            this.Group_Car_Status_Indicator.Controls.Add(this.Status_OnOff);
            this.Group_Car_Status_Indicator.Location = new System.Drawing.Point(8, 98);
            this.Group_Car_Status_Indicator.Margin = new System.Windows.Forms.Padding(2);
            this.Group_Car_Status_Indicator.Name = "Group_Car_Status_Indicator";
            this.Group_Car_Status_Indicator.Padding = new System.Windows.Forms.Padding(2);
            this.Group_Car_Status_Indicator.Size = new System.Drawing.Size(322, 84);
            this.Group_Car_Status_Indicator.TabIndex = 10;
            this.Group_Car_Status_Indicator.TabStop = false;
            this.Group_Car_Status_Indicator.Text = "Car Status Indicator";
            // 
            // Status_RearTirePressure
            // 
            this.Status_RearTirePressure.AutoCheck = false;
            this.Status_RearTirePressure.AutoSize = true;
            this.Status_RearTirePressure.Location = new System.Drawing.Point(118, 63);
            this.Status_RearTirePressure.Margin = new System.Windows.Forms.Padding(2);
            this.Status_RearTirePressure.Name = "Status_RearTirePressure";
            this.Status_RearTirePressure.Size = new System.Drawing.Size(119, 16);
            this.Status_RearTirePressure.TabIndex = 7;
            this.Status_RearTirePressure.TabStop = true;
            this.Status_RearTirePressure.Text = "後輪胎胎壓指示燈";
            this.Status_RearTirePressure.UseVisualStyleBackColor = true;
            // 
            // Status_FrontTirePressure
            // 
            this.Status_FrontTirePressure.AutoCheck = false;
            this.Status_FrontTirePressure.AutoSize = true;
            this.Status_FrontTirePressure.Location = new System.Drawing.Point(118, 47);
            this.Status_FrontTirePressure.Margin = new System.Windows.Forms.Padding(2);
            this.Status_FrontTirePressure.Name = "Status_FrontTirePressure";
            this.Status_FrontTirePressure.Size = new System.Drawing.Size(119, 16);
            this.Status_FrontTirePressure.TabIndex = 6;
            this.Status_FrontTirePressure.TabStop = true;
            this.Status_FrontTirePressure.Text = "前輪胎胎壓指示燈";
            this.Status_FrontTirePressure.UseVisualStyleBackColor = true;
            // 
            // Status_Maintenance
            // 
            this.Status_Maintenance.AutoCheck = false;
            this.Status_Maintenance.AutoSize = true;
            this.Status_Maintenance.Location = new System.Drawing.Point(118, 31);
            this.Status_Maintenance.Margin = new System.Windows.Forms.Padding(2);
            this.Status_Maintenance.Name = "Status_Maintenance";
            this.Status_Maintenance.Size = new System.Drawing.Size(107, 16);
            this.Status_Maintenance.TabIndex = 5;
            this.Status_Maintenance.TabStop = true;
            this.Status_Maintenance.Text = "保養提示指示燈";
            this.Status_Maintenance.UseVisualStyleBackColor = true;
            // 
            // Status_WaterTemp
            // 
            this.Status_WaterTemp.AutoCheck = false;
            this.Status_WaterTemp.AutoSize = true;
            this.Status_WaterTemp.Location = new System.Drawing.Point(118, 15);
            this.Status_WaterTemp.Margin = new System.Windows.Forms.Padding(2);
            this.Status_WaterTemp.Name = "Status_WaterTemp";
            this.Status_WaterTemp.Size = new System.Drawing.Size(59, 16);
            this.Status_WaterTemp.TabIndex = 4;
            this.Status_WaterTemp.TabStop = true;
            this.Status_WaterTemp.Text = "水溫燈";
            this.Status_WaterTemp.UseVisualStyleBackColor = true;
            // 
            // Status_ABS
            // 
            this.Status_ABS.AutoCheck = false;
            this.Status_ABS.AutoSize = true;
            this.Status_ABS.Location = new System.Drawing.Point(8, 64);
            this.Status_ABS.Margin = new System.Windows.Forms.Padding(2);
            this.Status_ABS.Name = "Status_ABS";
            this.Status_ABS.Size = new System.Drawing.Size(81, 16);
            this.Status_ABS.TabIndex = 3;
            this.Status_ABS.TabStop = true;
            this.Status_ABS.Text = "ABS故障燈";
            this.Status_ABS.UseVisualStyleBackColor = true;
            // 
            // Status_Fuel
            // 
            this.Status_Fuel.AutoCheck = false;
            this.Status_Fuel.AutoSize = true;
            this.Status_Fuel.Location = new System.Drawing.Point(8, 48);
            this.Status_Fuel.Margin = new System.Windows.Forms.Padding(2);
            this.Status_Fuel.Name = "Status_Fuel";
            this.Status_Fuel.Size = new System.Drawing.Size(59, 16);
            this.Status_Fuel.TabIndex = 2;
            this.Status_Fuel.TabStop = true;
            this.Status_Fuel.Text = "燃油燈";
            this.Status_Fuel.UseVisualStyleBackColor = true;
            // 
            // Status_EngineOil
            // 
            this.Status_EngineOil.AutoCheck = false;
            this.Status_EngineOil.AutoSize = true;
            this.Status_EngineOil.Location = new System.Drawing.Point(8, 31);
            this.Status_EngineOil.Margin = new System.Windows.Forms.Padding(2);
            this.Status_EngineOil.Name = "Status_EngineOil";
            this.Status_EngineOil.Size = new System.Drawing.Size(107, 16);
            this.Status_EngineOil.TabIndex = 1;
            this.Status_EngineOil.TabStop = true;
            this.Status_EngineOil.Text = "機油壓力指示燈";
            this.Status_EngineOil.UseVisualStyleBackColor = true;
            // 
            // Status_OnOff
            // 
            this.Status_OnOff.AutoCheck = false;
            this.Status_OnOff.AutoSize = true;
            this.Status_OnOff.Location = new System.Drawing.Point(8, 15);
            this.Status_OnOff.Margin = new System.Windows.Forms.Padding(2);
            this.Status_OnOff.Name = "Status_OnOff";
            this.Status_OnOff.Size = new System.Drawing.Size(83, 16);
            this.Status_OnOff.TabIndex = 0;
            this.Status_OnOff.TabStop = true;
            this.Status_OnOff.Text = "開機指示燈";
            this.Status_OnOff.UseVisualStyleBackColor = true;
            // 
            // listBox_Info
            // 
            this.listBox_Info.FormattingEnabled = true;
            this.listBox_Info.ItemHeight = 12;
            this.listBox_Info.Location = new System.Drawing.Point(8, 19);
            this.listBox_Info.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Info.Name = "listBox_Info";
            this.listBox_Info.Size = new System.Drawing.Size(322, 76);
            this.listBox_Info.TabIndex = 0;
            // 
            // timer_rec
            // 
            this.timer_rec.Interval = 250;
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // label_canbus_status
            // 
            this.label_canbus_status.AutoSize = true;
            this.label_canbus_status.Location = new System.Drawing.Point(12, 15);
            this.label_canbus_status.Name = "label_canbus_status";
            this.label_canbus_status.Size = new System.Drawing.Size(68, 12);
            this.label_canbus_status.TabIndex = 23;
            this.label_canbus_status.Text = "Canbus status";
            // 
            // Group_ABS_Error_Code
            // 
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5025);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5044);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5052);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5042);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5053);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5045);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5014);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5043);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5018);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5035);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5013);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5017);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5019);
            this.Group_ABS_Error_Code.Controls.Add(this.Kline_ABS_0x5055);
            this.Group_ABS_Error_Code.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_ABS_Error_Code.Location = new System.Drawing.Point(532, 1);
            this.Group_ABS_Error_Code.Margin = new System.Windows.Forms.Padding(2);
            this.Group_ABS_Error_Code.Name = "Group_ABS_Error_Code";
            this.Group_ABS_Error_Code.Padding = new System.Windows.Forms.Padding(2);
            this.Group_ABS_Error_Code.Size = new System.Drawing.Size(94, 368);
            this.Group_ABS_Error_Code.TabIndex = 27;
            this.Group_ABS_Error_Code.TabStop = false;
            this.Group_ABS_Error_Code.Text = "ABS Status";
            // 
            // Kline_ABS_0x5025
            // 
            this.Kline_ABS_0x5025.AutoSize = true;
            this.Kline_ABS_0x5025.Location = new System.Drawing.Point(10, 303);
            this.Kline_ABS_0x5025.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5025.Name = "Kline_ABS_0x5025";
            this.Kline_ABS_0x5025.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5025.TabIndex = 16;
            this.Kline_ABS_0x5025.Tag = "WSS generic failure";
            this.Kline_ABS_0x5025.Text = "0x5025";
            this.Kline_ABS_0x5025.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5044
            // 
            this.Kline_ABS_0x5044.AutoSize = true;
            this.Kline_ABS_0x5044.Location = new System.Drawing.Point(10, 283);
            this.Kline_ABS_0x5044.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5044.Name = "Kline_ABS_0x5044";
            this.Kline_ABS_0x5044.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5044.TabIndex = 15;
            this.Kline_ABS_0x5044.Tag = "Rear WSS plausibility failure";
            this.Kline_ABS_0x5044.Text = "0x5044";
            this.Kline_ABS_0x5044.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5052
            // 
            this.Kline_ABS_0x5052.AutoSize = true;
            this.Kline_ABS_0x5052.Location = new System.Drawing.Point(10, 160);
            this.Kline_ABS_0x5052.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5052.Name = "Kline_ABS_0x5052";
            this.Kline_ABS_0x5052.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5052.TabIndex = 7;
            this.Kline_ABS_0x5052.Tag = "Battery voltage fault(Under-Voltage)";
            this.Kline_ABS_0x5052.Text = "0x5052";
            this.Kline_ABS_0x5052.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5042
            // 
            this.Kline_ABS_0x5042.AutoSize = true;
            this.Kline_ABS_0x5042.Location = new System.Drawing.Point(10, 263);
            this.Kline_ABS_0x5042.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5042.Name = "Kline_ABS_0x5042";
            this.Kline_ABS_0x5042.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5042.TabIndex = 14;
            this.Kline_ABS_0x5042.Tag = "Front WSS plausibility failure";
            this.Kline_ABS_0x5042.Text = "0x5042";
            this.Kline_ABS_0x5042.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5053
            // 
            this.Kline_ABS_0x5053.AutoSize = true;
            this.Kline_ABS_0x5053.Location = new System.Drawing.Point(10, 140);
            this.Kline_ABS_0x5053.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5053.Name = "Kline_ABS_0x5053";
            this.Kline_ABS_0x5053.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5053.TabIndex = 6;
            this.Kline_ABS_0x5053.Tag = "Battery voltage fault(Over-Voltage)";
            this.Kline_ABS_0x5053.Text = "0x5053";
            this.Kline_ABS_0x5053.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5045
            // 
            this.Kline_ABS_0x5045.AutoSize = true;
            this.Kline_ABS_0x5045.Location = new System.Drawing.Point(10, 243);
            this.Kline_ABS_0x5045.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5045.Name = "Kline_ABS_0x5045";
            this.Kline_ABS_0x5045.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5045.TabIndex = 13;
            this.Kline_ABS_0x5045.Tag = "Rear WSS ohmic failure";
            this.Kline_ABS_0x5045.Text = "0x5045";
            this.Kline_ABS_0x5045.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5014
            // 
            this.Kline_ABS_0x5014.AutoSize = true;
            this.Kline_ABS_0x5014.Location = new System.Drawing.Point(10, 120);
            this.Kline_ABS_0x5014.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5014.Name = "Kline_ABS_0x5014";
            this.Kline_ABS_0x5014.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5014.TabIndex = 5;
            this.Kline_ABS_0x5014.Tag = "Rear outlet valve failure";
            this.Kline_ABS_0x5014.Text = "0x5014";
            this.Kline_ABS_0x5014.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5043
            // 
            this.Kline_ABS_0x5043.AutoSize = true;
            this.Kline_ABS_0x5043.Location = new System.Drawing.Point(10, 223);
            this.Kline_ABS_0x5043.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5043.Name = "Kline_ABS_0x5043";
            this.Kline_ABS_0x5043.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5043.TabIndex = 12;
            this.Kline_ABS_0x5043.Tag = "Front WSS ohmic failure";
            this.Kline_ABS_0x5043.Text = "0x5043";
            this.Kline_ABS_0x5043.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5018
            // 
            this.Kline_ABS_0x5018.AutoSize = true;
            this.Kline_ABS_0x5018.Location = new System.Drawing.Point(10, 100);
            this.Kline_ABS_0x5018.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5018.Name = "Kline_ABS_0x5018";
            this.Kline_ABS_0x5018.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5018.TabIndex = 4;
            this.Kline_ABS_0x5018.Tag = "Front outlet valve failure";
            this.Kline_ABS_0x5018.Text = "0x5018";
            this.Kline_ABS_0x5018.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5035
            // 
            this.Kline_ABS_0x5035.AutoSize = true;
            this.Kline_ABS_0x5035.Location = new System.Drawing.Point(10, 203);
            this.Kline_ABS_0x5035.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5035.Name = "Kline_ABS_0x5035";
            this.Kline_ABS_0x5035.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5035.TabIndex = 11;
            this.Kline_ABS_0x5035.Tag = "Pump motor failure";
            this.Kline_ABS_0x5035.Text = "0x5035";
            this.Kline_ABS_0x5035.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5013
            // 
            this.Kline_ABS_0x5013.AutoSize = true;
            this.Kline_ABS_0x5013.Location = new System.Drawing.Point(10, 80);
            this.Kline_ABS_0x5013.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5013.Name = "Kline_ABS_0x5013";
            this.Kline_ABS_0x5013.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5013.TabIndex = 3;
            this.Kline_ABS_0x5013.Tag = "Rear inlet valve failure";
            this.Kline_ABS_0x5013.Text = "0x5013";
            this.Kline_ABS_0x5013.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5017
            // 
            this.Kline_ABS_0x5017.AutoSize = true;
            this.Kline_ABS_0x5017.Location = new System.Drawing.Point(10, 60);
            this.Kline_ABS_0x5017.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5017.Name = "Kline_ABS_0x5017";
            this.Kline_ABS_0x5017.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5017.TabIndex = 2;
            this.Kline_ABS_0x5017.Tag = "Front inlet valve failure";
            this.Kline_ABS_0x5017.Text = "0x5017";
            this.Kline_ABS_0x5017.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5019
            // 
            this.Kline_ABS_0x5019.AutoSize = true;
            this.Kline_ABS_0x5019.Location = new System.Drawing.Point(10, 39);
            this.Kline_ABS_0x5019.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5019.Name = "Kline_ABS_0x5019";
            this.Kline_ABS_0x5019.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5019.TabIndex = 1;
            this.Kline_ABS_0x5019.Tag = "Valve relay fault";
            this.Kline_ABS_0x5019.Text = "0x5019";
            this.Kline_ABS_0x5019.UseVisualStyleBackColor = true;
            // 
            // Kline_ABS_0x5055
            // 
            this.Kline_ABS_0x5055.AutoSize = true;
            this.Kline_ABS_0x5055.Location = new System.Drawing.Point(10, 19);
            this.Kline_ABS_0x5055.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_ABS_0x5055.Name = "Kline_ABS_0x5055";
            this.Kline_ABS_0x5055.Size = new System.Drawing.Size(75, 20);
            this.Kline_ABS_0x5055.TabIndex = 0;
            this.Kline_ABS_0x5055.Tag = "Control unit failure";
            this.Kline_ABS_0x5055.Text = "0x5055";
            this.Kline_ABS_0x5055.UseVisualStyleBackColor = true;
            // 
            // Group_OBD_Error_Code
            // 
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0486);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0426);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0122);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0121);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0002);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0140);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0001);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_U0128);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P2600);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P2158);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P1800);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P1607);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P1536);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P1310);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0620_PIN31);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P1300);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0620_PIN2);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0A0F);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0606);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0655);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0605);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0650);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0604);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0601);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0560);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0512);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0500);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0480);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0410);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0505);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0352);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0501);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0351);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0336);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0335);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0230);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0217);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0202);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0130);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0201);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0120);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0155);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0115);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0150);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0110);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0135);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0105);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_C0085);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_C0083);
            this.Group_OBD_Error_Code.Controls.Add(this.Kline_OBD_P0503);
            this.Group_OBD_Error_Code.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_OBD_Error_Code.Location = new System.Drawing.Point(625, 1);
            this.Group_OBD_Error_Code.Margin = new System.Windows.Forms.Padding(2);
            this.Group_OBD_Error_Code.Name = "Group_OBD_Error_Code";
            this.Group_OBD_Error_Code.Padding = new System.Windows.Forms.Padding(2);
            this.Group_OBD_Error_Code.Size = new System.Drawing.Size(343, 368);
            this.Group_OBD_Error_Code.TabIndex = 26;
            this.Group_OBD_Error_Code.TabStop = false;
            this.Group_OBD_Error_Code.Text = "OBD Status";
            // 
            // Kline_OBD_U0486
            // 
            this.Kline_OBD_U0486.AutoSize = true;
            this.Kline_OBD_U0486.Location = new System.Drawing.Point(265, 39);
            this.Kline_OBD_U0486.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0486.Name = "Kline_OBD_U0486";
            this.Kline_OBD_U0486.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0486.TabIndex = 52;
            this.Kline_OBD_U0486.Tag = "Immobilizer";
            this.Kline_OBD_U0486.Text = "U0486";
            this.Kline_OBD_U0486.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0426
            // 
            this.Kline_OBD_U0426.AutoSize = true;
            this.Kline_OBD_U0426.Location = new System.Drawing.Point(265, 19);
            this.Kline_OBD_U0426.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0426.Name = "Kline_OBD_U0426";
            this.Kline_OBD_U0426.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0426.TabIndex = 51;
            this.Kline_OBD_U0426.Tag = "Immobilizer";
            this.Kline_OBD_U0426.Text = "U0426";
            this.Kline_OBD_U0426.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0122
            // 
            this.Kline_OBD_U0122.AutoSize = true;
            this.Kline_OBD_U0122.Location = new System.Drawing.Point(194, 303);
            this.Kline_OBD_U0122.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0122.Name = "Kline_OBD_U0122";
            this.Kline_OBD_U0122.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0122.TabIndex = 48;
            this.Kline_OBD_U0122.Tag = "CAN line diagnosis \"UIN Node\"";
            this.Kline_OBD_U0122.Text = "U0122";
            this.Kline_OBD_U0122.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0121
            // 
            this.Kline_OBD_U0121.AutoSize = true;
            this.Kline_OBD_U0121.Location = new System.Drawing.Point(194, 283);
            this.Kline_OBD_U0121.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0121.Name = "Kline_OBD_U0121";
            this.Kline_OBD_U0121.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0121.TabIndex = 47;
            this.Kline_OBD_U0121.Tag = "CAN line diagnosis \"ABS Node\"";
            this.Kline_OBD_U0121.Text = "U0121";
            this.Kline_OBD_U0121.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0002
            // 
            this.Kline_OBD_U0002.AutoSize = true;
            this.Kline_OBD_U0002.Location = new System.Drawing.Point(194, 263);
            this.Kline_OBD_U0002.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0002.Name = "Kline_OBD_U0002";
            this.Kline_OBD_U0002.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0002.TabIndex = 46;
            this.Kline_OBD_U0002.Tag = "\"Mute Node\" CAN line diagnosis(NCM)";
            this.Kline_OBD_U0002.Text = "U0002";
            this.Kline_OBD_U0002.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0140
            // 
            this.Kline_OBD_U0140.AutoSize = true;
            this.Kline_OBD_U0140.Location = new System.Drawing.Point(194, 343);
            this.Kline_OBD_U0140.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0140.Name = "Kline_OBD_U0140";
            this.Kline_OBD_U0140.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0140.TabIndex = 50;
            this.Kline_OBD_U0140.Tag = "Dashboard Node Absent\r\n";
            this.Kline_OBD_U0140.Text = "U0140";
            this.Kline_OBD_U0140.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0001
            // 
            this.Kline_OBD_U0001.AutoSize = true;
            this.Kline_OBD_U0001.Location = new System.Drawing.Point(194, 243);
            this.Kline_OBD_U0001.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0001.Name = "Kline_OBD_U0001";
            this.Kline_OBD_U0001.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0001.TabIndex = 45;
            this.Kline_OBD_U0001.Tag = "\"Bus Off\" CAN line diagnosis (NCM)";
            this.Kline_OBD_U0001.Text = "U0001";
            this.Kline_OBD_U0001.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_U0128
            // 
            this.Kline_OBD_U0128.AutoSize = true;
            this.Kline_OBD_U0128.Location = new System.Drawing.Point(194, 323);
            this.Kline_OBD_U0128.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_U0128.Name = "Kline_OBD_U0128";
            this.Kline_OBD_U0128.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_U0128.TabIndex = 49;
            this.Kline_OBD_U0128.Tag = "CAN line diagnosis \"NST Node\"";
            this.Kline_OBD_U0128.Text = "U0128";
            this.Kline_OBD_U0128.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P2600
            // 
            this.Kline_OBD_P2600.AutoSize = true;
            this.Kline_OBD_P2600.Location = new System.Drawing.Point(194, 223);
            this.Kline_OBD_P2600.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P2600.Name = "Kline_OBD_P2600";
            this.Kline_OBD_P2600.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P2600.TabIndex = 44;
            this.Kline_OBD_P2600.Tag = "Eletric water pump command";
            this.Kline_OBD_P2600.Text = "P2600";
            this.Kline_OBD_P2600.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P2158
            // 
            this.Kline_OBD_P2158.AutoSize = true;
            this.Kline_OBD_P2158.Location = new System.Drawing.Point(194, 203);
            this.Kline_OBD_P2158.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P2158.Name = "Kline_OBD_P2158";
            this.Kline_OBD_P2158.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P2158.TabIndex = 43;
            this.Kline_OBD_P2158.Tag = "Rear vehicle speed sensor / signal from ABS";
            this.Kline_OBD_P2158.Text = "P2158";
            this.Kline_OBD_P2158.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P1800
            // 
            this.Kline_OBD_P1800.AutoSize = true;
            this.Kline_OBD_P1800.Location = new System.Drawing.Point(194, 159);
            this.Kline_OBD_P1800.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P1800.Name = "Kline_OBD_P1800";
            this.Kline_OBD_P1800.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P1800.TabIndex = 42;
            this.Kline_OBD_P1800.Tag = "Wheel spoke learn";
            this.Kline_OBD_P1800.Text = "P1800";
            this.Kline_OBD_P1800.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P1607
            // 
            this.Kline_OBD_P1607.AutoSize = true;
            this.Kline_OBD_P1607.Location = new System.Drawing.Point(194, 139);
            this.Kline_OBD_P1607.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P1607.Name = "Kline_OBD_P1607";
            this.Kline_OBD_P1607.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P1607.TabIndex = 41;
            this.Kline_OBD_P1607.Tag = "Data buffer full and triggered by special events";
            this.Kline_OBD_P1607.Text = "P1607";
            this.Kline_OBD_P1607.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P1536
            // 
            this.Kline_OBD_P1536.AutoSize = true;
            this.Kline_OBD_P1536.Location = new System.Drawing.Point(194, 119);
            this.Kline_OBD_P1536.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P1536.Name = "Kline_OBD_P1536";
            this.Kline_OBD_P1536.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P1536.TabIndex = 40;
            this.Kline_OBD_P1536.Tag = "Tip Over";
            this.Kline_OBD_P1536.Text = "P1536";
            this.Kline_OBD_P1536.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P1310
            // 
            this.Kline_OBD_P1310.AutoSize = true;
            this.Kline_OBD_P1310.Location = new System.Drawing.Point(194, 99);
            this.Kline_OBD_P1310.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P1310.Name = "Kline_OBD_P1310";
            this.Kline_OBD_P1310.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P1310.TabIndex = 39;
            this.Kline_OBD_P1310.Tag = "Light Feedback Signal Error State";
            this.Kline_OBD_P1310.Text = "P1310";
            this.Kline_OBD_P1310.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0620_PIN31
            // 
            this.Kline_OBD_P0620_PIN31.AutoSize = true;
            this.Kline_OBD_P0620_PIN31.Location = new System.Drawing.Point(81, 344);
            this.Kline_OBD_P0620_PIN31.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0620_PIN31.Name = "Kline_OBD_P0620_PIN31";
            this.Kline_OBD_P0620_PIN31.Size = new System.Drawing.Size(115, 20);
            this.Kline_OBD_P0620_PIN31.TabIndex = 34;
            this.Kline_OBD_P0620_PIN31.Tag = "Alternator \"Boost\" command diagnosis PIN 2";
            this.Kline_OBD_P0620_PIN31.Text = "P0620_PIN31";
            this.Kline_OBD_P0620_PIN31.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P1300
            // 
            this.Kline_OBD_P1300.AutoSize = true;
            this.Kline_OBD_P1300.Location = new System.Drawing.Point(194, 79);
            this.Kline_OBD_P1300.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P1300.Name = "Kline_OBD_P1300";
            this.Kline_OBD_P1300.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P1300.TabIndex = 38;
            this.Kline_OBD_P1300.Tag = "Headlights Off relay command";
            this.Kline_OBD_P1300.Text = "P1300";
            this.Kline_OBD_P1300.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0620_PIN2
            // 
            this.Kline_OBD_P0620_PIN2.AutoSize = true;
            this.Kline_OBD_P0620_PIN2.Location = new System.Drawing.Point(81, 324);
            this.Kline_OBD_P0620_PIN2.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0620_PIN2.Name = "Kline_OBD_P0620_PIN2";
            this.Kline_OBD_P0620_PIN2.Size = new System.Drawing.Size(107, 20);
            this.Kline_OBD_P0620_PIN2.TabIndex = 33;
            this.Kline_OBD_P0620_PIN2.Tag = "Alternator \"Boost\" command diagnosis PIN 2";
            this.Kline_OBD_P0620_PIN2.Text = "P0620_PIN2";
            this.Kline_OBD_P0620_PIN2.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0A0F
            // 
            this.Kline_OBD_P0A0F.AutoSize = true;
            this.Kline_OBD_P0A0F.Location = new System.Drawing.Point(194, 59);
            this.Kline_OBD_P0A0F.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0A0F.Name = "Kline_OBD_P0A0F";
            this.Kline_OBD_P0A0F.Size = new System.Drawing.Size(70, 20);
            this.Kline_OBD_P0A0F.TabIndex = 37;
            this.Kline_OBD_P0A0F.Tag = "Engine start enable lamp command";
            this.Kline_OBD_P0A0F.Text = "P0A0F";
            this.Kline_OBD_P0A0F.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0606
            // 
            this.Kline_OBD_P0606.AutoSize = true;
            this.Kline_OBD_P0606.Location = new System.Drawing.Point(81, 304);
            this.Kline_OBD_P0606.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0606.Name = "Kline_OBD_P0606";
            this.Kline_OBD_P0606.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0606.TabIndex = 32;
            this.Kline_OBD_P0606.Tag = "Microprocessor error";
            this.Kline_OBD_P0606.Text = "P0606";
            this.Kline_OBD_P0606.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0655
            // 
            this.Kline_OBD_P0655.AutoSize = true;
            this.Kline_OBD_P0655.Location = new System.Drawing.Point(194, 39);
            this.Kline_OBD_P0655.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0655.Name = "Kline_OBD_P0655";
            this.Kline_OBD_P0655.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0655.TabIndex = 36;
            this.Kline_OBD_P0655.Tag = "Engine Overtemperature Lamp Command";
            this.Kline_OBD_P0655.Text = "P0655";
            this.Kline_OBD_P0655.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0605
            // 
            this.Kline_OBD_P0605.AutoSize = true;
            this.Kline_OBD_P0605.Location = new System.Drawing.Point(81, 284);
            this.Kline_OBD_P0605.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0605.Name = "Kline_OBD_P0605";
            this.Kline_OBD_P0605.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0605.TabIndex = 31;
            this.Kline_OBD_P0605.Tag = "ROM error (Flash)";
            this.Kline_OBD_P0605.Text = "P0605";
            this.Kline_OBD_P0605.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0650
            // 
            this.Kline_OBD_P0650.AutoSize = true;
            this.Kline_OBD_P0650.Location = new System.Drawing.Point(194, 19);
            this.Kline_OBD_P0650.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0650.Name = "Kline_OBD_P0650";
            this.Kline_OBD_P0650.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0650.TabIndex = 35;
            this.Kline_OBD_P0650.Tag = "MIL Lamp command";
            this.Kline_OBD_P0650.Text = "P0650";
            this.Kline_OBD_P0650.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0604
            // 
            this.Kline_OBD_P0604.AutoSize = true;
            this.Kline_OBD_P0604.Location = new System.Drawing.Point(81, 264);
            this.Kline_OBD_P0604.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0604.Name = "Kline_OBD_P0604";
            this.Kline_OBD_P0604.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0604.TabIndex = 30;
            this.Kline_OBD_P0604.Tag = "RAM error";
            this.Kline_OBD_P0604.Text = "P0604";
            this.Kline_OBD_P0604.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0601
            // 
            this.Kline_OBD_P0601.AutoSize = true;
            this.Kline_OBD_P0601.Location = new System.Drawing.Point(81, 244);
            this.Kline_OBD_P0601.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0601.Name = "Kline_OBD_P0601";
            this.Kline_OBD_P0601.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0601.TabIndex = 29;
            this.Kline_OBD_P0601.Tag = "EEPROM error (Flash emul.)";
            this.Kline_OBD_P0601.Text = "P0601";
            this.Kline_OBD_P0601.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0560
            // 
            this.Kline_OBD_P0560.AutoSize = true;
            this.Kline_OBD_P0560.Location = new System.Drawing.Point(81, 223);
            this.Kline_OBD_P0560.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0560.Name = "Kline_OBD_P0560";
            this.Kline_OBD_P0560.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0560.TabIndex = 28;
            this.Kline_OBD_P0560.Tag = "Battery Voltage";
            this.Kline_OBD_P0560.Text = "P0560";
            this.Kline_OBD_P0560.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0512
            // 
            this.Kline_OBD_P0512.AutoSize = true;
            this.Kline_OBD_P0512.Location = new System.Drawing.Point(81, 203);
            this.Kline_OBD_P0512.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0512.Name = "Kline_OBD_P0512";
            this.Kline_OBD_P0512.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0512.TabIndex = 27;
            this.Kline_OBD_P0512.Tag = "Engine Start Button";
            this.Kline_OBD_P0512.Text = "P0512";
            this.Kline_OBD_P0512.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0500
            // 
            this.Kline_OBD_P0500.AutoSize = true;
            this.Kline_OBD_P0500.Location = new System.Drawing.Point(81, 119);
            this.Kline_OBD_P0500.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0500.Name = "Kline_OBD_P0500";
            this.Kline_OBD_P0500.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0500.TabIndex = 24;
            this.Kline_OBD_P0500.Tag = "Vehicle speed sensor/signal";
            this.Kline_OBD_P0500.Text = "P0500";
            this.Kline_OBD_P0500.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0480
            // 
            this.Kline_OBD_P0480.AutoSize = true;
            this.Kline_OBD_P0480.Location = new System.Drawing.Point(81, 99);
            this.Kline_OBD_P0480.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0480.Name = "Kline_OBD_P0480";
            this.Kline_OBD_P0480.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0480.TabIndex = 23;
            this.Kline_OBD_P0480.Tag = "Cooling fan relay command";
            this.Kline_OBD_P0480.Text = "P0480";
            this.Kline_OBD_P0480.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0410
            // 
            this.Kline_OBD_P0410.AutoSize = true;
            this.Kline_OBD_P0410.Location = new System.Drawing.Point(81, 79);
            this.Kline_OBD_P0410.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0410.Name = "Kline_OBD_P0410";
            this.Kline_OBD_P0410.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0410.TabIndex = 22;
            this.Kline_OBD_P0410.Tag = "Secondary Air Valve";
            this.Kline_OBD_P0410.Text = "P0410";
            this.Kline_OBD_P0410.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0505
            // 
            this.Kline_OBD_P0505.AutoSize = true;
            this.Kline_OBD_P0505.Location = new System.Drawing.Point(81, 159);
            this.Kline_OBD_P0505.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0505.Name = "Kline_OBD_P0505";
            this.Kline_OBD_P0505.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0505.TabIndex = 26;
            this.Kline_OBD_P0505.Tag = "Idle control / stepper motor control";
            this.Kline_OBD_P0505.Text = "P0505";
            this.Kline_OBD_P0505.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0352
            // 
            this.Kline_OBD_P0352.AutoSize = true;
            this.Kline_OBD_P0352.Location = new System.Drawing.Point(81, 59);
            this.Kline_OBD_P0352.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0352.Name = "Kline_OBD_P0352";
            this.Kline_OBD_P0352.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0352.TabIndex = 21;
            this.Kline_OBD_P0352.Tag = "Ignition coil 2 circuit";
            this.Kline_OBD_P0352.Text = "P0352";
            this.Kline_OBD_P0352.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0501
            // 
            this.Kline_OBD_P0501.AutoSize = true;
            this.Kline_OBD_P0501.Location = new System.Drawing.Point(81, 139);
            this.Kline_OBD_P0501.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0501.Name = "Kline_OBD_P0501";
            this.Kline_OBD_P0501.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0501.TabIndex = 25;
            this.Kline_OBD_P0501.Tag = "Front vehicle speed sensor/signal from ABS";
            this.Kline_OBD_P0501.Text = "P0501";
            this.Kline_OBD_P0501.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0351
            // 
            this.Kline_OBD_P0351.AutoSize = true;
            this.Kline_OBD_P0351.Location = new System.Drawing.Point(81, 39);
            this.Kline_OBD_P0351.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0351.Name = "Kline_OBD_P0351";
            this.Kline_OBD_P0351.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0351.TabIndex = 20;
            this.Kline_OBD_P0351.Tag = "Ignition coil 1 circuit";
            this.Kline_OBD_P0351.Text = "P0351";
            this.Kline_OBD_P0351.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0336
            // 
            this.Kline_OBD_P0336.AutoSize = true;
            this.Kline_OBD_P0336.Location = new System.Drawing.Point(81, 19);
            this.Kline_OBD_P0336.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0336.Name = "Kline_OBD_P0336";
            this.Kline_OBD_P0336.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0336.TabIndex = 19;
            this.Kline_OBD_P0336.Tag = "Engine speed sensor - Functional";
            this.Kline_OBD_P0336.Text = "P0336";
            this.Kline_OBD_P0336.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0335
            // 
            this.Kline_OBD_P0335.AutoSize = true;
            this.Kline_OBD_P0335.Location = new System.Drawing.Point(10, 343);
            this.Kline_OBD_P0335.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0335.Name = "Kline_OBD_P0335";
            this.Kline_OBD_P0335.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0335.TabIndex = 18;
            this.Kline_OBD_P0335.Tag = "Engine speed sensor - Electric";
            this.Kline_OBD_P0335.Text = "P0335";
            this.Kline_OBD_P0335.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0230
            // 
            this.Kline_OBD_P0230.AutoSize = true;
            this.Kline_OBD_P0230.Location = new System.Drawing.Point(10, 323);
            this.Kline_OBD_P0230.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0230.Name = "Kline_OBD_P0230";
            this.Kline_OBD_P0230.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0230.TabIndex = 17;
            this.Kline_OBD_P0230.Tag = "Fuel Pump/Load Relay Command";
            this.Kline_OBD_P0230.Text = "P0230";
            this.Kline_OBD_P0230.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0217
            // 
            this.Kline_OBD_P0217.AutoSize = true;
            this.Kline_OBD_P0217.Location = new System.Drawing.Point(10, 303);
            this.Kline_OBD_P0217.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0217.Name = "Kline_OBD_P0217";
            this.Kline_OBD_P0217.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0217.TabIndex = 16;
            this.Kline_OBD_P0217.Tag = "Engine OverTemperature State Recognition";
            this.Kline_OBD_P0217.Text = "P0217";
            this.Kline_OBD_P0217.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0202
            // 
            this.Kline_OBD_P0202.AutoSize = true;
            this.Kline_OBD_P0202.Location = new System.Drawing.Point(10, 283);
            this.Kline_OBD_P0202.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0202.Name = "Kline_OBD_P0202";
            this.Kline_OBD_P0202.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0202.TabIndex = 15;
            this.Kline_OBD_P0202.Tag = "Cylinder 2 Injector Command";
            this.Kline_OBD_P0202.Text = "P0202";
            this.Kline_OBD_P0202.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0130
            // 
            this.Kline_OBD_P0130.AutoSize = true;
            this.Kline_OBD_P0130.Location = new System.Drawing.Point(10, 160);
            this.Kline_OBD_P0130.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0130.Name = "Kline_OBD_P0130";
            this.Kline_OBD_P0130.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0130.TabIndex = 7;
            this.Kline_OBD_P0130.Tag = "Oxygen Sensor 1";
            this.Kline_OBD_P0130.Text = "P0130";
            this.Kline_OBD_P0130.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0201
            // 
            this.Kline_OBD_P0201.AutoSize = true;
            this.Kline_OBD_P0201.Location = new System.Drawing.Point(10, 263);
            this.Kline_OBD_P0201.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0201.Name = "Kline_OBD_P0201";
            this.Kline_OBD_P0201.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0201.TabIndex = 14;
            this.Kline_OBD_P0201.Tag = "Cylinder 1 Injector Command";
            this.Kline_OBD_P0201.Text = "P0201";
            this.Kline_OBD_P0201.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0120
            // 
            this.Kline_OBD_P0120.AutoSize = true;
            this.Kline_OBD_P0120.Location = new System.Drawing.Point(10, 140);
            this.Kline_OBD_P0120.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0120.Name = "Kline_OBD_P0120";
            this.Kline_OBD_P0120.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0120.TabIndex = 6;
            this.Kline_OBD_P0120.Tag = "Throttle Position Potentiometer Sensor";
            this.Kline_OBD_P0120.Text = "P0120";
            this.Kline_OBD_P0120.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0155
            // 
            this.Kline_OBD_P0155.AutoSize = true;
            this.Kline_OBD_P0155.Location = new System.Drawing.Point(10, 243);
            this.Kline_OBD_P0155.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0155.Name = "Kline_OBD_P0155";
            this.Kline_OBD_P0155.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0155.TabIndex = 13;
            this.Kline_OBD_P0155.Tag = "Oxygen Sensor 2 Heater Circuit";
            this.Kline_OBD_P0155.Text = "P0155";
            this.Kline_OBD_P0155.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0115
            // 
            this.Kline_OBD_P0115.AutoSize = true;
            this.Kline_OBD_P0115.Location = new System.Drawing.Point(10, 120);
            this.Kline_OBD_P0115.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0115.Name = "Kline_OBD_P0115";
            this.Kline_OBD_P0115.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0115.TabIndex = 5;
            this.Kline_OBD_P0115.Tag = "Engine Temperature Sensor";
            this.Kline_OBD_P0115.Text = "P0115";
            this.Kline_OBD_P0115.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0150
            // 
            this.Kline_OBD_P0150.AutoSize = true;
            this.Kline_OBD_P0150.Location = new System.Drawing.Point(10, 223);
            this.Kline_OBD_P0150.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0150.Name = "Kline_OBD_P0150";
            this.Kline_OBD_P0150.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0150.TabIndex = 12;
            this.Kline_OBD_P0150.Tag = "Oxygen Sensor 2";
            this.Kline_OBD_P0150.Text = "P0150";
            this.Kline_OBD_P0150.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0110
            // 
            this.Kline_OBD_P0110.AutoSize = true;
            this.Kline_OBD_P0110.Location = new System.Drawing.Point(10, 100);
            this.Kline_OBD_P0110.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0110.Name = "Kline_OBD_P0110";
            this.Kline_OBD_P0110.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0110.TabIndex = 4;
            this.Kline_OBD_P0110.Tag = "Air Temperture Sensor";
            this.Kline_OBD_P0110.Text = "P0110";
            this.Kline_OBD_P0110.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0135
            // 
            this.Kline_OBD_P0135.AutoSize = true;
            this.Kline_OBD_P0135.Location = new System.Drawing.Point(10, 203);
            this.Kline_OBD_P0135.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0135.Name = "Kline_OBD_P0135";
            this.Kline_OBD_P0135.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0135.TabIndex = 11;
            this.Kline_OBD_P0135.Tag = "Oxygen Sensor 1 Heater Circuit";
            this.Kline_OBD_P0135.Text = "P0135";
            this.Kline_OBD_P0135.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0105
            // 
            this.Kline_OBD_P0105.AutoSize = true;
            this.Kline_OBD_P0105.Location = new System.Drawing.Point(10, 80);
            this.Kline_OBD_P0105.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0105.Name = "Kline_OBD_P0105";
            this.Kline_OBD_P0105.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0105.TabIndex = 3;
            this.Kline_OBD_P0105.Tag = "Pressure Sensor ";
            this.Kline_OBD_P0105.Text = "P0105";
            this.Kline_OBD_P0105.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_C0085
            // 
            this.Kline_OBD_C0085.AutoSize = true;
            this.Kline_OBD_C0085.Location = new System.Drawing.Point(10, 60);
            this.Kline_OBD_C0085.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_C0085.Name = "Kline_OBD_C0085";
            this.Kline_OBD_C0085.Size = new System.Drawing.Size(69, 20);
            this.Kline_OBD_C0085.TabIndex = 2;
            this.Kline_OBD_C0085.Tag = "ASR Lamp Command";
            this.Kline_OBD_C0085.Text = "C0085";
            this.Kline_OBD_C0085.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_C0083
            // 
            this.Kline_OBD_C0083.AutoSize = true;
            this.Kline_OBD_C0083.Location = new System.Drawing.Point(10, 39);
            this.Kline_OBD_C0083.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_C0083.Name = "Kline_OBD_C0083";
            this.Kline_OBD_C0083.Size = new System.Drawing.Size(69, 20);
            this.Kline_OBD_C0083.TabIndex = 1;
            this.Kline_OBD_C0083.Tag = "Tyres Pressure Lamp";
            this.Kline_OBD_C0083.Text = "C0083";
            this.Kline_OBD_C0083.UseVisualStyleBackColor = true;
            // 
            // Kline_OBD_P0503
            // 
            this.Kline_OBD_P0503.AutoSize = true;
            this.Kline_OBD_P0503.Location = new System.Drawing.Point(10, 19);
            this.Kline_OBD_P0503.Margin = new System.Windows.Forms.Padding(2);
            this.Kline_OBD_P0503.Name = "Kline_OBD_P0503";
            this.Kline_OBD_P0503.Size = new System.Drawing.Size(67, 20);
            this.Kline_OBD_P0503.TabIndex = 0;
            this.Kline_OBD_P0503.Tag = "Font DX vehicle speed sensor/signal(vehicle is equipped with NST node)";
            this.Kline_OBD_P0503.Text = "P0503";
            this.Kline_OBD_P0503.UseVisualStyleBackColor = true;
            // 
            // tmr_FetchingUARTInput
            // 
            this.tmr_FetchingUARTInput.Interval = 250;
            this.tmr_FetchingUARTInput.Tick += new System.EventHandler(this.tmr_FetchingUARTInput_Tick);
            // 
            // rtbKLineData
            // 
            this.rtbKLineData.Location = new System.Drawing.Point(973, 11);
            this.rtbKLineData.Name = "rtbKLineData";
            this.rtbKLineData.ReadOnly = true;
            this.rtbKLineData.Size = new System.Drawing.Size(340, 76);
            this.rtbKLineData.TabIndex = 28;
            this.rtbKLineData.Text = "";
            // 
            // Group_DTC_data_option
            // 
            this.Group_DTC_data_option.Controls.Add(this.DTC_option_all_in_turn);
            this.Group_DTC_data_option.Controls.Add(this.DTC_option_first_six);
            this.Group_DTC_data_option.Enabled = false;
            this.Group_DTC_data_option.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_DTC_data_option.Location = new System.Drawing.Point(395, 1);
            this.Group_DTC_data_option.Margin = new System.Windows.Forms.Padding(2);
            this.Group_DTC_data_option.Name = "Group_DTC_data_option";
            this.Group_DTC_data_option.Padding = new System.Windows.Forms.Padding(2);
            this.Group_DTC_data_option.Size = new System.Drawing.Size(133, 76);
            this.Group_DTC_data_option.TabIndex = 29;
            this.Group_DTC_data_option.TabStop = false;
            this.Group_DTC_data_option.Text = "DTC data options";
            this.Group_DTC_data_option.Visible = false;
            // 
            // DTC_option_all_in_turn
            // 
            this.DTC_option_all_in_turn.AutoSize = true;
            this.DTC_option_all_in_turn.Location = new System.Drawing.Point(13, 58);
            this.DTC_option_all_in_turn.Margin = new System.Windows.Forms.Padding(2);
            this.DTC_option_all_in_turn.Name = "DTC_option_all_in_turn";
            this.DTC_option_all_in_turn.Size = new System.Drawing.Size(124, 20);
            this.DTC_option_all_in_turn.TabIndex = 2;
            this.DTC_option_all_in_turn.Text = "All DTC in turn";
            this.DTC_option_all_in_turn.UseVisualStyleBackColor = true;
            // 
            // DTC_option_first_six
            // 
            this.DTC_option_first_six.AutoSize = true;
            this.DTC_option_first_six.Checked = true;
            this.DTC_option_first_six.Location = new System.Drawing.Point(13, 24);
            this.DTC_option_first_six.Margin = new System.Windows.Forms.Padding(2);
            this.DTC_option_first_six.Name = "DTC_option_first_six";
            this.DTC_option_first_six.Size = new System.Drawing.Size(100, 20);
            this.DTC_option_first_six.TabIndex = 0;
            this.DTC_option_first_six.TabStop = true;
            this.DTC_option_first_six.Text = "First-6 DTC";
            this.DTC_option_first_six.UseVisualStyleBackColor = true;
            // 
            // label_Kline_status
            // 
            this.label_Kline_status.AutoSize = true;
            this.label_Kline_status.Location = new System.Drawing.Point(12, 27);
            this.label_Kline_status.Name = "label_Kline_status";
            this.label_Kline_status.Size = new System.Drawing.Size(58, 12);
            this.label_Kline_status.TabIndex = 30;
            this.label_Kline_status.Text = "Kline status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Can_OBD_U0486);
            this.groupBox1.Controls.Add(this.Can_OBD_U0426);
            this.groupBox1.Controls.Add(this.Can_OBD_U0122);
            this.groupBox1.Controls.Add(this.Can_OBD_U0121);
            this.groupBox1.Controls.Add(this.Can_OBD_U0002);
            this.groupBox1.Controls.Add(this.Can_OBD_U0140);
            this.groupBox1.Controls.Add(this.Can_OBD_U0001);
            this.groupBox1.Controls.Add(this.Can_OBD_U0128);
            this.groupBox1.Controls.Add(this.Can_OBD_P2600);
            this.groupBox1.Controls.Add(this.Can_OBD_P2158);
            this.groupBox1.Controls.Add(this.Can_OBD_P1800);
            this.groupBox1.Controls.Add(this.Can_OBD_P1607);
            this.groupBox1.Controls.Add(this.Can_OBD_P1536);
            this.groupBox1.Controls.Add(this.Can_OBD_P1310);
            this.groupBox1.Controls.Add(this.Can_OBD_P0620_PIN31);
            this.groupBox1.Controls.Add(this.Can_OBD_P1300);
            this.groupBox1.Controls.Add(this.Can_OBD_P0620_PIN2);
            this.groupBox1.Controls.Add(this.Can_OBD_P0A0F);
            this.groupBox1.Controls.Add(this.Can_OBD_P0606);
            this.groupBox1.Controls.Add(this.Can_OBD_P0655);
            this.groupBox1.Controls.Add(this.Can_OBD_P0605);
            this.groupBox1.Controls.Add(this.Can_OBD_P0650);
            this.groupBox1.Controls.Add(this.Can_OBD_P0604);
            this.groupBox1.Controls.Add(this.Can_OBD_P0601);
            this.groupBox1.Controls.Add(this.Can_OBD_P0560);
            this.groupBox1.Controls.Add(this.Can_OBD_P0512);
            this.groupBox1.Controls.Add(this.Can_OBD_P0500);
            this.groupBox1.Controls.Add(this.Can_OBD_P0480);
            this.groupBox1.Controls.Add(this.Can_OBD_P0410);
            this.groupBox1.Controls.Add(this.Can_OBD_P0505);
            this.groupBox1.Controls.Add(this.Can_OBD_P0352);
            this.groupBox1.Controls.Add(this.Can_OBD_P0501);
            this.groupBox1.Controls.Add(this.Can_OBD_P0351);
            this.groupBox1.Controls.Add(this.Can_OBD_P0336);
            this.groupBox1.Controls.Add(this.Can_OBD_P0335);
            this.groupBox1.Controls.Add(this.Can_OBD_P0230);
            this.groupBox1.Controls.Add(this.Can_OBD_P0217);
            this.groupBox1.Controls.Add(this.Can_OBD_P0202);
            this.groupBox1.Controls.Add(this.Can_OBD_P0130);
            this.groupBox1.Controls.Add(this.Can_OBD_P0201);
            this.groupBox1.Controls.Add(this.Can_OBD_P0120);
            this.groupBox1.Controls.Add(this.Can_OBD_P0155);
            this.groupBox1.Controls.Add(this.Can_OBD_P0115);
            this.groupBox1.Controls.Add(this.Can_OBD_P0150);
            this.groupBox1.Controls.Add(this.Can_OBD_P0110);
            this.groupBox1.Controls.Add(this.Can_OBD_P0135);
            this.groupBox1.Controls.Add(this.Can_OBD_P0105);
            this.groupBox1.Controls.Add(this.Can_OBD_C0085);
            this.groupBox1.Controls.Add(this.Can_OBD_C0083);
            this.groupBox1.Controls.Add(this.Can_OBD_P0503);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.groupBox1.Location = new System.Drawing.Point(1071, 448);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 548);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OBD Status";
            // 
            // Can_OBD_U0486
            // 
            this.Can_OBD_U0486.AutoCheck = false;
            this.Can_OBD_U0486.AutoSize = true;
            this.Can_OBD_U0486.Location = new System.Drawing.Point(165, 39);
            this.Can_OBD_U0486.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0486.Name = "Can_OBD_U0486";
            this.Can_OBD_U0486.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0486.TabIndex = 52;
            this.Can_OBD_U0486.TabStop = true;
            this.Can_OBD_U0486.Text = "U0486";
            this.Can_OBD_U0486.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0426
            // 
            this.Can_OBD_U0426.AutoCheck = false;
            this.Can_OBD_U0426.AutoSize = true;
            this.Can_OBD_U0426.Location = new System.Drawing.Point(165, 19);
            this.Can_OBD_U0426.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0426.Name = "Can_OBD_U0426";
            this.Can_OBD_U0426.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0426.TabIndex = 51;
            this.Can_OBD_U0426.TabStop = true;
            this.Can_OBD_U0426.Text = "U0426";
            this.Can_OBD_U0426.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0122
            // 
            this.Can_OBD_U0122.AutoCheck = false;
            this.Can_OBD_U0122.AutoSize = true;
            this.Can_OBD_U0122.Location = new System.Drawing.Point(85, 441);
            this.Can_OBD_U0122.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0122.Name = "Can_OBD_U0122";
            this.Can_OBD_U0122.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0122.TabIndex = 48;
            this.Can_OBD_U0122.TabStop = true;
            this.Can_OBD_U0122.Text = "U0122";
            this.Can_OBD_U0122.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0121
            // 
            this.Can_OBD_U0121.AutoCheck = false;
            this.Can_OBD_U0121.AutoSize = true;
            this.Can_OBD_U0121.Location = new System.Drawing.Point(85, 421);
            this.Can_OBD_U0121.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0121.Name = "Can_OBD_U0121";
            this.Can_OBD_U0121.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0121.TabIndex = 47;
            this.Can_OBD_U0121.TabStop = true;
            this.Can_OBD_U0121.Text = "U0121";
            this.Can_OBD_U0121.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0002
            // 
            this.Can_OBD_U0002.AutoCheck = false;
            this.Can_OBD_U0002.AutoSize = true;
            this.Can_OBD_U0002.Location = new System.Drawing.Point(85, 401);
            this.Can_OBD_U0002.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0002.Name = "Can_OBD_U0002";
            this.Can_OBD_U0002.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0002.TabIndex = 46;
            this.Can_OBD_U0002.TabStop = true;
            this.Can_OBD_U0002.Text = "U0002";
            this.Can_OBD_U0002.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0140
            // 
            this.Can_OBD_U0140.AutoCheck = false;
            this.Can_OBD_U0140.AutoSize = true;
            this.Can_OBD_U0140.Location = new System.Drawing.Point(85, 481);
            this.Can_OBD_U0140.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0140.Name = "Can_OBD_U0140";
            this.Can_OBD_U0140.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0140.TabIndex = 50;
            this.Can_OBD_U0140.TabStop = true;
            this.Can_OBD_U0140.Text = "U0140";
            this.Can_OBD_U0140.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0001
            // 
            this.Can_OBD_U0001.AutoCheck = false;
            this.Can_OBD_U0001.AutoSize = true;
            this.Can_OBD_U0001.Location = new System.Drawing.Point(85, 381);
            this.Can_OBD_U0001.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0001.Name = "Can_OBD_U0001";
            this.Can_OBD_U0001.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0001.TabIndex = 45;
            this.Can_OBD_U0001.TabStop = true;
            this.Can_OBD_U0001.Text = "U0001";
            this.Can_OBD_U0001.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_U0128
            // 
            this.Can_OBD_U0128.AutoCheck = false;
            this.Can_OBD_U0128.AutoSize = true;
            this.Can_OBD_U0128.Location = new System.Drawing.Point(85, 461);
            this.Can_OBD_U0128.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_U0128.Name = "Can_OBD_U0128";
            this.Can_OBD_U0128.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_U0128.TabIndex = 49;
            this.Can_OBD_U0128.TabStop = true;
            this.Can_OBD_U0128.Text = "U0128";
            this.Can_OBD_U0128.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P2600
            // 
            this.Can_OBD_P2600.AutoCheck = false;
            this.Can_OBD_P2600.AutoSize = true;
            this.Can_OBD_P2600.Location = new System.Drawing.Point(85, 361);
            this.Can_OBD_P2600.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P2600.Name = "Can_OBD_P2600";
            this.Can_OBD_P2600.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P2600.TabIndex = 44;
            this.Can_OBD_P2600.TabStop = true;
            this.Can_OBD_P2600.Text = "P2600";
            this.Can_OBD_P2600.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P2158
            // 
            this.Can_OBD_P2158.AutoCheck = false;
            this.Can_OBD_P2158.AutoSize = true;
            this.Can_OBD_P2158.Location = new System.Drawing.Point(85, 341);
            this.Can_OBD_P2158.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P2158.Name = "Can_OBD_P2158";
            this.Can_OBD_P2158.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P2158.TabIndex = 43;
            this.Can_OBD_P2158.TabStop = true;
            this.Can_OBD_P2158.Text = "P2158";
            this.Can_OBD_P2158.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P1800
            // 
            this.Can_OBD_P1800.AutoCheck = false;
            this.Can_OBD_P1800.AutoSize = true;
            this.Can_OBD_P1800.Location = new System.Drawing.Point(85, 320);
            this.Can_OBD_P1800.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P1800.Name = "Can_OBD_P1800";
            this.Can_OBD_P1800.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P1800.TabIndex = 42;
            this.Can_OBD_P1800.TabStop = true;
            this.Can_OBD_P1800.Text = "P1800";
            this.Can_OBD_P1800.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P1607
            // 
            this.Can_OBD_P1607.AutoCheck = false;
            this.Can_OBD_P1607.AutoSize = true;
            this.Can_OBD_P1607.Location = new System.Drawing.Point(85, 300);
            this.Can_OBD_P1607.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P1607.Name = "Can_OBD_P1607";
            this.Can_OBD_P1607.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P1607.TabIndex = 41;
            this.Can_OBD_P1607.TabStop = true;
            this.Can_OBD_P1607.Text = "P1607";
            this.Can_OBD_P1607.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P1536
            // 
            this.Can_OBD_P1536.AutoCheck = false;
            this.Can_OBD_P1536.AutoSize = true;
            this.Can_OBD_P1536.Location = new System.Drawing.Point(85, 280);
            this.Can_OBD_P1536.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P1536.Name = "Can_OBD_P1536";
            this.Can_OBD_P1536.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P1536.TabIndex = 40;
            this.Can_OBD_P1536.TabStop = true;
            this.Can_OBD_P1536.Text = "P1536";
            this.Can_OBD_P1536.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P1310
            // 
            this.Can_OBD_P1310.AutoCheck = false;
            this.Can_OBD_P1310.AutoSize = true;
            this.Can_OBD_P1310.Location = new System.Drawing.Point(85, 260);
            this.Can_OBD_P1310.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P1310.Name = "Can_OBD_P1310";
            this.Can_OBD_P1310.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P1310.TabIndex = 39;
            this.Can_OBD_P1310.TabStop = true;
            this.Can_OBD_P1310.Text = "P1310";
            this.Can_OBD_P1310.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0620_PIN31
            // 
            this.Can_OBD_P0620_PIN31.AutoCheck = false;
            this.Can_OBD_P0620_PIN31.AutoSize = true;
            this.Can_OBD_P0620_PIN31.Location = new System.Drawing.Point(85, 160);
            this.Can_OBD_P0620_PIN31.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0620_PIN31.Name = "Can_OBD_P0620_PIN31";
            this.Can_OBD_P0620_PIN31.Size = new System.Drawing.Size(89, 16);
            this.Can_OBD_P0620_PIN31.TabIndex = 34;
            this.Can_OBD_P0620_PIN31.TabStop = true;
            this.Can_OBD_P0620_PIN31.Text = "P0620_PIN31";
            this.Can_OBD_P0620_PIN31.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P1300
            // 
            this.Can_OBD_P1300.AutoCheck = false;
            this.Can_OBD_P1300.AutoSize = true;
            this.Can_OBD_P1300.Location = new System.Drawing.Point(85, 240);
            this.Can_OBD_P1300.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P1300.Name = "Can_OBD_P1300";
            this.Can_OBD_P1300.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P1300.TabIndex = 38;
            this.Can_OBD_P1300.TabStop = true;
            this.Can_OBD_P1300.Text = "P1300";
            this.Can_OBD_P1300.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0620_PIN2
            // 
            this.Can_OBD_P0620_PIN2.AutoCheck = false;
            this.Can_OBD_P0620_PIN2.AutoSize = true;
            this.Can_OBD_P0620_PIN2.Location = new System.Drawing.Point(85, 140);
            this.Can_OBD_P0620_PIN2.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0620_PIN2.Name = "Can_OBD_P0620_PIN2";
            this.Can_OBD_P0620_PIN2.Size = new System.Drawing.Size(83, 16);
            this.Can_OBD_P0620_PIN2.TabIndex = 33;
            this.Can_OBD_P0620_PIN2.TabStop = true;
            this.Can_OBD_P0620_PIN2.Text = "P0620_PIN2";
            this.Can_OBD_P0620_PIN2.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0A0F
            // 
            this.Can_OBD_P0A0F.AutoCheck = false;
            this.Can_OBD_P0A0F.AutoSize = true;
            this.Can_OBD_P0A0F.Location = new System.Drawing.Point(85, 220);
            this.Can_OBD_P0A0F.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0A0F.Name = "Can_OBD_P0A0F";
            this.Can_OBD_P0A0F.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_P0A0F.TabIndex = 37;
            this.Can_OBD_P0A0F.TabStop = true;
            this.Can_OBD_P0A0F.Text = "P0A0F";
            this.Can_OBD_P0A0F.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0606
            // 
            this.Can_OBD_P0606.AutoCheck = false;
            this.Can_OBD_P0606.AutoSize = true;
            this.Can_OBD_P0606.Location = new System.Drawing.Point(85, 120);
            this.Can_OBD_P0606.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0606.Name = "Can_OBD_P0606";
            this.Can_OBD_P0606.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0606.TabIndex = 32;
            this.Can_OBD_P0606.TabStop = true;
            this.Can_OBD_P0606.Text = "P0606";
            this.Can_OBD_P0606.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0655
            // 
            this.Can_OBD_P0655.AutoCheck = false;
            this.Can_OBD_P0655.AutoSize = true;
            this.Can_OBD_P0655.Location = new System.Drawing.Point(85, 200);
            this.Can_OBD_P0655.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0655.Name = "Can_OBD_P0655";
            this.Can_OBD_P0655.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0655.TabIndex = 36;
            this.Can_OBD_P0655.TabStop = true;
            this.Can_OBD_P0655.Text = "P0655";
            this.Can_OBD_P0655.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0605
            // 
            this.Can_OBD_P0605.AutoCheck = false;
            this.Can_OBD_P0605.AutoSize = true;
            this.Can_OBD_P0605.Location = new System.Drawing.Point(85, 100);
            this.Can_OBD_P0605.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0605.Name = "Can_OBD_P0605";
            this.Can_OBD_P0605.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0605.TabIndex = 31;
            this.Can_OBD_P0605.TabStop = true;
            this.Can_OBD_P0605.Text = "P0605";
            this.Can_OBD_P0605.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0650
            // 
            this.Can_OBD_P0650.AutoCheck = false;
            this.Can_OBD_P0650.AutoSize = true;
            this.Can_OBD_P0650.Location = new System.Drawing.Point(85, 180);
            this.Can_OBD_P0650.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0650.Name = "Can_OBD_P0650";
            this.Can_OBD_P0650.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0650.TabIndex = 35;
            this.Can_OBD_P0650.TabStop = true;
            this.Can_OBD_P0650.Text = "P0650";
            this.Can_OBD_P0650.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0604
            // 
            this.Can_OBD_P0604.AutoCheck = false;
            this.Can_OBD_P0604.AutoSize = true;
            this.Can_OBD_P0604.Location = new System.Drawing.Point(85, 80);
            this.Can_OBD_P0604.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0604.Name = "Can_OBD_P0604";
            this.Can_OBD_P0604.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0604.TabIndex = 30;
            this.Can_OBD_P0604.TabStop = true;
            this.Can_OBD_P0604.Text = "P0604";
            this.Can_OBD_P0604.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0601
            // 
            this.Can_OBD_P0601.AutoCheck = false;
            this.Can_OBD_P0601.AutoSize = true;
            this.Can_OBD_P0601.Location = new System.Drawing.Point(85, 60);
            this.Can_OBD_P0601.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0601.Name = "Can_OBD_P0601";
            this.Can_OBD_P0601.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0601.TabIndex = 29;
            this.Can_OBD_P0601.TabStop = true;
            this.Can_OBD_P0601.Text = "P0601";
            this.Can_OBD_P0601.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0560
            // 
            this.Can_OBD_P0560.AutoCheck = false;
            this.Can_OBD_P0560.AutoSize = true;
            this.Can_OBD_P0560.Location = new System.Drawing.Point(85, 39);
            this.Can_OBD_P0560.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0560.Name = "Can_OBD_P0560";
            this.Can_OBD_P0560.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0560.TabIndex = 28;
            this.Can_OBD_P0560.TabStop = true;
            this.Can_OBD_P0560.Text = "P0560";
            this.Can_OBD_P0560.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0512
            // 
            this.Can_OBD_P0512.AutoCheck = false;
            this.Can_OBD_P0512.AutoSize = true;
            this.Can_OBD_P0512.Location = new System.Drawing.Point(85, 19);
            this.Can_OBD_P0512.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0512.Name = "Can_OBD_P0512";
            this.Can_OBD_P0512.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0512.TabIndex = 27;
            this.Can_OBD_P0512.TabStop = true;
            this.Can_OBD_P0512.Text = "P0512";
            this.Can_OBD_P0512.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0500
            // 
            this.Can_OBD_P0500.AutoCheck = false;
            this.Can_OBD_P0500.AutoSize = true;
            this.Can_OBD_P0500.Location = new System.Drawing.Point(10, 441);
            this.Can_OBD_P0500.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0500.Name = "Can_OBD_P0500";
            this.Can_OBD_P0500.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0500.TabIndex = 24;
            this.Can_OBD_P0500.TabStop = true;
            this.Can_OBD_P0500.Text = "P0500";
            this.Can_OBD_P0500.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0480
            // 
            this.Can_OBD_P0480.AutoCheck = false;
            this.Can_OBD_P0480.AutoSize = true;
            this.Can_OBD_P0480.Location = new System.Drawing.Point(10, 421);
            this.Can_OBD_P0480.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0480.Name = "Can_OBD_P0480";
            this.Can_OBD_P0480.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0480.TabIndex = 23;
            this.Can_OBD_P0480.TabStop = true;
            this.Can_OBD_P0480.Text = "P0480";
            this.Can_OBD_P0480.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0410
            // 
            this.Can_OBD_P0410.AutoCheck = false;
            this.Can_OBD_P0410.AutoSize = true;
            this.Can_OBD_P0410.Location = new System.Drawing.Point(10, 401);
            this.Can_OBD_P0410.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0410.Name = "Can_OBD_P0410";
            this.Can_OBD_P0410.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0410.TabIndex = 22;
            this.Can_OBD_P0410.TabStop = true;
            this.Can_OBD_P0410.Text = "P0410";
            this.Can_OBD_P0410.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0505
            // 
            this.Can_OBD_P0505.AutoCheck = false;
            this.Can_OBD_P0505.AutoSize = true;
            this.Can_OBD_P0505.Location = new System.Drawing.Point(10, 481);
            this.Can_OBD_P0505.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0505.Name = "Can_OBD_P0505";
            this.Can_OBD_P0505.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0505.TabIndex = 26;
            this.Can_OBD_P0505.TabStop = true;
            this.Can_OBD_P0505.Text = "P0505";
            this.Can_OBD_P0505.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0352
            // 
            this.Can_OBD_P0352.AutoCheck = false;
            this.Can_OBD_P0352.AutoSize = true;
            this.Can_OBD_P0352.Location = new System.Drawing.Point(10, 381);
            this.Can_OBD_P0352.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0352.Name = "Can_OBD_P0352";
            this.Can_OBD_P0352.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0352.TabIndex = 21;
            this.Can_OBD_P0352.TabStop = true;
            this.Can_OBD_P0352.Text = "P0352";
            this.Can_OBD_P0352.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0501
            // 
            this.Can_OBD_P0501.AutoCheck = false;
            this.Can_OBD_P0501.AutoSize = true;
            this.Can_OBD_P0501.Location = new System.Drawing.Point(10, 461);
            this.Can_OBD_P0501.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0501.Name = "Can_OBD_P0501";
            this.Can_OBD_P0501.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0501.TabIndex = 25;
            this.Can_OBD_P0501.TabStop = true;
            this.Can_OBD_P0501.Text = "P0501";
            this.Can_OBD_P0501.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0351
            // 
            this.Can_OBD_P0351.AutoCheck = false;
            this.Can_OBD_P0351.AutoSize = true;
            this.Can_OBD_P0351.Location = new System.Drawing.Point(10, 361);
            this.Can_OBD_P0351.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0351.Name = "Can_OBD_P0351";
            this.Can_OBD_P0351.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0351.TabIndex = 20;
            this.Can_OBD_P0351.TabStop = true;
            this.Can_OBD_P0351.Text = "P0351";
            this.Can_OBD_P0351.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0336
            // 
            this.Can_OBD_P0336.AutoCheck = false;
            this.Can_OBD_P0336.AutoSize = true;
            this.Can_OBD_P0336.Location = new System.Drawing.Point(10, 341);
            this.Can_OBD_P0336.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0336.Name = "Can_OBD_P0336";
            this.Can_OBD_P0336.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0336.TabIndex = 19;
            this.Can_OBD_P0336.TabStop = true;
            this.Can_OBD_P0336.Text = "P0336";
            this.Can_OBD_P0336.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0335
            // 
            this.Can_OBD_P0335.AutoCheck = false;
            this.Can_OBD_P0335.AutoSize = true;
            this.Can_OBD_P0335.Location = new System.Drawing.Point(10, 320);
            this.Can_OBD_P0335.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0335.Name = "Can_OBD_P0335";
            this.Can_OBD_P0335.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0335.TabIndex = 18;
            this.Can_OBD_P0335.TabStop = true;
            this.Can_OBD_P0335.Text = "P0335";
            this.Can_OBD_P0335.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0230
            // 
            this.Can_OBD_P0230.AutoCheck = false;
            this.Can_OBD_P0230.AutoSize = true;
            this.Can_OBD_P0230.Location = new System.Drawing.Point(10, 300);
            this.Can_OBD_P0230.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0230.Name = "Can_OBD_P0230";
            this.Can_OBD_P0230.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0230.TabIndex = 17;
            this.Can_OBD_P0230.TabStop = true;
            this.Can_OBD_P0230.Text = "P0230";
            this.Can_OBD_P0230.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0217
            // 
            this.Can_OBD_P0217.AutoCheck = false;
            this.Can_OBD_P0217.AutoSize = true;
            this.Can_OBD_P0217.Location = new System.Drawing.Point(10, 280);
            this.Can_OBD_P0217.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0217.Name = "Can_OBD_P0217";
            this.Can_OBD_P0217.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0217.TabIndex = 16;
            this.Can_OBD_P0217.TabStop = true;
            this.Can_OBD_P0217.Text = "P0217";
            this.Can_OBD_P0217.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0202
            // 
            this.Can_OBD_P0202.AutoCheck = false;
            this.Can_OBD_P0202.AutoSize = true;
            this.Can_OBD_P0202.Location = new System.Drawing.Point(10, 260);
            this.Can_OBD_P0202.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0202.Name = "Can_OBD_P0202";
            this.Can_OBD_P0202.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0202.TabIndex = 15;
            this.Can_OBD_P0202.TabStop = true;
            this.Can_OBD_P0202.Text = "P0202";
            this.Can_OBD_P0202.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0130
            // 
            this.Can_OBD_P0130.AutoCheck = false;
            this.Can_OBD_P0130.AutoSize = true;
            this.Can_OBD_P0130.Location = new System.Drawing.Point(10, 160);
            this.Can_OBD_P0130.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0130.Name = "Can_OBD_P0130";
            this.Can_OBD_P0130.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0130.TabIndex = 7;
            this.Can_OBD_P0130.TabStop = true;
            this.Can_OBD_P0130.Text = "P0130";
            this.Can_OBD_P0130.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0201
            // 
            this.Can_OBD_P0201.AutoCheck = false;
            this.Can_OBD_P0201.AutoSize = true;
            this.Can_OBD_P0201.Location = new System.Drawing.Point(10, 240);
            this.Can_OBD_P0201.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0201.Name = "Can_OBD_P0201";
            this.Can_OBD_P0201.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0201.TabIndex = 14;
            this.Can_OBD_P0201.TabStop = true;
            this.Can_OBD_P0201.Text = "P0201";
            this.Can_OBD_P0201.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0120
            // 
            this.Can_OBD_P0120.AutoCheck = false;
            this.Can_OBD_P0120.AutoSize = true;
            this.Can_OBD_P0120.Location = new System.Drawing.Point(10, 140);
            this.Can_OBD_P0120.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0120.Name = "Can_OBD_P0120";
            this.Can_OBD_P0120.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0120.TabIndex = 6;
            this.Can_OBD_P0120.TabStop = true;
            this.Can_OBD_P0120.Text = "P0120";
            this.Can_OBD_P0120.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0155
            // 
            this.Can_OBD_P0155.AutoCheck = false;
            this.Can_OBD_P0155.AutoSize = true;
            this.Can_OBD_P0155.Location = new System.Drawing.Point(10, 220);
            this.Can_OBD_P0155.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0155.Name = "Can_OBD_P0155";
            this.Can_OBD_P0155.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0155.TabIndex = 13;
            this.Can_OBD_P0155.TabStop = true;
            this.Can_OBD_P0155.Text = "P0155";
            this.Can_OBD_P0155.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0115
            // 
            this.Can_OBD_P0115.AutoCheck = false;
            this.Can_OBD_P0115.AutoSize = true;
            this.Can_OBD_P0115.Location = new System.Drawing.Point(10, 120);
            this.Can_OBD_P0115.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0115.Name = "Can_OBD_P0115";
            this.Can_OBD_P0115.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0115.TabIndex = 5;
            this.Can_OBD_P0115.TabStop = true;
            this.Can_OBD_P0115.Text = "P0115";
            this.Can_OBD_P0115.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0150
            // 
            this.Can_OBD_P0150.AutoCheck = false;
            this.Can_OBD_P0150.AutoSize = true;
            this.Can_OBD_P0150.Location = new System.Drawing.Point(10, 200);
            this.Can_OBD_P0150.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0150.Name = "Can_OBD_P0150";
            this.Can_OBD_P0150.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0150.TabIndex = 12;
            this.Can_OBD_P0150.TabStop = true;
            this.Can_OBD_P0150.Text = "P0150";
            this.Can_OBD_P0150.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0110
            // 
            this.Can_OBD_P0110.AutoCheck = false;
            this.Can_OBD_P0110.AutoSize = true;
            this.Can_OBD_P0110.Location = new System.Drawing.Point(10, 100);
            this.Can_OBD_P0110.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0110.Name = "Can_OBD_P0110";
            this.Can_OBD_P0110.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0110.TabIndex = 4;
            this.Can_OBD_P0110.TabStop = true;
            this.Can_OBD_P0110.Text = "P0110";
            this.Can_OBD_P0110.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0135
            // 
            this.Can_OBD_P0135.AutoCheck = false;
            this.Can_OBD_P0135.AutoSize = true;
            this.Can_OBD_P0135.Location = new System.Drawing.Point(10, 180);
            this.Can_OBD_P0135.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0135.Name = "Can_OBD_P0135";
            this.Can_OBD_P0135.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0135.TabIndex = 11;
            this.Can_OBD_P0135.TabStop = true;
            this.Can_OBD_P0135.Text = "P0135";
            this.Can_OBD_P0135.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0105
            // 
            this.Can_OBD_P0105.AutoCheck = false;
            this.Can_OBD_P0105.AutoSize = true;
            this.Can_OBD_P0105.Location = new System.Drawing.Point(10, 80);
            this.Can_OBD_P0105.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0105.Name = "Can_OBD_P0105";
            this.Can_OBD_P0105.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0105.TabIndex = 3;
            this.Can_OBD_P0105.TabStop = true;
            this.Can_OBD_P0105.Text = "P0105";
            this.Can_OBD_P0105.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_C0085
            // 
            this.Can_OBD_C0085.AutoCheck = false;
            this.Can_OBD_C0085.AutoSize = true;
            this.Can_OBD_C0085.Location = new System.Drawing.Point(10, 60);
            this.Can_OBD_C0085.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_C0085.Name = "Can_OBD_C0085";
            this.Can_OBD_C0085.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_C0085.TabIndex = 2;
            this.Can_OBD_C0085.TabStop = true;
            this.Can_OBD_C0085.Text = "C0085";
            this.Can_OBD_C0085.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_C0083
            // 
            this.Can_OBD_C0083.AutoCheck = false;
            this.Can_OBD_C0083.AutoSize = true;
            this.Can_OBD_C0083.Location = new System.Drawing.Point(10, 39);
            this.Can_OBD_C0083.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_C0083.Name = "Can_OBD_C0083";
            this.Can_OBD_C0083.Size = new System.Drawing.Size(55, 16);
            this.Can_OBD_C0083.TabIndex = 1;
            this.Can_OBD_C0083.TabStop = true;
            this.Can_OBD_C0083.Text = "C0083";
            this.Can_OBD_C0083.UseVisualStyleBackColor = true;
            // 
            // Can_OBD_P0503
            // 
            this.Can_OBD_P0503.AutoCheck = false;
            this.Can_OBD_P0503.AutoSize = true;
            this.Can_OBD_P0503.Location = new System.Drawing.Point(10, 19);
            this.Can_OBD_P0503.Margin = new System.Windows.Forms.Padding(2);
            this.Can_OBD_P0503.Name = "Can_OBD_P0503";
            this.Can_OBD_P0503.Size = new System.Drawing.Size(53, 16);
            this.Can_OBD_P0503.TabIndex = 0;
            this.Can_OBD_P0503.TabStop = true;
            this.Can_OBD_P0503.Text = "P0503";
            this.Can_OBD_P0503.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Can_ABS_0x5025);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5044);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5052);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5042);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5053);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5045);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5014);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5043);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5018);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5035);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5013);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5017);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5019);
            this.groupBox2.Controls.Add(this.Can_ABS_0x5055);
            this.groupBox2.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.groupBox2.Location = new System.Drawing.Point(973, 448);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(94, 302);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABS Status";
            // 
            // Can_ABS_0x5025
            // 
            this.Can_ABS_0x5025.AutoCheck = false;
            this.Can_ABS_0x5025.AutoSize = true;
            this.Can_ABS_0x5025.Location = new System.Drawing.Point(10, 280);
            this.Can_ABS_0x5025.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5025.Name = "Can_ABS_0x5025";
            this.Can_ABS_0x5025.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5025.TabIndex = 16;
            this.Can_ABS_0x5025.TabStop = true;
            this.Can_ABS_0x5025.Text = "0x5025";
            this.Can_ABS_0x5025.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5044
            // 
            this.Can_ABS_0x5044.AutoCheck = false;
            this.Can_ABS_0x5044.AutoSize = true;
            this.Can_ABS_0x5044.Location = new System.Drawing.Point(10, 260);
            this.Can_ABS_0x5044.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5044.Name = "Can_ABS_0x5044";
            this.Can_ABS_0x5044.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5044.TabIndex = 15;
            this.Can_ABS_0x5044.TabStop = true;
            this.Can_ABS_0x5044.Text = "0x5044";
            this.Can_ABS_0x5044.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5052
            // 
            this.Can_ABS_0x5052.AutoCheck = false;
            this.Can_ABS_0x5052.AutoSize = true;
            this.Can_ABS_0x5052.Location = new System.Drawing.Point(10, 160);
            this.Can_ABS_0x5052.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5052.Name = "Can_ABS_0x5052";
            this.Can_ABS_0x5052.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5052.TabIndex = 7;
            this.Can_ABS_0x5052.TabStop = true;
            this.Can_ABS_0x5052.Text = "0x5052";
            this.Can_ABS_0x5052.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5042
            // 
            this.Can_ABS_0x5042.AutoCheck = false;
            this.Can_ABS_0x5042.AutoSize = true;
            this.Can_ABS_0x5042.Location = new System.Drawing.Point(10, 240);
            this.Can_ABS_0x5042.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5042.Name = "Can_ABS_0x5042";
            this.Can_ABS_0x5042.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5042.TabIndex = 14;
            this.Can_ABS_0x5042.TabStop = true;
            this.Can_ABS_0x5042.Text = "0x5042";
            this.Can_ABS_0x5042.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5053
            // 
            this.Can_ABS_0x5053.AutoCheck = false;
            this.Can_ABS_0x5053.AutoSize = true;
            this.Can_ABS_0x5053.Location = new System.Drawing.Point(10, 140);
            this.Can_ABS_0x5053.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5053.Name = "Can_ABS_0x5053";
            this.Can_ABS_0x5053.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5053.TabIndex = 6;
            this.Can_ABS_0x5053.TabStop = true;
            this.Can_ABS_0x5053.Text = "0x5053";
            this.Can_ABS_0x5053.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5045
            // 
            this.Can_ABS_0x5045.AutoCheck = false;
            this.Can_ABS_0x5045.AutoSize = true;
            this.Can_ABS_0x5045.Location = new System.Drawing.Point(10, 220);
            this.Can_ABS_0x5045.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5045.Name = "Can_ABS_0x5045";
            this.Can_ABS_0x5045.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5045.TabIndex = 13;
            this.Can_ABS_0x5045.TabStop = true;
            this.Can_ABS_0x5045.Text = "0x5045";
            this.Can_ABS_0x5045.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5014
            // 
            this.Can_ABS_0x5014.AutoCheck = false;
            this.Can_ABS_0x5014.AutoSize = true;
            this.Can_ABS_0x5014.Location = new System.Drawing.Point(10, 120);
            this.Can_ABS_0x5014.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5014.Name = "Can_ABS_0x5014";
            this.Can_ABS_0x5014.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5014.TabIndex = 5;
            this.Can_ABS_0x5014.TabStop = true;
            this.Can_ABS_0x5014.Text = "0x5014";
            this.Can_ABS_0x5014.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5043
            // 
            this.Can_ABS_0x5043.AutoCheck = false;
            this.Can_ABS_0x5043.AutoSize = true;
            this.Can_ABS_0x5043.Location = new System.Drawing.Point(10, 200);
            this.Can_ABS_0x5043.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5043.Name = "Can_ABS_0x5043";
            this.Can_ABS_0x5043.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5043.TabIndex = 12;
            this.Can_ABS_0x5043.TabStop = true;
            this.Can_ABS_0x5043.Text = "0x5043";
            this.Can_ABS_0x5043.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5018
            // 
            this.Can_ABS_0x5018.AutoCheck = false;
            this.Can_ABS_0x5018.AutoSize = true;
            this.Can_ABS_0x5018.Location = new System.Drawing.Point(10, 100);
            this.Can_ABS_0x5018.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5018.Name = "Can_ABS_0x5018";
            this.Can_ABS_0x5018.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5018.TabIndex = 4;
            this.Can_ABS_0x5018.TabStop = true;
            this.Can_ABS_0x5018.Text = "0x5018";
            this.Can_ABS_0x5018.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5035
            // 
            this.Can_ABS_0x5035.AutoCheck = false;
            this.Can_ABS_0x5035.AutoSize = true;
            this.Can_ABS_0x5035.Location = new System.Drawing.Point(10, 180);
            this.Can_ABS_0x5035.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5035.Name = "Can_ABS_0x5035";
            this.Can_ABS_0x5035.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5035.TabIndex = 11;
            this.Can_ABS_0x5035.TabStop = true;
            this.Can_ABS_0x5035.Text = "0x5035";
            this.Can_ABS_0x5035.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5013
            // 
            this.Can_ABS_0x5013.AutoCheck = false;
            this.Can_ABS_0x5013.AutoSize = true;
            this.Can_ABS_0x5013.Location = new System.Drawing.Point(10, 80);
            this.Can_ABS_0x5013.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5013.Name = "Can_ABS_0x5013";
            this.Can_ABS_0x5013.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5013.TabIndex = 3;
            this.Can_ABS_0x5013.TabStop = true;
            this.Can_ABS_0x5013.Text = "0x5013";
            this.Can_ABS_0x5013.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5017
            // 
            this.Can_ABS_0x5017.AutoCheck = false;
            this.Can_ABS_0x5017.AutoSize = true;
            this.Can_ABS_0x5017.Location = new System.Drawing.Point(10, 60);
            this.Can_ABS_0x5017.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5017.Name = "Can_ABS_0x5017";
            this.Can_ABS_0x5017.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5017.TabIndex = 2;
            this.Can_ABS_0x5017.TabStop = true;
            this.Can_ABS_0x5017.Text = "0x5017";
            this.Can_ABS_0x5017.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5019
            // 
            this.Can_ABS_0x5019.AutoCheck = false;
            this.Can_ABS_0x5019.AutoSize = true;
            this.Can_ABS_0x5019.Location = new System.Drawing.Point(10, 39);
            this.Can_ABS_0x5019.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5019.Name = "Can_ABS_0x5019";
            this.Can_ABS_0x5019.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5019.TabIndex = 1;
            this.Can_ABS_0x5019.TabStop = true;
            this.Can_ABS_0x5019.Text = "0x5019";
            this.Can_ABS_0x5019.UseVisualStyleBackColor = true;
            // 
            // Can_ABS_0x5055
            // 
            this.Can_ABS_0x5055.AutoCheck = false;
            this.Can_ABS_0x5055.AutoSize = true;
            this.Can_ABS_0x5055.Location = new System.Drawing.Point(10, 19);
            this.Can_ABS_0x5055.Margin = new System.Windows.Forms.Padding(2);
            this.Can_ABS_0x5055.Name = "Can_ABS_0x5055";
            this.Can_ABS_0x5055.Size = new System.Drawing.Size(59, 16);
            this.Can_ABS_0x5055.TabIndex = 0;
            this.Can_ABS_0x5055.TabStop = true;
            this.Can_ABS_0x5055.Text = "0x5055";
            this.Can_ABS_0x5055.UseVisualStyleBackColor = true;
            // 
            // button_canbus_calulate
            // 
            this.button_canbus_calulate.Location = new System.Drawing.Point(893, 374);
            this.button_canbus_calulate.Name = "button_canbus_calulate";
            this.button_canbus_calulate.Size = new System.Drawing.Size(75, 23);
            this.button_canbus_calulate.TabIndex = 33;
            this.button_canbus_calulate.Text = "Canbus_Cal";
            this.button_canbus_calulate.UseVisualStyleBackColor = true;
            this.button_canbus_calulate.Click += new System.EventHandler(this.button_canbus_calulate_Click);
            // 
            // button_canbus_write
            // 
            this.button_canbus_write.Location = new System.Drawing.Point(814, 374);
            this.button_canbus_write.Name = "button_canbus_write";
            this.button_canbus_write.Size = new System.Drawing.Size(75, 23);
            this.button_canbus_write.TabIndex = 34;
            this.button_canbus_write.Text = "Canbus";
            this.button_canbus_write.UseVisualStyleBackColor = true;
            this.button_canbus_write.Click += new System.EventHandler(this.button_canbus_write_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1381, 749);
            this.Controls.Add(this.button_canbus_write);
            this.Controls.Add(this.button_canbus_calulate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_Kline_status);
            this.Controls.Add(this.Group_DTC_data_option);
            this.Controls.Add(this.rtbKLineData);
            this.Controls.Add(this.Group_ABS_Error_Code);
            this.Controls.Add(this.Group_OBD_Error_Code);
            this.Controls.Add(this.label_canbus_status);
            this.Controls.Add(this.Group_CAN_Reader);
            this.Controls.Add(this.label_autokit_status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.setting_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Digital Dashboard Simulation";
            this.Load += new System.EventHandler(this.DDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Group_CAN_Reader.ResumeLayout(false);
            this.Group_Driving_Status.ResumeLayout(false);
            this.Group_Driving_Status.PerformLayout();
            this.Group_Car_Status_Indicator.ResumeLayout(false);
            this.Group_Car_Status_Indicator.PerformLayout();
            this.Group_ABS_Error_Code.ResumeLayout(false);
            this.Group_ABS_Error_Code.PerformLayout();
            this.Group_OBD_Error_Code.ResumeLayout(false);
            this.Group_OBD_Error_Code.PerformLayout();
            this.Group_DTC_data_option.ResumeLayout(false);
            this.Group_DTC_data_option.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Button setting_button;
        private System.IO.Ports.SerialPort SerialPort2;
        private System.IO.Ports.SerialPort SerialPort3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.Ports.SerialPort Autokit_serialPort;
        private System.Windows.Forms.Label label_autokit_status;
        private System.Windows.Forms.GroupBox Group_CAN_Reader;
        private System.Windows.Forms.GroupBox Group_Driving_Status;
        private System.Windows.Forms.TextBox Value_Battery;
        private System.Windows.Forms.Label Label_Battery;
        private System.Windows.Forms.TextBox Value_RoomTemp;
        private System.Windows.Forms.TextBox Value_Fuel;
        private System.Windows.Forms.Label Label_RoomTemp;
        private System.Windows.Forms.Label Label_Fuel;
        private System.Windows.Forms.TextBox Value_WaterTemp;
        private System.Windows.Forms.Label Label_WaterTemp;
        private System.Windows.Forms.TextBox Value_AveSpeed;
        private System.Windows.Forms.TextBox Value_FuelConsumption;
        private System.Windows.Forms.Label Label_AveSpeed;
        private System.Windows.Forms.Label Label_FuelConsumption;
        private System.Windows.Forms.TextBox Value_MaxSpeed;
        private System.Windows.Forms.Label Label_MaxSpeed;
        private System.Windows.Forms.TextBox Value_EngineRPM;
        private System.Windows.Forms.TextBox Value_TotalMileage;
        private System.Windows.Forms.Label Label_EngineRPM;
        private System.Windows.Forms.Label Label_TotalMileage;
        private System.Windows.Forms.TextBox Value_Speed;
        private System.Windows.Forms.Label Label_Speed;
        private System.Windows.Forms.GroupBox Group_Car_Status_Indicator;
        private System.Windows.Forms.RadioButton Status_RearTirePressure;
        private System.Windows.Forms.RadioButton Status_FrontTirePressure;
        private System.Windows.Forms.RadioButton Status_Maintenance;
        private System.Windows.Forms.RadioButton Status_WaterTemp;
        private System.Windows.Forms.RadioButton Status_ABS;
        private System.Windows.Forms.RadioButton Status_Fuel;
        private System.Windows.Forms.RadioButton Status_EngineOil;
        private System.Windows.Forms.RadioButton Status_OnOff;
        private System.Windows.Forms.ListBox listBox_Info;
        private System.Windows.Forms.Timer timer_rec;
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
        private System.Windows.Forms.Label label_canbus_status;
        private System.Windows.Forms.TextBox Value_Fuel_LPK;
        private System.Windows.Forms.GroupBox Group_ABS_Error_Code;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5025;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5044;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5052;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5042;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5053;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5045;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5014;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5043;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5018;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5035;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5013;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5017;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5019;
        private System.Windows.Forms.CheckBox Kline_ABS_0x5055;
        private System.Windows.Forms.GroupBox Group_OBD_Error_Code;
        private System.Windows.Forms.CheckBox Kline_OBD_U0486;
        private System.Windows.Forms.CheckBox Kline_OBD_U0426;
        private System.Windows.Forms.CheckBox Kline_OBD_U0122;
        private System.Windows.Forms.CheckBox Kline_OBD_U0121;
        private System.Windows.Forms.CheckBox Kline_OBD_U0002;
        private System.Windows.Forms.CheckBox Kline_OBD_U0140;
        private System.Windows.Forms.CheckBox Kline_OBD_U0001;
        private System.Windows.Forms.CheckBox Kline_OBD_U0128;
        private System.Windows.Forms.CheckBox Kline_OBD_P2600;
        private System.Windows.Forms.CheckBox Kline_OBD_P2158;
        private System.Windows.Forms.CheckBox Kline_OBD_P1800;
        private System.Windows.Forms.CheckBox Kline_OBD_P1607;
        private System.Windows.Forms.CheckBox Kline_OBD_P1536;
        private System.Windows.Forms.CheckBox Kline_OBD_P1310;
        private System.Windows.Forms.CheckBox Kline_OBD_P0620_PIN31;
        private System.Windows.Forms.CheckBox Kline_OBD_P1300;
        private System.Windows.Forms.CheckBox Kline_OBD_P0620_PIN2;
        private System.Windows.Forms.CheckBox Kline_OBD_P0A0F;
        private System.Windows.Forms.CheckBox Kline_OBD_P0606;
        private System.Windows.Forms.CheckBox Kline_OBD_P0655;
        private System.Windows.Forms.CheckBox Kline_OBD_P0605;
        private System.Windows.Forms.CheckBox Kline_OBD_P0650;
        private System.Windows.Forms.CheckBox Kline_OBD_P0604;
        private System.Windows.Forms.CheckBox Kline_OBD_P0601;
        private System.Windows.Forms.CheckBox Kline_OBD_P0560;
        private System.Windows.Forms.CheckBox Kline_OBD_P0512;
        private System.Windows.Forms.CheckBox Kline_OBD_P0500;
        private System.Windows.Forms.CheckBox Kline_OBD_P0480;
        private System.Windows.Forms.CheckBox Kline_OBD_P0410;
        private System.Windows.Forms.CheckBox Kline_OBD_P0505;
        private System.Windows.Forms.CheckBox Kline_OBD_P0352;
        private System.Windows.Forms.CheckBox Kline_OBD_P0501;
        private System.Windows.Forms.CheckBox Kline_OBD_P0351;
        private System.Windows.Forms.CheckBox Kline_OBD_P0336;
        private System.Windows.Forms.CheckBox Kline_OBD_P0335;
        private System.Windows.Forms.CheckBox Kline_OBD_P0230;
        private System.Windows.Forms.CheckBox Kline_OBD_P0217;
        private System.Windows.Forms.CheckBox Kline_OBD_P0202;
        private System.Windows.Forms.CheckBox Kline_OBD_P0130;
        private System.Windows.Forms.CheckBox Kline_OBD_P0201;
        private System.Windows.Forms.CheckBox Kline_OBD_P0120;
        private System.Windows.Forms.CheckBox Kline_OBD_P0155;
        private System.Windows.Forms.CheckBox Kline_OBD_P0115;
        private System.Windows.Forms.CheckBox Kline_OBD_P0150;
        private System.Windows.Forms.CheckBox Kline_OBD_P0110;
        private System.Windows.Forms.CheckBox Kline_OBD_P0135;
        private System.Windows.Forms.CheckBox Kline_OBD_P0105;
        private System.Windows.Forms.CheckBox Kline_OBD_C0085;
        private System.Windows.Forms.CheckBox Kline_OBD_C0083;
        private System.Windows.Forms.CheckBox Kline_OBD_P0503;
        private System.Windows.Forms.Timer tmr_FetchingUARTInput;
        private System.Windows.Forms.RichTextBox rtbKLineData;
        private System.Windows.Forms.GroupBox Group_DTC_data_option;
        private System.Windows.Forms.RadioButton DTC_option_all_in_turn;
        private System.Windows.Forms.RadioButton DTC_option_first_six;
        private System.Windows.Forms.Label label_Kline_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Can_OBD_U0486;
        private System.Windows.Forms.RadioButton Can_OBD_U0426;
        private System.Windows.Forms.RadioButton Can_OBD_U0122;
        private System.Windows.Forms.RadioButton Can_OBD_U0121;
        private System.Windows.Forms.RadioButton Can_OBD_U0002;
        private System.Windows.Forms.RadioButton Can_OBD_U0140;
        private System.Windows.Forms.RadioButton Can_OBD_U0001;
        private System.Windows.Forms.RadioButton Can_OBD_U0128;
        private System.Windows.Forms.RadioButton Can_OBD_P2600;
        private System.Windows.Forms.RadioButton Can_OBD_P2158;
        private System.Windows.Forms.RadioButton Can_OBD_P1800;
        private System.Windows.Forms.RadioButton Can_OBD_P1607;
        private System.Windows.Forms.RadioButton Can_OBD_P1536;
        private System.Windows.Forms.RadioButton Can_OBD_P1310;
        private System.Windows.Forms.RadioButton Can_OBD_P0620_PIN31;
        private System.Windows.Forms.RadioButton Can_OBD_P1300;
        private System.Windows.Forms.RadioButton Can_OBD_P0620_PIN2;
        private System.Windows.Forms.RadioButton Can_OBD_P0A0F;
        private System.Windows.Forms.RadioButton Can_OBD_P0606;
        private System.Windows.Forms.RadioButton Can_OBD_P0655;
        private System.Windows.Forms.RadioButton Can_OBD_P0605;
        private System.Windows.Forms.RadioButton Can_OBD_P0650;
        private System.Windows.Forms.RadioButton Can_OBD_P0604;
        private System.Windows.Forms.RadioButton Can_OBD_P0601;
        private System.Windows.Forms.RadioButton Can_OBD_P0560;
        private System.Windows.Forms.RadioButton Can_OBD_P0512;
        private System.Windows.Forms.RadioButton Can_OBD_P0500;
        private System.Windows.Forms.RadioButton Can_OBD_P0480;
        private System.Windows.Forms.RadioButton Can_OBD_P0410;
        private System.Windows.Forms.RadioButton Can_OBD_P0505;
        private System.Windows.Forms.RadioButton Can_OBD_P0352;
        private System.Windows.Forms.RadioButton Can_OBD_P0501;
        private System.Windows.Forms.RadioButton Can_OBD_P0351;
        private System.Windows.Forms.RadioButton Can_OBD_P0336;
        private System.Windows.Forms.RadioButton Can_OBD_P0335;
        private System.Windows.Forms.RadioButton Can_OBD_P0230;
        private System.Windows.Forms.RadioButton Can_OBD_P0217;
        private System.Windows.Forms.RadioButton Can_OBD_P0202;
        private System.Windows.Forms.RadioButton Can_OBD_P0130;
        private System.Windows.Forms.RadioButton Can_OBD_P0201;
        private System.Windows.Forms.RadioButton Can_OBD_P0120;
        private System.Windows.Forms.RadioButton Can_OBD_P0155;
        private System.Windows.Forms.RadioButton Can_OBD_P0115;
        private System.Windows.Forms.RadioButton Can_OBD_P0150;
        private System.Windows.Forms.RadioButton Can_OBD_P0110;
        private System.Windows.Forms.RadioButton Can_OBD_P0135;
        private System.Windows.Forms.RadioButton Can_OBD_P0105;
        private System.Windows.Forms.RadioButton Can_OBD_C0085;
        private System.Windows.Forms.RadioButton Can_OBD_C0083;
        private System.Windows.Forms.RadioButton Can_OBD_P0503;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Can_ABS_0x5025;
        private System.Windows.Forms.RadioButton Can_ABS_0x5044;
        private System.Windows.Forms.RadioButton Can_ABS_0x5052;
        private System.Windows.Forms.RadioButton Can_ABS_0x5042;
        private System.Windows.Forms.RadioButton Can_ABS_0x5053;
        private System.Windows.Forms.RadioButton Can_ABS_0x5045;
        private System.Windows.Forms.RadioButton Can_ABS_0x5014;
        private System.Windows.Forms.RadioButton Can_ABS_0x5043;
        private System.Windows.Forms.RadioButton Can_ABS_0x5018;
        private System.Windows.Forms.RadioButton Can_ABS_0x5035;
        private System.Windows.Forms.RadioButton Can_ABS_0x5013;
        private System.Windows.Forms.RadioButton Can_ABS_0x5017;
        private System.Windows.Forms.RadioButton Can_ABS_0x5019;
        private System.Windows.Forms.RadioButton Can_ABS_0x5055;
        private System.Windows.Forms.Button button_canbus_calulate;
        private System.Windows.Forms.Button button_canbus_write;
    }
}

