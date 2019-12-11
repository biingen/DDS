using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using jini;
using System.IO.Ports;
using System.IO;
using System.Windows;
using BlueRatLibrary;
using System.Management;
using Microsoft.Win32.SafeHandles;
using System.Threading;
using System.Runtime.InteropServices;
using CRC;

namespace PSC
{
    public partial class Main : Form
    {
        private string Script_Path = Application.StartupPath + "\\Script.ini";
        private string Config_Path = Application.StartupPath + "\\Config.ini";
        

        private int Location_X = 30, Location_Y = 15;
        String output_schedule = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;
        String output_log = "";

        System.Windows.Forms.Button[] AutoKit_GPIO_icon_on_button;
        System.Windows.Forms.Button[] AutoKit_GPIO_icon_off_button;
        System.Windows.Forms.Label[] AutoKit_GPIO_icon_remark;

        System.Windows.Forms.HScrollBar[] AutoKit_RS232_one_Bar_hscorllbar;
        System.Windows.Forms.TextBox[] AutoKit_RS232_one_Bar_textbox;
        System.Windows.Forms.TextBox[] AutoKit_RS232_one_Bar_High_textbox;
        System.Windows.Forms.Button[] AutoKit_RS232_one_Bar_button;

        public Main()
        {
            InitializeComponent();
            this.textBox1.Text = "Ver:001";
        }

        private void DDS_Load(object sender, EventArgs e)
        {
            CSVtoINIfile();
            Extend_Initial_port();
            Default_Env();
        }

        private void Extend_Initial_port()
        {
            string SerialPort1_Exist = ini12.INIRead(Config_Path, "serialPort1", "Exist", "");

            if (SerialPort1_Exist == "1")
            {
                Open_serialPort1();
            }
        }

