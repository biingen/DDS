namespace Venus
{
    partial class DDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDS));
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
            this.ABS_0x5025 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5044 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5052 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5042 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5053 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5045 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5014 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5043 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5018 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5035 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5013 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5017 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5019 = new System.Windows.Forms.CheckBox();
            this.ABS_0x5055 = new System.Windows.Forms.CheckBox();
            this.Group_OBD_Error_Code = new System.Windows.Forms.GroupBox();
            this.OBD_U0486 = new System.Windows.Forms.CheckBox();
            this.OBD_U0426 = new System.Windows.Forms.CheckBox();
            this.OBD_U0122 = new System.Windows.Forms.CheckBox();
            this.OBD_U0121 = new System.Windows.Forms.CheckBox();
            this.OBD_U0002 = new System.Windows.Forms.CheckBox();
            this.OBD_U0140 = new System.Windows.Forms.CheckBox();
            this.OBD_U0001 = new System.Windows.Forms.CheckBox();
            this.OBD_U0128 = new System.Windows.Forms.CheckBox();
            this.OBD_P2600 = new System.Windows.Forms.CheckBox();
            this.OBD_P2158 = new System.Windows.Forms.CheckBox();
            this.OBD_P1800 = new System.Windows.Forms.CheckBox();
            this.OBD_P1607 = new System.Windows.Forms.CheckBox();
            this.OBD_P1536 = new System.Windows.Forms.CheckBox();
            this.OBD_P1310 = new System.Windows.Forms.CheckBox();
            this.OBD_P0620_PIN31 = new System.Windows.Forms.CheckBox();
            this.OBD_P1300 = new System.Windows.Forms.CheckBox();
            this.OBD_P0620_PIN2 = new System.Windows.Forms.CheckBox();
            this.OBD_P0A0F = new System.Windows.Forms.CheckBox();
            this.OBD_P0606 = new System.Windows.Forms.CheckBox();
            this.OBD_P0655 = new System.Windows.Forms.CheckBox();
            this.OBD_P0605 = new System.Windows.Forms.CheckBox();
            this.OBD_P0650 = new System.Windows.Forms.CheckBox();
            this.OBD_P0604 = new System.Windows.Forms.CheckBox();
            this.OBD_P0601 = new System.Windows.Forms.CheckBox();
            this.OBD_P0560 = new System.Windows.Forms.CheckBox();
            this.OBD_P0512 = new System.Windows.Forms.CheckBox();
            this.OBD_P0500 = new System.Windows.Forms.CheckBox();
            this.OBD_P0480 = new System.Windows.Forms.CheckBox();
            this.OBD_P0410 = new System.Windows.Forms.CheckBox();
            this.OBD_P0505 = new System.Windows.Forms.CheckBox();
            this.OBD_P0352 = new System.Windows.Forms.CheckBox();
            this.OBD_P0501 = new System.Windows.Forms.CheckBox();
            this.OBD_P0351 = new System.Windows.Forms.CheckBox();
            this.OBD_P0336 = new System.Windows.Forms.CheckBox();
            this.OBD_P0335 = new System.Windows.Forms.CheckBox();
            this.OBD_P0230 = new System.Windows.Forms.CheckBox();
            this.OBD_P0217 = new System.Windows.Forms.CheckBox();
            this.OBD_P0202 = new System.Windows.Forms.CheckBox();
            this.OBD_P0130 = new System.Windows.Forms.CheckBox();
            this.OBD_P0201 = new System.Windows.Forms.CheckBox();
            this.OBD_P0120 = new System.Windows.Forms.CheckBox();
            this.OBD_P0155 = new System.Windows.Forms.CheckBox();
            this.OBD_P0115 = new System.Windows.Forms.CheckBox();
            this.OBD_P0150 = new System.Windows.Forms.CheckBox();
            this.OBD_P0110 = new System.Windows.Forms.CheckBox();
            this.OBD_P0135 = new System.Windows.Forms.CheckBox();
            this.OBD_P0105 = new System.Windows.Forms.CheckBox();
            this.OBD_C0085 = new System.Windows.Forms.CheckBox();
            this.OBD_C0083 = new System.Windows.Forms.CheckBox();
            this.OBD_P0503 = new System.Windows.Forms.CheckBox();
            this.tmr_FetchingUARTInput = new System.Windows.Forms.Timer(this.components);
            this.rtbKLineData = new System.Windows.Forms.RichTextBox();
            this.Group_DTC_data_option = new System.Windows.Forms.GroupBox();
            this.DTC_option_all_in_turn = new System.Windows.Forms.RadioButton();
            this.DTC_option_first_six = new System.Windows.Forms.RadioButton();
            this.label_Kline_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton38 = new System.Windows.Forms.RadioButton();
            this.radioButton39 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.radioButton41 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.radioButton44 = new System.Windows.Forms.RadioButton();
            this.radioButton45 = new System.Windows.Forms.RadioButton();
            this.radioButton46 = new System.Windows.Forms.RadioButton();
            this.radioButton47 = new System.Windows.Forms.RadioButton();
            this.radioButton48 = new System.Windows.Forms.RadioButton();
            this.radioButton49 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton51 = new System.Windows.Forms.RadioButton();
            this.radioButton52 = new System.Windows.Forms.RadioButton();
            this.radioButton53 = new System.Windows.Forms.RadioButton();
            this.radioButton54 = new System.Windows.Forms.RadioButton();
            this.radioButton55 = new System.Windows.Forms.RadioButton();
            this.radioButton56 = new System.Windows.Forms.RadioButton();
            this.radioButton57 = new System.Windows.Forms.RadioButton();
            this.radioButton58 = new System.Windows.Forms.RadioButton();
            this.radioButton59 = new System.Windows.Forms.RadioButton();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.radioButton61 = new System.Windows.Forms.RadioButton();
            this.radioButton62 = new System.Windows.Forms.RadioButton();
            this.radioButton63 = new System.Windows.Forms.RadioButton();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
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
            this.label_autokit_status.Location = new System.Drawing.Point(12, -1);
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
            this.Group_CAN_Reader.Location = new System.Drawing.Point(921, 11);
            this.Group_CAN_Reader.Margin = new System.Windows.Forms.Padding(2);
            this.Group_CAN_Reader.Name = "Group_CAN_Reader";
            this.Group_CAN_Reader.Padding = new System.Windows.Forms.Padding(2);
            this.Group_CAN_Reader.Size = new System.Drawing.Size(309, 352);
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
            this.Group_Driving_Status.Size = new System.Drawing.Size(292, 161);
            this.Group_Driving_Status.TabIndex = 13;
            this.Group_Driving_Status.TabStop = false;
            this.Group_Driving_Status.Text = "Driving Status";
            // 
            // Value_Fuel_LPK
            // 
            this.Value_Fuel_LPK.Location = new System.Drawing.Point(52, 86);
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
            this.Value_Battery.Location = new System.Drawing.Point(228, 135);
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
            this.Label_Battery.Location = new System.Drawing.Point(155, 136);
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
            this.Value_Fuel.Location = new System.Drawing.Point(228, 111);
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
            this.Label_Fuel.Location = new System.Drawing.Point(155, 112);
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
            this.Value_AveSpeed.Location = new System.Drawing.Point(228, 62);
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
            this.Label_AveSpeed.Location = new System.Drawing.Point(155, 64);
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
            this.Value_MaxSpeed.Location = new System.Drawing.Point(228, 38);
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
            this.Label_MaxSpeed.Location = new System.Drawing.Point(155, 40);
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
            this.Value_TotalMileage.Location = new System.Drawing.Point(228, 14);
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
            this.Label_TotalMileage.Location = new System.Drawing.Point(155, 17);
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
            this.Group_Car_Status_Indicator.Size = new System.Drawing.Size(292, 84);
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
            this.listBox_Info.Size = new System.Drawing.Size(294, 76);
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
            this.label_canbus_status.Location = new System.Drawing.Point(12, 11);
            this.label_canbus_status.Name = "label_canbus_status";
            this.label_canbus_status.Size = new System.Drawing.Size(68, 12);
            this.label_canbus_status.TabIndex = 23;
            this.label_canbus_status.Text = "Canbus status";
            // 
            // Group_ABS_Error_Code
            // 
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5025);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5044);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5052);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5042);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5053);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5045);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5014);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5043);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5018);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5035);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5013);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5017);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5019);
            this.Group_ABS_Error_Code.Controls.Add(this.ABS_0x5055);
            this.Group_ABS_Error_Code.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_ABS_Error_Code.Location = new System.Drawing.Point(369, 89);
            this.Group_ABS_Error_Code.Margin = new System.Windows.Forms.Padding(2);
            this.Group_ABS_Error_Code.Name = "Group_ABS_Error_Code";
            this.Group_ABS_Error_Code.Padding = new System.Windows.Forms.Padding(2);
            this.Group_ABS_Error_Code.Size = new System.Drawing.Size(94, 368);
            this.Group_ABS_Error_Code.TabIndex = 27;
            this.Group_ABS_Error_Code.TabStop = false;
            this.Group_ABS_Error_Code.Text = "ABS Status";
            // 
            // ABS_0x5025
            // 
            this.ABS_0x5025.AutoSize = true;
            this.ABS_0x5025.Location = new System.Drawing.Point(10, 303);
            this.ABS_0x5025.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5025.Name = "ABS_0x5025";
            this.ABS_0x5025.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5025.TabIndex = 16;
            this.ABS_0x5025.Text = "0x5025";
            this.ABS_0x5025.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5044
            // 
            this.ABS_0x5044.AutoSize = true;
            this.ABS_0x5044.Location = new System.Drawing.Point(10, 283);
            this.ABS_0x5044.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5044.Name = "ABS_0x5044";
            this.ABS_0x5044.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5044.TabIndex = 15;
            this.ABS_0x5044.Text = "0x5044";
            this.ABS_0x5044.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5052
            // 
            this.ABS_0x5052.AutoSize = true;
            this.ABS_0x5052.Location = new System.Drawing.Point(10, 160);
            this.ABS_0x5052.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5052.Name = "ABS_0x5052";
            this.ABS_0x5052.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5052.TabIndex = 7;
            this.ABS_0x5052.Text = "0x5052";
            this.ABS_0x5052.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5042
            // 
            this.ABS_0x5042.AutoSize = true;
            this.ABS_0x5042.Location = new System.Drawing.Point(10, 263);
            this.ABS_0x5042.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5042.Name = "ABS_0x5042";
            this.ABS_0x5042.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5042.TabIndex = 14;
            this.ABS_0x5042.Text = "0x5042";
            this.ABS_0x5042.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5053
            // 
            this.ABS_0x5053.AutoSize = true;
            this.ABS_0x5053.Location = new System.Drawing.Point(10, 140);
            this.ABS_0x5053.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5053.Name = "ABS_0x5053";
            this.ABS_0x5053.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5053.TabIndex = 6;
            this.ABS_0x5053.Text = "0x5053";
            this.ABS_0x5053.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5045
            // 
            this.ABS_0x5045.AutoSize = true;
            this.ABS_0x5045.Location = new System.Drawing.Point(10, 243);
            this.ABS_0x5045.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5045.Name = "ABS_0x5045";
            this.ABS_0x5045.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5045.TabIndex = 13;
            this.ABS_0x5045.Text = "0x5045";
            this.ABS_0x5045.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5014
            // 
            this.ABS_0x5014.AutoSize = true;
            this.ABS_0x5014.Location = new System.Drawing.Point(10, 120);
            this.ABS_0x5014.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5014.Name = "ABS_0x5014";
            this.ABS_0x5014.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5014.TabIndex = 5;
            this.ABS_0x5014.Text = "0x5014";
            this.ABS_0x5014.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5043
            // 
            this.ABS_0x5043.AutoSize = true;
            this.ABS_0x5043.Location = new System.Drawing.Point(10, 223);
            this.ABS_0x5043.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5043.Name = "ABS_0x5043";
            this.ABS_0x5043.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5043.TabIndex = 12;
            this.ABS_0x5043.Text = "0x5043";
            this.ABS_0x5043.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5018
            // 
            this.ABS_0x5018.AutoSize = true;
            this.ABS_0x5018.Location = new System.Drawing.Point(10, 100);
            this.ABS_0x5018.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5018.Name = "ABS_0x5018";
            this.ABS_0x5018.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5018.TabIndex = 4;
            this.ABS_0x5018.Text = "0x5018";
            this.ABS_0x5018.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5035
            // 
            this.ABS_0x5035.AutoSize = true;
            this.ABS_0x5035.Location = new System.Drawing.Point(10, 203);
            this.ABS_0x5035.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5035.Name = "ABS_0x5035";
            this.ABS_0x5035.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5035.TabIndex = 11;
            this.ABS_0x5035.Text = "0x5035";
            this.ABS_0x5035.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5013
            // 
            this.ABS_0x5013.AutoSize = true;
            this.ABS_0x5013.Location = new System.Drawing.Point(10, 80);
            this.ABS_0x5013.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5013.Name = "ABS_0x5013";
            this.ABS_0x5013.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5013.TabIndex = 3;
            this.ABS_0x5013.Text = "0x5013";
            this.ABS_0x5013.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5017
            // 
            this.ABS_0x5017.AutoSize = true;
            this.ABS_0x5017.Location = new System.Drawing.Point(10, 60);
            this.ABS_0x5017.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5017.Name = "ABS_0x5017";
            this.ABS_0x5017.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5017.TabIndex = 2;
            this.ABS_0x5017.Text = "0x5017";
            this.ABS_0x5017.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5019
            // 
            this.ABS_0x5019.AutoSize = true;
            this.ABS_0x5019.Location = new System.Drawing.Point(10, 39);
            this.ABS_0x5019.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5019.Name = "ABS_0x5019";
            this.ABS_0x5019.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5019.TabIndex = 1;
            this.ABS_0x5019.Text = "0x5019";
            this.ABS_0x5019.UseVisualStyleBackColor = true;
            // 
            // ABS_0x5055
            // 
            this.ABS_0x5055.AutoSize = true;
            this.ABS_0x5055.Location = new System.Drawing.Point(10, 19);
            this.ABS_0x5055.Margin = new System.Windows.Forms.Padding(2);
            this.ABS_0x5055.Name = "ABS_0x5055";
            this.ABS_0x5055.Size = new System.Drawing.Size(75, 20);
            this.ABS_0x5055.TabIndex = 0;
            this.ABS_0x5055.Tag = "";
            this.ABS_0x5055.Text = "0x5055";
            this.ABS_0x5055.UseVisualStyleBackColor = true;
            // 
            // Group_OBD_Error_Code
            // 
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0486);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0426);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0122);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0121);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0002);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0140);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0001);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_U0128);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P2600);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P2158);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1800);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1607);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1536);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1310);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0620_PIN31);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P1300);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0620_PIN2);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0A0F);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0606);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0655);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0605);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0650);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0604);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0601);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0560);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0512);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0500);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0480);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0410);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0505);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0352);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0501);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0351);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0336);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0335);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0230);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0217);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0202);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0130);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0201);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0120);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0155);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0115);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0150);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0110);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0135);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0105);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_C0085);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_C0083);
            this.Group_OBD_Error_Code.Controls.Add(this.OBD_P0503);
            this.Group_OBD_Error_Code.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_OBD_Error_Code.Location = new System.Drawing.Point(462, 89);
            this.Group_OBD_Error_Code.Margin = new System.Windows.Forms.Padding(2);
            this.Group_OBD_Error_Code.Name = "Group_OBD_Error_Code";
            this.Group_OBD_Error_Code.Padding = new System.Windows.Forms.Padding(2);
            this.Group_OBD_Error_Code.Size = new System.Drawing.Size(451, 368);
            this.Group_OBD_Error_Code.TabIndex = 26;
            this.Group_OBD_Error_Code.TabStop = false;
            this.Group_OBD_Error_Code.Text = "OBD Status";
            // 
            // OBD_U0486
            // 
            this.OBD_U0486.AutoSize = true;
            this.OBD_U0486.Location = new System.Drawing.Point(369, 38);
            this.OBD_U0486.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0486.Name = "OBD_U0486";
            this.OBD_U0486.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0486.TabIndex = 52;
            this.OBD_U0486.Text = "U0486";
            this.OBD_U0486.UseVisualStyleBackColor = true;
            // 
            // OBD_U0426
            // 
            this.OBD_U0426.AutoSize = true;
            this.OBD_U0426.Location = new System.Drawing.Point(369, 18);
            this.OBD_U0426.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0426.Name = "OBD_U0426";
            this.OBD_U0426.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0426.TabIndex = 51;
            this.OBD_U0426.Text = "U0426";
            this.OBD_U0426.UseVisualStyleBackColor = true;
            // 
            // OBD_U0122
            // 
            this.OBD_U0122.AutoSize = true;
            this.OBD_U0122.Location = new System.Drawing.Point(254, 303);
            this.OBD_U0122.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0122.Name = "OBD_U0122";
            this.OBD_U0122.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0122.TabIndex = 48;
            this.OBD_U0122.Text = "U0122";
            this.OBD_U0122.UseVisualStyleBackColor = true;
            // 
            // OBD_U0121
            // 
            this.OBD_U0121.AutoSize = true;
            this.OBD_U0121.Location = new System.Drawing.Point(254, 283);
            this.OBD_U0121.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0121.Name = "OBD_U0121";
            this.OBD_U0121.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0121.TabIndex = 47;
            this.OBD_U0121.Text = "U0121";
            this.OBD_U0121.UseVisualStyleBackColor = true;
            // 
            // OBD_U0002
            // 
            this.OBD_U0002.AutoSize = true;
            this.OBD_U0002.Location = new System.Drawing.Point(254, 263);
            this.OBD_U0002.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0002.Name = "OBD_U0002";
            this.OBD_U0002.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0002.TabIndex = 46;
            this.OBD_U0002.Text = "U0002";
            this.OBD_U0002.UseVisualStyleBackColor = true;
            // 
            // OBD_U0140
            // 
            this.OBD_U0140.AutoSize = true;
            this.OBD_U0140.Location = new System.Drawing.Point(254, 343);
            this.OBD_U0140.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0140.Name = "OBD_U0140";
            this.OBD_U0140.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0140.TabIndex = 50;
            this.OBD_U0140.Text = "U0140";
            this.OBD_U0140.UseVisualStyleBackColor = true;
            // 
            // OBD_U0001
            // 
            this.OBD_U0001.AutoSize = true;
            this.OBD_U0001.Location = new System.Drawing.Point(254, 243);
            this.OBD_U0001.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0001.Name = "OBD_U0001";
            this.OBD_U0001.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0001.TabIndex = 45;
            this.OBD_U0001.Text = "U0001";
            this.OBD_U0001.UseVisualStyleBackColor = true;
            // 
            // OBD_U0128
            // 
            this.OBD_U0128.AutoSize = true;
            this.OBD_U0128.Location = new System.Drawing.Point(254, 323);
            this.OBD_U0128.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_U0128.Name = "OBD_U0128";
            this.OBD_U0128.Size = new System.Drawing.Size(70, 20);
            this.OBD_U0128.TabIndex = 49;
            this.OBD_U0128.Text = "U0128";
            this.OBD_U0128.UseVisualStyleBackColor = true;
            // 
            // OBD_P2600
            // 
            this.OBD_P2600.AutoSize = true;
            this.OBD_P2600.Location = new System.Drawing.Point(254, 223);
            this.OBD_P2600.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P2600.Name = "OBD_P2600";
            this.OBD_P2600.Size = new System.Drawing.Size(67, 20);
            this.OBD_P2600.TabIndex = 44;
            this.OBD_P2600.Text = "P2600";
            this.OBD_P2600.UseVisualStyleBackColor = true;
            // 
            // OBD_P2158
            // 
            this.OBD_P2158.AutoSize = true;
            this.OBD_P2158.Location = new System.Drawing.Point(254, 203);
            this.OBD_P2158.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P2158.Name = "OBD_P2158";
            this.OBD_P2158.Size = new System.Drawing.Size(67, 20);
            this.OBD_P2158.TabIndex = 43;
            this.OBD_P2158.Text = "P2158";
            this.OBD_P2158.UseVisualStyleBackColor = true;
            // 
            // OBD_P1800
            // 
            this.OBD_P1800.AutoSize = true;
            this.OBD_P1800.Location = new System.Drawing.Point(254, 159);
            this.OBD_P1800.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P1800.Name = "OBD_P1800";
            this.OBD_P1800.Size = new System.Drawing.Size(67, 20);
            this.OBD_P1800.TabIndex = 42;
            this.OBD_P1800.Text = "P1800";
            this.OBD_P1800.UseVisualStyleBackColor = true;
            // 
            // OBD_P1607
            // 
            this.OBD_P1607.AutoSize = true;
            this.OBD_P1607.Location = new System.Drawing.Point(254, 139);
            this.OBD_P1607.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P1607.Name = "OBD_P1607";
            this.OBD_P1607.Size = new System.Drawing.Size(67, 20);
            this.OBD_P1607.TabIndex = 41;
            this.OBD_P1607.Text = "P1607";
            this.OBD_P1607.UseVisualStyleBackColor = true;
            // 
            // OBD_P1536
            // 
            this.OBD_P1536.AutoSize = true;
            this.OBD_P1536.Location = new System.Drawing.Point(254, 119);
            this.OBD_P1536.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P1536.Name = "OBD_P1536";
            this.OBD_P1536.Size = new System.Drawing.Size(67, 20);
            this.OBD_P1536.TabIndex = 40;
            this.OBD_P1536.Text = "P1536";
            this.OBD_P1536.UseVisualStyleBackColor = true;
            // 
            // OBD_P1310
            // 
            this.OBD_P1310.AutoSize = true;
            this.OBD_P1310.Location = new System.Drawing.Point(254, 99);
            this.OBD_P1310.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P1310.Name = "OBD_P1310";
            this.OBD_P1310.Size = new System.Drawing.Size(67, 20);
            this.OBD_P1310.TabIndex = 39;
            this.OBD_P1310.Text = "P1310";
            this.OBD_P1310.UseVisualStyleBackColor = true;
            // 
            // OBD_P0620_PIN31
            // 
            this.OBD_P0620_PIN31.AutoSize = true;
            this.OBD_P0620_PIN31.Location = new System.Drawing.Point(124, 344);
            this.OBD_P0620_PIN31.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0620_PIN31.Name = "OBD_P0620_PIN31";
            this.OBD_P0620_PIN31.Size = new System.Drawing.Size(115, 20);
            this.OBD_P0620_PIN31.TabIndex = 34;
            this.OBD_P0620_PIN31.Text = "P0620_PIN31";
            this.OBD_P0620_PIN31.UseVisualStyleBackColor = true;
            // 
            // OBD_P1300
            // 
            this.OBD_P1300.AutoSize = true;
            this.OBD_P1300.Location = new System.Drawing.Point(254, 79);
            this.OBD_P1300.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P1300.Name = "OBD_P1300";
            this.OBD_P1300.Size = new System.Drawing.Size(67, 20);
            this.OBD_P1300.TabIndex = 38;
            this.OBD_P1300.Text = "P1300";
            this.OBD_P1300.UseVisualStyleBackColor = true;
            // 
            // OBD_P0620_PIN2
            // 
            this.OBD_P0620_PIN2.AutoSize = true;
            this.OBD_P0620_PIN2.Location = new System.Drawing.Point(124, 324);
            this.OBD_P0620_PIN2.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0620_PIN2.Name = "OBD_P0620_PIN2";
            this.OBD_P0620_PIN2.Size = new System.Drawing.Size(107, 20);
            this.OBD_P0620_PIN2.TabIndex = 33;
            this.OBD_P0620_PIN2.Text = "P0620_PIN2";
            this.OBD_P0620_PIN2.UseVisualStyleBackColor = true;
            // 
            // OBD_P0A0F
            // 
            this.OBD_P0A0F.AutoSize = true;
            this.OBD_P0A0F.Location = new System.Drawing.Point(254, 59);
            this.OBD_P0A0F.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0A0F.Name = "OBD_P0A0F";
            this.OBD_P0A0F.Size = new System.Drawing.Size(70, 20);
            this.OBD_P0A0F.TabIndex = 37;
            this.OBD_P0A0F.Text = "P0A0F";
            this.OBD_P0A0F.UseVisualStyleBackColor = true;
            // 
            // OBD_P0606
            // 
            this.OBD_P0606.AutoSize = true;
            this.OBD_P0606.Location = new System.Drawing.Point(124, 304);
            this.OBD_P0606.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0606.Name = "OBD_P0606";
            this.OBD_P0606.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0606.TabIndex = 32;
            this.OBD_P0606.Text = "P0606";
            this.OBD_P0606.UseVisualStyleBackColor = true;
            // 
            // OBD_P0655
            // 
            this.OBD_P0655.AutoSize = true;
            this.OBD_P0655.Location = new System.Drawing.Point(254, 39);
            this.OBD_P0655.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0655.Name = "OBD_P0655";
            this.OBD_P0655.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0655.TabIndex = 36;
            this.OBD_P0655.Text = "P0655";
            this.OBD_P0655.UseVisualStyleBackColor = true;
            // 
            // OBD_P0605
            // 
            this.OBD_P0605.AutoSize = true;
            this.OBD_P0605.Location = new System.Drawing.Point(124, 284);
            this.OBD_P0605.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0605.Name = "OBD_P0605";
            this.OBD_P0605.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0605.TabIndex = 31;
            this.OBD_P0605.Text = "P0605";
            this.OBD_P0605.UseVisualStyleBackColor = true;
            // 
            // OBD_P0650
            // 
            this.OBD_P0650.AutoSize = true;
            this.OBD_P0650.Location = new System.Drawing.Point(254, 19);
            this.OBD_P0650.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0650.Name = "OBD_P0650";
            this.OBD_P0650.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0650.TabIndex = 35;
            this.OBD_P0650.Text = "P0650";
            this.OBD_P0650.UseVisualStyleBackColor = true;
            // 
            // OBD_P0604
            // 
            this.OBD_P0604.AutoSize = true;
            this.OBD_P0604.Location = new System.Drawing.Point(124, 264);
            this.OBD_P0604.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0604.Name = "OBD_P0604";
            this.OBD_P0604.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0604.TabIndex = 30;
            this.OBD_P0604.Text = "P0604";
            this.OBD_P0604.UseVisualStyleBackColor = true;
            // 
            // OBD_P0601
            // 
            this.OBD_P0601.AutoSize = true;
            this.OBD_P0601.Location = new System.Drawing.Point(124, 244);
            this.OBD_P0601.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0601.Name = "OBD_P0601";
            this.OBD_P0601.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0601.TabIndex = 29;
            this.OBD_P0601.Text = "P0601";
            this.OBD_P0601.UseVisualStyleBackColor = true;
            // 
            // OBD_P0560
            // 
            this.OBD_P0560.AutoSize = true;
            this.OBD_P0560.Location = new System.Drawing.Point(124, 223);
            this.OBD_P0560.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0560.Name = "OBD_P0560";
            this.OBD_P0560.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0560.TabIndex = 28;
            this.OBD_P0560.Text = "P0560";
            this.OBD_P0560.UseVisualStyleBackColor = true;
            // 
            // OBD_P0512
            // 
            this.OBD_P0512.AutoSize = true;
            this.OBD_P0512.Location = new System.Drawing.Point(124, 203);
            this.OBD_P0512.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0512.Name = "OBD_P0512";
            this.OBD_P0512.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0512.TabIndex = 27;
            this.OBD_P0512.Text = "P0512";
            this.OBD_P0512.UseVisualStyleBackColor = true;
            // 
            // OBD_P0500
            // 
            this.OBD_P0500.AutoSize = true;
            this.OBD_P0500.Location = new System.Drawing.Point(124, 119);
            this.OBD_P0500.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0500.Name = "OBD_P0500";
            this.OBD_P0500.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0500.TabIndex = 24;
            this.OBD_P0500.Text = "P0500";
            this.OBD_P0500.UseVisualStyleBackColor = true;
            // 
            // OBD_P0480
            // 
            this.OBD_P0480.AutoSize = true;
            this.OBD_P0480.Location = new System.Drawing.Point(124, 99);
            this.OBD_P0480.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0480.Name = "OBD_P0480";
            this.OBD_P0480.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0480.TabIndex = 23;
            this.OBD_P0480.Text = "P0480";
            this.OBD_P0480.UseVisualStyleBackColor = true;
            // 
            // OBD_P0410
            // 
            this.OBD_P0410.AutoSize = true;
            this.OBD_P0410.Location = new System.Drawing.Point(124, 79);
            this.OBD_P0410.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0410.Name = "OBD_P0410";
            this.OBD_P0410.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0410.TabIndex = 22;
            this.OBD_P0410.Text = "P0410";
            this.OBD_P0410.UseVisualStyleBackColor = true;
            // 
            // OBD_P0505
            // 
            this.OBD_P0505.AutoSize = true;
            this.OBD_P0505.Location = new System.Drawing.Point(124, 159);
            this.OBD_P0505.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0505.Name = "OBD_P0505";
            this.OBD_P0505.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0505.TabIndex = 26;
            this.OBD_P0505.Text = "P0505";
            this.OBD_P0505.UseVisualStyleBackColor = true;
            // 
            // OBD_P0352
            // 
            this.OBD_P0352.AutoSize = true;
            this.OBD_P0352.Location = new System.Drawing.Point(124, 59);
            this.OBD_P0352.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0352.Name = "OBD_P0352";
            this.OBD_P0352.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0352.TabIndex = 21;
            this.OBD_P0352.Text = "P0352";
            this.OBD_P0352.UseVisualStyleBackColor = true;
            // 
            // OBD_P0501
            // 
            this.OBD_P0501.AutoSize = true;
            this.OBD_P0501.Location = new System.Drawing.Point(124, 139);
            this.OBD_P0501.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0501.Name = "OBD_P0501";
            this.OBD_P0501.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0501.TabIndex = 25;
            this.OBD_P0501.Text = "P0501";
            this.OBD_P0501.UseVisualStyleBackColor = true;
            // 
            // OBD_P0351
            // 
            this.OBD_P0351.AutoSize = true;
            this.OBD_P0351.Location = new System.Drawing.Point(124, 39);
            this.OBD_P0351.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0351.Name = "OBD_P0351";
            this.OBD_P0351.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0351.TabIndex = 20;
            this.OBD_P0351.Text = "P0351";
            this.OBD_P0351.UseVisualStyleBackColor = true;
            // 
            // OBD_P0336
            // 
            this.OBD_P0336.AutoSize = true;
            this.OBD_P0336.Location = new System.Drawing.Point(124, 19);
            this.OBD_P0336.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0336.Name = "OBD_P0336";
            this.OBD_P0336.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0336.TabIndex = 19;
            this.OBD_P0336.Text = "P0336";
            this.OBD_P0336.UseVisualStyleBackColor = true;
            // 
            // OBD_P0335
            // 
            this.OBD_P0335.AutoSize = true;
            this.OBD_P0335.Location = new System.Drawing.Point(10, 343);
            this.OBD_P0335.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0335.Name = "OBD_P0335";
            this.OBD_P0335.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0335.TabIndex = 18;
            this.OBD_P0335.Text = "P0335";
            this.OBD_P0335.UseVisualStyleBackColor = true;
            // 
            // OBD_P0230
            // 
            this.OBD_P0230.AutoSize = true;
            this.OBD_P0230.Location = new System.Drawing.Point(10, 323);
            this.OBD_P0230.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0230.Name = "OBD_P0230";
            this.OBD_P0230.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0230.TabIndex = 17;
            this.OBD_P0230.Text = "P0230";
            this.OBD_P0230.UseVisualStyleBackColor = true;
            // 
            // OBD_P0217
            // 
            this.OBD_P0217.AutoSize = true;
            this.OBD_P0217.Location = new System.Drawing.Point(10, 303);
            this.OBD_P0217.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0217.Name = "OBD_P0217";
            this.OBD_P0217.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0217.TabIndex = 16;
            this.OBD_P0217.Text = "P0217";
            this.OBD_P0217.UseVisualStyleBackColor = true;
            // 
            // OBD_P0202
            // 
            this.OBD_P0202.AutoSize = true;
            this.OBD_P0202.Location = new System.Drawing.Point(10, 283);
            this.OBD_P0202.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0202.Name = "OBD_P0202";
            this.OBD_P0202.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0202.TabIndex = 15;
            this.OBD_P0202.Text = "P0202";
            this.OBD_P0202.UseVisualStyleBackColor = true;
            // 
            // OBD_P0130
            // 
            this.OBD_P0130.AutoSize = true;
            this.OBD_P0130.Location = new System.Drawing.Point(10, 160);
            this.OBD_P0130.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0130.Name = "OBD_P0130";
            this.OBD_P0130.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0130.TabIndex = 7;
            this.OBD_P0130.Text = "P0130";
            this.OBD_P0130.UseVisualStyleBackColor = true;
            // 
            // OBD_P0201
            // 
            this.OBD_P0201.AutoSize = true;
            this.OBD_P0201.Location = new System.Drawing.Point(10, 263);
            this.OBD_P0201.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0201.Name = "OBD_P0201";
            this.OBD_P0201.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0201.TabIndex = 14;
            this.OBD_P0201.Text = "P0201";
            this.OBD_P0201.UseVisualStyleBackColor = true;
            // 
            // OBD_P0120
            // 
            this.OBD_P0120.AutoSize = true;
            this.OBD_P0120.Location = new System.Drawing.Point(10, 140);
            this.OBD_P0120.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0120.Name = "OBD_P0120";
            this.OBD_P0120.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0120.TabIndex = 6;
            this.OBD_P0120.Text = "P0120";
            this.OBD_P0120.UseVisualStyleBackColor = true;
            // 
            // OBD_P0155
            // 
            this.OBD_P0155.AutoSize = true;
            this.OBD_P0155.Location = new System.Drawing.Point(10, 243);
            this.OBD_P0155.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0155.Name = "OBD_P0155";
            this.OBD_P0155.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0155.TabIndex = 13;
            this.OBD_P0155.Text = "P0155";
            this.OBD_P0155.UseVisualStyleBackColor = true;
            // 
            // OBD_P0115
            // 
            this.OBD_P0115.AutoSize = true;
            this.OBD_P0115.Location = new System.Drawing.Point(10, 120);
            this.OBD_P0115.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0115.Name = "OBD_P0115";
            this.OBD_P0115.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0115.TabIndex = 5;
            this.OBD_P0115.Text = "P0115";
            this.OBD_P0115.UseVisualStyleBackColor = true;
            // 
            // OBD_P0150
            // 
            this.OBD_P0150.AutoSize = true;
            this.OBD_P0150.Location = new System.Drawing.Point(10, 223);
            this.OBD_P0150.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0150.Name = "OBD_P0150";
            this.OBD_P0150.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0150.TabIndex = 12;
            this.OBD_P0150.Text = "P0150";
            this.OBD_P0150.UseVisualStyleBackColor = true;
            // 
            // OBD_P0110
            // 
            this.OBD_P0110.AutoSize = true;
            this.OBD_P0110.Location = new System.Drawing.Point(10, 100);
            this.OBD_P0110.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0110.Name = "OBD_P0110";
            this.OBD_P0110.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0110.TabIndex = 4;
            this.OBD_P0110.Text = "P0110";
            this.OBD_P0110.UseVisualStyleBackColor = true;
            // 
            // OBD_P0135
            // 
            this.OBD_P0135.AutoSize = true;
            this.OBD_P0135.Location = new System.Drawing.Point(10, 203);
            this.OBD_P0135.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0135.Name = "OBD_P0135";
            this.OBD_P0135.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0135.TabIndex = 11;
            this.OBD_P0135.Text = "P0135";
            this.OBD_P0135.UseVisualStyleBackColor = true;
            // 
            // OBD_P0105
            // 
            this.OBD_P0105.AutoSize = true;
            this.OBD_P0105.Location = new System.Drawing.Point(10, 80);
            this.OBD_P0105.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0105.Name = "OBD_P0105";
            this.OBD_P0105.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0105.TabIndex = 3;
            this.OBD_P0105.Text = "P0105";
            this.OBD_P0105.UseVisualStyleBackColor = true;
            // 
            // OBD_C0085
            // 
            this.OBD_C0085.AutoSize = true;
            this.OBD_C0085.Location = new System.Drawing.Point(10, 60);
            this.OBD_C0085.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_C0085.Name = "OBD_C0085";
            this.OBD_C0085.Size = new System.Drawing.Size(69, 20);
            this.OBD_C0085.TabIndex = 2;
            this.OBD_C0085.Text = "C0085";
            this.OBD_C0085.UseVisualStyleBackColor = true;
            // 
            // OBD_C0083
            // 
            this.OBD_C0083.AutoSize = true;
            this.OBD_C0083.Location = new System.Drawing.Point(10, 39);
            this.OBD_C0083.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_C0083.Name = "OBD_C0083";
            this.OBD_C0083.Size = new System.Drawing.Size(69, 20);
            this.OBD_C0083.TabIndex = 1;
            this.OBD_C0083.Text = "C0083";
            this.OBD_C0083.UseVisualStyleBackColor = true;
            // 
            // OBD_P0503
            // 
            this.OBD_P0503.AutoSize = true;
            this.OBD_P0503.Location = new System.Drawing.Point(10, 19);
            this.OBD_P0503.Margin = new System.Windows.Forms.Padding(2);
            this.OBD_P0503.Name = "OBD_P0503";
            this.OBD_P0503.Size = new System.Drawing.Size(67, 20);
            this.OBD_P0503.TabIndex = 0;
            this.OBD_P0503.Text = "P0503";
            this.OBD_P0503.UseVisualStyleBackColor = true;
            // 
            // tmr_FetchingUARTInput
            // 
            this.tmr_FetchingUARTInput.Interval = 250;
            this.tmr_FetchingUARTInput.Tick += new System.EventHandler(this.Tmr_FetchingUARTInput_Tick);
            // 
            // rtbKLineData
            // 
            this.rtbKLineData.Location = new System.Drawing.Point(367, 8);
            this.rtbKLineData.Name = "rtbKLineData";
            this.rtbKLineData.ReadOnly = true;
            this.rtbKLineData.Size = new System.Drawing.Size(408, 76);
            this.rtbKLineData.TabIndex = 28;
            this.rtbKLineData.Text = "";
            // 
            // Group_DTC_data_option
            // 
            this.Group_DTC_data_option.Controls.Add(this.DTC_option_all_in_turn);
            this.Group_DTC_data_option.Controls.Add(this.DTC_option_first_six);
            this.Group_DTC_data_option.Enabled = false;
            this.Group_DTC_data_option.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Group_DTC_data_option.Location = new System.Drawing.Point(780, 8);
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
            this.label_Kline_status.Location = new System.Drawing.Point(12, 23);
            this.label_Kline_status.Name = "label_Kline_status";
            this.label_Kline_status.Size = new System.Drawing.Size(58, 12);
            this.label_Kline_status.TabIndex = 30;
            this.label_Kline_status.Text = "Kline status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.radioButton13);
            this.groupBox1.Controls.Add(this.radioButton14);
            this.groupBox1.Controls.Add(this.radioButton15);
            this.groupBox1.Controls.Add(this.radioButton16);
            this.groupBox1.Controls.Add(this.radioButton17);
            this.groupBox1.Controls.Add(this.radioButton18);
            this.groupBox1.Controls.Add(this.radioButton19);
            this.groupBox1.Controls.Add(this.radioButton20);
            this.groupBox1.Controls.Add(this.radioButton21);
            this.groupBox1.Controls.Add(this.radioButton22);
            this.groupBox1.Controls.Add(this.radioButton23);
            this.groupBox1.Controls.Add(this.radioButton24);
            this.groupBox1.Controls.Add(this.radioButton25);
            this.groupBox1.Controls.Add(this.radioButton26);
            this.groupBox1.Controls.Add(this.radioButton27);
            this.groupBox1.Controls.Add(this.radioButton28);
            this.groupBox1.Controls.Add(this.radioButton29);
            this.groupBox1.Controls.Add(this.radioButton30);
            this.groupBox1.Controls.Add(this.radioButton31);
            this.groupBox1.Controls.Add(this.radioButton32);
            this.groupBox1.Controls.Add(this.radioButton33);
            this.groupBox1.Controls.Add(this.radioButton34);
            this.groupBox1.Controls.Add(this.radioButton35);
            this.groupBox1.Controls.Add(this.radioButton36);
            this.groupBox1.Controls.Add(this.radioButton37);
            this.groupBox1.Controls.Add(this.radioButton38);
            this.groupBox1.Controls.Add(this.radioButton39);
            this.groupBox1.Controls.Add(this.radioButton40);
            this.groupBox1.Controls.Add(this.radioButton41);
            this.groupBox1.Controls.Add(this.radioButton42);
            this.groupBox1.Controls.Add(this.radioButton43);
            this.groupBox1.Controls.Add(this.radioButton44);
            this.groupBox1.Controls.Add(this.radioButton45);
            this.groupBox1.Controls.Add(this.radioButton46);
            this.groupBox1.Controls.Add(this.radioButton47);
            this.groupBox1.Controls.Add(this.radioButton48);
            this.groupBox1.Controls.Add(this.radioButton49);
            this.groupBox1.Controls.Add(this.radioButton50);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(1020, 367);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 548);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OBD Status";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(165, 39);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "U0486";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoCheck = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 20);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "U0426";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoCheck = false;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(85, 441);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 20);
            this.radioButton3.TabIndex = 48;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "U0122";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoCheck = false;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(85, 421);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 20);
            this.radioButton4.TabIndex = 47;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "U0121";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoCheck = false;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(85, 401);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 20);
            this.radioButton5.TabIndex = 46;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "U0002";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoCheck = false;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(85, 481);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(69, 20);
            this.radioButton6.TabIndex = 50;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "U0140";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoCheck = false;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(85, 381);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(69, 20);
            this.radioButton7.TabIndex = 45;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "U0001";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoCheck = false;
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(85, 461);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(69, 20);
            this.radioButton8.TabIndex = 49;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "U0128";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoCheck = false;
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(85, 361);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(66, 20);
            this.radioButton9.TabIndex = 44;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "P2600";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoCheck = false;
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(85, 341);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(66, 20);
            this.radioButton10.TabIndex = 43;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "P2158";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoCheck = false;
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(85, 320);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(66, 20);
            this.radioButton11.TabIndex = 42;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "P1800";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoCheck = false;
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(85, 300);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(66, 20);
            this.radioButton12.TabIndex = 41;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "P1607";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoCheck = false;
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(85, 280);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(66, 20);
            this.radioButton13.TabIndex = 40;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "P1536";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoCheck = false;
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(85, 260);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(66, 20);
            this.radioButton14.TabIndex = 39;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "P1310";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoCheck = false;
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(85, 160);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(114, 20);
            this.radioButton15.TabIndex = 34;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "P0620_PIN31";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoCheck = false;
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(85, 240);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(66, 20);
            this.radioButton16.TabIndex = 38;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "P1300";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoCheck = false;
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(85, 140);
            this.radioButton17.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(106, 20);
            this.radioButton17.TabIndex = 33;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "P0620_PIN2";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoCheck = false;
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(85, 220);
            this.radioButton18.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(69, 20);
            this.radioButton18.TabIndex = 37;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "P0A0F";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoCheck = false;
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(85, 120);
            this.radioButton19.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(66, 20);
            this.radioButton19.TabIndex = 32;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "P0606";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoCheck = false;
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(85, 200);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(66, 20);
            this.radioButton20.TabIndex = 36;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "P0655";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoCheck = false;
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(85, 100);
            this.radioButton21.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(66, 20);
            this.radioButton21.TabIndex = 31;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "P0605";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoCheck = false;
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(85, 180);
            this.radioButton22.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(66, 20);
            this.radioButton22.TabIndex = 35;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "P0650";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoCheck = false;
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(85, 80);
            this.radioButton23.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(66, 20);
            this.radioButton23.TabIndex = 30;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "P0604";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoCheck = false;
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(85, 60);
            this.radioButton24.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(66, 20);
            this.radioButton24.TabIndex = 29;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "P0601";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoCheck = false;
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(85, 39);
            this.radioButton25.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(66, 20);
            this.radioButton25.TabIndex = 28;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "P0560";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoCheck = false;
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(85, 19);
            this.radioButton26.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(66, 20);
            this.radioButton26.TabIndex = 27;
            this.radioButton26.TabStop = true;
            this.radioButton26.Text = "P0512";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoCheck = false;
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(10, 441);
            this.radioButton27.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(66, 20);
            this.radioButton27.TabIndex = 24;
            this.radioButton27.TabStop = true;
            this.radioButton27.Text = "P0500";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoCheck = false;
            this.radioButton28.AutoSize = true;
            this.radioButton28.Location = new System.Drawing.Point(10, 421);
            this.radioButton28.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(66, 20);
            this.radioButton28.TabIndex = 23;
            this.radioButton28.TabStop = true;
            this.radioButton28.Text = "P0480";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoCheck = false;
            this.radioButton29.AutoSize = true;
            this.radioButton29.Location = new System.Drawing.Point(10, 401);
            this.radioButton29.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(66, 20);
            this.radioButton29.TabIndex = 22;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "P0410";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoCheck = false;
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(10, 481);
            this.radioButton30.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(66, 20);
            this.radioButton30.TabIndex = 26;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "P0505";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoCheck = false;
            this.radioButton31.AutoSize = true;
            this.radioButton31.Location = new System.Drawing.Point(10, 381);
            this.radioButton31.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(66, 20);
            this.radioButton31.TabIndex = 21;
            this.radioButton31.TabStop = true;
            this.radioButton31.Text = "P0352";
            this.radioButton31.UseVisualStyleBackColor = true;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoCheck = false;
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(10, 461);
            this.radioButton32.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(66, 20);
            this.radioButton32.TabIndex = 25;
            this.radioButton32.TabStop = true;
            this.radioButton32.Text = "P0501";
            this.radioButton32.UseVisualStyleBackColor = true;
            // 
            // radioButton33
            // 
            this.radioButton33.AutoCheck = false;
            this.radioButton33.AutoSize = true;
            this.radioButton33.Location = new System.Drawing.Point(10, 361);
            this.radioButton33.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(66, 20);
            this.radioButton33.TabIndex = 20;
            this.radioButton33.TabStop = true;
            this.radioButton33.Text = "P0351";
            this.radioButton33.UseVisualStyleBackColor = true;
            // 
            // radioButton34
            // 
            this.radioButton34.AutoCheck = false;
            this.radioButton34.AutoSize = true;
            this.radioButton34.Location = new System.Drawing.Point(10, 341);
            this.radioButton34.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(66, 20);
            this.radioButton34.TabIndex = 19;
            this.radioButton34.TabStop = true;
            this.radioButton34.Text = "P0336";
            this.radioButton34.UseVisualStyleBackColor = true;
            // 
            // radioButton35
            // 
            this.radioButton35.AutoCheck = false;
            this.radioButton35.AutoSize = true;
            this.radioButton35.Location = new System.Drawing.Point(10, 320);
            this.radioButton35.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(66, 20);
            this.radioButton35.TabIndex = 18;
            this.radioButton35.TabStop = true;
            this.radioButton35.Text = "P0335";
            this.radioButton35.UseVisualStyleBackColor = true;
            // 
            // radioButton36
            // 
            this.radioButton36.AutoCheck = false;
            this.radioButton36.AutoSize = true;
            this.radioButton36.Location = new System.Drawing.Point(10, 300);
            this.radioButton36.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.Size = new System.Drawing.Size(66, 20);
            this.radioButton36.TabIndex = 17;
            this.radioButton36.TabStop = true;
            this.radioButton36.Text = "P0230";
            this.radioButton36.UseVisualStyleBackColor = true;
            // 
            // radioButton37
            // 
            this.radioButton37.AutoCheck = false;
            this.radioButton37.AutoSize = true;
            this.radioButton37.Location = new System.Drawing.Point(10, 280);
            this.radioButton37.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(66, 20);
            this.radioButton37.TabIndex = 16;
            this.radioButton37.TabStop = true;
            this.radioButton37.Text = "P0217";
            this.radioButton37.UseVisualStyleBackColor = true;
            // 
            // radioButton38
            // 
            this.radioButton38.AutoCheck = false;
            this.radioButton38.AutoSize = true;
            this.radioButton38.Location = new System.Drawing.Point(10, 260);
            this.radioButton38.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton38.Name = "radioButton38";
            this.radioButton38.Size = new System.Drawing.Size(66, 20);
            this.radioButton38.TabIndex = 15;
            this.radioButton38.TabStop = true;
            this.radioButton38.Text = "P0202";
            this.radioButton38.UseVisualStyleBackColor = true;
            // 
            // radioButton39
            // 
            this.radioButton39.AutoCheck = false;
            this.radioButton39.AutoSize = true;
            this.radioButton39.Location = new System.Drawing.Point(10, 160);
            this.radioButton39.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton39.Name = "radioButton39";
            this.radioButton39.Size = new System.Drawing.Size(66, 20);
            this.radioButton39.TabIndex = 7;
            this.radioButton39.TabStop = true;
            this.radioButton39.Text = "P0130";
            this.radioButton39.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            this.radioButton40.AutoCheck = false;
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(10, 240);
            this.radioButton40.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(66, 20);
            this.radioButton40.TabIndex = 14;
            this.radioButton40.TabStop = true;
            this.radioButton40.Text = "P0201";
            this.radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton41
            // 
            this.radioButton41.AutoCheck = false;
            this.radioButton41.AutoSize = true;
            this.radioButton41.Location = new System.Drawing.Point(10, 140);
            this.radioButton41.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton41.Name = "radioButton41";
            this.radioButton41.Size = new System.Drawing.Size(66, 20);
            this.radioButton41.TabIndex = 6;
            this.radioButton41.TabStop = true;
            this.radioButton41.Text = "P0120";
            this.radioButton41.UseVisualStyleBackColor = true;
            // 
            // radioButton42
            // 
            this.radioButton42.AutoCheck = false;
            this.radioButton42.AutoSize = true;
            this.radioButton42.Location = new System.Drawing.Point(10, 220);
            this.radioButton42.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.Size = new System.Drawing.Size(66, 20);
            this.radioButton42.TabIndex = 13;
            this.radioButton42.TabStop = true;
            this.radioButton42.Text = "P0155";
            this.radioButton42.UseVisualStyleBackColor = true;
            // 
            // radioButton43
            // 
            this.radioButton43.AutoCheck = false;
            this.radioButton43.AutoSize = true;
            this.radioButton43.Location = new System.Drawing.Point(10, 120);
            this.radioButton43.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.Size = new System.Drawing.Size(66, 20);
            this.radioButton43.TabIndex = 5;
            this.radioButton43.TabStop = true;
            this.radioButton43.Text = "P0115";
            this.radioButton43.UseVisualStyleBackColor = true;
            // 
            // radioButton44
            // 
            this.radioButton44.AutoCheck = false;
            this.radioButton44.AutoSize = true;
            this.radioButton44.Location = new System.Drawing.Point(10, 200);
            this.radioButton44.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton44.Name = "radioButton44";
            this.radioButton44.Size = new System.Drawing.Size(66, 20);
            this.radioButton44.TabIndex = 12;
            this.radioButton44.TabStop = true;
            this.radioButton44.Text = "P0150";
            this.radioButton44.UseVisualStyleBackColor = true;
            // 
            // radioButton45
            // 
            this.radioButton45.AutoCheck = false;
            this.radioButton45.AutoSize = true;
            this.radioButton45.Location = new System.Drawing.Point(10, 100);
            this.radioButton45.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton45.Name = "radioButton45";
            this.radioButton45.Size = new System.Drawing.Size(66, 20);
            this.radioButton45.TabIndex = 4;
            this.radioButton45.TabStop = true;
            this.radioButton45.Text = "P0110";
            this.radioButton45.UseVisualStyleBackColor = true;
            // 
            // radioButton46
            // 
            this.radioButton46.AutoCheck = false;
            this.radioButton46.AutoSize = true;
            this.radioButton46.Location = new System.Drawing.Point(10, 180);
            this.radioButton46.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton46.Name = "radioButton46";
            this.radioButton46.Size = new System.Drawing.Size(66, 20);
            this.radioButton46.TabIndex = 11;
            this.radioButton46.TabStop = true;
            this.radioButton46.Text = "P0135";
            this.radioButton46.UseVisualStyleBackColor = true;
            // 
            // radioButton47
            // 
            this.radioButton47.AutoCheck = false;
            this.radioButton47.AutoSize = true;
            this.radioButton47.Location = new System.Drawing.Point(10, 80);
            this.radioButton47.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton47.Name = "radioButton47";
            this.radioButton47.Size = new System.Drawing.Size(66, 20);
            this.radioButton47.TabIndex = 3;
            this.radioButton47.TabStop = true;
            this.radioButton47.Text = "P0105";
            this.radioButton47.UseVisualStyleBackColor = true;
            // 
            // radioButton48
            // 
            this.radioButton48.AutoCheck = false;
            this.radioButton48.AutoSize = true;
            this.radioButton48.Location = new System.Drawing.Point(10, 60);
            this.radioButton48.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton48.Name = "radioButton48";
            this.radioButton48.Size = new System.Drawing.Size(68, 20);
            this.radioButton48.TabIndex = 2;
            this.radioButton48.TabStop = true;
            this.radioButton48.Text = "C0085";
            this.radioButton48.UseVisualStyleBackColor = true;
            // 
            // radioButton49
            // 
            this.radioButton49.AutoCheck = false;
            this.radioButton49.AutoSize = true;
            this.radioButton49.Location = new System.Drawing.Point(10, 39);
            this.radioButton49.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton49.Name = "radioButton49";
            this.radioButton49.Size = new System.Drawing.Size(68, 20);
            this.radioButton49.TabIndex = 1;
            this.radioButton49.TabStop = true;
            this.radioButton49.Text = "C0083";
            this.radioButton49.UseVisualStyleBackColor = true;
            // 
            // radioButton50
            // 
            this.radioButton50.AutoCheck = false;
            this.radioButton50.AutoSize = true;
            this.radioButton50.Location = new System.Drawing.Point(10, 19);
            this.radioButton50.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(66, 20);
            this.radioButton50.TabIndex = 0;
            this.radioButton50.TabStop = true;
            this.radioButton50.Text = "P0503";
            this.radioButton50.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton51);
            this.groupBox2.Controls.Add(this.radioButton52);
            this.groupBox2.Controls.Add(this.radioButton53);
            this.groupBox2.Controls.Add(this.radioButton54);
            this.groupBox2.Controls.Add(this.radioButton55);
            this.groupBox2.Controls.Add(this.radioButton56);
            this.groupBox2.Controls.Add(this.radioButton57);
            this.groupBox2.Controls.Add(this.radioButton58);
            this.groupBox2.Controls.Add(this.radioButton59);
            this.groupBox2.Controls.Add(this.radioButton60);
            this.groupBox2.Controls.Add(this.radioButton61);
            this.groupBox2.Controls.Add(this.radioButton62);
            this.groupBox2.Controls.Add(this.radioButton63);
            this.groupBox2.Controls.Add(this.radioButton64);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(922, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(94, 302);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABS Status";
            // 
            // radioButton51
            // 
            this.radioButton51.AutoCheck = false;
            this.radioButton51.AutoSize = true;
            this.radioButton51.Location = new System.Drawing.Point(10, 280);
            this.radioButton51.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton51.Name = "radioButton51";
            this.radioButton51.Size = new System.Drawing.Size(74, 20);
            this.radioButton51.TabIndex = 16;
            this.radioButton51.TabStop = true;
            this.radioButton51.Text = "0x5025";
            this.radioButton51.UseVisualStyleBackColor = true;
            // 
            // radioButton52
            // 
            this.radioButton52.AutoCheck = false;
            this.radioButton52.AutoSize = true;
            this.radioButton52.Location = new System.Drawing.Point(10, 260);
            this.radioButton52.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton52.Name = "radioButton52";
            this.radioButton52.Size = new System.Drawing.Size(74, 20);
            this.radioButton52.TabIndex = 15;
            this.radioButton52.TabStop = true;
            this.radioButton52.Text = "0x5044";
            this.radioButton52.UseVisualStyleBackColor = true;
            // 
            // radioButton53
            // 
            this.radioButton53.AutoCheck = false;
            this.radioButton53.AutoSize = true;
            this.radioButton53.Location = new System.Drawing.Point(10, 160);
            this.radioButton53.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton53.Name = "radioButton53";
            this.radioButton53.Size = new System.Drawing.Size(74, 20);
            this.radioButton53.TabIndex = 7;
            this.radioButton53.TabStop = true;
            this.radioButton53.Text = "0x5052";
            this.radioButton53.UseVisualStyleBackColor = true;
            // 
            // radioButton54
            // 
            this.radioButton54.AutoCheck = false;
            this.radioButton54.AutoSize = true;
            this.radioButton54.Location = new System.Drawing.Point(10, 240);
            this.radioButton54.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton54.Name = "radioButton54";
            this.radioButton54.Size = new System.Drawing.Size(74, 20);
            this.radioButton54.TabIndex = 14;
            this.radioButton54.TabStop = true;
            this.radioButton54.Text = "0x5042";
            this.radioButton54.UseVisualStyleBackColor = true;
            // 
            // radioButton55
            // 
            this.radioButton55.AutoCheck = false;
            this.radioButton55.AutoSize = true;
            this.radioButton55.Location = new System.Drawing.Point(10, 140);
            this.radioButton55.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton55.Name = "radioButton55";
            this.radioButton55.Size = new System.Drawing.Size(74, 20);
            this.radioButton55.TabIndex = 6;
            this.radioButton55.TabStop = true;
            this.radioButton55.Text = "0x5053";
            this.radioButton55.UseVisualStyleBackColor = true;
            // 
            // radioButton56
            // 
            this.radioButton56.AutoCheck = false;
            this.radioButton56.AutoSize = true;
            this.radioButton56.Location = new System.Drawing.Point(10, 220);
            this.radioButton56.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton56.Name = "radioButton56";
            this.radioButton56.Size = new System.Drawing.Size(74, 20);
            this.radioButton56.TabIndex = 13;
            this.radioButton56.TabStop = true;
            this.radioButton56.Text = "0x5045";
            this.radioButton56.UseVisualStyleBackColor = true;
            // 
            // radioButton57
            // 
            this.radioButton57.AutoCheck = false;
            this.radioButton57.AutoSize = true;
            this.radioButton57.Location = new System.Drawing.Point(10, 120);
            this.radioButton57.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton57.Name = "radioButton57";
            this.radioButton57.Size = new System.Drawing.Size(74, 20);
            this.radioButton57.TabIndex = 5;
            this.radioButton57.TabStop = true;
            this.radioButton57.Text = "0x5014";
            this.radioButton57.UseVisualStyleBackColor = true;
            // 
            // radioButton58
            // 
            this.radioButton58.AutoCheck = false;
            this.radioButton58.AutoSize = true;
            this.radioButton58.Location = new System.Drawing.Point(10, 200);
            this.radioButton58.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton58.Name = "radioButton58";
            this.radioButton58.Size = new System.Drawing.Size(74, 20);
            this.radioButton58.TabIndex = 12;
            this.radioButton58.TabStop = true;
            this.radioButton58.Text = "0x5043";
            this.radioButton58.UseVisualStyleBackColor = true;
            // 
            // radioButton59
            // 
            this.radioButton59.AutoCheck = false;
            this.radioButton59.AutoSize = true;
            this.radioButton59.Location = new System.Drawing.Point(10, 100);
            this.radioButton59.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton59.Name = "radioButton59";
            this.radioButton59.Size = new System.Drawing.Size(74, 20);
            this.radioButton59.TabIndex = 4;
            this.radioButton59.TabStop = true;
            this.radioButton59.Text = "0x5018";
            this.radioButton59.UseVisualStyleBackColor = true;
            // 
            // radioButton60
            // 
            this.radioButton60.AutoCheck = false;
            this.radioButton60.AutoSize = true;
            this.radioButton60.Location = new System.Drawing.Point(10, 180);
            this.radioButton60.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.Size = new System.Drawing.Size(74, 20);
            this.radioButton60.TabIndex = 11;
            this.radioButton60.TabStop = true;
            this.radioButton60.Text = "0x5035";
            this.radioButton60.UseVisualStyleBackColor = true;
            // 
            // radioButton61
            // 
            this.radioButton61.AutoCheck = false;
            this.radioButton61.AutoSize = true;
            this.radioButton61.Location = new System.Drawing.Point(10, 80);
            this.radioButton61.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton61.Name = "radioButton61";
            this.radioButton61.Size = new System.Drawing.Size(74, 20);
            this.radioButton61.TabIndex = 3;
            this.radioButton61.TabStop = true;
            this.radioButton61.Text = "0x5013";
            this.radioButton61.UseVisualStyleBackColor = true;
            // 
            // radioButton62
            // 
            this.radioButton62.AutoCheck = false;
            this.radioButton62.AutoSize = true;
            this.radioButton62.Location = new System.Drawing.Point(10, 60);
            this.radioButton62.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton62.Name = "radioButton62";
            this.radioButton62.Size = new System.Drawing.Size(74, 20);
            this.radioButton62.TabIndex = 2;
            this.radioButton62.TabStop = true;
            this.radioButton62.Text = "0x5017";
            this.radioButton62.UseVisualStyleBackColor = true;
            // 
            // radioButton63
            // 
            this.radioButton63.AutoCheck = false;
            this.radioButton63.AutoSize = true;
            this.radioButton63.Location = new System.Drawing.Point(10, 39);
            this.radioButton63.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton63.Name = "radioButton63";
            this.radioButton63.Size = new System.Drawing.Size(74, 20);
            this.radioButton63.TabIndex = 1;
            this.radioButton63.TabStop = true;
            this.radioButton63.Text = "0x5019";
            this.radioButton63.UseVisualStyleBackColor = true;
            // 
            // radioButton64
            // 
            this.radioButton64.AutoCheck = false;
            this.radioButton64.AutoSize = true;
            this.radioButton64.Location = new System.Drawing.Point(10, 19);
            this.radioButton64.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.Size = new System.Drawing.Size(74, 20);
            this.radioButton64.TabIndex = 0;
            this.radioButton64.TabStop = true;
            this.radioButton64.Text = "0x5055";
            this.radioButton64.UseVisualStyleBackColor = true;
            // 
            // DDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1460, 735);
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
            this.Name = "DDS";
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
        private System.Windows.Forms.CheckBox ABS_0x5025;
        private System.Windows.Forms.CheckBox ABS_0x5044;
        private System.Windows.Forms.CheckBox ABS_0x5052;
        private System.Windows.Forms.CheckBox ABS_0x5042;
        private System.Windows.Forms.CheckBox ABS_0x5053;
        private System.Windows.Forms.CheckBox ABS_0x5045;
        private System.Windows.Forms.CheckBox ABS_0x5014;
        private System.Windows.Forms.CheckBox ABS_0x5043;
        private System.Windows.Forms.CheckBox ABS_0x5018;
        private System.Windows.Forms.CheckBox ABS_0x5035;
        private System.Windows.Forms.CheckBox ABS_0x5013;
        private System.Windows.Forms.CheckBox ABS_0x5017;
        private System.Windows.Forms.CheckBox ABS_0x5019;
        private System.Windows.Forms.CheckBox ABS_0x5055;
        private System.Windows.Forms.GroupBox Group_OBD_Error_Code;
        private System.Windows.Forms.CheckBox OBD_U0486;
        private System.Windows.Forms.CheckBox OBD_U0426;
        private System.Windows.Forms.CheckBox OBD_U0122;
        private System.Windows.Forms.CheckBox OBD_U0121;
        private System.Windows.Forms.CheckBox OBD_U0002;
        private System.Windows.Forms.CheckBox OBD_U0140;
        private System.Windows.Forms.CheckBox OBD_U0001;
        private System.Windows.Forms.CheckBox OBD_U0128;
        private System.Windows.Forms.CheckBox OBD_P2600;
        private System.Windows.Forms.CheckBox OBD_P2158;
        private System.Windows.Forms.CheckBox OBD_P1800;
        private System.Windows.Forms.CheckBox OBD_P1607;
        private System.Windows.Forms.CheckBox OBD_P1536;
        private System.Windows.Forms.CheckBox OBD_P1310;
        private System.Windows.Forms.CheckBox OBD_P0620_PIN31;
        private System.Windows.Forms.CheckBox OBD_P1300;
        private System.Windows.Forms.CheckBox OBD_P0620_PIN2;
        private System.Windows.Forms.CheckBox OBD_P0A0F;
        private System.Windows.Forms.CheckBox OBD_P0606;
        private System.Windows.Forms.CheckBox OBD_P0655;
        private System.Windows.Forms.CheckBox OBD_P0605;
        private System.Windows.Forms.CheckBox OBD_P0650;
        private System.Windows.Forms.CheckBox OBD_P0604;
        private System.Windows.Forms.CheckBox OBD_P0601;
        private System.Windows.Forms.CheckBox OBD_P0560;
        private System.Windows.Forms.CheckBox OBD_P0512;
        private System.Windows.Forms.CheckBox OBD_P0500;
        private System.Windows.Forms.CheckBox OBD_P0480;
        private System.Windows.Forms.CheckBox OBD_P0410;
        private System.Windows.Forms.CheckBox OBD_P0505;
        private System.Windows.Forms.CheckBox OBD_P0352;
        private System.Windows.Forms.CheckBox OBD_P0501;
        private System.Windows.Forms.CheckBox OBD_P0351;
        private System.Windows.Forms.CheckBox OBD_P0336;
        private System.Windows.Forms.CheckBox OBD_P0335;
        private System.Windows.Forms.CheckBox OBD_P0230;
        private System.Windows.Forms.CheckBox OBD_P0217;
        private System.Windows.Forms.CheckBox OBD_P0202;
        private System.Windows.Forms.CheckBox OBD_P0130;
        private System.Windows.Forms.CheckBox OBD_P0201;
        private System.Windows.Forms.CheckBox OBD_P0120;
        private System.Windows.Forms.CheckBox OBD_P0155;
        private System.Windows.Forms.CheckBox OBD_P0115;
        private System.Windows.Forms.CheckBox OBD_P0150;
        private System.Windows.Forms.CheckBox OBD_P0110;
        private System.Windows.Forms.CheckBox OBD_P0135;
        private System.Windows.Forms.CheckBox OBD_P0105;
        private System.Windows.Forms.CheckBox OBD_C0085;
        private System.Windows.Forms.CheckBox OBD_C0083;
        private System.Windows.Forms.CheckBox OBD_P0503;
        private System.Windows.Forms.Timer tmr_FetchingUARTInput;
        private System.Windows.Forms.RichTextBox rtbKLineData;
        private System.Windows.Forms.GroupBox Group_DTC_data_option;
        private System.Windows.Forms.RadioButton DTC_option_all_in_turn;
        private System.Windows.Forms.RadioButton DTC_option_first_six;
        private System.Windows.Forms.Label label_Kline_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton28;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton31;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.RadioButton radioButton33;
        private System.Windows.Forms.RadioButton radioButton34;
        private System.Windows.Forms.RadioButton radioButton35;
        private System.Windows.Forms.RadioButton radioButton36;
        private System.Windows.Forms.RadioButton radioButton37;
        private System.Windows.Forms.RadioButton radioButton38;
        private System.Windows.Forms.RadioButton radioButton39;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.RadioButton radioButton41;
        private System.Windows.Forms.RadioButton radioButton42;
        private System.Windows.Forms.RadioButton radioButton43;
        private System.Windows.Forms.RadioButton radioButton44;
        private System.Windows.Forms.RadioButton radioButton45;
        private System.Windows.Forms.RadioButton radioButton46;
        private System.Windows.Forms.RadioButton radioButton47;
        private System.Windows.Forms.RadioButton radioButton48;
        private System.Windows.Forms.RadioButton radioButton49;
        private System.Windows.Forms.RadioButton radioButton50;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton51;
        private System.Windows.Forms.RadioButton radioButton52;
        private System.Windows.Forms.RadioButton radioButton53;
        private System.Windows.Forms.RadioButton radioButton54;
        private System.Windows.Forms.RadioButton radioButton55;
        private System.Windows.Forms.RadioButton radioButton56;
        private System.Windows.Forms.RadioButton radioButton57;
        private System.Windows.Forms.RadioButton radioButton58;
        private System.Windows.Forms.RadioButton radioButton59;
        private System.Windows.Forms.RadioButton radioButton60;
        private System.Windows.Forms.RadioButton radioButton61;
        private System.Windows.Forms.RadioButton radioButton62;
        private System.Windows.Forms.RadioButton radioButton63;
        private System.Windows.Forms.RadioButton radioButton64;
    }
}

