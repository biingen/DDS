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
using Can_Reader_Lib;
using MySerialLibrary;
using BlockMessageLibrary;
using KWP_2000;
using DTC_ABS;
using DTC_OBD;

namespace DDS
{
    public partial class Main : Form
    {
        private string Script_Path = Application.StartupPath + "\\Script.ini";
        private string Config_Path = Application.StartupPath + "\\Config.ini";
        public delegate void MyDelegate(string str);
        private BlueRat MyBlueRat = new BlueRat();
        private int Location_X = 25, Location_Y = 50;
        private double AutoKit_Output_value = 0, AutoKit_Initial = 0; 
        private double P0_Output_value = 0, P1_Output_value = 0, P2_Output_value = 0, NI_Initial = 0;

        public static List<string> VID = new List<string> { };
        public static List<string> PID = new List<string> { };
        public static List<string> AutoBoxComport = new List<string> { };

        private MySerial MySerialPort = new MySerial();
        private List<BlockMessage> MyBlockMessageList = new List<BlockMessage>();
        private ProcessBlockMessage MyProcessBlockMessage = new ProcessBlockMessage();

        UInt64 Can_ID100 = Convert.ToUInt64(~0UL), Can_ID200 = Convert.ToUInt64(~0UL);

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

        System.Windows.Forms.TextBox[] Canbus_text_textbox;

        private CAN_Reader MYCanReader = new CAN_Reader();
        
        public Main()
        {
            InitializeComponent();

            ToolTip KlinetoolTip = new ToolTip();
            //ABS
            KlinetoolTip.SetToolTip(Kline_ABS_0x5055, Kline_ABS_0x5055.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5019, Kline_ABS_0x5019.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5017, Kline_ABS_0x5017.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5013, Kline_ABS_0x5013.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5018, Kline_ABS_0x5018.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5014, Kline_ABS_0x5014.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5053, Kline_ABS_0x5053.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5052, Kline_ABS_0x5052.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_ABS_0x5035, Kline_ABS_0x5035.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5043, Kline_ABS_0x5043.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5045, Kline_ABS_0x5045.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5042, Kline_ABS_0x5042.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5044, Kline_ABS_0x5044.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_ABS_0x5025, Kline_ABS_0x5025.Tag.ToString());
            
            //OBD
            KlinetoolTip.SetToolTip(Kline_OBD_P0503, Kline_OBD_P0503.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_C0083, Kline_OBD_C0083.Tag.ToString()); 
            KlinetoolTip.SetToolTip(Kline_OBD_C0085, Kline_OBD_C0085.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0105, Kline_OBD_P0105.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0110, Kline_OBD_P0110.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0115, Kline_OBD_P0115.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0120, Kline_OBD_P0120.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0130, Kline_OBD_P0503.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_P0135, Kline_OBD_P0135.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0150, Kline_OBD_P0150.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0155, Kline_OBD_P0155.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0201, Kline_OBD_P0201.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0202, Kline_OBD_P0202.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0217, Kline_OBD_P0217.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0230, Kline_OBD_P0230.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0335, Kline_OBD_P0335.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_P0336, Kline_OBD_P0336.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0351, Kline_OBD_P0351.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0352, Kline_OBD_P0352.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0410, Kline_OBD_P0410.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0480, Kline_OBD_P0480.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0500, Kline_OBD_P0500.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0501, Kline_OBD_P0501.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0505, Kline_OBD_P0505.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_P0512, Kline_OBD_P0512.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0560, Kline_OBD_P0560.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0601, Kline_OBD_P0601.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0604, Kline_OBD_P0604.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0605, Kline_OBD_P0605.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0606, Kline_OBD_P0606.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0620_PIN2, Kline_OBD_P0620_PIN2.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0620_PIN31, Kline_OBD_P0620_PIN31.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_P0650, Kline_OBD_P0650.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0655, Kline_OBD_P0655.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P0A0F, Kline_OBD_P0A0F.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P1300, Kline_OBD_P1300.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P1310, Kline_OBD_P1310.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P1536, Kline_OBD_P1536.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P1607, Kline_OBD_P1607.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P1800, Kline_OBD_P1800.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_P2158, Kline_OBD_P2158.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_P2600, Kline_OBD_P2600.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0001, Kline_OBD_U0001.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0002, Kline_OBD_U0002.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0121, Kline_OBD_U0121.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0122, Kline_OBD_U0122.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0128, Kline_OBD_U0128.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0140, Kline_OBD_U0140.Tag.ToString());

            KlinetoolTip.SetToolTip(Kline_OBD_U0426, Kline_OBD_U0426.Tag.ToString());
            KlinetoolTip.SetToolTip(Kline_OBD_U0486, Kline_OBD_U0486.Tag.ToString());

        }

