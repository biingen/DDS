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

namespace Venus
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
            comboBox5.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            comboBox8.DataSource = System.IO.Ports.SerialPort.GetPortNames();

            if (ini12.INIRead(Config_Path, "serialPort1", "Exist", "") == "1")
            {
                checkBox1.Checked = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }

            if (ini12.INIRead(Config_Path, "serialPort2", "Exist", "") == "1")
            {
                checkBox2.Checked = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                checkBox2.Checked = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
            }

            if (ini12.INIRead(Config_Path, "serialPort3", "Exist", "") == "1")
            {
                checkBox3.Checked = true;
                comboBox7.Enabled = true;
                comboBox8.Enabled = true;
                comboBox9.Enabled = true;
            }
            else
            {
                checkBox3.Checked = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
            }

            comboBox1.Text = ini12.INIRead(Config_Path, "serialPort1", "Type", "");
            comboBox2.Text = ini12.INIRead(Config_Path, "serialPort1", "PortName", "");
            comboBox3.Text = ini12.INIRead(Config_Path, "serialPort1", "BaudRate", "");
            comboBox4.Text = ini12.INIRead(Config_Path, "serialPort2", "BaudRate", "");
            comboBox5.Text = ini12.INIRead(Config_Path, "serialPort2", "PortName", "");
            comboBox6.Text = ini12.INIRead(Config_Path, "serialPort2", "Type", "");
            comboBox7.Text = ini12.INIRead(Config_Path, "serialPort3", "BaudRate", "");
            comboBox8.Text = ini12.INIRead(Config_Path, "serialPort3", "PortName", "");
            comboBox9.Text = ini12.INIRead(Config_Path, "serialPort3", "Type", "");

            textBox_csv_script.Text = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
            textBox_log_folder.Text = ini12.INIRead(Config_Path, "Config", "canbusLog", "");
            if (ini12.INIRead(Config_Path, "AutoKit", "Exist", "") == "1")
                label10.Text = "AutoKit connnected to " + ini12.INIRead(Config_Path, "AutoKit", "PortName", "") + ".";
            else
                label10.Text = "AutoKit can't connected.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Exist", "1");
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Exist", "0");
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                ini12.INIWrite(Config_Path, "serialPort2", "Exist", "1");
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                ini12.INIWrite(Config_Path, "serialPort2", "Exist", "0");
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                ini12.INIWrite(Config_Path, "serialPort3", "Exist", "1");
                comboBox7.Enabled = true;
                comboBox8.Enabled = true;
                comboBox9.Enabled = true;
            }
            else
            {
                ini12.INIWrite(Config_Path, "serialPort3", "Exist", "0");
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != comboBox6.Text.Trim() && comboBox1.Text.Trim() != comboBox9.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort1", "Type", comboBox1.Text.Trim());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ini12.INIRead(Config_Path, "AutoKit", "PortName", "") != comboBox2.Text.Trim() && comboBox2.Text.Trim() != comboBox5.Text.Trim() && comboBox2.Text.Trim() != comboBox8.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort1", "PortName", comboBox2.Text.Trim());
            }
            else
            {
                label11.Text = "serialPort1 portname can't save to config.";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Config_Path, "serialPort1", "BaudRate", comboBox3.Text.Trim());
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != comboBox6.Text.Trim() && comboBox6.Text.Trim() != comboBox9.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort2", "Type", comboBox6.Text.Trim());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ini12.INIRead(Config_Path, "AutoKit", "PortName", "") != comboBox5.Text.Trim() && comboBox2.Text.Trim() != comboBox5.Text.Trim() && comboBox5.Text.Trim() != comboBox8.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort2", "PortName", comboBox5.Text.Trim());
                label11.Text = "serialPort2 portname already save.";
            }
            else
            {
                label11.Text = "serialPort2 portname can't save to config.";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Config_Path, "serialPort2", "BaudRate", comboBox4.Text.Trim());
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != comboBox9.Text.Trim() && comboBox6.Text.Trim() != comboBox9.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort3", "Type", comboBox9.Text.Trim());
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ini12.INIRead(Config_Path, "AutoKit", "PortName", "") != comboBox8.Text.Trim() && comboBox2.Text.Trim() != comboBox8.Text.Trim() && comboBox5.Text.Trim() != comboBox8.Text.Trim())
            {
                ini12.INIWrite(Config_Path, "serialPort3", "PortName", comboBox8.Text.Trim());
                label11.Text = "serialPort3 portname already save.";
            }
            else
            {
                label11.Text = "serialPort3 portname can't save to config.";
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(Config_Path, "serialPort3", "BaudRate", comboBox7.Text.Trim());
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

        private void button_log_folder_Click(object sender, EventArgs e)
        {
            //Save Video Path
            folderBrowserDialog_canbuslog.ShowDialog();
            if (folderBrowserDialog_canbuslog.SelectedPath == "")
            {
                textBox_log_folder.Text = textBox_log_folder.Text;
            }
            else
            {
                textBox_log_folder.Text = folderBrowserDialog_canbuslog.SelectedPath;
            }
        }

        private void textBox_log_folder_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_log_folder.Text.Trim()) == true)
            {
                ini12.INIWrite(Config_Path, "Config", "Canbuslog", textBox_log_folder.Text.Trim());
            }
        }
    }
}
