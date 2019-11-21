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
using NationalInstruments.DAQmx;
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

        private BlueRat MyBlueRat = new BlueRat();
        private int Location_X = 25, Location_Y = 50;
        private double AutoKit_Output_value = 0, AutoKit_Initial = 0; 
        private double P0_Output_value = 0, P1_Output_value = 0, P2_Output_value = 0, NI_Initial = 0;

        public static List<string> VID = new List<string> { };
        public static List<string> PID = new List<string> { };
        public static List<string> AutoBoxComport = new List<string> { };

        System.Windows.Forms.Label[] v3_GPIO_icon_remark;
        System.Windows.Forms.Label[] v3_GPIO_iconR_remark;
        System.Windows.Forms.Label[] v3_GPIO_key_remark;

        System.Windows.Forms.HScrollBar[] v3_PWM_two_Bar_freq_hscorllbar;
        System.Windows.Forms.HScrollBar[] v3_PWM_two_Bar_duty_hscorllbar;
        System.Windows.Forms.TextBox[] v3_PWM_two_Bar_freq_textbox;
        System.Windows.Forms.TextBox[] v3_PWM_two_Bar_duty_textbox;

        System.Windows.Forms.HScrollBar[] DSS_GPIO_one_Bar_hscorllbar;
        System.Windows.Forms.TextBox[] DSS_GPIO_one_Bar_textbox;

        System.Windows.Forms.Button[] AutoKit_GPIO_icon_on_button;
        System.Windows.Forms.Button[] AutoKit_GPIO_icon_off_button;
        System.Windows.Forms.Label[] AutoKit_GPIO_icon_remark;

        System.Windows.Forms.HScrollBar[] AutoKit_RS232_one_Bar_hscorllbar;
        System.Windows.Forms.TextBox[] AutoKit_RS232_one_Bar_textbox;

        System.Windows.Forms.HScrollBar[] AutoKit_RS232_two_Bar_freq_hscorllbar;
        System.Windows.Forms.HScrollBar[] AutoKit_RS232_two_Bar_duty_hscorllbar;
        System.Windows.Forms.TextBox[] AutoKit_RS232_two_Bar_freq_textbox;
        System.Windows.Forms.TextBox[] AutoKit_RS232_two_Bar_duty_textbox;

        System.Windows.Forms.Button[] NI_GPIO_icon_on_button;
        System.Windows.Forms.Button[] NI_GPIO_icon_off_button;
        System.Windows.Forms.Label[] NI_GPIO_icon_remark;
        
        public Main()
        {
            InitializeComponent();
        }

        private void DDS_Load(object sender, EventArgs e)
        {
            USB_Read();
            AutoKit_Initial_port();
            Extend_Initial_port();
            CSVtoINIfile();
        }

        #region -- 讀取USB裝置 --
        public void USB_Read()
        {
            //預設AutoBox沒接上
            ini12.INIWrite(Config_Path, "AutoKit", "Exist", "0");
            ini12.INIWrite(Config_Path, "AutoKit", "PortName", "");
            ini12.INIWrite(Config_Path, "NI_6501", "Exist", "0");
            ini12.INIWrite(Config_Path, "K_Line", "Exist", "0");

            ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
            ManagementObjectCollection collection = search.Get();
            var usbList = from u in collection.Cast<ManagementBaseObject>()
                          select new
                          {
                              id = u.GetPropertyValue("DeviceID"),
                              name = u.GetPropertyValue("Name"),
                              description = u.GetPropertyValue("Description"),
                              status = u.GetPropertyValue("Status"),
                              system = u.GetPropertyValue("SystemName"),
                              caption = u.GetPropertyValue("Caption"),
                              pnp = u.GetPropertyValue("PNPDeviceID"),
                          };

            foreach (var usbDevice in usbList)
            {
                string deviceId = (string)usbDevice.id;
                string deviceTp = (string)usbDevice.name;
                string deviecDescription = (string)usbDevice.description;

                string deviceStatus = (string)usbDevice.status;
                string deviceSystem = (string)usbDevice.system;
                string deviceCaption = (string)usbDevice.caption;
                string devicePnp = (string)usbDevice.pnp;

                if (deviecDescription != null)
                {
                    #region 偵測相機
                    if (deviecDescription.IndexOf("USB 視訊裝置", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        deviecDescription.IndexOf("USB 视频设备", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        deviceTp.IndexOf("Webcam", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        deviceTp.IndexOf("Camera", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (deviceId.IndexOf("VID_", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            int vidIndex = deviceId.IndexOf("VID_");
                            string startingAtVid = deviceId.Substring(vidIndex + 4); // + 4 to remove "VID_"
                            string vid = startingAtVid.Substring(0, 4); // vid is four characters long
                            VID.Add(vid);
                        }

                        if (deviceId.IndexOf("PID_", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            int pidIndex = deviceId.IndexOf("PID_");
                            string startingAtPid = deviceId.Substring(pidIndex + 4); // + 4 to remove "PID_"
                            string pid = startingAtPid.Substring(0, 4); // pid is four characters long
                            PID.Add(pid);
                        }

                        Console.WriteLine("-----------------Camera------------------");
                        Console.WriteLine("DeviceID: {0}\n" +
                                              "Name: {1}\n" +
                                              "Description: {2}\n" +
                                              "Status: {3}\n" +
                                              "System: {4}\n" +
                                              "Caption: {5}\n" +
                                              "Pnp: {6}\n"
                                              , deviceId, deviceTp, deviecDescription, deviceStatus, deviceSystem, deviceCaption, devicePnp);

                        //Camera存在
                        ini12.INIWrite(Config_Path, "Camera", "Exist", "1");
                    }
                    #endregion

                    #region 偵測AutoBox2
                    if (deviceId.IndexOf("&0&5", StringComparison.OrdinalIgnoreCase) >= 0 &&
                        deviceId.IndexOf("USB\\VID_067B&PID_2303\\", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine("-----------------AutoBox2------------------");
                        Console.WriteLine("DeviceID: {0}\n" +
                                              "Name: {1}\n" +
                                              "Description: {2}\n" +
                                              "Status: {3}\n" +
                                              "System: {4}\n" +
                                              "Caption: {5}\n" +
                                              "Pnp: {6}\n"
                                              , deviceId, deviceTp, deviecDescription, deviceStatus, deviceSystem, deviceCaption, devicePnp);

                        int FirstIndex = deviceTp.IndexOf("(");
                        string AutoBoxPortSubstring = deviceTp.Substring(FirstIndex + 1);
                        string AutoBoxPort = AutoBoxPortSubstring.Substring(0);

                        int AutoBoxPortLengh = AutoBoxPort.Length;
                        string AutoBoxPortFinal = AutoBoxPort.Remove(AutoBoxPortLengh - 1);

                        if (AutoBoxPortSubstring.Substring(0, 3) == "COM")
                        {
                            ini12.INIWrite(Config_Path, "AutoKit", "Exist", "1");
                            ini12.INIWrite(Config_Path, "AutoKit", "PortName", AutoBoxPortFinal);
                        }
                    }
                    #endregion

                    #region 偵測NI_USB-6501
                    if (deviceId.IndexOf("USB\\VID_3923&PID_718A\\", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine("-----------------NI_USB-6501------------------");
                        Console.WriteLine("DeviceID: {0}\n" +
                                              "Name: {1}\n" +
                                              "Description: {2}\n" +
                                              "Status: {3}\n" +
                                              "System: {4}\n" +
                                              "Caption: {5}\n" +
                                              "Pnp: {6}\n"
                                              , deviceId, deviceTp, deviecDescription, deviceStatus, deviceSystem, deviceCaption, devicePnp);

                        ini12.INIWrite(Config_Path, "NI_6501", "Exist", "1");
                    }
                    #endregion

                    #region 偵測K-Line
                    if (deviceId.IndexOf("USB\\VID_0403&PID_6001\\", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine("-----------------FTDI K-Line------------------");
                        Console.WriteLine("DeviceID: {0}\n" +
                                              "Name: {1}\n" +
                                              "Description: {2}\n" +
                                              "Status: {3}\n" +
                                              "System: {4}\n" +
                                              "Caption: {5}\n" +
                                              "Pnp: {6}\n"
                                              , deviceId, deviceTp, deviecDescription, deviceStatus, deviceSystem, deviceCaption, devicePnp);

                        ini12.INIWrite(Config_Path, "K_Line", "Exist", "1");
                    }
                    #endregion
                }
            }
        }
        #endregion

        private void AutoKit_Initial_port()
        {
            const int max_retry = 10;

            string AutoKit_Exist = ini12.INIRead(Config_Path, "AutoKit", "Exist", "");
            if (AutoKit_Exist == "1")
            {
                string com_port_name = ini12.INIRead(Config_Path, "AutoKit", "PortName", "");
                bool Connection_OK = false;
                int retry = max_retry;

                do
                {
                    Connection_OK = MyBlueRat.Connect(com_port_name);
                    if (MyBlueRat.Connect(com_port_name))
                    {
                        // 在第一次/或長時間未使用之後,要開始使用BlueRat跑Schedule之前,建議執行這一行,確保BlueRat的起始狀態一致 -- 正常情況下不執行並不影響BlueRat運行,但為了找問題方便,還是請務必執行
                        MyBlueRat.Force_Init_BlueRat();
                        MyBlueRat.Reset_SX1509();

                        byte SX1509_detect_status;
                        SX1509_detect_status = MyBlueRat.TEST_Detect_SX1509();

                        if (SX1509_detect_status != 3)
                        {
                            label_autokit_status.Text = "Autokit can't connect the extend board.";
                            // Error, need to check SX1509 connection
                            return;
                        }
                        else
                            label_autokit_status.Text = "Autokit can connect the extend board.";
                    }
                    else
                    {
                        retry--;
                        Thread.Sleep(500);
                        List<string> bluerat_com = BlueRat.FindAllBlueRat();
                        label_autokit_status.Text = "Autokit retry " + (max_retry - retry) + " times to connect the extend board.";
                    }
                }
                while ((Connection_OK != true) && (retry > 0));
            }
        }

        private void Extend_Initial_port()
        {
            string SerialPort1_Exist = ini12.INIRead(Config_Path, "serialPort1", "Exist", "");
            string SerialPort2_Exist = ini12.INIRead(Config_Path, "serialPort2", "Exist", "");
            string SerialPort3_Exist = ini12.INIRead(Config_Path, "serialPort3", "Exist", "");

            if (SerialPort1_Exist == "1")
            {
                Open_serialPort1();
            }

            if (SerialPort2_Exist == "1")
            {
                Open_serialPort2();
            }

            if (SerialPort3_Exist == "1")
            {
                Open_serialPort3();
            }
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
                if (int.Parse(ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", "")) != 0)
                {
                    AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", ""));
                }
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
                AutoKit_RS232_one_Bar_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Min", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Max", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Step", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""));
                AutoKit_RS232_one_Bar_hscorllbar[index].ValueChanged += new EventHandler(this.AutoKit_RS232_one_Bar_hscorllbar_ValueChanged);
                AutoKit_RS232_one_Bar_textbox[index] = new TextBox();
                AutoKit_RS232_one_Bar_textbox[index].Name = "AutoKit_RS232_one_Bar_textbox_" + index;
                AutoKit_RS232_one_Bar_textbox[index].Text = Convert.ToString(AutoKit_RS232_one_Bar_hscorllbar[index].Value);
                AutoKit_RS232_one_Bar_textbox[index].Size = new Size(60, 30);
                AutoKit_RS232_one_Bar_textbox[index].Location = new System.Drawing.Point(Location_X + 350, Location_Y + index * 30);
                AutoKit_RS232_one_Bar_remark[index] = new Label();
                AutoKit_RS232_one_Bar_remark[index].Name = "AutoKit_RS232_one_Bar_remark" + index;
                AutoKit_RS232_one_Bar_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Remark", "");
                AutoKit_RS232_one_Bar_remark[index].Size = new Size(200, 30);
                AutoKit_RS232_one_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_remark);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_textbox);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_hscorllbar);
                this.Controls.AddRange(AutoKit_RS232_one_Bar_label);
                if (int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", "")) != 0)
                {
                    AutoKit_RS232_Control("oneBar", index, ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""), ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""));
                }
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        void AutoKit_GPIO_icon_on_button_Click(object sender, EventArgs e)
        {
            AutoKit_Initial = 1;
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("AutoKit_GPIO_icon_on_button_", ""));
            AutoKit_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Remark_On", "");
            AutoKit_GPIO_icon_on_button[index].Enabled = false;
            AutoKit_GPIO_icon_off_button[index].Enabled = true;
            AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Status_On", ""));
            Thread.Sleep(50);
        }

        void AutoKit_GPIO_icon_off_button_Click(object sender, EventArgs e)
        {
            AutoKit_Initial = 1;
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

        private void v3_GPIO_icon_Control(string type, int index, string status)
        {
            //使用ASCII字元集將位元組轉換為字元組(字串)
            Encoding Enc = Encoding.ASCII;

            //字串[]
            string MyFirstFunction = "";

            if (type == "Onoff")
                MyFirstFunction = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Command", "");
            else if (type == "IconR")
                MyFirstFunction = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Command", "");
            else if (type == "Key")
                MyFirstFunction = ini12.INIRead(Script_Path, "V3_GPIO_Key_" + index, "Command", "");

            MyFirstFunction = MyFirstFunction + " " + status + "\r";

            //將字串[]轉換為16進位字串(Hex string)
            string hexValues = Enc.GetBytes(MyFirstFunction).BToHex();
            Console.WriteLine("Method:string to Hexstring");
            Console.WriteLine("{0} = {1}", MyFirstFunction, hexValues);
            Console.WriteLine("");
            byte[] bdata = hexValues.HexToByte();
            Console.WriteLine("Method:Hexstring to string");
            Console.WriteLine("{0} = {1}", hexValues, Enc.GetString(bdata));
            Console.WriteLine("");
            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort1", "Type", "") == ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Com", ""))
            {
                try
                {
                    SerialPort1.Write(bdata, 0, bdata.Length);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort1 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ini12.INIRead(Config_Path, "serialPort2", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort2", "Type", "") == ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Com", ""))
            {
                try
                {
                    SerialPort2.Write(bdata, 0, bdata.Length);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort2 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ini12.INIRead(Config_Path, "serialPort3", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort3", "Type", "") == ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Com", ""))
            {
                try
                {
                    SerialPort3.Write(bdata, 0, bdata.Length);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort3 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AutoKit_GPIO_icon_Control(int index, string status)
        {
            byte[] InputBuffer = new byte[6];
            byte[] OutputBuffer = new byte[8];
            string monitor = ini12.INIRead(Script_Path, "Config", "MonitorID", "");
            string behavior = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Com", "");
            string name = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "");

            InputBuffer[0] = Convert.ToByte((Convert.ToInt32(monitor, 16)));
            switch (behavior)
            {
                case "W":
                    InputBuffer[1] = Convert.ToByte("0x03");
                    break;
                case "R":
                    InputBuffer[1] = Convert.ToByte("0x06");
                    break;
            }
            InputBuffer[2] = 0x00;
            switch (name)
            {
                case "Power Status":
                    InputBuffer[3] = Convert.ToByte("0x01");
                    break;
                case "Volume":
                    InputBuffer[3] = Convert.ToByte("0x02");
                    break;
                case "Mute":
                    InputBuffer[3] = Convert.ToByte("0x03");
                    break;
            }
            byte high_value = Convert.ToByte((Convert.ToInt32(status, 16) >> 8 & 0xFF));
            InputBuffer[4] = high_value;
            byte low_value = Convert.ToByte((Convert.ToInt32(status, 16) & 0xFF));
            InputBuffer[5] = low_value;
            Byte[] crc = CRC16.ToModbus(InputBuffer);
            InputBuffer[6] = crc[0];
            InputBuffer[7] = crc[1];
            OutputBuffer = { InputBuffer[0], InputBuffer[1], InputBuffer[2], InputBuffer[3], InputBuffer[4], InputBuffer[5], InputBuffer[6], InputBuffer[7] };

        }

        private void AutoKit_RS232_Control(string type, int index, string frequency, string duty)
        {
            byte[] InputBuffer = new byte[8];
            byte[] OutputBuffer = new byte[8];
            string monitor = ini12.INIRead(Script_Path, "Config", "MonitorID", "");
            string behavior = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Com", "");
            string name = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Control Name", "");

            InputBuffer[0] = Convert.ToByte((Convert.ToInt32(monitor, 16)));
            switch (behavior)
            {
                case "W":
                    InputBuffer[1] = Convert.ToByte("0x03");
                    break;
                case "R":
                    InputBuffer[1] = Convert.ToByte("0x06");
                    break;
                case "Multi":
                    InputBuffer[1] = Convert.ToByte("0x10");
                    break;
            }
            InputBuffer[2] = 0x00;
            switch (name)
            {
                case "Power Status":
                    InputBuffer[3] = Convert.ToByte("0x01");
                    break;
                case "Volume":
                    InputBuffer[3] = Convert.ToByte("0x02");
                    break;
                case "Mute":
                    InputBuffer[3] = Convert.ToByte("0x03");
                    break;
            }
            byte high_value = Convert.ToByte((Convert.ToInt32(frequency, 16) >> 8 & 0xFF));
            InputBuffer[4] = high_value;
            byte low_value = Convert.ToByte((Convert.ToInt32(frequency, 16) & 0xFF));
            InputBuffer[5] = low_value;
            Byte[] crc = CRC16.ToModbus(InputBuffer);
            InputBuffer[6] = crc[0];
            InputBuffer[7] = crc[1];
            OutputBuffer = { InputBuffer[0], InputBuffer[1], InputBuffer[2], InputBuffer[3], InputBuffer[4], InputBuffer[5], InputBuffer[6], InputBuffer[7] };

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

        private void button_Start_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x06, 0x00, 0x00, 0x00, 0x2D };
            Byte[] crc = CRC16.ToModbus(data);
            this.label_autokit_status.Text = crc[0].ToString("X") + crc[1].ToString("X");
        }

        private void textBox_MonitorID_TextChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Script_Path, "Config", "MonitorID", textBox_MonitorID.Text.Trim());
        }

        private void comboBox_Serialport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Script_Path, "Config", "Serialport", comboBox_Serialport.Text.Trim());
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
                else 
                {
                    USB_Read();
                    AutoKit_Initial_port();
                    Extend_Initial_port();
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