        //  開啟SerialPort
        protected void Open_serialPort1()
        {
            try
            {
                if (SerialPort1.IsOpen == false)
                {
                    SerialPort1.StopBits = StopBits.One;
                    SerialPort1.PortName = ini12.INIRead(Config_Path, "serialPort1", "PortName", "");
                    SerialPort1.BaudRate = int.Parse((ini12.INIRead(Config_Path, "serialPort1", "BaudRate", "")));
                    SerialPort1.DataBits = 8;
                    SerialPort1.Parity = (Parity)0;
                    SerialPort1.ReceivedBytesThreshold = 1;
                    // V3_serialPort.Encoding = System.Text.Encoding.GetEncoding(1252);
                    // V3_serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);       // DataReceived呼叫函式
                    SerialPort1.Open();
                }
            }
            catch (Exception Ex)
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Exist", "0");
                MessageBox.Show(Ex.Message.ToString(), "SerialPort1 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  關閉SerialPort
        protected void Close_serialPort1()
        {
            SerialPort1.Dispose();
            SerialPort1.Close();
        }

        private void CSVtoINIfile()
        {
            // CSV 轉 ini File
            int AutoKit_GPIO_icon_10 = 0, AutoKit_RS232_one_Bar = 0;
            string TextLine = "";
            string[] SplitLine;
            int j = 0;
            string SchedulePath = ini12.INIRead(Config_Path, "Config", "scriptFile", "");

            // 開檔案讀取csv.
            if ((File.Exists(SchedulePath) == true) && IsFileLocked(SchedulePath) == false)
            {
                dataGridView1.Rows.Clear();
                StreamReader objReader = new StreamReader(SchedulePath);
                while ((objReader.Peek() != -1))
                {
                    TextLine = objReader.ReadLine();
                    if (j != 0)
                    {
                        SplitLine = TextLine.Split(',');
                        dataGridView1.Rows.Add(SplitLine);
                    }
                    j++;
                }
                objReader.Close();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)  // 產生 Script.ini
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "AutoKit_GPIO")  // 分類Autokit_GPIO
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Icon10")  // button 0 or 1
                        {
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Status_On", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Remark_On", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Status_Off", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Remark_Off", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            AutoKit_GPIO_icon_10++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "AutoKit_RS232") // 分類Autokit_RS232
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "oneBar")  // one bar
                        {
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Duty_Min", dataGridView1.Rows[i].Cells[10].Value.ToString()); //
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Duty_Step", dataGridView1.Rows[i].Cells[11].Value.ToString()); //
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Remark", dataGridView1.Rows[i].Cells[13].Value.ToString());
                            AutoKit_RS232_one_Bar++;
                        }
                    }
                }
                AutoKit_GPIO_icon_10_Create(AutoKit_GPIO_icon_10);   // 產生Button
                AutoKit_RS232_one_Bar_Create(AutoKit_RS232_one_Bar); // 產生Bar
            }
            else
            {
                MessageBox.Show("You can write a new script.", "New Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Default_Env()
        {
            comboBox_Serialport.Text = "A"; // 預設 A
            textBox_MonitorID.Text = "01"; // 預設 MonitorID
            comboBox_function.Text = "W"; // 預設 function
            textBox_times.Text = "1000"; // 預設 delay
        }

        private void AutoKit_GPIO_icon_10_Create(int count)   // button產生數量
        {
            System.Windows.Forms.Label[] AutoKit_GPIO_icon_label;

            AutoKit_GPIO_icon_label = new Label[count];
            AutoKit_GPIO_icon_on_button = new Button[count];
            AutoKit_GPIO_icon_off_button = new Button[count];
            AutoKit_GPIO_icon_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                AutoKit_GPIO_icon_label[index] = new Label();
                AutoKit_GPIO_icon_label[index].Name = "AutoKit_GPIO_icon_label_" + index;
                AutoKit_GPIO_icon_label[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Control Name", "");
                AutoKit_GPIO_icon_label[index].Size = new System.Drawing.Size(150, 30);
                AutoKit_GPIO_icon_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                AutoKit_GPIO_icon_on_button[index] = new Button();
                AutoKit_GPIO_icon_on_button[index].Name = "AutoKit_GPIO_icon_on_button_" + index;
                AutoKit_GPIO_icon_on_button[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "");
                AutoKit_GPIO_icon_on_button[index].Size = new System.Drawing.Size(60, 30);
                AutoKit_GPIO_icon_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                AutoKit_GPIO_icon_on_button[index].Click += new EventHandler(this.AutoKit_GPIO_icon_on_button_Click);
                AutoKit_GPIO_icon_off_button[index] = new Button();
                AutoKit_GPIO_icon_off_button[index].Name = "AutoKit_GPIO_icon_off_button_" + index;
                AutoKit_GPIO_icon_off_button[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_Off", "");
                AutoKit_GPIO_icon_off_button[index].Size = new System.Drawing.Size(60, 30);
                AutoKit_GPIO_icon_off_button[index].Click += new EventHandler(this.AutoKit_GPIO_icon_off_button_Click);
                AutoKit_GPIO_icon_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                AutoKit_GPIO_icon_remark[index] = new Label();
                AutoKit_GPIO_icon_remark[index].Name = "AutoKit_GPIO_icon_remark_" + index;
                AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark", "");
                AutoKit_GPIO_icon_remark[index].Size = new System.Drawing.Size(250, 30);
                AutoKit_GPIO_icon_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                this.panel2.Controls.AddRange(AutoKit_GPIO_icon_off_button);
                this.panel2.Controls.AddRange(AutoKit_GPIO_icon_on_button);
                this.panel2.Controls.AddRange(AutoKit_GPIO_icon_remark);
                this.panel2.Controls.AddRange(AutoKit_GPIO_icon_label);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void AutoKit_RS232_one_Bar_Create(int count)    // bar產生數量
        {
            System.Windows.Forms.Label[] AutoKit_RS232_one_Bar_label;
            System.Windows.Forms.Label[] AutoKit_RS232_one_Bar_remark;
            System.Windows.Forms.Label[] AutoKit_RS232_one_Bar_sign;

            AutoKit_RS232_one_Bar_label = new Label[count];
            AutoKit_RS232_one_Bar_hscorllbar = new HScrollBar[count];
            AutoKit_RS232_one_Bar_textbox = new TextBox[count];
            AutoKit_RS232_one_Bar_High_textbox = new TextBox[count];
            AutoKit_RS232_one_Bar_button = new Button[count];
            AutoKit_RS232_one_Bar_remark = new Label[count];
            AutoKit_RS232_one_Bar_sign = new Label[count];

            for (int index = 0; index < count; index++)
            {
                AutoKit_RS232_one_Bar_label[index] = new Label();
                AutoKit_RS232_one_Bar_label[index].Name = "AutoKit_RS232_one_Bar_label_" + index;
                AutoKit_RS232_one_Bar_label[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "");
                AutoKit_RS232_one_Bar_label[index].Size = new System.Drawing.Size(200, 30);
                AutoKit_RS232_one_Bar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_hscorllbar[index] = new HScrollBar();
                AutoKit_RS232_one_Bar_hscorllbar[index].Name = "AutoKit_RS232_one_Bar_hscorllbar_" + index;
                AutoKit_RS232_one_Bar_hscorllbar[index].Text = "Frequency";
                AutoKit_RS232_one_Bar_hscorllbar[index].Size = new System.Drawing.Size(150, 30);
                AutoKit_RS232_one_Bar_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Min", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Max", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Step", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].ValueChanged += new EventHandler(this.AutoKit_RS232_one_Bar_hscorllbar_ValueChanged);
                AutoKit_RS232_one_Bar_textbox[index] = new TextBox();  //min
                AutoKit_RS232_one_Bar_textbox[index].Name = "AutoKit_RS232_one_Bar_textbox_" + index;
                AutoKit_RS232_one_Bar_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
                AutoKit_RS232_one_Bar_textbox[index].Size = new System.Drawing.Size(60, 30);
                AutoKit_RS232_one_Bar_textbox[index].Location = new System.Drawing.Point(Location_X + 290, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_sign[index] = new Label();  // ~~~~~~~~
                AutoKit_RS232_one_Bar_sign[index].Name = "AutoKit_RS232_one_Bar_sign_" + index;
                AutoKit_RS232_one_Bar_sign[index].Text = " ~~~~~ ";
                AutoKit_RS232_one_Bar_sign[index].Size = new System.Drawing.Size(30, 30);
                AutoKit_RS232_one_Bar_sign[index].Location = new System.Drawing.Point(Location_X + 350, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_High_textbox[index] = new TextBox();  //max
                AutoKit_RS232_one_Bar_High_textbox[index].Name = "AutoKit_RS232_one_Bar_High_textbox" + index;
                AutoKit_RS232_one_Bar_High_textbox[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Max", "");
                AutoKit_RS232_one_Bar_High_textbox[index].Size = new System.Drawing.Size(60, 30);
                AutoKit_RS232_one_Bar_High_textbox[index].Location = new System.Drawing.Point(Location_X + 380, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_button[index] = new Button();
                AutoKit_RS232_one_Bar_button[index].Name = "AutoKit_RS232_one_Bar_button_" + index;
                AutoKit_RS232_one_Bar_button[index].Text = "Enter";
                AutoKit_RS232_one_Bar_button[index].Size = new System.Drawing.Size(60, 30);
                AutoKit_RS232_one_Bar_button[index].Location = new System.Drawing.Point(Location_X + 440, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_button[index].Click += new EventHandler(this.AutoKit_RS232_one_Bar_button_Click);
                AutoKit_RS232_one_Bar_remark[index] = new Label();
                AutoKit_RS232_one_Bar_remark[index].Name = "AutoKit_RS232_one_Bar_remark" + index;
                AutoKit_RS232_one_Bar_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Remark", "");
                AutoKit_RS232_one_Bar_remark[index].Size = new System.Drawing.Size(250, 30);
                AutoKit_RS232_one_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 500, Location_Y + index * 30); 
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_remark);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_button);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_textbox);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_High_textbox);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_hscorllbar);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_label);
                this.panel2.Controls.AddRange(AutoKit_RS232_one_Bar_sign);                
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        void AutoKit_GPIO_icon_on_button_Click(object sender, EventArgs e)      //按下On按鈕的動作
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_GPIO_icon_on_button_", ""));
            AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_On", "");
            AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", ""));
            Thread.Sleep(50);
        }

        void AutoKit_GPIO_icon_off_button_Click(object sender, EventArgs e)     //按下Off按鈕的動作
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_GPIO_icon_off_button_", ""));
            AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_Off", "");
            AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_Off", ""));
            Thread.Sleep(50);
        }

        void AutoKit_RS232_one_Bar_hscorllbar_ValueChanged(object sender, EventArgs e)      //調整bar的動作
        {

            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("AutoKit_RS232_one_Bar_hscorllbar_", ""));
            int min = Convert.ToInt32(AutoKit_RS232_one_Bar_textbox[index].Text);
            int max = Convert.ToInt32(AutoKit_RS232_one_Bar_High_textbox[index].Text);
            if (min <= max )
            {
                AutoKit_RS232_one_Bar_High_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
                AutoKit_RS232_Control("oneBar", index, AutoKit_RS232_one_Bar_High_textbox[index].Text, AutoKit_RS232_one_Bar_High_textbox[index].Text);
                Thread.Sleep(50);

                /*AutoKit_RS232_one_Bar_High_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
                AutoKit_RS232_Control("oneBar", index, AutoKit_RS232_one_Bar_High_textbox[index].Text, AutoKit_RS232_one_Bar_High_textbox[index].Text);
                Thread.Sleep(50);*/
            }
            
            else if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.", "Error");
            }
        }

        void AutoKit_RS232_one_Bar_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_RS232_one_Bar_button_", ""));
            int min = Convert.ToInt32(AutoKit_RS232_one_Bar_textbox[index].Text);
            int max = Convert.ToInt32(AutoKit_RS232_one_Bar_High_textbox[index].Text);
            int value = Convert.ToInt32(AutoKit_RS232_one_Bar_textbox[index].Text);
            if (min < max)
            {
                if (AutoKit_RS232_one_Bar_textbox[index].Text != AutoKit_RS232_one_Bar_High_textbox[index].Text)
                {
                    for (int i = 0; i <= (max - min); i++)
                    {
                        Console.WriteLine("index: " + i);
                        AutoKit_RS232_Control("oneBar", index, Convert.ToString(value + i), Convert.ToString(value + i));
                        Thread.Sleep(50);
                    }

                }
                else if (AutoKit_RS232_one_Bar_textbox[index].Text == AutoKit_RS232_one_Bar_High_textbox[index].Text)
                {
                    AutoKit_RS232_Control("oneBar", index, Convert.ToString(value), Convert.ToString(value));
                    Thread.Sleep(50);
                }
            }
            else if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.", "Error");
            }
        }

        private void AutoKit_GPIO_icon_Control(int index, string status)    //Button 0, 1
        {
            string port = comboBox_Serialport.Text; //Autokit serial port
            string monitor = textBox_MonitorID.Text;  // Monitor ID value
            string function = comboBox_function.Text;  // Function value
            switch (function)
            {
                case "R":
                    function = "03";
                    break;
                case "W":
                    function = "06";
                    break;
                case "Multi":
                    function = "10";
                    break;
            }
            string times = textBox_times.Text;  //Autokit wait value
            int value = Convert.ToInt32(status);
            string hexValue = string.Empty;
            string high_value = "", low_value = "";
            if (value > -1 && value < 65536)
            {
                hexValue = value.ToString("X").PadLeft(4, '0');
                high_value = hexValue.Substring(0, 2);
                low_value = hexValue.Substring(2);
            }
            string CRC_calu = "";

            string OutputString = "";       //Autokit schedule 變數
            OutputString = "_HEX,,,";
            OutputString += port + ",,,";


            CRC_calu = (Convert.ToInt32(monitor)).ToString("X2") + " " + function + " 00 " + ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "").PadLeft(2,'0') + " " + high_value.PadLeft(2, '0') + " " + low_value.PadLeft(2, '0');       //計算CRC原始資料
            string[] hexValuesSplit = CRC_calu.Split(' ');
            byte[] bytes = new byte[hexValuesSplit.Count()];
            int hex_number = 0;
            foreach (string hex in hexValuesSplit)          //改為Byte陣列
            {
                // Convert the number expressed in base-16 to an integer.
                byte number = Convert.ToByte(Convert.ToInt32(hex, 16));
                // Get the character corresponding to the integral value.
                bytes[hex_number++] = number;
            }

            ushort crc = Crc16.ComputeCrc(bytes);       //計算CRC
            string crcHex = ((int)crc).ToString("X2").PadLeft(4, '0');
            string crcLow = crcHex.Substring(0, 2);     //低位數
            string crcHigh = crcHex.Substring(2);       //高位數
            CRC_calu += " " + crcHigh + " " + crcLow;   //原始資料加入CRC

            string[] CRCSplit = CRC_calu.Split(' ');
            byte[] CRCbytes = new byte[CRCSplit.Count()];
            int CRCindex = 0;
            foreach (string hex in CRCSplit)          //改為Byte陣列
            {
                // Convert the number expressed in base-16 to an integer.
                byte number = Convert.ToByte(Convert.ToInt32(hex, 16));
                // Get the character corresponding to the integral value.
                CRCbytes[CRCindex++] = number;
            }

            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1")          //送至Comport
            {
                try
                {
                    SerialPort1.Write(CRCbytes, 0, CRCbytes.Length);
                    DateTime dt = DateTime.Now;
                    string text = "[Send_Port] [" + dt.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + CRC_calu + Environment.NewLine;
                    output_log = string.Concat(output_log, text);         //輸出至log變數
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort1 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            output_schedule += OutputString + CRC_calu + ",," + times + "," + function + @"/" + ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Control Name", "") + " : " + AutoKit_GPIO_icon_remark[index].Text + Environment.NewLine;
            output_log += "[Schedule] [" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + OutputString + CRC_calu + ",," + times + "," + function + @"/" + ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "") + ": " + status + Environment.NewLine;
        }

        private void AutoKit_RS232_Control(string type, int index, string frequency, string duty)   //OneBer控制
        {
            string port = comboBox_Serialport.Text;     // Autokit serial port
            string monitor = textBox_MonitorID.Text;    // Monitor ID value
            string function = comboBox_function.Text;   // Function value
            
            switch (function)
            {
                case "R":
                    function = "03";
                    break;
                case "W":
                    function = "06";
                    break;
                case "Multi":
                    function = "10";
                    break;
            }
            string times = textBox_times.Text;
            string high_value = "", low_value = "";
            int value = Convert.ToInt32(frequency);
            string hexValue = string.Empty;
            if (value > -1 && value < 65536)
            {
                hexValue = value.ToString("X").PadLeft(4, '0');
                high_value = hexValue.Substring(0, 2);
                low_value = hexValue.Substring(2);
            }
            string CRC_calu = "";

            string OutputString = "";           //Autokit schedule 變數
            OutputString = "_HEX,,,";
            OutputString += port + ",,,";

            CRC_calu = (Convert.ToInt32(monitor)).ToString("X2") + " " + function + " 00 " + ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", "").PadLeft(2, '0') + " " + high_value.PadLeft(2, '0') + " " + low_value.PadLeft(2, '0');       //計算CRC原始資料
            string[] hexValuesSplit = CRC_calu.Split(' ');
            byte[] bytes = new byte[hexValuesSplit.Count()];
            int hex_number = 0;
            foreach (string hex in hexValuesSplit)          //改為Byte陣列
            {
                // Convert the number expressed in base-16 to an integer.
                byte number = Convert.ToByte(Convert.ToInt32(hex, 16));
                // Get the character corresponding to the integral value.
                bytes[hex_number++] = number;
            }

            ushort crc = Crc16.ComputeCrc(bytes);       //計算CRC
            string crcHex = ((int)crc).ToString("X2").PadLeft(4, '0');  
            string crcLow = crcHex.Substring(0, 2);     //低位數
            string crcHigh = crcHex.Substring(2);       //高位數
            CRC_calu += " " + crcHigh + " " + crcLow;   //原始資料加入CRC

            string[] CRCSplit = CRC_calu.Split(' ');
            byte[] CRCbytes = new byte[CRCSplit.Count()];
            int CRCindex = 0;
            foreach (string hex in CRCSplit)          //改為Byte陣列
            {
                // Convert the number expressed in base-16 to an integer.
                byte number = Convert.ToByte(Convert.ToInt32(hex, 16));
                // Get the character corresponding to the integral value.
                CRCbytes[CRCindex++] = number;
            }

            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1")          //送至Comport
            {
                try
                {
                    SerialPort1.Write(CRCbytes, 0, CRCbytes.Length);
                    DateTime dt = DateTime.Now;
                    string text = "[Send_Port] [" + dt.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + CRC_calu + Environment.NewLine;
                    output_log = string.Concat(output_log, text);         //輸出至log變數
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort1 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            output_schedule += OutputString + CRC_calu + ",," + times + "," + function + @"/" + ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "") + ": " + frequency + Environment.NewLine;    //輸出至Schedule變數
            output_log += "[Schedule] [" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + OutputString + CRC_calu + ",," + times + "," + function + @"/" + ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "") + ": " + frequency + Environment.NewLine;
        }

        public static bool IsFileLocked(string file)     //偵測檔案被鎖住
        {
            try
            {
                using (File.Open(file, FileMode.Open, FileAccess.Write, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException exception)
            {
                var errorCode = Marshal.GetHRForException(exception) & 65535;
                return errorCode == 32 || errorCode == 33;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime myDate = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\Schedule\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", true))
            {
                file.Write(output_schedule);
                output_schedule = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\Log\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", true))
            {
                file.Write(output_log);
                output_log = "";
            }
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            string csv_file = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
            Setting Setting = new Setting();

            //如果serialport開著則先關閉//
            if (SerialPort1.IsOpen == true)
            {
                Close_serialPort1();
            }

            if (Setting.ShowDialog() == DialogResult.Cancel)                //當關閉Setting視窗
            {
                if (csv_file != ini12.INIRead(Config_Path, "Config", "scriptFile", ""))
                {
                    MessageBox.Show("Please wait, PSC will restart.");
                    Application.Restart();
                }
                else
                {
                    Extend_Initial_port();
                }
            }
            Setting.Dispose();
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int data_to_read = SerialPort1.BytesToRead;
                if (data_to_read > 0)
                {
                    byte[] dataset = new byte[data_to_read];

                    SerialPort1.Read(dataset, 0, data_to_read);

                    // hex to string
                    string hexValues = BitConverter.ToString(dataset).Replace("-", "");
                    DateTime dt;
                    dt = DateTime.Now;

                    hexValues = "[Receive_Port] [" + dt.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + hexValues + Environment.NewLine;

                    output_log = string.Concat(output_log, hexValues);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_Analysis Form = new Log_Analysis();
            Form.ShowDialog(new Log_Analysis());
        }

        private void hScrollBar_monitorID_ValueChanged(object sender, EventArgs e)
        {
            string old_value = hScrollBar_monitorID.Value.ToString();
            string new_value = hScrollBar_monitorID.Value.ToString();
            textBox_MonitorID.Text = hScrollBar_monitorID.Value.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            output_schedule = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;      //預設Schedule第一行內容
            output_log = "";   //預設log內容
        }

    }
}
