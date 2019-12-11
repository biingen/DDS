using ClosedXML.Excel;  //tools Install
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PSC
{
    public partial class Log_Analysis : Form
    {
        public Log_Analysis()
        {
            InitializeComponent();
        }

        private void button_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.FileName = "Select a text file";
            path.InitialDirectory = @".\Log\";
            path.Filter = "Text files (*.txt)|*.txt";
            path.Title = "Open text file";
            path.ShowDialog();
            this.textBox_Path.Text = path.FileName;
        }
        // File path and name
        string docPath = string.Empty;
        string fileName = string.Empty;
        string txtFileName = string.Empty;

        string command = string.Empty;
        string hexNoSpace = string.Empty;
        string Time = string.Empty;
        string Item = string.Empty;

        string response = string.Empty;
        string CMD = string.Empty;
        string hexAdd = string.Empty;
        string OSDstatus = string.Empty;
        string CMDNAKResponse = string.Empty;
        string hexAddID = string.Empty;
        string hexAddCMD = string.Empty;
        string hexAddErroecode = string.Empty;

        string resultColumn = string.Empty;


        bool commandIsFound = false;
        bool CMDreadIsFound = false;
        bool CMDwriteIsFound = false;

        List<string> commandList = new List<string>();
        List<string> responseList = new List<string>();
        List<string> TimeList = new List<string>();
        List<string> ItemList = new List<string>();

        //Raw data for log
        string line = string.Empty;

        private void button_Generate_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())     //create Excel file
            {
                var worksheet = workbook.Worksheets.Add("Test report");

                //Style
                worksheet.Style.Font.FontSize = 12;
                worksheet.Column(2).Width = 10;
                worksheet.Column(3).Width = 35;
                worksheet.Column(4).Width = 10;
                worksheet.Column(5).Width = 35;
                worksheet.Column(6).Width = 35;
                worksheet.Column(7).Width = 35;

                // Headers
                worksheet.Cells("B2").Value = "CMD";  //W or R
                worksheet.Cells("C2").Value = "Item";  //Fuction
                worksheet.Cells("D2").Value = "Time";  //Fuction time
                worksheet.Cells("E2").Value = "Command";
                worksheet.Cells("F2").Value = "Reply string";
                worksheet.Cells("G2").Value = "Result";  // pass or failed

                // Format for headers
                var header = worksheet.Range("B2:G2");
                header.Style.Font.Bold = true;
                header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                header.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                header.Style.Fill.BackgroundColor = XLColor.CadetBlue;
                worksheet.Row(2).Height = 24;

                try
                {
                    if (textBox_Path.Text != "")
                    {
                        //~~~~~~~~~~Read log file~~~~~~~~~~~~~
                        List<string> readContent = new List<string>(); //For saving every line 
                        StreamReader sr = new StreamReader(textBox_Path.Text);
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            if (!string.IsNullOrEmpty(line))
                            {
                                readContent.Add(line);
                            }
                        }
                        sr.Close();

                        //Location of test result files 
                        docPath = textBox_Path.Text;
                        //fileName = string.Format("TestResult_{0}", Path.GetFileName(docPath).Substring(Path.GetFileName(docPath).IndexOf("_") + 1, 14));
                        //txtFileName = fileName + ".txt";
                        //StreamWriter sw = new StreamWriter(Path.Combine(Path.GetDirectoryName(docPath), txtFileName));

                        //foreach (var content in readContent.Select((value, index) => new { value, index }))
                        int commandCount = 0;
                        int count = 0;
                        int Receivecount = 0;
                        var CMDColumn = worksheet.Cell(commandCount + 2, 2);
                        var ItemColumn = worksheet.Cell(commandCount + 2, 3);
                        var TimeColumn = worksheet.Cell(commandCount + 2, 4);
                        var commandColumn = worksheet.Cell(commandCount + 2, 5);
                        var commandColumn1 = worksheet.Cell(commandCount + 2, 6);
                        var resultColumn = worksheet.Cell(commandCount + 2, 7);

                        foreach (string content in readContent)
                        {
                            count++;
                            //Get schedule from log
                            if (content.Contains("Schedule"))
                            {
                                //-------------------Command----------------
                                string[] scheduleSplit = content.Split(',');  //使用逗號做字元分割
                                command = scheduleSplit[6].Trim();   //選取逗號分割的第6個字元
                                hexNoSpace = scheduleSplit[6].Replace(" ", "");  //字串去空格
                                commandList.Add(hexNoSpace);   //第6個字串加到LIST                           
                                commandCount = commandList.Count;  //字串數量
                                commandColumn = worksheet.Cell(commandCount + 2, 5);

                                //-------------------CMD----------------
                                CMD = hexNoSpace.Substring(2, 2);  //2字開始取2個字
                                Console.WriteLine("=========CMD: " + CMD + "=============");

                                //-------------------Item----------------
                                Item = scheduleSplit[9].Trim();
                                ItemList.Add(Item);
                                ItemColumn = worksheet.Cell(commandCount + 2, 3);
                                ItemColumn.Value = Item;

                                //-------------------TIME----------------
                                Time = scheduleSplit[8].Trim();
                                TimeList.Add(Time);
                                TimeColumn = worksheet.Cell(commandCount + 2, 4);
                                TimeColumn.Value = Time;

                                //-------------------W or R----------------
                                if (CMD == "06") //W
                                {
                                    Console.WriteLine("============= W =============");
                                    CMDColumn = worksheet.Cell(commandCount + 2, 2);
                                    CMDColumn.Value = "W";
                                    CMDwriteIsFound = true;
                                }
                                else if (CMD == "03")  //R
                                {
                                    Console.WriteLine("============= R =============");
                                    CMDColumn = worksheet.Cell(commandCount + 2, 2);
                                    CMDColumn.Value = "R";
                                    CMDreadIsFound = true;
                                }

                                Console.WriteLine("=========Command: " + hexNoSpace + "=============");

                                // Write schedule command column for Excel
                                commandColumn.Value = hexNoSpace;
                                commandIsFound = true;  //如果有找到Schedule
                                //-------------------NO RESPONSE----------------
                                if (commandIsFound == true)
                                {
                                    commandColumn1 = worksheet.Cell(commandCount + 2, 6);
                                    resultColumn = worksheet.Cell(commandCount + 2, 7);
                                    Console.WriteLine("========= NO RESPONSE =============");
                                    commandColumn1.Value = "No response";
                                    resultColumn.Value = "FAILED";
                                    resultColumn.Style.Fill.BackgroundColor = XLColor.Red;
                                }
                                //-------------------- LAST LINENO RESPONSE----------------
                                if (count == readContent.Count)
                                {
                                    commandColumn1 = worksheet.Cell(commandCount + 2, 6);
                                    resultColumn = worksheet.Cell(commandCount + 2, 7);
                                    Console.WriteLine("========= NO RESPONSE - LAST LINE =============");
                                    commandColumn1.Value = "No response - Last line";
                                    resultColumn.Value = "FAILED";
                                    resultColumn.Style.Fill.BackgroundColor = XLColor.Red;
                                }
                            }
                            //Get Receive from log
                            else if (content.Contains("Receive_Port"))
                            {
                                Receivecount++;
                                string[] scheduleSplit = content.Split(new string[] { "]  " }, StringSplitOptions.None);



                                hexAdd = hexAdd + response;

                                commandColumn1 = worksheet.Cell(commandCount + 2, 6);
                                resultColumn = worksheet.Cell(commandCount + 2, 7);

                                if (commandIsFound == true && hexAdd.Length == 16)
                                {
                                    Console.WriteLine("=========Response: " + hexAdd + "=============");
                                    // Write Receive log column for Excel
                                    commandColumn1.Value = hexAdd;

                                    //============= W Judge ============
                                    if (CMDwriteIsFound == true)
                                    {

                                        if (hexNoSpace == hexAdd)
                                        {
                                            Console.WriteLine("PASS");

                                            //Write result into excel
                                            resultColumn.Value = "PASS";
                                            resultColumn.Style.Fill.BackgroundColor = XLColor.Green;
                                            hexAdd = "";  //Receive hex清空
                                            commandIsFound = false;
                                            CMDwriteIsFound = false;
                                        }
                                        else if (hexNoSpace != hexAdd)
                                        {
                                            Console.WriteLine("FAILED");

                                            //Write result into excel
                                            resultColumn.Value = "FAILED";
                                            resultColumn.Style.Fill.BackgroundColor = XLColor.Red;
                                            hexAdd = "";
                                            commandIsFound = false;
                                            CMDwriteIsFound = false;
                                        }

                                    }

                                    //============= R Judge ============
                                    else if (CMDreadIsFound == true)
                                    {
                                        hexAdd = hexNoSpace.Substring(8, 4);  //6字開始取4個字
                                        Console.WriteLine(hexAdd);
                                        //十六進位轉十進位
                                        Console.WriteLine(Convert.ToInt32(hexAdd, 16));

                                        resultColumn.Value = Convert.ToInt32(hexAdd, 16);
                                        resultColumn.Style.Fill.BackgroundColor = XLColor.BabyBlue;
                                        hexAdd = "";  //Receive hex清空
                                        commandIsFound = false;
                                    }
                                }


                                else if (commandIsFound == true && hexAdd.Length == 10)
                                {
                                    hexAddID = hexAdd.Substring(0, 2);  //第0字開始取2個字 Monitor ID
                                    hexAddCMD = hexAdd.Substring(2, 2);  //第2字開始取2個字 CMD
                                    byte[] InputBuffer = new byte[2];
                                    byte[] OutputBuffer = new byte[2];
                                    InputBuffer[0] = Convert.ToByte(hexAddID, 16);
                                    InputBuffer[1] = Convert.ToByte(hexAddCMD, 16);
                                    for (int i = 0; i < 2; i++)
                                    {
                                        OutputBuffer[i] = InputBuffer[i];   //輸入把至轉出陣列
                                    }
                                    //============= Error code ============
                                    if ((OutputBuffer[1] == 0x83) || (OutputBuffer[1] == 0x86) || (OutputBuffer[1] == 0x90))

                                    {
                                        Console.WriteLine("=========hexAddFour Response: " + OutputBuffer[1] + "=============");
                                        hexAddErroecode = hexAdd.Substring(0, 10);  //第0字開始取2個字 Error code
                                        Console.WriteLine("=========Errorcode: " + hexAddErroecode + "=============");

                                        // Write Receive log column for Excel
                                        commandColumn1.Value = hexAddErroecode;

                                        //Write result into excel
                                        resultColumn.Value = "Error Code";
                                        resultColumn.Style.Fill.BackgroundColor = XLColor.Red;
                                        Console.WriteLine("1)     {0}", hexAdd.Remove(0, 10));
                                        hexAdd = hexAdd.Remove(0, 10);
                                        commandIsFound = false;
                                        CMDwriteIsFound = false;

                                    }
                                }
                            }
                        }
                        workbook.SaveAs(Path.GetDirectoryName(docPath) + "\\" + Path.GetFileNameWithoutExtension(docPath) + ".xlsx");
                        workbook.Dispose();
                        worksheet = null;
                        MessageBox.Show("Report is generated.", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Please select file", "Error");
                    }
                }
                catch (IOException)  //excel is open
                {

                    MessageBox.Show("File is in use!!!", "Error");
                }
            }
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
