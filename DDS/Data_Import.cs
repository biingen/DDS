using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jini;
using System.Threading;
using Can_Reader_Lib;

namespace DDS
{
    public struct Canbus_Icon
    {
        public string control_Name;
        public uint ID;
        public UInt32 Initial;
        public UInt32 Min;
        public UInt32 Max;
        public UInt32 Gain;
        public int start_Position;
        public int address_Length;
        public string remark_Min;
        public string remark_Max;
    }

    public struct Canbus_Text
    {
        public string control_Name;
        public uint ID;
        public UInt32 Initial;
        public UInt32 Min;
        public UInt32 Max;
        public UInt32 Gain;
        public int start_Position;
        public int address_Length;
        public string remark;
    }

    public struct Canbus_oneBar
    {
        public string control_Name;
        public uint ID;
        public UInt32 Initial;
        public UInt32 Min;
        public UInt32 Max;
        public UInt32 Gain;
        public int start_Position;
        public int address_Length;
        public string remark;
    }

    public partial class Data_Import : Form
    {
        private string Config_Path = Application.StartupPath + "\\Config.ini";
        private int Location_X = 25, Location_Y = 50;
        UInt64 Can_ID100 = Convert.ToUInt64(~0UL), Can_ID200 = Convert.ToUInt64(~0UL);
        List<Canbus_Icon> canbus_icon_list = new List<Canbus_Icon>();
        List<Canbus_Text> canbus_text_list = new List<Canbus_Text>();
        List<Canbus_oneBar> canbus_onebar_list = new List<Canbus_oneBar>();

        System.Windows.Forms.Button[] Canbus_icon_on_button;
        System.Windows.Forms.Button[] Canbus_icon_off_button;
        System.Windows.Forms.Label[] Canbus_icon_remark;

        System.Windows.Forms.HScrollBar[] Canbus_oneBar_hscorllbar;
        System.Windows.Forms.TextBox[] Canbus_oneBar_textbox;

        System.Windows.Forms.TextBox[] Canbus_text_textbox;
        System.Windows.Forms.Label[] Canbus_text_remark;

        private CAN_Reader MYCanReader = new CAN_Reader();

        public Data_Import()
        {
            InitializeComponent();
        }

        private void Data_Import_Load(object sender, EventArgs e)
        {
            string SchedulePath = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
            ReadValues(SchedulePath);
            Canbus_icon_Create(canbus_icon_list.Count);
            Canbus_text_Create(canbus_text_list.Count);
            Canbus_oneBar_Create(canbus_onebar_list.Count);
        }

        private void WriteValues()
        {
            using (var writer = new CsvFileWriter("WriteTest.csv"))
            {
                // Write each row of data
                for (int row = 0; row < 100; row++)
                {
                    // TODO: Populate column values for this row
                    List<string> columns = new List<string>();
                    writer.WriteRow(columns);
                }
            }
        }

