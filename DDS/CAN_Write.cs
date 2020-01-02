using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS
{
    public partial class CAN_Write : Form
    {
        public CAN_Write()
        {
            InitializeComponent();
        }

        static public UInt64 Update_value(UInt64 before_value, UInt64 data_value, UInt64 data_min, 
            UInt64 data_max, int data_pos, int data_len)
        {
            UInt64 data_mask = ~0UL;

            // Generate data mask
            data_mask <<= data_len;
            data_mask = ~data_mask;
            data_mask <<= data_pos;

            // Clear data field
            before_value &= ~data_mask;

            // Check data range then set data field
            data_value = (data_value > data_max) ? data_max : data_value;
            data_value = (data_value < data_min) ? data_min : data_value;
            data_value <<= data_pos;
            before_value |= (data_value);

            return before_value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UInt64 Engine1_message_after_value, Engine1_message_before_value;
            UInt64 gear_engaged, vehicle_speed;

            Engine1_message_before_value = Convert.ToUInt64(Before_value.Text,16);

            // Process user input value
            gear_engaged = (UInt64)(Convert.ToDouble(Gear_engaged.Text)*1);
            vehicle_speed = (UInt64)(Convert.ToDouble(Vehicle_speed.Text)*4);

            // Insert values into corresponding fields
            Engine1_message_after_value = Update_value(Engine1_message_before_value, gear_engaged, 0x0, 0xf, 60, 4);
            Engine1_message_after_value = Update_value(Engine1_message_after_value, vehicle_speed, 0x0, 0xfff, 48, 12);
            After_value.Text = Engine1_message_after_value.ToString("X"); 
        }
    }
}
