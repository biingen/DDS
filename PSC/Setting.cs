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
using System.IO;
using System.Threading;

namespace PSC
{
    public partial class Setting : Form
    {
        private string Config_Path = Application.StartupPath + "\\Config.ini";

        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            textBox_csv_script.Text = ini12.INIRead(Config_Path, "Config", "scriptFile", "");

            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1")
            {
                checkBox1.Checked = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }

            comboBox2.Text = ini12.INIRead(Config_Path, "serialPort1", "PortName", "");
            comboBox3.Text = ini12.INIRead(Config_Path, "serialPort1", "BaudRate", "");
        }

        private void button_csv_script_Click(object sender, EventArgs e)
        {
            OpenFileDialog_CSV.Filter = "CSV files (*.csv)|*.CSV";
            OpenFileDialog_CSV.ShowDialog();
            if (OpenFileDialog_CSV.FileName == "CSV_Open")
                textBox_csv_script.Text = textBox_csv_script.Text;
            else
                textBox_csv_script.Text = OpenFileDialog_CSV.FileName;
        }

        private void textBox_csv_script_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBox_csv_script.Text.Trim()) == true)
            {
                ini12.INIWrite(Config_Path, "Config", "scriptFile", textBox_csv_script.Text.Trim());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Exist", "1");
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Exist", "0");
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Config_Path, "serialPort1", "PortName", comboBox2.Text.Trim());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Config_Path, "serialPort1", "BaudRate", comboBox3.Text.Trim());
        }
    }
}