        private void ReadValues(string Schedule)
        {
            List<string> columns = new List<string>();
            Canbus_Icon canbus_icon = new Canbus_Icon();
            Canbus_Text canbus_text = new Canbus_Text();
            Canbus_oneBar canbus_onebar = new Canbus_oneBar();

            using (var reader = new CsvFileReader(Schedule))
            {
                while (reader.ReadRow(columns))
                {
                    // TODO: Do something with columns' values
                    switch (columns[0])
                    {
                        case "GPIO":

                            break;
                        case "PWM":

                            break;
                        case "CANBUS":
                            switch (columns[2])
                            {
                                case "Icon":
                                    canbus_icon.control_Name = columns[3];
                                    canbus_icon.ID = Convert.ToUInt32(columns[4]);
                                    canbus_icon.Initial = Convert.ToUInt32(columns[5]);
                                    canbus_icon.Min = Convert.ToUInt32(columns[6]);
                                    canbus_icon.Max = Convert.ToUInt32(columns[7]);
                                    if (Convert.ToDouble(columns[8]) < 1)
                                        canbus_icon.Gain = (UInt16)(1 / Convert.ToDouble(columns[8]));
                                    else
                                        canbus_icon.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_icon.start_Position = Convert.ToInt32(columns[9]);
                                    canbus_icon.address_Length = Convert.ToInt32(columns[10]);
                                    canbus_icon.remark_Min = columns[11];
                                    canbus_icon.remark_Max = columns[12];
                                    canbus_icon_list.Add(canbus_icon);
                                    break;
                                case "Text":
                                    canbus_text.control_Name = columns[3];
                                    canbus_text.ID = Convert.ToUInt32(columns[4]);
                                    canbus_text.Initial = Convert.ToUInt32(columns[5]);
                                    canbus_text.Min = Convert.ToUInt32(columns[6]);
                                    canbus_text.Max = Convert.ToUInt32(columns[7]);
                                    if (Convert.ToDouble(columns[8]) < 1)
                                        canbus_text.Gain = (UInt16)(1 / Convert.ToDouble(columns[8]));
                                    else
                                        canbus_text.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_text.start_Position = Convert.ToInt32(columns[9]);
                                    canbus_text.address_Length = Convert.ToInt32(columns[10]);
                                    canbus_text.remark = columns[13];
                                    canbus_text_list.Add(canbus_text);
                                    break;
                                case "oneBar":
                                    canbus_onebar.control_Name = columns[3];
                                    canbus_onebar.ID = Convert.ToUInt32(columns[4]);
                                    canbus_onebar.Initial = Convert.ToUInt32(columns[5]);
                                    canbus_onebar.Min = Convert.ToUInt32(columns[6]);
                                    canbus_onebar.Max = Convert.ToUInt32(columns[7]);
                                    if (Convert.ToDouble(columns[8]) < 1)
                                        canbus_onebar.Gain = (UInt16)(1 / Convert.ToDouble(columns[8]));
                                    else
                                        canbus_onebar.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_onebar.start_Position = Convert.ToInt32(columns[9]);
                                    canbus_onebar.address_Length = Convert.ToInt32(columns[10]);
                                    canbus_onebar.remark = columns[13];
                                    canbus_onebar_list.Add(canbus_onebar);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Canbus_icon_Create(int count)
        {
            System.Windows.Forms.Label[] Canbus_icon_label;

            Canbus_icon_label = new Label[count];
            Canbus_icon_on_button = new Button[count];
            Canbus_icon_off_button = new Button[count];
            Canbus_icon_remark = new Label[count];
            for (int index = 0; index < count; index++)
            {
                Canbus_icon_label[index] = new Label();
                Canbus_icon_label[index].Name = "Canbus_icon_label_" + index;
                Canbus_icon_label[index].Text = canbus_icon_list[index].control_Name;
                Canbus_icon_label[index].Size = new Size(150, 30);
                Canbus_icon_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                Canbus_icon_on_button[index] = new Button();
                Canbus_icon_on_button[index].Name = "Canbus_icon_on_button_" + index;
                Canbus_icon_on_button[index].Text = canbus_icon_list[index].Max.ToString();
                Canbus_icon_on_button[index].Size = new Size(60, 30);
                Canbus_icon_on_button[index].Location = new System.Drawing.Point(Location_X + 140, Location_Y + index * 30);
                Canbus_icon_on_button[index].Click += new EventHandler(this.Canbus_icon_on_button_Click);
                Canbus_icon_off_button[index] = new Button();
                Canbus_icon_off_button[index].Name = "Canbus_icon_off_button_" + index;
                Canbus_icon_off_button[index].Text = canbus_icon_list[index].Min.ToString();
                Canbus_icon_off_button[index].Size = new Size(60, 30);
                Canbus_icon_off_button[index].Click += new EventHandler(this.Canbus_icon_off_button_Click);
                Canbus_icon_off_button[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                Canbus_icon_remark[index] = new Label();
                Canbus_icon_remark[index].Name = "Canbus_icon_remark_" + index;
                if (canbus_icon_list[index].Initial.ToString() == "1" && canbus_icon_list[index].Max.ToString() == "1")
                {
                    Canbus_icon_on_button[index].Enabled = false;
                    Canbus_icon_off_button[index].Enabled = true;
                    Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Max.ToString();
                }
                else if (canbus_icon_list[index].Initial.ToString() == "1" && canbus_icon_list[index].Max.ToString() == "0")
                {
                    Canbus_icon_on_button[index].Enabled = true;
                    Canbus_icon_off_button[index].Enabled = false;
                    Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Min.ToString();
                }
                else if (canbus_icon_list[index].Initial.ToString() == "0" && canbus_icon_list[index].Max.ToString() == "1")
                {
                    Canbus_icon_on_button[index].Enabled = true;
                    Canbus_icon_off_button[index].Enabled = false;
                    Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Min.ToString();
                }
                else if (canbus_icon_list[index].Initial.ToString() == "0" && canbus_icon_list[index].Max.ToString() == "1")
                {
                    Canbus_icon_on_button[index].Enabled = false;
                    Canbus_icon_off_button[index].Enabled = true;
                    Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Max.ToString();
                }
                Canbus_icon_remark[index].Size = new Size(250, 30);
                Canbus_icon_remark[index].Location = new System.Drawing.Point(Location_X + 260, Location_Y + index * 30);
                this.Controls.AddRange(Canbus_icon_off_button);
                this.Controls.AddRange(Canbus_icon_on_button);
                this.Controls.AddRange(Canbus_icon_remark);
                this.Controls.AddRange(Canbus_icon_label);
                Canbus_Control("Icon", index, canbus_icon_list[index].Initial);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void Canbus_text_Create(int count)
        {
            System.Windows.Forms.Label[] Canbus_text_label;

            Canbus_text_label = new Label[count];
            Canbus_text_textbox = new TextBox[count];
            Canbus_text_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                Canbus_text_label[index] = new Label();
                Canbus_text_label[index].Name = "Canbus_text_" + index;
                Canbus_text_label[index].Text = canbus_text_list[index].control_Name;
                Canbus_text_label[index].Size = new Size(150, 30);
                Canbus_text_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                Canbus_text_textbox[index] = new TextBox();
                Canbus_text_textbox[index].Name = "Canbus_text_" + index;
                Canbus_text_textbox[index].Text = canbus_text_list[index].Initial.ToString();
                Canbus_text_textbox[index].Size = new Size(60, 30);
                Canbus_text_textbox[index].Location = new System.Drawing.Point(Location_X + 150, Location_Y + index * 30);
                Canbus_text_textbox[index].TextChanged += new System.EventHandler(this.Canbus_text_textbox_TextChanged);
                Canbus_text_remark[index] = new Label();
                Canbus_text_remark[index].Name = "Canbus_text_" + index;
                Canbus_text_remark[index].Text = Convert.ToInt32(Canbus_text_textbox[index].Text).ToString("X");
                Canbus_text_remark[index].Size = new Size(60, 30);
                Canbus_text_remark[index].Location = new System.Drawing.Point(Location_X + 210, Location_Y + index * 30);
                this.Controls.AddRange(Canbus_text_label);
                this.Controls.AddRange(Canbus_text_textbox);
                this.Controls.AddRange(Canbus_text_remark);
                Canbus_Control("Text", index, canbus_text_list[index].Initial);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        private void Canbus_oneBar_Create(int count)
        {
            System.Windows.Forms.Label[] Canbus_oneBar_label;
            System.Windows.Forms.Label[] Canbus_oneBar_remark;

            Canbus_oneBar_label = new Label[count];
            Canbus_oneBar_hscorllbar = new HScrollBar[count];
            Canbus_oneBar_textbox = new TextBox[count];
            Canbus_oneBar_remark = new Label[count];

            for (int index = 0; index < count; index++)
            {
                Canbus_oneBar_label[index] = new Label();
                Canbus_oneBar_label[index].Name = "Canbus_oneBar_label_" + index;
                Canbus_oneBar_label[index].Text = canbus_onebar_list[index].control_Name;
                Canbus_oneBar_label[index].Size = new Size(200, 30);
                Canbus_oneBar_label[index].Location = new System.Drawing.Point(Location_X, Location_Y + index * 30);
                Canbus_oneBar_hscorllbar[index] = new HScrollBar();
                Canbus_oneBar_hscorllbar[index].Name = "Canbus_oneBar_hscorllbar_" + index;
                Canbus_oneBar_hscorllbar[index].Text = canbus_onebar_list[index].control_Name;
                Canbus_oneBar_hscorllbar[index].Size = new Size(150, 30);
                Canbus_oneBar_hscorllbar[index].Location = new System.Drawing.Point(Location_X + 200, Location_Y + index * 30);
                Canbus_oneBar_hscorllbar[index].Minimum = (int)canbus_onebar_list[index].Min;
                Canbus_oneBar_hscorllbar[index].Maximum = (int)canbus_onebar_list[index].Max;
                Canbus_oneBar_hscorllbar[index].LargeChange = (int)canbus_onebar_list[index].Gain;
                Canbus_oneBar_hscorllbar[index].Value = (int)canbus_onebar_list[index].Initial;
                Canbus_oneBar_hscorllbar[index].ValueChanged += new EventHandler(this.Canbus_oneBar_hscorllbar_ValueChanged);
                Canbus_oneBar_textbox[index] = new TextBox();
                Canbus_oneBar_textbox[index].Name = "Canbus_oneBar_textbox_" + index;
                Canbus_oneBar_textbox[index].Text = Convert.ToString(Canbus_oneBar_hscorllbar[index].Value);
                Canbus_oneBar_textbox[index].Size = new Size(60, 30);
                Canbus_oneBar_textbox[index].Location = new System.Drawing.Point(Location_X + 350, Location_Y + index * 30);
                Canbus_oneBar_remark[index] = new Label();
                Canbus_oneBar_remark[index].Name = "Canbus_oneBar_remark" + index;
                Canbus_oneBar_remark[index].Text = canbus_onebar_list[index].remark;
                Canbus_oneBar_remark[index].Size = new Size(200, 30);
                Canbus_oneBar_remark[index].Location = new System.Drawing.Point(Location_X + 410, Location_Y + index * 30);
                this.Controls.AddRange(Canbus_oneBar_remark);
                this.Controls.AddRange(Canbus_oneBar_textbox);
                this.Controls.AddRange(Canbus_oneBar_hscorllbar);
                this.Controls.AddRange(Canbus_oneBar_label);
                Canbus_Control("oneBar", index, canbus_onebar_list[index].Initial);
                Thread.Sleep(50);
            }
            Location_Y = Location_Y + (count * 30);
        }

        void Canbus_icon_on_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("Canbus_icon_on_button_", ""));
            Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Max;
            Canbus_icon_on_button[index].Enabled = false;
            Canbus_icon_off_button[index].Enabled = true;
            Canbus_Control("Icon", index, canbus_icon_list[index].Max);
            Thread.Sleep(50);
        }

        void Canbus_icon_off_button_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((Button)(sender)).Name.ToString().Replace("Canbus_icon_off_button_", ""));
            Canbus_icon_remark[index].Text = canbus_icon_list[index].remark_Min;
            Canbus_icon_on_button[index].Enabled = true;
            Canbus_icon_off_button[index].Enabled = false;
            Canbus_Control("Icon", index, canbus_icon_list[index].Min);
            Thread.Sleep(50);
        }

        void Canbus_text_textbox_TextChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((TextBox)(sender)).Name.ToString().Replace("Canbus_text_", ""));
            if (Canbus_text_textbox[index].Text != "")
            {
                Canbus_text_remark[index].Text = Convert.ToUInt32(Canbus_text_textbox[index].Text).ToString("X");
                Canbus_Control("Text", index, (UInt64)Convert.ToDouble(Canbus_text_textbox[index].Text));
            }
            Thread.Sleep(50);
        }

        void Canbus_oneBar_hscorllbar_ValueChanged(object sender, EventArgs e)
        {
            int index = int.Parse(((HScrollBar)(sender)).Name.ToString().Replace("Canbus_oneBar_hscorllbar_", ""));
            Canbus_oneBar_textbox[index].Text = Convert.ToString(Canbus_oneBar_hscorllbar[index].Value);
            Canbus_Control("oneBar", index, (UInt64)(Canbus_oneBar_textbox[index].Text);
            Thread.Sleep(50);
        }

        private void Canbus_Control(string type, int index, uint value)
        {
            UInt64 data_value, data_min, data_max;
            UInt32 can_id, can_unit;
            int data_pos, data_len;
            string data_remark_min, data_remark_max, data_remark;

            switch (type)
            {
                case "Icon":
                    can_id = Convert.ToUInt32(canbus_icon_list[index].ID.ToString(), 16);
                    data_pos = canbus_icon_list[index].start_Position;
                    data_len = canbus_icon_list[index].address_Length;
                    can_unit = canbus_icon_list[index].Gain;
                    data_min = canbus_icon_list[index].Min;
                    data_max = canbus_icon_list[index].Max;
                    data_remark_min = canbus_icon_list[index].remark_Min;
                    data_remark_max = canbus_icon_list[index].remark_Max;
                    // Process user input value
                    if (Convert.ToUInt64(value) >= data_min && Convert.ToUInt64(value) <= data_max)
                    {
                        data_value = (UInt64)(Convert.ToDouble(value) * can_unit);

                        switch (Convert.ToString(can_id, 16))
                        {
                            case "100":
                                Can_ID100 = CAN_Write.Update_value(Can_ID100, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID100);
                                break;
                            case "200":
                                Can_ID200 = CAN_Write.Update_value(Can_ID200, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID200);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "Text":
                    can_id = Convert.ToUInt32(canbus_text_list[index].ID.ToString(), 16);
                    data_pos = canbus_text_list[index].start_Position;
                    data_len = canbus_text_list[index].address_Length;
                    can_unit = canbus_text_list[index].Gain;
                    data_min = canbus_text_list[index].Min;
                    data_max = canbus_text_list[index].Max;
                    data_remark = canbus_text_list[index].remark;
                    // Process user input value
                    if (Convert.ToUInt64(value) >= data_min && Convert.ToUInt64(value) <= data_max)
                    {
                        data_value = (UInt64)(Convert.ToDouble(value) * can_unit);

                        switch (Convert.ToString(can_id, 16))
                        {
                            case "100":
                                Can_ID100 = CAN_Write.Update_value(Can_ID100, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID100);
                                break;
                            case "200":
                                Can_ID200 = CAN_Write.Update_value(Can_ID200, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID200);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "oneBar":
                    can_id = Convert.ToUInt32(canbus_onebar_list[index].ID.ToString(), 16);
                    data_pos = canbus_onebar_list[index].start_Position;
                    data_len = canbus_onebar_list[index].address_Length;
                    can_unit = canbus_onebar_list[index].Gain;
                    data_min = canbus_onebar_list[index].Min;
                    data_max = canbus_onebar_list[index].Max;
                    data_remark = canbus_onebar_list[index].remark;
                    // Process user input value
                    if (Convert.ToUInt64(value) >= data_min && Convert.ToUInt64(value) <= data_max)
                    {
                        data_value = (UInt64)(Convert.ToDouble(value) * can_unit);

                        switch (Convert.ToString(can_id, 16))
                        {
                            case "100":
                                Can_ID100 = CAN_Write.Update_value(Can_ID100, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID100);
                                break;
                            case "200":
                                Can_ID200 = CAN_Write.Update_value(Can_ID200, data_value, data_min, data_max, data_pos, data_len);
                                MYCanReader.TransmitData(can_id, Can_ID200);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