        private void DDS_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            USB_Device.USB_Read();
            Form_K_Line_Load();
            AutoKit_Initial_port();
            Extend_Initial_port();
            CSVtoINIfile();
            ConnectCanBus();
            ConnectKline();
        }

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
            int v3_GPIO_icon_onoff = 0, v3_GPIO_iconR = 0, v3_GPIO_key = 0, DSS_GPIO_one_Bar = 0, v3_PWM_two_Bar = 0, AutoKit_GPIO_icon_10 = 0, AutoKit_RS232_one_Bar = 0, AutoKit_RS232_two_Bar = 0, NI_GPIO_icon_10 = 0, Canbus_text = 0;
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
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "V3_GPIO")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "IconOnOff")
                        {
                            int hashcode = HashCode_Create("V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff);
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Status_On", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Remark_On", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Status_Off", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconOnoff_" + v3_GPIO_icon_onoff, "Remark_Off", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            v3_GPIO_icon_onoff++;
                        }
                        else if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "IconR")
                        {
                            int hashcode = HashCode_Create("V3_GPIO_IconR_" + v3_GPIO_iconR);
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Status_On", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Remark_On", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Status_Off", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_IconR_" + v3_GPIO_iconR, "Remark_Off", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            v3_GPIO_iconR++;
                        }
                        else if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Key")
                        {
                            int hashcode = HashCode_Create("V3_GPIO_key_" + v3_GPIO_key);
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Status_On", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Remark_On", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Status_Off", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_GPIO_key_" + v3_GPIO_key, "Remark_Off", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            v3_GPIO_key++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "V3_PWM")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "twoBar")
                        {
                            int hashcode = HashCode_Create("V3_PWM_twoBar_" + v3_PWM_two_Bar);
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Freq_Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Freq_Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Freq_Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Freq_Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Duty_Initial", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Duty_Min", dataGridView1.Rows[i].Cells[10].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Duty_Max", dataGridView1.Rows[i].Cells[11].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Duty_Step", dataGridView1.Rows[i].Cells[12].Value.ToString());
                            ini12.INIWrite(Script_Path, "V3_PWM_twoBar_" + v3_PWM_two_Bar, "Remark", dataGridView1.Rows[i].Cells[13].Value.ToString());
                            v3_PWM_two_Bar++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "DSS_GPIO")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "oneBar")
                        {
                            int hashcode = HashCode_Create("DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar);
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "DSS_GPIO_oneBar_" + DSS_GPIO_one_Bar, "Remark", dataGridView1.Rows[i].Cells[13].Value.ToString());
                            DSS_GPIO_one_Bar++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "AutoKit_GPIO")
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
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "twoBar")
                        {
                            int hashcode = HashCode_Create("AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar);
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Freq_Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Freq_Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Freq_Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Freq_Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Duty_Initial", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Duty_Min", dataGridView1.Rows[i].Cells[10].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Duty_Max", dataGridView1.Rows[i].Cells[11].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Duty_Step", dataGridView1.Rows[i].Cells[12].Value.ToString());
                            ini12.INIWrite(Script_Path, "AutoKit_RS232_twoBar_" + AutoKit_RS232_two_Bar, "Remark", dataGridView1.Rows[i].Cells[13].Value.ToString());
                            AutoKit_RS232_two_Bar++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "NI_GPIO")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Icon10")
                        {
                            int hashcode = HashCode_Create("NI_GPIO_Icon10_" + NI_GPIO_icon_10);
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Status_On", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Remark_On", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Status_Off", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            ini12.INIWrite(Script_Path, "NI_GPIO_Icon10_" + NI_GPIO_icon_10, "Remark_Off", dataGridView1.Rows[i].Cells[9].Value.ToString());
                            NI_GPIO_icon_10++;
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Canbus")
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Text")
                        {
                            int hashcode = HashCode_Create("Canbus_Text_" + Canbus_text);
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Hashcode", Convert.ToString(hashcode, 16));
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Com", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Control Name", dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Command", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Freq_Initial", dataGridView1.Rows[i].Cells[5].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Freq_Min", dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Freq_Max", dataGridView1.Rows[i].Cells[7].Value.ToString());
                            ini12.INIWrite(Script_Path, "Canbus_Text_" + Canbus_text, "Freq_Step", dataGridView1.Rows[i].Cells[8].Value.ToString());
                            Canbus_text++;
                        }
                    }
                }
                v3_GPIO_icon_Create(v3_GPIO_icon_onoff);
                v3_GPIO_iconR_Create(v3_GPIO_iconR);
                v3_GPIO_key_Create(v3_GPIO_key);
                v3_PWM_two_Bar_Create(v3_PWM_two_Bar);
                DSS_GPIO_one_Bar_Create(DSS_GPIO_one_Bar);
                AutoKit_GPIO_icon_10_Create(AutoKit_GPIO_icon_10);
                AutoKit_RS232_one_Bar_Create(AutoKit_RS232_one_Bar);
                AutoKit_RS232_two_Bar_Create(AutoKit_RS232_two_Bar);
                NI_GPIO_icon_10_Create(NI_GPIO_icon_10);
                Canbus_text_Create(Canbus_text);
            }
            else
            {
                MessageBox.Show("You can write a new script.", "New Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void v3_GPIO_icon_Create(int count)
        {
            System.Windows.Forms.Label[] v3_GPIO_icon_label;
            System.Windows.Forms.Button[] v3_GPIO_icon_on_button;
            System.Windows.Forms.Button[] v3_GPIO_icon_off_button;

            v3_GPIO_icon_label = new Label[count];
            v3_GPIO_icon_on_button = new Button[count];
            v3_GPIO_icon_off_button = new Button[count];
            v3_GPIO_icon_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                v3_GPIO_icon_label[index] = new Label();
                v3_GPIO_icon_label[index].Name = "v3_GPIO_icon_label_" + index;
                v3_GPIO_icon_label[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Control Name", "");
                v3_GPIO_icon_label[index].Size = new Size(150, 30);
                v3_GPIO_icon_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                v3_GPIO_icon_remark[index] = new Label();
                v3_GPIO_icon_remark[index].Name = "v3_GPIO_icon_remark_" + index;
                if (ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_On", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_On", "") == "0")
                {
                    v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_On", "");
                }
                v3_GPIO_icon_remark[index].Size = new Size(250, 30);
                v3_GPIO_icon_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                v3_GPIO_icon_on_button[index] = new Button();
                v3_GPIO_icon_on_button[index].Name = "v3_GPIO_icon_on_button_" + index;
                v3_GPIO_icon_on_button[index].Text = "On";
                v3_GPIO_icon_on_button[index].Size = new Size(60, 30);
                v3_GPIO_icon_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                v3_GPIO_icon_on_button[index].Click += new EventHandler(this.v3_GPIO_icon_on_button_Click);
                v3_GPIO_icon_off_button[index] = new Button();
                v3_GPIO_icon_off_button[index].Name = "v3_GPIO_icon_off_button_" + index;
                v3_GPIO_icon_off_button[index].Text = "Off";
                v3_GPIO_icon_off_button[index].Size = new Size(60, 30);
                v3_GPIO_icon_off_button[index].Click += new EventHandler(this.v3_GPIO_icon_off_button_Click);
                v3_GPIO_icon_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                this.Controls.AddRange(v3_GPIO_icon_off_button);
                this.Controls.AddRange(v3_GPIO_icon_on_button);
                this.Controls.AddRange(v3_GPIO_icon_remark);
                this.Controls.AddRange(v3_GPIO_icon_label);
                v3_GPIO_icon_Control("Onoff", index, ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void v3_GPIO_iconR_Create(int count)
        {
            System.Windows.Forms.Label[] v3_GPIO_iconR_label;
            System.Windows.Forms.Button[] v3_GPIO_iconR_on_button;
            System.Windows.Forms.Button[] v3_GPIO_iconR_off_button;

            v3_GPIO_iconR_label = new Label[count];
            v3_GPIO_iconR_on_button = new Button[count];
            v3_GPIO_iconR_off_button = new Button[count];
            v3_GPIO_iconR_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                v3_GPIO_iconR_label[index] = new Label();
                v3_GPIO_iconR_label[index].Name = "v3_GPIO_iconR_label_" + index;
                v3_GPIO_iconR_label[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Control Name", "");
                v3_GPIO_iconR_label[index].Size = new Size(150, 30);
                v3_GPIO_iconR_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                v3_GPIO_iconR_remark[index] = new Label();
                v3_GPIO_iconR_remark[index].Name = "v3_GPIO_iconR_remark_" + index;
                if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_On", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "0")
                {
                    v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_On", "");
                }
                v3_GPIO_iconR_remark[index].Size = new Size(250, 30);
                v3_GPIO_iconR_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                v3_GPIO_iconR_on_button[index] = new Button();
                v3_GPIO_iconR_on_button[index].Name = "v3_GPIO_iconR_on_button_" + index;
                if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "1")
                {
                    v3_GPIO_iconR_on_button[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_On", "");
                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", "") == "0")
                {
                    v3_GPIO_iconR_on_button[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_Off", "");
                }
                v3_GPIO_iconR_on_button[index].Size = new Size(60, 30);
                v3_GPIO_iconR_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                v3_GPIO_iconR_on_button[index].Click += new EventHandler(this.v3_GPIO_iconR_on_button_Click);
                v3_GPIO_iconR_off_button[index] = new Button();
                v3_GPIO_iconR_off_button[index].Name = "v3_GPIO_iconR_off_button_" + index;
                if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_Off", "") == "1")
                {
                    v3_GPIO_iconR_off_button[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_On", "");

                }
                else if (ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_Off", "") == "0")
                {
                    v3_GPIO_iconR_off_button[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_Off", "");
                }
                v3_GPIO_iconR_off_button[index].Size = new Size(60, 30);
                v3_GPIO_iconR_off_button[index].Click += new EventHandler(this.v3_GPIO_iconR_off_button_Click);
                v3_GPIO_iconR_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                this.Controls.AddRange(v3_GPIO_iconR_off_button);
                this.Controls.AddRange(v3_GPIO_iconR_on_button);
                this.Controls.AddRange(v3_GPIO_iconR_remark);
                this.Controls.AddRange(v3_GPIO_iconR_label);
                v3_GPIO_icon_Control("IconR", index, ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void v3_GPIO_key_Create(int count)
        {
            System.Windows.Forms.Label[] v3_GPIO_key_label;
            System.Windows.Forms.Button[] v3_GPIO_key_button;

            v3_GPIO_key_label = new Label[count];
            v3_GPIO_key_button = new Button[count];
            v3_GPIO_key_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                v3_GPIO_key_label[index] = new Label();
                v3_GPIO_key_label[index].Name = "v3_GPIO_key_label_" + index;
                v3_GPIO_key_label[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Control Name", "");
                v3_GPIO_key_label[index].Size = new Size(150, 30);
                v3_GPIO_key_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                v3_GPIO_key_remark[index] = new Label();
                v3_GPIO_key_remark[index].Name = "v3_GPIO_key_remark_" + index;
                v3_GPIO_key_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Remark_Off", "");
                v3_GPIO_key_remark[index].Size = new Size(250, 30);
                v3_GPIO_key_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                v3_GPIO_key_button[index] = new Button();
                v3_GPIO_key_button[index].Name = "v3_GPIO_key_button_" + index;
                v3_GPIO_key_button[index].Text = "Push";
                v3_GPIO_key_button[index].Size = new Size(120, 30);
                v3_GPIO_key_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                v3_GPIO_key_button[index].MouseDown += new System.Windows.Forms.MouseEventHandler(this.v3_GPIO_key_button_MouseDown);
                v3_GPIO_key_button[index].MouseUp += new System.Windows.Forms.MouseEventHandler(this.v3_GPIO_key_button_MouseUp);
                this.Controls.AddRange(v3_GPIO_key_button);
                this.Controls.AddRange(v3_GPIO_key_remark);
                this.Controls.AddRange(v3_GPIO_key_label);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void v3_PWM_two_Bar_Create(int count)
        {
            System.Windows.Forms.Label[] v3_PWM_two_Bar_label;
            System.Windows.Forms.Label[] v3_PWM_two_Bar_remark;

            v3_PWM_two_Bar_label = new Label[count];
            v3_PWM_two_Bar_freq_hscorllbar = new HScrollBar[count];
            v3_PWM_two_Bar_duty_hscorllbar = new HScrollBar[count];
            v3_PWM_two_Bar_freq_textbox = new TextBox[count];
            v3_PWM_two_Bar_duty_textbox = new TextBox[count];
            v3_PWM_two_Bar_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                v3_PWM_two_Bar_label[index] = new Label();
                v3_PWM_two_Bar_label[index].Name = "v3_PWM_two_Bar_label_" + index;
                v3_PWM_two_Bar_label[index].Text = ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Control Name", "");
                v3_PWM_two_Bar_label[index].Size = new Size(200, 30);
                v3_PWM_two_Bar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                v3_PWM_two_Bar_freq_hscorllbar[index] = new HScrollBar();
                v3_PWM_two_Bar_freq_hscorllbar[index].Name = "v3_PWM_two_Bar_freq_hscorllbar_" + index;
                v3_PWM_two_Bar_freq_hscorllbar[index].Text = "Frequency";
                v3_PWM_two_Bar_freq_hscorllbar[index].Size = new Size(150, 30);
                v3_PWM_two_Bar_freq_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                v3_PWM_two_Bar_freq_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Freq_Min", ""));
                v3_PWM_two_Bar_freq_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Freq_Max", ""));
                v3_PWM_two_Bar_freq_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Freq_Step", ""));
                v3_PWM_two_Bar_freq_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Freq_Initial", ""));
                v3_PWM_two_Bar_freq_hscorllbar[index].ValueChanged += new EventHandler(this.v3_PWM_two_Bar_freq_hscorllbar_ValueChanged);
                v3_PWM_two_Bar_freq_textbox[index] = new TextBox();
                v3_PWM_two_Bar_freq_textbox[index].Name = "v3_PWM_two_Bar_freq_textbox_" + index;
                v3_PWM_two_Bar_freq_textbox[index].Text = Convert.ToString(v3_PWM_two_Bar_freq_hscorllbar[index].Value);
                v3_PWM_two_Bar_freq_textbox[index].Size = new Size(60, 30);
                v3_PWM_two_Bar_freq_textbox[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                v3_PWM_two_Bar_duty_hscorllbar[index] = new HScrollBar();
                v3_PWM_two_Bar_duty_hscorllbar[index].Name = "v3_PWM_two_Bar_duty_hscorllbar_" + index;
                v3_PWM_two_Bar_duty_hscorllbar[index].Text = "Duty";
                v3_PWM_two_Bar_duty_hscorllbar[index].Size = new Size(150, 30);
                v3_PWM_two_Bar_duty_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                v3_PWM_two_Bar_duty_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Duty_Min", ""));
                v3_PWM_two_Bar_duty_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Duty_Max", ""));
                v3_PWM_two_Bar_duty_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Duty_Step", ""));
                v3_PWM_two_Bar_duty_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Duty_Initial", ""));
                v3_PWM_two_Bar_duty_hscorllbar[index].ValueChanged += new EventHandler(this.v3_PWM_two_Bar_duty_hscorllbar_ValueChanged);
                v3_PWM_two_Bar_duty_textbox[index] = new TextBox();
                v3_PWM_two_Bar_duty_textbox[index].Name = "v3_PWM_two_Bar_duty_textbox_" + index;
                v3_PWM_two_Bar_duty_textbox[index].Text = Convert.ToString(v3_PWM_two_Bar_duty_hscorllbar[index].Value);
                v3_PWM_two_Bar_duty_textbox[index].Size = new Size(60, 30);
                v3_PWM_two_Bar_duty_textbox[index].Location = new System.Drawing.Point(Location_X + 560, Location_Y + index * 30);
                v3_PWM_two_Bar_remark[index] = new Label();
                v3_PWM_two_Bar_remark[index].Name = "v3_PWM_two_Bar_remark_" + index;
                v3_PWM_two_Bar_remark[index].Text = ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Remark", "");
                v3_PWM_two_Bar_remark[index].Size = new Size(200, 30);
                v3_PWM_two_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 620, Location_Y + index * 30);
                this.Controls.AddRange(v3_PWM_two_Bar_remark);
                this.Controls.AddRange(v3_PWM_two_Bar_duty_textbox);
                this.Controls.AddRange(v3_PWM_two_Bar_freq_textbox);
                this.Controls.AddRange(v3_PWM_two_Bar_duty_hscorllbar);
                this.Controls.AddRange(v3_PWM_two_Bar_freq_hscorllbar);
                this.Controls.AddRange(v3_PWM_two_Bar_label);
                v3_PWM_Control(index, ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Freq_Initial", ""), ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Duty_Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void DSS_GPIO_one_Bar_Create(int count)
        {
            System.Windows.Forms.Label[] DSS_GPIO_one_Bar_label;
            System.Windows.Forms.Label[] DSS_GPIO_one_Bar_remark;

            DSS_GPIO_one_Bar_label = new Label[count];
            DSS_GPIO_one_Bar_hscorllbar = new HScrollBar[count];
            DSS_GPIO_one_Bar_textbox = new TextBox[count];
            DSS_GPIO_one_Bar_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                DSS_GPIO_one_Bar_label[index] = new Label();
                DSS_GPIO_one_Bar_label[index].Name = "DSS_GPIO_one_Bar_label_" + index;
                DSS_GPIO_one_Bar_label[index].Text = ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Control Name", "");
                DSS_GPIO_one_Bar_label[index].Size = new Size(200, 30);
                DSS_GPIO_one_Bar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                DSS_GPIO_one_Bar_hscorllbar[index] = new HScrollBar();
                DSS_GPIO_one_Bar_hscorllbar[index].Name = "DSS_GPIO_one_Bar_hscorllbar_" + index;
                DSS_GPIO_one_Bar_hscorllbar[index].Text = DSS_GPIO_one_Bar_hscorllbar[index].Name;
                DSS_GPIO_one_Bar_hscorllbar[index].Size = new Size(150, 30);
                DSS_GPIO_one_Bar_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                DSS_GPIO_one_Bar_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Min", ""));
                DSS_GPIO_one_Bar_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Max", ""));
                DSS_GPIO_one_Bar_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Step", ""));
                DSS_GPIO_one_Bar_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Initial", ""));
                DSS_GPIO_one_Bar_hscorllbar[index].ValueChanged += new EventHandler(this.DSS_GPIO_one_Bar_hscorllbar_ValueChanged);
                DSS_GPIO_one_Bar_textbox[index] = new TextBox();
                DSS_GPIO_one_Bar_textbox[index].Name = "v3_PWM_two_Bar_freq_textbox_" + index;
                DSS_GPIO_one_Bar_textbox[index].Text = Convert.ToString(DSS_GPIO_one_Bar_hscorllbar[index].Value);
                DSS_GPIO_one_Bar_textbox[index].Size = new Size(60, 30);
                DSS_GPIO_one_Bar_textbox[index].Location = new System.Drawing.Point(Location_X + 350, Location_Y + index * 30);
                DSS_GPIO_one_Bar_remark[index] = new Label();
                DSS_GPIO_one_Bar_remark[index].Name = "DSS_GPIO_one_Bar_remark_" + index;
                DSS_GPIO_one_Bar_remark[index].Text = ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Remark", "");
                DSS_GPIO_one_Bar_remark[index].Size = new Size(200, 30);
                DSS_GPIO_one_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                this.Controls.AddRange(DSS_GPIO_one_Bar_remark);
                this.Controls.AddRange(DSS_GPIO_one_Bar_textbox);
                this.Controls.AddRange(DSS_GPIO_one_Bar_hscorllbar);
                this.Controls.AddRange(DSS_GPIO_one_Bar_label);
                DSS_GPIO_Control(index, ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
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
                AutoKit_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Initial", ""));
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
                AutoKit_RS232_Control("oneBar", index, ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""), ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void AutoKit_RS232_two_Bar_Create(int count)
        {
            System.Windows.Forms.Label[] AutoKit_RS232_two_Bar_label;
            System.Windows.Forms.Label[] AutoKit_RS232_two_Bar_remark;

            AutoKit_RS232_two_Bar_label = new Label[count];
            AutoKit_RS232_two_Bar_freq_hscorllbar = new HScrollBar[count];
            AutoKit_RS232_two_Bar_duty_hscorllbar = new HScrollBar[count];
            AutoKit_RS232_two_Bar_freq_textbox = new TextBox[count];
            AutoKit_RS232_two_Bar_duty_textbox = new TextBox[count];
            AutoKit_RS232_two_Bar_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                AutoKit_RS232_two_Bar_label[index] = new Label();
                AutoKit_RS232_two_Bar_label[index].Name = "AutoKit_RS232_two_Bar_label_" + index;
                AutoKit_RS232_two_Bar_label[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Control Name", "");
                AutoKit_RS232_two_Bar_label[index].Size = new Size(200, 30);
                AutoKit_RS232_two_Bar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                AutoKit_RS232_two_Bar_freq_hscorllbar[index] = new HScrollBar();
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Name = "AutoKit_RS232_two_Bar_freq_hscorllbar_" + index;
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Text = "Frequency";
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Size = new Size(150, 30);
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Freq_Min", ""));
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Freq_Max", ""));
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Freq_Step", ""));
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Freq_Initial", ""));
                AutoKit_RS232_two_Bar_freq_hscorllbar[index].ValueChanged += new EventHandler(this.AutoKit_RS232_two_Bar_freq_hscorllbar_ValueChanged);
                AutoKit_RS232_two_Bar_freq_textbox[index] = new TextBox();
                AutoKit_RS232_two_Bar_freq_textbox[index].Name = "AutoKit_RS232_two_Bar_freq_textbox_" + index;
                AutoKit_RS232_two_Bar_freq_textbox[index].Text = Convert.ToString(AutoKit_RS232_two_Bar_freq_hscorllbar[index].Value);
                AutoKit_RS232_two_Bar_freq_textbox[index].Size = new Size(60, 30);
                AutoKit_RS232_two_Bar_freq_textbox[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                AutoKit_RS232_two_Bar_duty_hscorllbar[index] = new HScrollBar();
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Name = "AutoKit_RS232_two_Bar_duty_hscorllbar_" + index;
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Text = "Duty";
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Size = new Size(150, 30);
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Minimum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Duty_Min", ""));
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Maximum = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Duty_Max", ""));
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].LargeChange = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Duty_Step", ""));
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].Value = int.Parse(ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Duty_Initial", ""));
                AutoKit_RS232_two_Bar_duty_hscorllbar[index].ValueChanged += new EventHandler(this.AutoKit_RS232_two_Bar_duty_hscorllbar_ValueChanged);
                AutoKit_RS232_two_Bar_duty_textbox[index] = new TextBox();
                AutoKit_RS232_two_Bar_duty_textbox[index].Name = "AutoKit_RS232_two_Bar_duty_textbox_" + index;
                AutoKit_RS232_two_Bar_duty_textbox[index].Text = Convert.ToString(AutoKit_RS232_two_Bar_duty_hscorllbar[index].Value);
                AutoKit_RS232_two_Bar_duty_textbox[index].Size = new Size(60, 30);
                AutoKit_RS232_two_Bar_duty_textbox[index].Location = new System.Drawing.Point(Location_X + 560, Location_Y + index * 30);
                AutoKit_RS232_two_Bar_remark[index] = new Label();
                AutoKit_RS232_two_Bar_remark[index].Name = "AutoKit_RS232_two_Bar_remark_" + index;
                AutoKit_RS232_two_Bar_remark[index].Text = ini12.INIRead(Script_Path, "AutoKit_RS232_two_Bar_remark_" + index, "Remark", ""); ;
                AutoKit_RS232_two_Bar_remark[index].Size = new Size(200, 30);
                AutoKit_RS232_two_Bar_remark[index].Location = new System.Drawing.Point(Location_X + 620, Location_Y + index * 30);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_remark);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_duty_textbox);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_freq_textbox);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_duty_hscorllbar);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_freq_hscorllbar);
                this.Controls.AddRange(AutoKit_RS232_two_Bar_label);
                AutoKit_RS232_Control("twoBar", index, ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Freq_Initial", ""), ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Duty_Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void NI_GPIO_icon_10_Create(int count)
        {
            System.Windows.Forms.Label[] NI_GPIO_icon_label;

            NI_GPIO_icon_label = new Label[count];
            NI_GPIO_icon_on_button = new Button[count];
            NI_GPIO_icon_off_button = new Button[count];
            NI_GPIO_icon_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                NI_GPIO_icon_label[index] = new Label();
                NI_GPIO_icon_label[index].Name = "NI_GPIO_icon_label_" + index;
                NI_GPIO_icon_label[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Control Name", "");
                NI_GPIO_icon_label[index].Size = new Size(150, 30);
                NI_GPIO_icon_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                NI_GPIO_icon_on_button[index] = new Button();
                NI_GPIO_icon_on_button[index].Name = "NI_GPIO_icon_on_button_" + index;
                NI_GPIO_icon_on_button[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", "");
                NI_GPIO_icon_on_button[index].Size = new Size(60, 30);
                NI_GPIO_icon_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                NI_GPIO_icon_on_button[index].Click += new EventHandler(this.NI_GPIO_icon_on_button_Click);
                NI_GPIO_icon_off_button[index] = new Button();
                NI_GPIO_icon_off_button[index].Name = "NI_GPIO_icon_off_button_" + index;
                NI_GPIO_icon_off_button[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_Off", "");
                NI_GPIO_icon_off_button[index].Size = new Size(60, 30);
                NI_GPIO_icon_off_button[index].Click += new EventHandler(this.NI_GPIO_icon_off_button_Click);
                NI_GPIO_icon_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                NI_GPIO_icon_remark[index] = new Label();
                NI_GPIO_icon_remark[index].Name = "NI_GPIO_icon_remark_" + index;
                if (ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    NI_GPIO_icon_on_button[index].Enabled = false;
                    NI_GPIO_icon_off_button[index].Enabled = true;
                    NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_On", "");
                }
                else if (ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Initial", "") == "1" && ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", "") == "0")
                {
                    NI_GPIO_icon_on_button[index].Enabled = true;
                    NI_GPIO_icon_off_button[index].Enabled = false;
                    NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    NI_GPIO_icon_on_button[index].Enabled = true;
                    NI_GPIO_icon_off_button[index].Enabled = false;
                    NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_Off", "");
                }
                else if (ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Initial", "") == "0" && ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", "") == "1")
                {
                    NI_GPIO_icon_on_button[index].Enabled = false;
                    NI_GPIO_icon_off_button[index].Enabled = true;
                    NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_On", "");
                }
                NI_GPIO_icon_remark[index].Size = new Size(250, 30);
                NI_GPIO_icon_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                this.Controls.AddRange(NI_GPIO_icon_off_button);
                this.Controls.AddRange(NI_GPIO_icon_on_button);
                this.Controls.AddRange(NI_GPIO_icon_remark);
                this.Controls.AddRange(NI_GPIO_icon_label);
                NI_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Initial", ""));
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void Canbus_text_Create(int count)
        {
            System.Windows.Forms.Label[] Canbus_text_label;

            Canbus_text_label = new Label[count];
            Canbus_text_textbox = new TextBox[count];

            for (int index = 0; index < count; index++)
            {
                Canbus_text_label[index] = new Label();
                Canbus_text_label[index].Name = "Canbus_text_" + index;
                Canbus_text_label[index].Text = ini12.INIRead(Script_Path, "Canbus_text_" + index, "Control Name", "");
                Canbus_text_label[index].Size = new Size(150, 30);
                Canbus_text_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                Canbus_text_textbox[index] = new TextBox();
                Canbus_text_textbox[index].Name = "Canbus_text_" + index;
                Canbus_text_textbox[index].Text = "0";
                Canbus_text_textbox[index].Size = new Size(60, 30);
                Canbus_text_textbox[index].Location = new System.Drawing.Point(Location_X + 210, Location_Y + index * 30);
                Canbus_text_textbox[index].TextChanged += new System.EventHandler(this.Canbus_text_textbox_TextChanged);
                this.Controls.AddRange(Canbus_text_label);
                this.Controls.AddRange(Canbus_text_textbox);
                Canbus_text_Control(index, Canbus_text_textbox[index].Text);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        void v3_GPIO_icon_on_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_icon_on_button_", ""));
            v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_On", "");
            v3_GPIO_icon_Control("Onoff", index, ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_On", ""));
        }

        void v3_GPIO_icon_off_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_icon_off_button_", ""));
            v3_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Remark_Off", "");
            v3_GPIO_icon_Control("Onoff", index, ini12.INIRead(Script_Path, "V3_GPIO_IconOnoff_" + index, "Status_Off", ""));
        }

        void v3_GPIO_iconR_on_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_iconR_on_button_", ""));
            v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_On", "");
            v3_GPIO_icon_Control("IconR", index, ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_On", ""));
        }

        void v3_GPIO_iconR_off_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_iconR_off_button_", ""));
            v3_GPIO_iconR_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Remark_Off", "");
            v3_GPIO_icon_Control("IconR", index, ini12.INIRead(Script_Path, "V3_GPIO_IconR_" + index, "Status_Off", ""));
        }

        void v3_GPIO_key_button_MouseDown(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_key_button_", ""));
            if (ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Status_On", "") == "1")
            {
                v3_GPIO_key_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Remark_On", "");
            }
            v3_GPIO_icon_Control("Key", index, ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Status_On", ""));
        }

        void v3_GPIO_key_button_MouseUp(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("v3_GPIO_key_button_", ""));
            if (ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Status_Off", "") == "0")
            {
                v3_GPIO_key_remark[index].Text = ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Remark_Off", "");
            }
            v3_GPIO_icon_Control("Key", index, ini12.INIRead(Script_Path, "V3_GPIO_key_" + index, "Status_Off", ""));
        }

        void v3_PWM_two_Bar_freq_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("v3_PWM_two_Bar_freq_hscorllbar_", ""));
            v3_PWM_two_Bar_freq_textbox[index].Text = Convert.ToString(v3_PWM_two_Bar_freq_hscorllbar[index].Value);
            v3_PWM_Control(index, v3_PWM_two_Bar_freq_textbox[index].Text, v3_PWM_two_Bar_duty_textbox[index].Text);
        }

        void v3_PWM_two_Bar_duty_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("v3_PWM_two_Bar_duty_hscorllbar_", ""));
            v3_PWM_two_Bar_duty_textbox[index].Text = Convert.ToString(v3_PWM_two_Bar_duty_hscorllbar[index].Value);
            v3_PWM_Control(index, v3_PWM_two_Bar_freq_textbox[index].Text, v3_PWM_two_Bar_duty_textbox[index].Text);
        }

        void DSS_GPIO_one_Bar_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("DSS_GPIO_one_Bar_hscorllbar_", ""));
            DSS_GPIO_one_Bar_textbox[index].Text = Convert.ToString(DSS_GPIO_one_Bar_hscorllbar[index].Value);
            DSS_GPIO_Control(index, DSS_GPIO_one_Bar_textbox[index].Text);
            Thread.Sleep(50);
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

        void AutoKit_RS232_two_Bar_freq_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("AutoKit_RS232_two_Bar_freq_hscorllbar_", ""));
            AutoKit_RS232_two_Bar_freq_textbox[index].Text = Convert.ToString(AutoKit_RS232_two_Bar_freq_hscorllbar[index].Value);
            AutoKit_RS232_Control("twoBar", index, AutoKit_RS232_two_Bar_freq_textbox[index].Text, AutoKit_RS232_two_Bar_duty_textbox[index].Text);
            Thread.Sleep(50);
        }

        void AutoKit_RS232_two_Bar_duty_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("AutoKit_RS232_two_Bar_duty_hscorllbar_", ""));
            AutoKit_RS232_two_Bar_duty_textbox[index].Text = Convert.ToString(AutoKit_RS232_two_Bar_duty_hscorllbar[index].Value);
            AutoKit_RS232_Control("twoBar", index, AutoKit_RS232_two_Bar_freq_textbox[index].Text, AutoKit_RS232_two_Bar_duty_textbox[index].Text);
            Thread.Sleep(50);
        }

        void NI_GPIO_icon_on_button_Click(object sender, EventArgs e)
        {
            NI_Initial = 1;
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("NI_GPIO_icon_on_button_", ""));
            NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_On", "");
            NI_GPIO_icon_on_button[index].Enabled = false;
            NI_GPIO_icon_off_button[index].Enabled = true;
            NI_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_On", ""));
        }

        void NI_GPIO_icon_off_button_Click(object sender, EventArgs e)
        {
            NI_Initial = 1;
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("NI_GPIO_icon_off_button_", ""));
            NI_GPIO_icon_remark[index].Text = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Remark_Off", "");
            NI_GPIO_icon_on_button[index].Enabled = true;
            NI_GPIO_icon_off_button[index].Enabled = false;
            NI_GPIO_icon_Control(index, ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Status_Off", ""));
        }

        void Canbus_text_textbox_TextChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((TextBox)(sender)).Name.ToString().Replace("Canbus_text_", ""));
            Canbus_text_textbox[index].Text = Convert.ToString(Canbus_text_textbox[index].Text);
            Canbus_text_Control(index, Canbus_text_textbox[index].Text);
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

        private void v3_PWM_Control(int index, string frequency, string duty)
        {
            //使用ASCII字元集將位元組轉換為字元組(字串)
            Encoding Enc = Encoding.ASCII;

            //字串[]
            string MyFirstFunction = ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Command", "");

            MyFirstFunction = MyFirstFunction + " " + duty + " " + frequency + "\r";

            //將字串[]轉換為16進位字串(Hex string)
            string hexValues = Enc.GetBytes(MyFirstFunction).BToHex();
            Console.WriteLine("Method:string to Hexstring");
            Console.WriteLine("{0} = {1}", MyFirstFunction, hexValues);
            Console.WriteLine("");
            byte[] bdata = hexValues.HexToByte();
            Console.WriteLine("Method:Hexstring to string");
            Console.WriteLine("{0} = {1}", hexValues, Enc.GetString(bdata));
            Console.WriteLine("");
            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort1", "Type", "") == ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Com", ""))
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
            else if (ini12.INIRead(Config_Path, "serialPort2", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort2", "Type", "") == ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Com", ""))
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
            else if (ini12.INIRead(Config_Path, "serialPort3", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort3", "Type", "") == ini12.INIRead(Script_Path, "V3_PWM_twoBar_" + index, "Com", ""))
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

        private void DSS_GPIO_Control(int index, string value)
        {
            string MyFirstFunction = ini12.INIRead(Script_Path, "DSS_GPIO_oneBar_" + index, "Command", "");

            //字串[]
            int GPIO_value = int.Parse(value);
            if (ini12.INIRead(Config_Path, "AutoKit", "Exist", "") == "1")
            {
                if (MyFirstFunction == "Water Temp")
                {
                    if (value == "0")
                        MyBlueRat.Set_IO_Extend_Set_Pin(0, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(0, 0);

                    if (value == "1")
                        MyBlueRat.Set_IO_Extend_Set_Pin(1, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(1, 0);

                    if (value == "2")
                        MyBlueRat.Set_IO_Extend_Set_Pin(2, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(2, 0);

                    if (value == "3")
                        MyBlueRat.Set_IO_Extend_Set_Pin(3, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(3, 0);

                    if (value == "4")
                        MyBlueRat.Set_IO_Extend_Set_Pin(4, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(4, 0);

                    if (value == "5")
                        MyBlueRat.Set_IO_Extend_Set_Pin(5, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(5, 0);
                    
                    if (value == "6")
                        MyBlueRat.Set_IO_Extend_Set_Pin(6, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(6, 0);

                    if (value == "7")
                        MyBlueRat.Set_IO_Extend_Set_Pin(7, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(7, 0);

                    if (value == "8")
                        MyBlueRat.Set_IO_Extend_Set_Pin(8, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(8, 0);

                    Console.WriteLine("Water Temp = " + value);
                }
                else if (MyFirstFunction == "Fuel Display")
                {
                    if (value == "0")
                        MyBlueRat.Set_IO_Extend_Set_Pin(16, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(16, 0);

                    if (value == "1")
                        MyBlueRat.Set_IO_Extend_Set_Pin(17, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(17, 0);

                    if (value == "2")
                        MyBlueRat.Set_IO_Extend_Set_Pin(18, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(18, 0);

                    if (value == "3")
                        MyBlueRat.Set_IO_Extend_Set_Pin(19, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(19, 0);

                    if (value == "4")
                        MyBlueRat.Set_IO_Extend_Set_Pin(20, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(20, 0);

                    if (value == "5")
                        MyBlueRat.Set_IO_Extend_Set_Pin(21, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(21, 0);

                    if (value == "6")
                        MyBlueRat.Set_IO_Extend_Set_Pin(22, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(22, 0);

                    if (value == "7")
                        MyBlueRat.Set_IO_Extend_Set_Pin(23, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(23, 0);

                    if (value == "8")
                        MyBlueRat.Set_IO_Extend_Set_Pin(24, 1);
                    else
                        MyBlueRat.Set_IO_Extend_Set_Pin(24, 0);

                    Console.WriteLine("Fuel Display = " + value);
                }
                else if (MyFirstFunction == "Temp")
                {
                    if (GPIO_value == -20)
                        MyBlueRat.Set_MCP42xxx(224);
                    else if (GPIO_value == -15)
                        MyBlueRat.Set_MCP42xxx(172);
                    else if (GPIO_value == -10)
                        MyBlueRat.Set_MCP42xxx(130);
                    else if (GPIO_value == -5)
                        MyBlueRat.Set_MCP42xxx(101);
                    else if (GPIO_value == 0)
                        MyBlueRat.Set_MCP42xxx(78);
                    else if (GPIO_value == 5)
                        MyBlueRat.Set_MCP42xxx(61);
                    else if (GPIO_value == 10)
                        MyBlueRat.Set_MCP42xxx(47);
                    else if (GPIO_value == 15)
                        MyBlueRat.Set_MCP42xxx(36);
                    else if (GPIO_value == 20)
                        MyBlueRat.Set_MCP42xxx(29);
                    else if (GPIO_value == 25)
                        MyBlueRat.Set_MCP42xxx(23);
                    else if (GPIO_value == 30)
                        MyBlueRat.Set_MCP42xxx(19);
                    else if (GPIO_value == 35)
                        MyBlueRat.Set_MCP42xxx(15);
                    else if (GPIO_value == 40)
                        MyBlueRat.Set_MCP42xxx(12);
                    else if (GPIO_value == 45)
                        MyBlueRat.Set_MCP42xxx(10);
                    else if (GPIO_value == 50)
                        MyBlueRat.Set_MCP42xxx(8);
                    Console.WriteLine("Temp = " + GPIO_value);
                }
                else if (MyFirstFunction == "Ohm")
                {
                    MyBlueRat.Set_MCP42xxx(Convert.ToByte(value));
                    Console.WriteLine("Ohm = " + GPIO_value);
                }
            }

        }

        private void AutoKit_GPIO_icon_Control(int index, string status)
        {
            //使用ASCII字元集將位元組轉換為字元組(字串)
            Encoding Enc = Encoding.ASCII;

            string Port = ini12.INIRead(Script_Path, "AutoKit_GPIO_Icon10_" + index, "Command", "").Substring(4);
            double Set_GPIO_value = 0;

            if (AutoKit_Initial == 0)
            {
                if (status == "1")
                {
                    Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                    AutoKit_Output_value = AutoKit_Output_value + Set_GPIO_value;
                }
            }
            else if (AutoKit_Initial == 1)
            {
                if (status == "1")
                {
                    Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                    AutoKit_Output_value = AutoKit_Output_value + Set_GPIO_value;
                }
                else if (status == "0")
                {
                    Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                    if (AutoKit_Output_value < Set_GPIO_value)
                    {
                        AutoKit_Output_value = Set_GPIO_value - AutoKit_Output_value;
                    }
                    else if (AutoKit_Output_value >= Set_GPIO_value)
                    {
                        AutoKit_Output_value = AutoKit_Output_value - Set_GPIO_value;
                    }
                }
            }
            //字串[]
            string MyFirstFunction = "";

            MyFirstFunction = Convert.ToString(Convert.ToInt32(AutoKit_Output_value), 2);
            MyFirstFunction = MyFirstFunction.PadLeft(8, '0');
            byte GPIO_B = Convert.ToByte(MyFirstFunction, 2);
            MyBlueRat.Set_GPIO_Output(GPIO_B);
        }

        private void AutoKit_RS232_Control(string type, int index, string frequency, string duty)
        {
            string Freqency_Function = "", Duty_Function = "";

            if (type == "oneBar")
            {
                Freqency_Function = ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Command", "");
            }
            else if (type == "twoBar")
            {
                Freqency_Function = ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Command", "");
                Duty_Function = ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Command", "");
            }
          
            if (ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Command", "").Substring(0, 4) == "VSET" || ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Command", "").Substring(0, 4) == "ISET")
            {
                double valtage = Convert.ToInt16(frequency);
                string output = String.Format("{0:0.000}", valtage = valtage / 10);
                Freqency_Function = Freqency_Function + output;
                Duty_Function = "";
                Console.WriteLine("GPP4323: " + Freqency_Function);
            }
            else if (type == "twoBar" && ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Command", "") == "S1" || ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Command", "") == "S2")
            {
                if (int.Parse(frequency) > -1 && int.Parse(frequency) < 1000)
                    Freqency_Function = Freqency_Function + "F" + frequency + "T";
                else if (int.Parse(frequency) >= 1000 && int.Parse(frequency) < 100000)
                    Freqency_Function = Freqency_Function + "F" + frequency.Substring(0, 2) + "." + frequency.Substring(2, 1) + "T";
                else if (int.Parse(frequency) >= 100000 && int.Parse(frequency) <= 150000)
                    Freqency_Function = Freqency_Function + "F" + frequency.Substring(0, 1) + "." + frequency.Substring(1, 1) + "." + frequency.Substring(2, 1) + "T";
                Console.WriteLine("Output:" + Freqency_Function);

                if (int.Parse(duty) < 10)
                    Duty_Function = Duty_Function + "D" + "00" + duty + "T";
                else if (int.Parse(duty) >= 10 && int.Parse(duty) < 100)
                    Duty_Function = Duty_Function + "D" + "0" + duty + "T";
                else if (int.Parse(duty) == 100)
                    Duty_Function = Duty_Function + "D" + duty + "T";
                Console.WriteLine("Output:" + Duty_Function);
            }
            else
            {

            }
            
            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort1", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Com", "") || ini12.INIRead(Config_Path, "serialPort1", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Com", ""))
            {
                try
                {
                    if (type == "oneBar")
                        SerialPort1.WriteLine(Freqency_Function);
                    else if (type == "twoBar")
                    {
                        SerialPort1.WriteLine(Freqency_Function);
                        SerialPort1.WriteLine(Duty_Function);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort1 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ini12.INIRead(Config_Path, "serialPort2", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort2", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Com", "") || ini12.INIRead(Config_Path, "serialPort2", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Com", ""))
            {
                try
                {
                    if (type == "oneBar")
                        SerialPort2.WriteLine(Freqency_Function);
                    else if (type == "twoBar")
                    {
                        SerialPort2.WriteLine(Freqency_Function);
                        SerialPort2.WriteLine(Duty_Function);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort2 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ini12.INIRead(Config_Path, "serialPort3", "Exist", "") == "1" && ini12.INIRead(Config_Path, "serialPort3", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_oneBar_" + index, "Com", "") || ini12.INIRead(Config_Path, "serialPort3", "Type", "") == ini12.INIRead(Script_Path, "AutoKit_RS232_twoBar_" + index, "Com", ""))
            {
                try
                {
                    if (type == "oneBar")
                        SerialPort3.WriteLine(Freqency_Function);
                    else if (type == "twoBar")
                    {
                        SerialPort3.WriteLine(Freqency_Function);
                        SerialPort3.WriteLine(Duty_Function);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "SerialPort3 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NI_GPIO_icon_Control(int index, string status)
        {
            string Exist = ini12.INIRead(Script_Path, "NI_6501", "Exist", "");
            string Device = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Command", "").Substring(4, 2);
            string Port = ini12.INIRead(Script_Path, "NI_GPIO_Icon10_" + index, "Command", "").Substring(7);
            double Set_GPIO_value = 0;

            if (Device == "p0")
            {
                if (NI_Initial == 0)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P0_Output_value = P0_Output_value + Set_GPIO_value;
                    }
                }
                else if (NI_Initial == 1)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P0_Output_value = P0_Output_value + Set_GPIO_value;
                    }
                    else if (status == "0")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        if (P0_Output_value < Set_GPIO_value)
                        {
                            P0_Output_value = Set_GPIO_value - P0_Output_value;
                        }
                        else if (P0_Output_value >= Set_GPIO_value)
                        {
                            P0_Output_value = P0_Output_value - Set_GPIO_value;
                        }
                    }
                }
            }
            else if (Device == "p1")
            {
                if (NI_Initial == 0)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P1_Output_value = P1_Output_value + Set_GPIO_value;
                    }
                }
                else if (NI_Initial == 1)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P1_Output_value = P1_Output_value + Set_GPIO_value;
                    }
                    else if (status == "0")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        if (P1_Output_value < Set_GPIO_value)
                        {
                            P1_Output_value = Set_GPIO_value - P1_Output_value;
                        }
                        else if (P1_Output_value >= Set_GPIO_value)
                        {
                            P1_Output_value = P1_Output_value - Set_GPIO_value;
                        }
                    }
                }
            }
            else if (Device == "p2")
            {
                if (NI_Initial == 0)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P2_Output_value = P2_Output_value + Set_GPIO_value;
                    }
                }
                else if (NI_Initial == 1)
                {
                    if (status == "1")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        P2_Output_value = P2_Output_value + Set_GPIO_value;
                    }
                    else if (status == "0")
                    {
                        Set_GPIO_value = Math.Pow(2, Double.Parse(Port));
                        if (P2_Output_value < Set_GPIO_value)
                        {
                            P2_Output_value = Set_GPIO_value - P2_Output_value;
                        }
                        else if (P2_Output_value >= Set_GPIO_value)
                        {
                            P2_Output_value = P2_Output_value - Set_GPIO_value;
                        }
                    }
                }
            }

            Console.WriteLine("P0_Output_value = " + P0_Output_value);
            Console.WriteLine("P1_Output_value = " + P1_Output_value);
            Console.WriteLine("P2_Output_value = " + P2_Output_value);
            if (Exist == "1")
            {
                switch (Device)
                {
                    case "p0":
                        try
                        {
                            using (NationalInstruments.DAQmx.Task digitalWriteTask = new NationalInstruments.DAQmx.Task())
                            {
                                //  Create an Digital Output channel and name it.
                                digitalWriteTask.DOChannels.CreateChannel(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.DOPort, PhysicalChannelAccess.External)[0].ToString(), "port0",
                                    ChannelLineGrouping.OneChannelForAllLines);

                                //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                                //  of digital data on demand, so no timeout is necessary.
                                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                                writer.WriteSingleSamplePort(true, (UInt32)Convert.ToUInt32(P0_Output_value));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "p1":
                        try
                        {
                            using (NationalInstruments.DAQmx.Task digitalWriteTask = new NationalInstruments.DAQmx.Task())
                            {
                                //  Create an Digital Output channel and name it.
                                digitalWriteTask.DOChannels.CreateChannel(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.DOPort, PhysicalChannelAccess.External)[1].ToString(), "port0",
                                    ChannelLineGrouping.OneChannelForAllLines);

                                //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                                //  of digital data on demand, so no timeout is necessary.
                                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                                writer.WriteSingleSamplePort(true, (UInt32)Convert.ToUInt32(P1_Output_value));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case "p2":
                        try
                        {
                            using (NationalInstruments.DAQmx.Task digitalWriteTask = new NationalInstruments.DAQmx.Task())
                            {
                                //  Create an Digital Output channel and name it.
                                digitalWriteTask.DOChannels.CreateChannel(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.DOPort, PhysicalChannelAccess.External)[2].ToString(), "port0",
                                    ChannelLineGrouping.OneChannelForAllLines);

                                //  Write digital port data. WriteDigitalSingChanSingSampPort writes a single sample
                                //  of digital data on demand, so no timeout is necessary.
                                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                                writer.WriteSingleSamplePort(true, (UInt32)Convert.ToUInt32(P2_Output_value));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
            }
        }

        private void Canbus_text_Control(int index, string value)
        {
            UInt64 after_value, before_value, data_value, data_min, data_max;
            int data_pos, data_len, can_id, can_unit, i;
            string data, can_data;
            can_id = Convert.ToInt16(ini12.INIRead(Script_Path, "Canbus_Text_"+ index, "Com", ""));
            data_pos = Convert.ToInt16(ini12.INIRead(Script_Path, "Canbus_Text_" + index, "Command", ""));
            data_len = Convert.ToInt16(ini12.INIRead(Script_Path, "Canbus_Text_" + index, "Freq_Initial", ""));
            can_unit = Convert.ToUInt16(ini12.INIRead(Script_Path, "Canbus_Text_" + index, "Freq_Step", ""));
            data_min = Convert.ToUInt64(ini12.INIRead(Script_Path, "Canbus_Text_" + index, "Freq_Min", ""));
            data_max = Convert.ToUInt64(ini12.INIRead(Script_Path, "Canbus_Text_" + index, "Freq_Max", ""));
            // Process user input value
            data_value = (UInt64)(Convert.ToDouble(value) * can_unit);

            switch (can_id)
            {
                case 100:
                    before_value = Can_ID100;
                    // Insert values into corresponding fields
                    after_value = CAN_Write.Update_value(before_value, data_value, data_min, data_max, data_pos, data_len);
                    Can_ID100 = after_value;
                    data = Can_ID100.ToString("X");
                    can_data = data.Substring(0, 2);
                    for (i = 2; i < data.Length; i = i + 2)
                    {
                        can_data += " " + data.Substring(i, 2);
                    }
                    break;
                case 200:
                    before_value = Can_ID200;
                    // Insert values into corresponding fields
                    after_value = CAN_Write.Update_value(before_value, data_value, data_min, data_max, data_pos, data_len);
                    Can_ID200 = after_value;
                    data = Can_ID200.ToString("X");
                    can_data = data.Substring(0, 2);
                    for (i = 2; i < data.Length; i = i + 2)
                    {
                        can_data += " " + data.Substring(i, 2);
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            //After_value.Text = Engine1_message_after_value.ToString("X");
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

        protected void ConnectCanBus()
        {
            uint status;

            status = MYCanReader.Connect();
            if (status == 1)
            {
                status = MYCanReader.StartCAN();
                if (status == 1)
                {
                    timer_rec.Enabled = true;
                    label_canbus_status.Text = "The CAN BUS Reader already start.";
                }
                else
                {
                    label_canbus_status.Text = "The CAN BUS Reader can't connect.";
                }
            }
            else
            {
                label_canbus_status.Text = "The CAN BUS Reader can't connect.";
            }

        }

        protected void ConnectKline()
        {
            string Kline_Exist = ini12.INIRead(Config_Path, "K_Line", "Exist", "");
            string curItem = ini12.INIRead(Config_Path, "K_Line", "PortName", "");

            if (Kline_Exist == "1" && curItem != "")
            {
                if (MySerialPort.OpenPort(curItem) == true)
                {
                    //BlueRat_UART_Exception_status = false;
                    tmr_FetchingUARTInput.Enabled = true;
                    label_Kline_status.Text = "The K-Line already connected.";
                }
                else
                {
                    tmr_FetchingUARTInput.Enabled = false;
                    label_Kline_status.Text = "The K-Line can't connect.";
                }
            }
        }

        private List<CheckBox> abs_lut = new List<CheckBox>();
        private List<CheckBox> obd_lut = new List<CheckBox>();
        private void Form_K_Line_Load()
        {
            // Generate abs_lut -- need to add CheckBox in sequence of byte/bit index from (0,0)
            abs_lut.Add(Kline_ABS_0x5055); //, ABS_DTC_Code.ECU_Control_unit_failure);
            abs_lut.Add(Kline_ABS_0x5019); //, ABS_DTC_Code.VR_Valve_Relay_Fault);
            abs_lut.Add(Kline_ABS_0x5017); //, ABS_DTC_Code.Valves_EV_Inlet_value_Failure_F);
            abs_lut.Add(Kline_ABS_0x5013); //, ABS_DTC_Code.Valves_EV_Inlet_value_Failure_R);
            abs_lut.Add(Kline_ABS_0x5018); //, ABS_DTC_Code.Valves_AV_Outlet_value_Failure_F);
            abs_lut.Add(Kline_ABS_0x5014); //, ABS_DTC_Code.Valves_AV_Outlet_value_Failure_R);
            abs_lut.Add(Kline_ABS_0x5053); //, ABS_DTC_Code.UZ_Batter_Voltage_fault_Over_Voltage);
            abs_lut.Add(Kline_ABS_0x5052); //, ABS_DTC_Code.UZ_Batter_Voltage_fault_Under_Voltage);
            // Byte (1,0)
            abs_lut.Add(Kline_ABS_0x5035); //, ABS_DTC_Code.RFP_Pump_Motor_Failure);
            abs_lut.Add(Kline_ABS_0x5043); //, ABS_DTC_Code.WSS_ohmic_WSS_ohmic_failure_F);
            abs_lut.Add(Kline_ABS_0x5045); //, ABS_DTC_Code.WSS_ohmic_WSS_ohmic_failure_R);
            abs_lut.Add(Kline_ABS_0x5042); //, ABS_DTC_Code.WSS_plausibility_failure_F);
            abs_lut.Add(Kline_ABS_0x5044); //, ABS_DTC_Code.WSS_plausibility_failure_R);
            abs_lut.Add(Kline_ABS_0x5025); //, ABS_DTC_Code.WSS_generic_failure);

            // Generate obd_lut -- need to add CheckBox in sequence of byte/bit index from (0,0)
            obd_lut.Add(Kline_OBD_P0503);
            obd_lut.Add(Kline_OBD_C0083);
            obd_lut.Add(Kline_OBD_C0085);
            obd_lut.Add(Kline_OBD_P0105);
            obd_lut.Add(Kline_OBD_P0110);
            obd_lut.Add(Kline_OBD_P0115);
            obd_lut.Add(Kline_OBD_P0120);
            obd_lut.Add(Kline_OBD_P0130);
            // Byte (1,0)
            obd_lut.Add(Kline_OBD_P0135);
            obd_lut.Add(Kline_OBD_P0150);
            obd_lut.Add(Kline_OBD_P0155);
            obd_lut.Add(Kline_OBD_P0201);
            obd_lut.Add(Kline_OBD_P0202);
            obd_lut.Add(Kline_OBD_P0217);
            obd_lut.Add(Kline_OBD_P0230);
            obd_lut.Add(Kline_OBD_P0335);
            // Byte (2,0)
            obd_lut.Add(Kline_OBD_P0336);
            obd_lut.Add(Kline_OBD_P0351);
            obd_lut.Add(Kline_OBD_P0352);
            obd_lut.Add(Kline_OBD_P0410);
            obd_lut.Add(Kline_OBD_P0480);
            obd_lut.Add(Kline_OBD_P0500);
            obd_lut.Add(Kline_OBD_P0501);
            obd_lut.Add(Kline_OBD_P0505);
            // Byte (3,0)
            obd_lut.Add(Kline_OBD_P0512);
            obd_lut.Add(Kline_OBD_P0560);
            obd_lut.Add(Kline_OBD_P0601);
            obd_lut.Add(Kline_OBD_P0604);
            obd_lut.Add(Kline_OBD_P0605);
            obd_lut.Add(Kline_OBD_P0606);
            obd_lut.Add(Kline_OBD_P0620_PIN2);
            obd_lut.Add(Kline_OBD_P0620_PIN31);
            // Byte (4,0)
            obd_lut.Add(Kline_OBD_P0650);
            obd_lut.Add(Kline_OBD_P0655);
            obd_lut.Add(Kline_OBD_P0A0F);
            obd_lut.Add(Kline_OBD_P1300);
            obd_lut.Add(Kline_OBD_P1310);
            obd_lut.Add(Kline_OBD_P1536);
            obd_lut.Add(Kline_OBD_P1607);
            obd_lut.Add(Kline_OBD_P1800);
            // Byte (5,0)
            obd_lut.Add(Kline_OBD_P2158);
            obd_lut.Add(Kline_OBD_P2600);
            obd_lut.Add(Kline_OBD_U0001);
            obd_lut.Add(Kline_OBD_U0002);
            obd_lut.Add(Kline_OBD_U0121);
            obd_lut.Add(Kline_OBD_U0122);
            obd_lut.Add(Kline_OBD_U0128);
            obd_lut.Add(Kline_OBD_U0140);
            // Byte (6,0)
            obd_lut.Add(Kline_OBD_U0426);
            obd_lut.Add(Kline_OBD_U0486);
        }

        //private bool First_Run = true;
        private byte Previous_Car_Indicator = 0;
        private uint Previous_Speed = 0;
        private uint Previous_RPM = 0;
        private uint Previous_Consumption = 0;
        private uint Previous_WaterTemp = 0;
        private int  Previous_Final_Room_temp = 0;
        private uint Previous_Fuel = 0;
        private uint Previous_Battery;
        private uint Previous_Mileage;
        private uint Previous_MaxSpeed = 0;
        private uint Previous_AveSpeed = 0;

        private bool FirstRun_Car_Indicator = true;
        private bool FirstRun_Speed = true;
        private bool FirstRun_RPM = true;
        private bool FirstRun_Consumption = true;
        private bool FirstRun_WaterTemp = true;
        private bool FirstRun_Room_Temp = true;
        private bool FirstRun_Fuel = true;
        private bool FirstRun_Battery = true;
        private bool FirstRun_Mileage = true;
        private bool FirstRun_MaxSpeed = true;
        private bool FirstRun_AveSpeed = true;

        private Color BGHighLightColor = System.Drawing.SystemColors.ActiveCaption;
        private Color BGNormalColor = System.Drawing.SystemColors.Control;
        private Color BGOutOfRange = System.Drawing.Color.OrangeRed;

        private const byte MASK_Status_OnOff = 0x01;
        private const byte MASK_Status_EngineOil = 0x02;
        private const byte MASK_Status_Fuel = 0x04;
        private const byte MASK_Status_ABS = 0x08;
        private const byte MASK_Status_WaterTemp = 0x10;
        private const byte MASK_Status_Maintenance = 0x20;
        private const byte MASK_Status_FrontTirePressure = 0x40;
        private const byte MASK_Status_RearTirePressure = 0x80;

        private const byte MASK_Status_Can_ABS_0x5055 = 0x01;
        private const byte MASK_Status_Can_ABS_0x5019 = 0x02;
        private const byte MASK_Status_Can_ABS_0x5017 = 0x04;
        private const byte MASK_Status_Can_ABS_0x5013 = 0x08;
        private const byte MASK_Status_Can_ABS_0x5018 = 0x10;
        private const byte MASK_Status_Can_ABS_0x5014 = 0x20;
        private const byte MASK_Status_Can_ABS_0x5053 = 0x40;
        private const byte MASK_Status_Can_ABS_0x5052 = 0x80;

        private const byte MASK_Status_Can_ABS_0x5035 = 0x01;
        private const byte MASK_Status_Can_ABS_0x5043 = 0x02;
        private const byte MASK_Status_Can_ABS_0x5045 = 0x04;
        private const byte MASK_Status_Can_ABS_0x5042 = 0x08;
        private const byte MASK_Status_Can_ABS_0x5044 = 0x10;
        private const byte MASK_Status_Can_ABS_0x5025 = 0x20;

        private const byte MASK_Status_Can_OBD_P0503 = 0x01;
        private const byte MASK_Status_Can_OBD_C0083 = 0x02;
        private const byte MASK_Status_Can_OBD_C0085 = 0x04;
        private const byte MASK_Status_Can_OBD_P0105 = 0x08;
        private const byte MASK_Status_Can_OBD_P0110 = 0x10;
        private const byte MASK_Status_Can_OBD_P0115 = 0x20;
        private const byte MASK_Status_Can_OBD_P0120 = 0x40;
        private const byte MASK_Status_Can_OBD_P0130 = 0x80;

        private const byte MASK_Status_Can_OBD_P0135 = 0x01;
        private const byte MASK_Status_Can_OBD_P0150 = 0x02;
        private const byte MASK_Status_Can_OBD_P0155 = 0x04;
        private const byte MASK_Status_Can_OBD_P0201 = 0x08;
        private const byte MASK_Status_Can_OBD_P0202 = 0x10;
        private const byte MASK_Status_Can_OBD_P0217 = 0x20;
        private const byte MASK_Status_Can_OBD_P0230 = 0x40;
        private const byte MASK_Status_Can_OBD_P0335 = 0x80;

        private const byte MASK_Status_Can_OBD_P0336 = 0x01;
        private const byte MASK_Status_Can_OBD_P0351 = 0x02;
        private const byte MASK_Status_Can_OBD_P0352 = 0x04;
        private const byte MASK_Status_Can_OBD_P0410 = 0x08;
        private const byte MASK_Status_Can_OBD_P0480 = 0x10;
        private const byte MASK_Status_Can_OBD_P0500 = 0x20;
        private const byte MASK_Status_Can_OBD_P0501 = 0x40;
        private const byte MASK_Status_Can_OBD_P0505 = 0x80;

        private const byte MASK_Status_Can_OBD_P0512 = 0x01;
        private const byte MASK_Status_Can_OBD_P0560 = 0x02;
        private const byte MASK_Status_Can_OBD_P0601 = 0x04;
        private const byte MASK_Status_Can_OBD_P0604 = 0x08;
        private const byte MASK_Status_Can_OBD_P0605 = 0x10;
        private const byte MASK_Status_Can_OBD_P0606 = 0x20;
        private const byte MASK_Status_Can_OBD_P0620_PIN2 = 0x40;
        private const byte MASK_Status_Can_OBD_P0620_PIN31 = 0x80;

        private const byte MASK_Status_Can_OBD_P0650 = 0x01;
        private const byte MASK_Status_Can_OBD_P0655 = 0x02;
        private const byte MASK_Status_Can_OBD_P0A0F = 0x04;
        private const byte MASK_Status_Can_OBD_P1300 = 0x08;
        private const byte MASK_Status_Can_OBD_P1310 = 0x10;
        private const byte MASK_Status_Can_OBD_P1536 = 0x20;
        private const byte MASK_Status_Can_OBD_P1607 = 0x40;
        private const byte MASK_Status_Can_OBD_P1800 = 0x80;

        private const byte MASK_Status_Can_OBD_P2158 = 0x01;
        private const byte MASK_Status_Can_OBD_P2600 = 0x02;
        private const byte MASK_Status_Can_OBD_U0001 = 0x04;
        private const byte MASK_Status_Can_OBD_U0002 = 0x08;
        private const byte MASK_Status_Can_OBD_U0121 = 0x10;
        private const byte MASK_Status_Can_OBD_U0122 = 0x20;
        private const byte MASK_Status_Can_OBD_U0128 = 0x40;
        private const byte MASK_Status_Can_OBD_U0140 = 0x80;

        private const byte MASK_Status_Can_OBD_U0426 = 0x01;
        private const byte MASK_Status_Can_OBD_U0486 = 0x02;

        private Color UpdateItemColor(ref bool FirstRunBit, ref uint Previous, uint Current)
        {
            Color ret_color;

            if (FirstRunBit == true)
            {
                ret_color = BGHighLightColor;
                FirstRunBit = false;
            }
            else
            {
                ret_color = (Previous != Current) ? BGHighLightColor : BGNormalColor;
            }
            Previous = Current;
            return ret_color;
        }

        private Color UpdateItemColor(ref bool FirstRunBit, ref int Previous, int Current)
        {
            Color ret_color;

            if (FirstRunBit == true)
            {
                ret_color = BGHighLightColor;
                FirstRunBit = false;
            }
            else
            {
                ret_color = (Previous != Current) ? BGHighLightColor : BGNormalColor;
            }
            Previous = Current;
            return ret_color;
        }

        private void CAN_Update_DashBoard(uint ID, uint DLC, byte[] DATA)
        {
            switch (ID)
            {
                case 0x1:       // CMD_A
                    if (DLC == 1)
                    {
                        Byte status = DATA[0];
                        Status_OnOff.Checked = ((status & 0x01) != 0) ? true : false;
                        Status_EngineOil.Checked = ((status & 0x02) != 0) ? true : false;
                        Status_Fuel.Checked = ((status & 0x04) != 0) ? true : false;
                        Status_ABS.Checked = ((status & 0x08) != 0) ? true : false;
                        Status_WaterTemp.Checked = ((status & 0x10) != 0) ? true : false;
                        Status_Maintenance.Checked = ((status & 0x20) != 0) ? true : false;
                        Status_FrontTirePressure.Checked = ((status & 0x40) != 0) ? true : false;
                        Status_RearTirePressure.Checked = ((status & 0x80) != 0) ? true : false;

                        if (FirstRun_Car_Indicator == true)
                        {
                            Status_OnOff.BackColor = BGHighLightColor;
                            Status_EngineOil.BackColor = BGHighLightColor;
                            Status_Fuel.BackColor = BGHighLightColor;
                            Status_ABS.BackColor = BGHighLightColor;
                            Status_WaterTemp.BackColor = BGHighLightColor;
                            Status_Maintenance.BackColor = BGHighLightColor;
                            Status_FrontTirePressure.BackColor = BGHighLightColor;
                            Status_RearTirePressure.BackColor = BGHighLightColor;
                            FirstRun_Car_Indicator = false;
                        }
                        else
                        {
                            // if changed, bit_a ^ bit_b != 0
                            byte comparsion = (byte)(Previous_Car_Indicator ^ status);
                            Status_OnOff.BackColor = ((comparsion & MASK_Status_OnOff) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_EngineOil.BackColor = ((comparsion & MASK_Status_EngineOil) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_Fuel.BackColor = ((comparsion  & MASK_Status_Fuel) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_ABS.BackColor = ((comparsion & MASK_Status_ABS) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_WaterTemp.BackColor = ((comparsion & MASK_Status_WaterTemp) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_Maintenance.BackColor = ((comparsion & MASK_Status_Maintenance) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_FrontTirePressure.BackColor = ((comparsion & MASK_Status_FrontTirePressure) != 0) ? BGHighLightColor : BGNormalColor;
                            Status_RearTirePressure.BackColor = ((comparsion & MASK_Status_RearTirePressure) != 0) ? BGHighLightColor : BGNormalColor;
                        }
                        Previous_Car_Indicator = status;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x2:       // CMD_B
                    if (DLC == 5)
                    {
                        // Speed
                        uint Speed = DATA[0];
                        if (Speed <= 180)  // 180?
                        {
                            Value_Speed.Text = Speed.ToString() + " km/h";
                            Label_Speed.BackColor = UpdateItemColor(ref FirstRun_Speed, ref Previous_Speed, Speed);
                        }
                        else
                        {
                            // Out of range
                            // Always warning in color if out of range
                            Value_Speed.Text = Speed.ToString() + " km/h";
                            FirstRun_Speed = false;
                            Label_Speed.BackColor = BGOutOfRange;
                            Previous_Speed = Speed;
                        }

                        // RPM
                        uint RPM = DATA[1];
                        RPM = RPM * 256 + DATA[2];
                        Value_EngineRPM.Text = RPM.ToString() + " RPM";
                        Label_EngineRPM.BackColor = UpdateItemColor(ref FirstRun_RPM, ref Previous_RPM, RPM);

                        // Consumption
                        uint Consumption = DATA[3];
                        Consumption = Consumption * 256 + DATA[4];
                        if ((Consumption == 0xfffe) || (Speed < 9))
                        {
                            Value_Speed.Text = "--.-km/L";
                            Value_Fuel_LPK.Text = "--.-L/100km";
                        }
                        else
                        {
                            float f_Consumption = ((float)Consumption) / 10;
                            Value_FuelConsumption.Text = f_Consumption.ToString() + " km/L";
                            if (f_Consumption >= 0)
                            {
                                float f_lpk_Consumption = 1 / f_Consumption * 100;
                                Value_Fuel_LPK.Text = String.Format("{0:0.00}", f_lpk_Consumption) + " L/100km";
                            }
                            else
                                Value_Fuel_LPK.Text = "0 L/100km";

                            Label_FuelConsumption.BackColor = UpdateItemColor(ref FirstRun_Consumption, ref Previous_Consumption, Consumption);
                        }
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x3:       // CMD_C
                    if (DLC == 5)
                    {
                        // Water Temp
                        uint WaterTemp = DATA[0];
                        if (WaterTemp <= 8)
                        {
                            Value_WaterTemp.Text = WaterTemp.ToString();
                        }
                        else
                        {
                            // Out of range
                        }
                        Label_WaterTemp.BackColor = UpdateItemColor(ref FirstRun_WaterTemp, ref Previous_WaterTemp, WaterTemp);

                        // Room Temperature
                        uint Temp_Sign_Value = DATA[1];
                        uint Room_Temp = DATA[2];
                        int Final_Room_temp;

                        if ((DATA[1] == 0xFF) && (DATA[2] == 0xFE))
                        {
                            Value_RoomTemp.Text = "-- C";
                        }

                        if (Temp_Sign_Value == 0)
                        {
                            Value_RoomTemp.Text = "+" + Room_Temp.ToString() + " C";
                            Final_Room_temp = (int)Room_Temp;
                            Label_RoomTemp.BackColor = UpdateItemColor(ref FirstRun_Room_Temp, ref Previous_Final_Room_temp, Final_Room_temp);
                        }
                        else if (Temp_Sign_Value == 1)
                        {
                            Value_RoomTemp.Text = "-" + Room_Temp.ToString() + " C";
                            Final_Room_temp = -((int)Room_Temp);
                            Label_RoomTemp.BackColor = UpdateItemColor(ref FirstRun_Room_Temp, ref Previous_Final_Room_temp, Final_Room_temp);
                        }
                        else
                        {
                            // Error data of Temp_Sign
                            FirstRun_Room_Temp = false;
                            Label_RoomTemp.BackColor = BGOutOfRange;
                            Previous_Final_Room_temp = 32767;
                        }

                        // Fuel
                        uint Fuel = DATA[3];
                        if (Fuel <= 160)
                        {
                            float f_Fuel;
                            f_Fuel = ((float)Fuel) / 10;
                            Value_Fuel.Text = f_Fuel.ToString() + "L";
                            Label_Fuel.BackColor = UpdateItemColor(ref FirstRun_Fuel, ref Previous_Fuel, Fuel);
                        }
                        else
                        {
                            // Error data of Fuel
                            FirstRun_Fuel = false;
                            Label_Fuel.BackColor = BGOutOfRange;
                            Previous_Fuel = Fuel;
                        }

                        // Battery
                        uint Battery = DATA[4];
                        float f_Battery;
                        f_Battery = ((float)Battery) / 10;
                        Value_Battery.Text = f_Battery.ToString() + "V";
                        Label_Battery.BackColor = UpdateItemColor(ref FirstRun_Battery, ref Previous_Battery, Battery);
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x4:       // CMD_D
                    if (DLC == 5)
                    {
                        // Mileage
                        uint Mileage = (((uint)DATA[0]) * 0x10000) + (((uint)DATA[1]) * 0x100) + DATA[2];
                        Value_TotalMileage.Text = Mileage.ToString() + " km";
                        Label_TotalMileage.BackColor = UpdateItemColor(ref FirstRun_Mileage, ref Previous_Mileage, Mileage);

                        // Max Speed
                        uint MaxSpeed = DATA[3];
                        Value_MaxSpeed.Text = ((MaxSpeed != 0xff) ? (MaxSpeed.ToString()) : ("--")) + " km/h";
                        Label_MaxSpeed.BackColor = UpdateItemColor(ref FirstRun_MaxSpeed, ref Previous_MaxSpeed, MaxSpeed);

                        // Average Speed
                        uint AveSpeed = DATA[4];
                        AveSpeed = DATA[4];
                        Value_AveSpeed.Text = ((AveSpeed != 0xff) ? (AveSpeed.ToString()) : ("--")) + " km/h";
                        Label_AveSpeed.BackColor = UpdateItemColor(ref FirstRun_AveSpeed, ref Previous_AveSpeed, AveSpeed);
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x5:       // CMD_E
                    if (DLC == 2)
                    {
                        Byte status = DATA[0];
                        Can_ABS_0x5055.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_ABS_0x5019.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_ABS_0x5017.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_ABS_0x5013.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_ABS_0x5018.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_ABS_0x5014.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_ABS_0x5053.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_ABS_0x5052.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[1];
                        Can_ABS_0x5035.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_ABS_0x5043.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_ABS_0x5045.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_ABS_0x5042.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_ABS_0x5044.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_ABS_0x5025.Checked = ((status & 0x20) != 0) ? true : false;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                case 0x6:       // CMD_F
                    if (DLC == 7)
                    {
                        Byte status = DATA[0];
                        Can_OBD_P0503.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_C0083.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_C0085.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_P0105.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_P0110.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_P0115.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_P0120.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_P0130.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[1];
                        Can_OBD_P0135.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_P0150.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_P0155.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_P0201.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_P0202.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_P0217.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_P0230.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_P0335.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[2];
                        Can_OBD_P0336.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_P0351.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_P0352.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_P0410.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_P0480.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_P0500.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_P0501.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_P0505.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[3];
                        Can_OBD_P0512.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_P0560.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_P0601.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_P0604.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_P0605.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_P0606.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_P0620_PIN2.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_P0620_PIN31.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[4];
                        Can_OBD_P0650.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_P0655.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_P0A0F.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_P1300.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_P1310.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_P1536.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_P1607.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_P1800.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[5];
                        Can_OBD_P2158.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_P2600.Checked = ((status & 0x02) != 0) ? true : false;
                        Can_OBD_U0001.Checked = ((status & 0x04) != 0) ? true : false;
                        Can_OBD_U0002.Checked = ((status & 0x08) != 0) ? true : false;
                        Can_OBD_U0121.Checked = ((status & 0x10) != 0) ? true : false;
                        Can_OBD_U0122.Checked = ((status & 0x20) != 0) ? true : false;
                        Can_OBD_U0128.Checked = ((status & 0x40) != 0) ? true : false;
                        Can_OBD_U0140.Checked = ((status & 0x80) != 0) ? true : false;
                        status = DATA[6];
                        Can_OBD_U0426.Checked = ((status & 0x01) != 0) ? true : false;
                        Can_OBD_U0486.Checked = ((status & 0x02) != 0) ? true : false;
                    }
                    else
                    {
                        // Error DLC
                    }
                    break;

                default:
                    break;
            }

        }

        unsafe private void timer_rec_Tick(object sender, EventArgs e)
        {
            UInt32 res = new UInt32();

            res = MYCanReader.ReceiveData();

            if (res >= CAN_Reader.MAX_CAN_OBJ_ARRAY_LEN)     // Must be something wrong
            {
                timer_rec.Enabled = false;
                MYCanReader.StopCAN();
                MYCanReader.Disconnect();

                label_canbus_status.Text = "The CAN BUS Reader can't connect.";

                return;
            }

            uint ID = 0, DLC = 0;
            const int DATA_LEN = 8;
            byte[] DATA = new byte[DATA_LEN];

            String str = "";
            string time = "";
            if (Directory.Exists(ini12.INIRead(Config_Path, "Config", "canbusLog", "")))
            {
                string Canbuslog = ini12.INIRead(Config_Path, "Config", "canbusLog", "") + "\\canbusLog.txt";
                StreamWriter sw = new StreamWriter(Canbuslog, true);
                for (UInt32 i = 0; i < res; i++)
                {
                    DateTime.Now.ToShortTimeString();
                    DateTime dt = DateTime.Now;
                    MYCanReader.GetOneCommand(i, out str, out ID, out DLC, out DATA);
                    CAN_Update_DashBoard(ID, DLC, DATA);
                    listBox_Info.Items.Add(str);
                    listBox_Info.SelectedIndex = listBox_Info.Items.Count - 1;
                    time = "[" + dt.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " + str;
                    sw.WriteLine(time);
                }
                sw.Close();
            }
            else
            {
                for (UInt32 i = 0; i < res; i++)
                {
                    MYCanReader.GetOneCommand(i, out str, out ID, out DLC, out DATA);
                    CAN_Update_DashBoard(ID, DLC, DATA);
                    listBox_Info.Items.Add(str);
                    listBox_Info.SelectedIndex = listBox_Info.Items.Count - 1;
                }
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

        private void Use_Fixed_DTC_from_HQ(KWP_2000_Process kwp2000)
        {
            // byte[] fixed_response_data_abs = { 0x04, 0x50, 0x43, 0xE0, 0x50, 0x45, 0xE0, 0x50, 0x52, 0xA0, 0x50, 0x53, 0xA0 };
            kwp2000.ABS_DTC_Queue_Add(0x50, 0x43, 0xE0);
            kwp2000.ABS_DTC_Queue_Add(0x50, 0x45, 0xE0);
            kwp2000.ABS_DTC_Queue_Add(0x50, 0x52, 0xA0);
            kwp2000.ABS_DTC_Queue_Add(0x50, 0x53, 0xA0);
            // byte[] fixed_response_data_obd = { 0x04, 0x01, 0x15, 0x61, 0x40, 0x85, 0x62, 0x02, 0x30, 0x62, 0xC4, 0x86, 0x62 };
            // P0115: 0x0115
            // C0085: 0x4085
            // P0230: 0x0230
            // U0486: 0xC486
            kwp2000.OBD_DTC_Queue_Add(0x01, 0x15, 0x61);
            kwp2000.OBD_DTC_Queue_Add(0x40, 0x85, 0x62);
            kwp2000.OBD_DTC_Queue_Add(0x02, 0x30, 0x62);
            kwp2000.OBD_DTC_Queue_Add(0xC4, 0x86, 0x62);
        }
        //
        private void Use_Random_DTC(KWP_2000_Process kwp2000)
        {
            Random rs = new Random();
            Byte DTC_no;
            DTC_no = (byte)(rs.Next(10));
            DTC_no = (byte)((DTC_no <= KWP_2000_Process.ReadABSDiagnosticCodesByStatus_MaxNumberOfDTC) ? DTC_no : 0);
            for (int no = 0; no < DTC_no; no++)
            {
                CMD_E_ABS_DTC random_dtc = ABS_DTC_Table.Find_ABS_DTC(rs.Next(ABS_DTC_Table.Count()));
                kwp2000.ABS_DTC_Queue_Add(random_dtc, (byte)kwp2000.dtc_status_table[rs.Next(kwp2000.dtc_status_table.Length)]);
            }
            // for OBD
            DTC_no = (byte)(rs.Next(10));
            DTC_no = (byte)((DTC_no <= KWP_2000_Process.ReadOBDDiagnosticCodesByStatus_MaxNumberOfDTC) ? DTC_no : 0);
            for (int no = 0; no < DTC_no; no++)
            {
                CMD_F_OBD_DTC random_dtc = OBD_DTC_Table.Find_OBD_DTC(rs.Next(OBD_DTC_Table.Count()));
                kwp2000.OBD_DTC_Queue_Add(random_dtc, (byte)kwp2000.dtc_status_table_for_obd[rs.Next(kwp2000.dtc_status_table_for_obd.Length)]);
            }
        }

        private void Scan_DTC_from_UI(KWP_2000_Process kwp2000)
        {
            // CheckBox lut of UI must be listed accroding to its byte/bit index.

            uint byte_bit_index;

            byte_bit_index = 0;
            foreach (var item in abs_lut)
            {
                if (item.Checked == true)
                {
                    // If CheckBox is checked, treat it as Lamp_ON_Failure_Set
                    kwp2000.ABS_DTC_Queue_Add(ABS_DTC_Table.Find_ABS_DTC((byte_bit_index / 8), (byte_bit_index % 8)), KWP_2000_Process.Lamp_ON_Failure_Set);
                }
                byte_bit_index++;
            }

            byte_bit_index = 0;
            foreach (var item in obd_lut)
            {
                if (item.Checked == true)
                {
                    // If CheckBox is checked, treat it as Lamp_ON_Failure_Set
                    kwp2000.OBD_DTC_Queue_Add(OBD_DTC_Table.Find_OBD_DTC((byte_bit_index / 8), (byte_bit_index % 8)), KWP_2000_Process.Lamp_ON_Failure_Set);
                }
                byte_bit_index++;
            }

        }

        private void tmr_FetchingUARTInput_Tick(object sender, EventArgs e)
        {
            // Regularly polling request message
            while (MySerialPort.KLineBlockMessageList.Count() > 0)
            {
                // Pop 1st KLine Block Message
                BlockMessage in_message = MySerialPort.KLineBlockMessageList[0];
                MySerialPort.KLineBlockMessageList.RemoveAt(0);

                // Display debug message on RichTextBox
                String raw_data_in_string = MySerialPort.KLineRawDataInStringList[0];
                MySerialPort.KLineRawDataInStringList.RemoveAt(0);
                DisplayKLineBlockMessage(rtbKLineData, "raw_input: " + raw_data_in_string);
                DisplayKLineBlockMessage(rtbKLineData, "In - " + in_message.GenerateDebugString());

                // Process input Kline message and generate output KLine message
                KWP_2000_Process kwp_2000_process = new KWP_2000_Process();
                BlockMessage out_message = new BlockMessage();

                //Use_Random_DTC(kwp_2000_process);  // Random Test
                //Use_Fixed_DTC_from_HQ(kwp_2000_process);  // Simulate response from a ECU device
                Scan_DTC_from_UI(kwp_2000_process);  // Scan Checkbox status and add DTC into queue

                // Generate output block message according to input message and DTC codes
                kwp_2000_process.ProcessMessage(in_message, ref out_message);

                // Convert output block message to List<byte> so that it can be sent via UART
                List<byte> output_data;
                out_message.GenerateSerialOutput(out output_data);

                // NOTE: because we will also receive all data sent by us, we need to tell UART to skip all data to be sent by SendToSerial
                MySerialPort.Add_ECU_Filtering_Data(output_data);
                MySerialPort.Enable_ECU_Filtering(true);
                // Send output KLine message via UART (after some delay)
                Thread.Sleep((KWP_2000_Process.min_delay_before_response - 1));
                MySerialPort.SendToSerial(output_data.ToArray());

                // Show output KLine message for debug purpose
                DisplayKLineBlockMessage(rtbKLineData, "Out - " + out_message.GenerateDebugString());
            }
        }

        private void DisplayKLineBlockMessage(RichTextBox rtb, String msg)
        {
            String current_time_str = DateTime.Now.ToString("[HH:mm:ss.fff] ");
            rtb.AppendText(current_time_str + msg + "\n");
            rtb.ScrollToCaret();
        }

        protected void Close_serialPort1()
        {
            SerialPort1.Dispose();
            SerialPort1.Close();
        }

        private void button_canbus_Click(object sender, EventArgs e)
        {
            CAN_Write CAN_Write = new CAN_Write();

            if (CAN_Write.ShowDialog() == DialogResult.OK)
            {

            }

            CAN_Write.Dispose();
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

        protected void Close_klineserialPort()
        {
            MySerialPort.ClosePort();
            MySerialPort.Dispose();
            label_Kline_status.Text = "The K-Line already disconnected.";
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

            if (MySerialPort.IsPortOpened() == true)
            {
                Close_klineserialPort();
            }

            if (MYCanReader.Connect() == 1)
            {
                timer_rec.Enabled = false;
                MYCanReader.StopCAN();
                MYCanReader.Disconnect();
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
                    USB_Device.USB_Read();
                    AutoKit_Initial_port();
                    Extend_Initial_port();
                    ConnectCanBus();
                    ConnectKline();
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

    public static class HexConverter
    {
        public static byte[] HexToByte(this string hexString)
        {
            //運算後的位元組長度:16進位數字字串長/2
            byte[] byteOUT = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i = i + 2)
            {
                //每2位16進位數字轉換為一個10進位整數
                byteOUT[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return byteOUT;
        }

        public static string BToHex(this byte[] Bdata)
        {
            return BitConverter.ToString(Bdata).Replace("-", "");
        }

        //取出字串右邊開始的指定數目字元
        public static string Right(this string str, int len)
        {
            return str.Substring(str.Length - len, len);
        }
        //取出字串右邊開始的指定數目字元(跳過幾個字元)
        public static string Right(this string str, int len, int skiplen)
        {
            return str.Substring(str.Length - len - skiplen, len);
        }
    }
}
