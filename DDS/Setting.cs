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

namespace DDS
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
            textBox_csv_script.Text = ini12.INIRead(Config_Path, "Config", "scriptFile", "");
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
    }
}
