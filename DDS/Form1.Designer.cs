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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Group_CAN_Reader.SuspendLayout();
            this.Group_Driving_Status.SuspendLayout();
            this.Group_Car_Status_Indicator.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(540, 9);
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
            this.label_autokit_status.Location = new System.Drawing.Point(12, 9);
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
            this.Group_CAN_Reader.Location = new System.Drawing.Point(675, 10);
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
            this.label_canbus_status.Location = new System.Drawing.Point(12, 29);
            this.label_canbus_status.Name = "label_canbus_status";
            this.label_canbus_status.Size = new System.Drawing.Size(68, 12);
            this.label_canbus_status.TabIndex = 23;
            this.label_canbus_status.Text = "Canbus status";
            // 
            // DDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1443, 735);
            this.Controls.Add(this.label_canbus_status);
            this.Controls.Add(this.Group_CAN_Reader);
            this.Controls.Add(this.label_autokit_status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.setting_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DDS";
            this.Text = "Digital Dashboard Simulation";
            this.Load += new System.EventHandler(this.Venus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Group_CAN_Reader.ResumeLayout(false);
            this.Group_Driving_Status.ResumeLayout(false);
            this.Group_Driving_Status.PerformLayout();
            this.Group_Car_Status_Indicator.ResumeLayout(false);
            this.Group_Car_Status_Indicator.PerformLayout();
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
    }
}

