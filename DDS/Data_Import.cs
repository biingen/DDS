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
        public UInt32 start_Address;
        public UInt32 address_Length;
    }

    public struct Canbus_Text
    {
        public string control_Name;
        public uint ID;
        public UInt32 Initial;
        public UInt32 Min;
        public UInt32 Max;
        public UInt32 Gain;
        public UInt32 start_Address;
        public UInt32 address_Length;
    }

    public struct Canbus_oneBar
    {
        public string control_Name;
        public uint ID;
        public UInt32 Initial;
        public UInt32 Min;
        public UInt32 Max;
        public UInt32 Gain;
        public UInt32 start_Address;
        public UInt32 address_Length;
    }

    public partial class Data_Import : Form
    {
        private string Config_Path = Application.StartupPath + "\\Config.ini";
        private int Location_X = 25, Location_Y = 50;
        UInt64 Can_ID100 = Convert.ToUInt64(~0UL), Can_ID200 = Convert.ToUInt64(~0UL);

        public Data_Import()
        {
            InitializeComponent();
        }

        private void Data_Import_Load(object sender, EventArgs e)
        {
            string SchedulePath = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
            List<string> Script = ReadValues(SchedulePath);

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

        private List<string> ReadValues(string Schedule)
        {
            List<string> columns = new List<string>();
            List<Canbus_Icon> canbus_icon_list = new List<Canbus_Icon>();
            List<Canbus_Text> canbus_text_list = new List<Canbus_Text>();
            List<Canbus_oneBar> canbus_onebar_list = new List<Canbus_oneBar>();
            Canbus_Icon canbus_icon = new Canbus_Icon();
            Canbus_Text canbus_text = new Canbus_Text();
            Canbus_oneBar canbus_onebar = new Canbus_oneBar();

            using (var reader = new CsvFileReader(Schedule))
            {
                while (reader.ReadRow(columns))
                {
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
                                    canbus_icon.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_icon.start_Address = Convert.ToUInt32(columns[9]);
                                    canbus_icon.start_Address = Convert.ToUInt32(columns[10]);
                                    canbus_icon_list.Add(canbus_icon);
                                    break;
                                case "Text":
                                    canbus_text.control_Name = columns[3];
                                    canbus_text.ID = Convert.ToUInt32(columns[4]);
                                    canbus_text.Initial = Convert.ToUInt32(columns[5]);
                                    canbus_text.Min = Convert.ToUInt32(columns[6]);
                                    canbus_text.Max = Convert.ToUInt32(columns[7]);
                                    canbus_text.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_text.start_Address = Convert.ToUInt32(columns[9]);
                                    canbus_text.start_Address = Convert.ToUInt32(columns[10]);
                                    canbus_text_list.Add(canbus_text);
                                    break;
                                case "oneBar":
                                    canbus_onebar.control_Name = columns[3];
                                    canbus_onebar.ID = Convert.ToUInt32(columns[4]);
                                    canbus_onebar.Initial = Convert.ToUInt32(columns[5]);
                                    canbus_onebar.Min = Convert.ToUInt32(columns[6]);
                                    canbus_onebar.Max = Convert.ToUInt32(columns[7]);
                                    canbus_onebar.Gain = Convert.ToUInt32(columns[8]);
                                    canbus_onebar.start_Address = Convert.ToUInt32(columns[9]);
                                    canbus_onebar.start_Address = Convert.ToUInt32(columns[10]);
                                    canbus_onebar_list.Add(canbus_onebar);
                                    break;
                                default:
                                    throw new InvalidOperationException("unknown item type");
                            }
                            break;
                        default:
                            throw new InvalidOperationException("unknown item type");
                    }
                    // TODO: Do something with columns' values
                }
            }
            return columns;
        }
    }
}
