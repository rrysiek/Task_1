using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class MemoryGame : Form
    {
        #region variable settings
        //Settings
        public string str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, str16, str17, str18, str19, str20;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string str18a, str18b, str18c, str18d, str18e, str18f, str10a, str20a;
        private string sFileMark = "", strFileData = "", strMod = "", strCam = "", strCEMdes = "", strCEMdes2 = "", strCEMdat = "", strCEMkm = "", sDatDos = "", sCarCol = "";
        #endregion

        public MemoryGame()
        {
            InitializeComponent();

            //sFileMark = Path.Combine(@"..\", "Words.txt");
            //sFileMark = Path.Combine(@"~\App_Data", "Words.txt");



            try
            {
                //sFileMark = Path.Combine(@"Task_1.exe");
                sFileMark = Path.Combine("Words.txt");

                //if (System.IO.File.Exists(sFileMark))
                if (System.IO.File.Exists(sFileMark))
                {
                    lConf_OK.Text = "OK " + sFileMark;
                    using (StreamReader sr = new StreamReader(sFileMark))
                    {
                        strFileData = sr.ReadToEnd();
                        if (strFileData != "")
                        {
                            //sql = "update kkf_dealer_data_agenda set workers = '" + strFileData + "' where ID_dealer = '" + strFullUData + "'";
                            tBFileData.Text = strFileData + "' where ID_dealer = '" + sFileMark + "'";
                            //SqlCommand cmd = new SqlCommand(sql, conn);
                            //string r = Convert.ToString(cmd.ExecuteNonQuery());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("No valid data");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data read from the Words.txt file
            //try
            //{
            //    sFileMark = Path.Combine(@"..\", "Words.txt");
            //sFileMark = Path.Combine(@"~~\App_Data", "Words.txt");

            //sFileMark = Path.Combine(@"Task_1.exe");
            sFileMark = Path.Combine("Words.txt");

            //if (System.IO.File.Exists(sFileMark))
             if (System.IO.File.Exists(sFileMark))
                {
                    lConf_OK.Text = "OK" + sFileMark;
                    using (StreamReader sr = new StreamReader(sFileMark))
                    {
                        strFileData = sr.ReadToEnd();
                        if (strFileData != "")
                        {
                        //sql = "update kkf_dealer_data_agenda set workers = '" + strFileData + "' where ID_dealer = '" + strFullUData + "'";
                            tBFileData.Text = "update dortech_admin.kkf_dealer_data_agenda set workers = '" + strFileData + "' where ID_dealer = '" + sFileMark + "'";
                            //SqlCommand cmd = new SqlCommand(sql, conn);
                            //string r = Convert.ToString(cmd.ExecuteNonQuery());
                        }
                    }
                }

                ////Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader("C:\\Sample.txt");
                ////Read the first line of text
                //line = sr.ReadLine();
                ////Continue to read until you reach end of file
                //while (line != null)
                //{
                //    //write the line to console window
                //    Console.WriteLine(line);
                //    //Read the next line
                //    line = sr.ReadLine();
                //}
                ////close the file
                //sr.Close();
                //Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Exception: ");
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}


            /*
            StreamReader reader = new StreamReader(winDir + "\\system.ini");
            try
            {
                do
                {
                    addListItem(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch
            {
                addListItem("File is empty");
            }
            finally
            {
                reader.Close();
            }
            */

            //using (StreamReader sr = new StreamReader(strAgendaData))
            //{
            //    strFileData = sr.ReadToEnd();
            //    if (strFileData != "")
            //    {
            //        //sql = "update kkf_dealer_data_agenda set workers = '" + strFileData + "' where ID_dealer = '" + strFullUData + "'";
            //        string sql = "update dortech_admin.kkf_dealer_data_agenda set workers = '" + strFileData + "' where ID_dealer = '" + strIDname + "'";
            //        SqlCommand cmd = new SqlCommand(sql, conn);
            //        string r = Convert.ToString(cmd.ExecuteNonQuery());
            //    }
            //}

        }
    }
}
