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
using MaterialSkin.Controls;
using BlueRatLibrary;
using System.Management;
using Microsoft.Win32.SafeHandles;
using System.Threading;
using System.Runtime.InteropServices;
using CRC;

namespace DDS
{
    public partial class Main : Form
    {
        private string Script_Path = Application.StartupPath + "\\Script.ini";
        private string Config_Path = Application.StartupPath + "\\Config.ini";

        private int Location_X = 25, Location_Y = 50;
        String output_log = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;

        System.Windows.Forms.Button[] AutoKit_GPIO_icon_on_button;
        System.Windows.Forms.Button[] AutoKit_GPIO_icon_off_button;
        System.Windows.Forms.Label[] AutoKit_GPIO_icon_remark;

        System.Windows.Forms.HScrollBar[] AutoKit_RS232_one_Bar_hscorllbar;
        System.Windows.Forms.TextBox[] AutoKit_RS232_one_Bar_textbox;
        System.Windows.Forms.Button[] AutoKit_RS232_one_Bar_button;

        public Main()
        {
            InitializeComponent();
        }

        private void DDS_Load(object sender, EventArgs e)
        {
            CSVtoINIfile();
            Default_Env();
        }

        private void CSVtoINIfile()
        {
            int AutoKit_GPIO_icon_10 = 0, AutoKit_RS232_one_Bar = 0;
            string TextLine = "";
            string[] SplitLine;
            int j = 0;
            string SchedulePath = ini12.INIRead(Config_Path, "Config", "scriptFile", "");

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

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "AutoKit_GPIO")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Icon10")
                        {
                            int hashcode = HashCode_Create("AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10);
                            ini12.INIWrite(Script_Path, "AutoKit_GPIO_Icon10_" + AutoKit_GPIO_icon_10, "Hashcode", Convert.ToString(hashcode, 16));
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
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "AutoKit_RS232")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "oneBar")
                        {
                            int hashcode = HashCode_Create("AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar);
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_oneBar_" + AutoKit_RS232_one_Bar, "Remark", dataGridView1.Rows[i].Cells[13].Value.ToString());
                            AutoKit_RS232_one_Bar++;
                        }
                    }
                }
                AutoKit_GPIO_icon_10_Create(AutoKit_GPIO_icon_10);
                AutoKit_RS232_one_Bar_Create(AutoKit_RS232_one_Bar);
            }
            else
            {
                MessageBox.Show("You can write a new script.", "New Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Default_Env()
        {
            comboBox_Serialport.Text = "A";
            textBox_MonitorID.Text = "01";
            comboBox_function.Text = "R";
            textBox_times.Text = "1000";
        }

        private void AutoKit_GPIO_icon_10_Create(int count)
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
                AutoKit_GPIO_icon_label[index].Size = new Size(150, 30);
                AutoKit_GPIO_icon_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                AutoKit_GPIO_icon_on_button[index] = new Button();
                AutoKit_GPIO_icon_on_button[index].Name = "AutoKit_GPIO_icon_on_button_" + index;
                AutoKit_GPIO_icon_on_button[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "");
                AutoKit_GPIO_icon_on_button[index].Size = new Size(60, 30);
                AutoKit_GPIO_icon_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                AutoKit_GPIO_icon_on_button[index].Click += new EventHandler(this.AutoKit_GPIO_icon_on_button_Click);
                AutoKit_GPIO_icon_off_button[index] = new Button();
                AutoKit_GPIO_icon_off_button[index].Name = "AutoKit_GPIO_icon_off_button_" + index;
                AutoKit_GPIO_icon_off_button[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_Off", "");
                AutoKit_GPIO_icon_off_button[index].Size = new Size(60, 30);
                AutoKit_GPIO_icon_off_button[index].Click += new EventHandler(this.AutoKit_GPIO_icon_off_button_Click);
                AutoKit_GPIO_icon_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                AutoKit_GPIO_icon_remark[index] = new Label();
                AutoKit_GPIO_icon_remark[index].Name = "AutoKit_GPIO_icon_remark_" + index;
                if (ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    AutoKit_GPIO_icon_on_button[index].Enabled = false;
                    AutoKit_GPIO_icon_off_button[index].Enabled = true;
                    AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_On", "");
                }
                else if (ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "") == "0")
                {
                    AutoKit_GPIO_icon_on_button[index].Enabled = true;
                    AutoKit_GPIO_icon_off_button[index].Enabled = false;
                    AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    AutoKit_GPIO_icon_on_button[index].Enabled = true;
                    AutoKit_GPIO_icon_off_button[index].Enabled = false;
                    AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    AutoKit_GPIO_icon_on_button[index].Enabled = false;
                    AutoKit_GPIO_icon_off_button[index].Enabled = true;
                    AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_On", "");
                }
                AutoKit_GPIO_icon_remark[index].Size = new Size(250, 30);
                AutoKit_GPIO_icon_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                this.Controls.AddRange(AutoKit_GPIO_icon_off_button);
                this.Controls.AddRange(AutoKit_GPIO_icon_on_button);
                this.Controls.AddRange(AutoKit_GPIO_icon_remark);
                this.Controls.AddRange(AutoKit_GPIO_icon_label);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void AutoKit_RS232_one_Bar_Create(int count)
        {
            System.Windows.Forms.Label[] AutoKit_RS232_one_Bar_label;
            System.Windows.Forms.Label[] AutoKit_RS232_one_Bar_remark;

            AutoKit_RS232_one_Bar_label = new Label[count];
            AutoKit_RS232_one_Bar_hscorllbar = new HScrollBar[count];
            AutoKit_RS232_one_Bar_textbox = new TextBox[count];
            AutoKit_RS232_one_Bar_button = new Button[count];
            AutoKit_RS232_one_Bar_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                AutoKit_RS232_one_Bar_label[index] = new Label();
                AutoKit_RS232_one_Bar_label[index].Name = "AutoKit_RS232_one_Bar_label_" + index;
                AutoKit_RS232_one_Bar_label[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "");
                AutoKit_RS232_one_Bar_label[index].Size = new Size(200, 30);
                AutoKit_RS232_one_Bar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_hscorllbar[index] = new HScrollBar();
                AutoKit_RS232_one_Bar_hscorllbar[index].Name = "AutoKit_RS232_one_Bar_hscorllbar_" + index;
                AutoKit_RS232_one_Bar_hscorllbar[index].Text = "Frequency";
                AutoKit_RS232_one_Bar_hscorllbar[index].Size = new Size(150, 30);
                AutoKit_RS232_one_Bar_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Min", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Max", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Step", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].ValueChanged += new EventHandler(this.AutoKit_RS232_one_Bar_hscorllbar_ValueChanged);
                AutoKit_RS232_one_Bar_textbox[index] = new TextBox();
                AutoKit_RS232_one_Bar_textbox[index].Name = "AutoKit_RS232_one_Bar_textbox_" + index;
                AutoKit_RS232_one_Bar_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
                AutoKit_RS232_one_Bar_textbox[index].Size = new Size(60, 30);
                AutoKit_RS232_one_Bar_textbox[index].Location = new System.Drawing.Point(Location_X + 290, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_button[index] = new Button();
                AutoKit_RS232_one_Bar_button[index].Name = "AutoKit_RS232_one_Bar_button_" + index;
                AutoKit_RS232_one_Bar_button[index].Text = "Enter";
                AutoKit_RS232_one_Bar_button[index].Size = new Size(60, 30);
                AutoKit_RS232_one_Bar_button[index].Location = new System.Drawing.Point(Location_X + 350, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_button[index].Click += new EventHandler(this.AutoKit_RS232_one_Bar_button_Click);
                AutoKit_RS232_one_Bar_remark[index] = new Label();
                AutoKit_RS232_one_Bar_remark[index].Name = "AutoKit_RS232_one_Bar_remark" + index;
                AutoKit_RS232_one_Bar_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Remark", "");
                AutoKit_RS232_one_Bar_remark[index].Size = new Size(200, 30);
                AutoKit_RS232_one_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_remark);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_button);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_textbox);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_hscorllbar);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_label);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        void AutoKit_GPIO_icon_on_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_GPIO_icon_on_button_", ""));
            AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_On", "");
            AutoKit_GPIO_icon_on_button[index].Enabled = false;
            AutoKit_GPIO_icon_off_button[index].Enabled = true;
            AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", ""));
            Thread.Sleep(50);
        }

        void AutoKit_GPIO_icon_off_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_GPIO_icon_off_button_", ""));
            AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_Off", "");
            AutoKit_GPIO_icon_on_button[index].Enabled = true;
            AutoKit_GPIO_icon_off_button[index].Enabled = false;
            AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_Off", ""));
            Thread.Sleep(50);
        }

        void AutoKit_RS232_one_Bar_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("AutoKit_RS232_one_Bar_hscorllbar_", ""));
            AutoKit_RS232_one_Bar_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
            AutoKit_RS232_Control("oneBar", index, AutoKit_RS232_one_Bar_textbox[index].Text, AutoKit_RS232_one_Bar_textbox[index].Text);
            Thread.Sleep(50);
        }

        void AutoKit_RS232_one_Bar_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_RS232_one_Bar_button_", ""));
            if (AutoKit_RS232_one_Bar_textbox[index].Text != "")
                AutoKit_RS232_Control("oneBar", index, AutoKit_RS232_one_Bar_textbox[index].Text, AutoKit_RS232_one_Bar_textbox[index].Text);
            Thread.Sleep(50);
        }

        private void AutoKit_GPIO_icon_Control(int index, string status)
        {
            byte[] InputBuffer = new byte[6];
            byte[] OutputBuffer = new byte[8];
            string port = comboBox_Serialport.Text;
            string monitor = textBox_MonitorID.Text;
            string function = comboBox_function.Text;
            string times = textBox_times.Text;

            string OutputString = "";
            OutputString = "_HEX,,,";
            OutputString += port + ",,,";

            InputBuffer[0] = Convert.ToByte(monitor, 16);
            switch (function)
            {
                case "R":
                    InputBuffer[1] = Convert.ToByte("03");
                    break;
                case "W":
                    InputBuffer[1] = Convert.ToByte("06");
                    break;
                case "Multi":
                    InputBuffer[1] = Convert.ToByte("10");
                    break;
            }
            InputBuffer[2] = 0x00;
            InputBuffer[3] = Convert.ToByte(ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", ""), 16);
            if (status != "")
            {
                int Decimal = Convert.ToInt32(status);
                int Hexadecimal = Convert.ToInt32(Convert.ToString(Decimal, 16), 16);
                byte high_value = Convert.ToByte(Hexadecimal >> 8 & 0xFF);
                InputBuffer[4] = high_value;
                byte low_value = Convert.ToByte(Hexadecimal & 0xFF);
                InputBuffer[5] = low_value;
            }
            Byte[] crc = CRC16.ToModbus(InputBuffer);
            OutputBuffer[6] = crc[0];
            OutputBuffer[7] = crc[1];

            for (int i = 0; i < 6; i++)
            {
                OutputBuffer[i] = InputBuffer[i];
            }

            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                    OutputString += OutputBuffer[i].ToString("X2");
                else
                    OutputString += " " + OutputBuffer[i].ToString("X2");
            }
            output_log += OutputString + ",," + times + "," + Environment.NewLine;
        }


        private void AutoKit_RS232_Control(string type, int index, string frequency, string duty)
        {
            byte[] InputBuffer = new byte[6];
            byte[] OutputBuffer = new byte[8];
            string port = comboBox_Serialport.Text;
            string monitor = textBox_MonitorID.Text;
            string function = comboBox_function.Text;
            string times = textBox_times.Text;

            string OutputString = "";
            OutputString = "_HEX,,,";
            OutputString += port + ",,,";

            InputBuffer[0] = Convert.ToByte(monitor, 16);
            switch (function)
            {
                case "R":
                    InputBuffer[1] = Convert.ToByte("03");
                    break;
                case "W":
                    InputBuffer[1] = Convert.ToByte("06");
                    break;
                case "Multi":
                    InputBuffer[1] = Convert.ToByte("10");
                    break;
            }
            InputBuffer[2] = 0x00;
            InputBuffer[3] = Convert.ToByte(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""), 16);
            if (frequency != "")
            {
                int Decimal = Convert.ToInt32(frequency);
                int Hexadecimal = Convert.ToInt32(Convert.ToString(Decimal, 16), 16);
                byte high_value = Convert.ToByte(Hexadecimal >> 8 & 0xFF);
                InputBuffer[4] = high_value;
                byte low_value = Convert.ToByte(Hexadecimal & 0xFF);
                InputBuffer[5] = low_value;
            }
            Byte[] crc = CRC16.ToModbus(InputBuffer);
            OutputBuffer[6] = crc[0];
            OutputBuffer[7] = crc[1];

            for (int i = 0; i < 6; i++)
            {
                OutputBuffer[i] = InputBuffer[i];
            }

            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                    OutputString += OutputBuffer[i].ToString("X2");
                else
                    OutputString += " " + OutputBuffer[i].ToString("X2");
            }
            output_log += OutputString + ",," + times + "," + Environment.NewLine;
        }

        public static bool IsFileLocked(string file)
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

        protected void Open_serialPort2()
        {
            try
            {
                if (SerialPort2.IsOpen == false)
                {
                    SerialPort2.StopBits = StopBits.One;
                    SerialPort2.PortName = ini12.INIRead(Config_Path, "serialPort2", "PortName", "");
                    SerialPort2.BaudRate = int.Parse((ini12.INIRead(Config_Path, "serialPort2", "BaudRate", "")));
                    SerialPort2.DataBits = 8;
                    SerialPort2.Parity = (Parity)0;
                    SerialPort2.ReceivedBytesThreshold = 1;
                    // Autokit_serialPort1.Encoding = System.Text.Encoding.GetEncoding(1252);
                    // Autokit_serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);       // DataReceived呼叫函式
                    SerialPort2.Open();
                }
            }
            catch (Exception Ex)
            {
                ini12.INIWrite(Config_Path, "serialPort2", "Exist", "0");
                MessageBox.Show(Ex.Message.ToString(), "SerialPort2 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        protected void Open_serialPort3()
        {
            try
            {
                if (SerialPort3.IsOpen == false)
                {
                    SerialPort3.StopBits = StopBits.One;
                    SerialPort3.PortName = ini12.INIRead(Config_Path, "serialPort3", "PortName", "");
                    SerialPort3.BaudRate = int.Parse((ini12.INIRead(Config_Path, "serialPort3", "BaudRate", "")));
                    SerialPort3.DataBits = 8;
                    SerialPort3.Parity = (Parity)0;
                    SerialPort3.ReceivedBytesThreshold = 1;
                    // Autokit_serialPort3.Encoding = System.Text.Encoding.GetEncoding(1252);
                    // Autokit_serialPort3.DataReceived += new SerialDataReceivedEventHandler(SerialPort3_DataReceived);       // DataReceived呼叫函式
                    SerialPort3.Open();
                }
            }
            catch (Exception Ex)
            {
                ini12.INIWrite(Config_Path, "serialPort3", "Exist", "0");
                MessageBox.Show(Ex.Message.ToString(), "SerialPort3 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Close_serialPort1()
        {
            SerialPort1.Dispose();
            SerialPort1.Close();
        }


        protected void Close_serialPort2()
        {
            SerialPort2.Dispose();
            SerialPort2.Close();
        }

        protected void Close_serialPort3()
        {
            SerialPort3.Dispose();
            SerialPort3.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime myDate = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", true))
            {
                file.Write(output_log);
                output_log = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            output_log = "Command,>Times >Keyword#,Interval,>COM  >Pin,Function,Sub-function,>SerialPort                   >I/O cmd,AC/USB Switch,Wait,Remark," + Environment.NewLine;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            string csv_file = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
            Setting Setting = new Setting();
            //如果serialport開著則先關閉//
            if (SerialPort1.IsOpen == true)
            {
                Close_serialPort1();
            }

            if (SerialPort2.IsOpen == true)
            {
                Close_serialPort2();
            }

            if (SerialPort3.IsOpen == true)
            {
                Close_serialPort3();
            }

            if (Setting.ShowDialog() == DialogResult.Cancel)
            {
                if (csv_file != ini12.INIRead(Config_Path, "Config", "scriptFile", ""))
                {
                    MessageBox.Show("Please wait, DSS will restart.");
                    Application.Restart();
                }
            }
            Setting.Dispose();
        }

        public static int HashCode_Create(String Operand)
        {
            int HashCode = Operand.GetHashCode();
            Console.WriteLine("The hash code for \"{0}\" is: 0x{1:X8}, {1}",
                              Operand, HashCode);
            return HashCode;
        }
    }
}
