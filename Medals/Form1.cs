using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Medals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            USApanel.BackColor = Color.FromArgb(12, Color.Black);
            RussiaPanel.BackColor = Color.FromArgb(12, Color.Black);
            WinnerBox1.BackColor = Color.FromArgb(12, Color.Black);
            WinnerBox2.BackColor = Color.FromArgb(12, Color.Black);
            WinnerBox3.BackColor = Color.FromArgb(12, Color.Black);
            WinnerBox4.BackColor = Color.FromArgb(12, Color.Black);
            WinnerBox5.BackColor = Color.FromArgb(12, Color.Black);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBoxList.AddRange(new[] { WinnerBox1, WinnerBox2, WinnerBox3, WinnerBox4, WinnerBox5 });
        }

        OpenFileDialog ofd = new OpenFileDialog();
        List<PictureBox> pictureBoxList = new List<PictureBox>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                TextFieldParser parser = new TextFieldParser(ofd.FileName);
                parser.HasFieldsEnclosedInQuotes = false;
                parser.SetDelimiters(",");
                string[] line = { };
                List<string> lineList = new List<string>();
                while (!parser.EndOfData)
                {
                    line = parser.ReadFields();

                    foreach(string field in line)
                    {
                        lineList.Add(field);
                    }
                }
                parser.Close();
                for(int i = 0; i < lineList.Count; i++)
                {
                    if(lineList[i] == "")
                    {
                        lineList.RemoveAt(i);
                    }
                }
                populate_fields(lineList);
            }
        }

        private void populate_fields(List<string> lineList)
        {
            if(lineList[0] == "1")
            {
                USGold1.Text = lineList[1];
                USSilver1.Text = lineList[2];
                USBronze1.Text = lineList[3];
                RUGold1.Text = lineList[4];
                RUSilver1.Text = lineList[5];
                RUBronze1.Text = lineList[6];
            }
            else if(lineList[0] == "2")
            {
                USGold1.Text = lineList[1];
                USSilver1.Text = lineList[2];
                USBronze1.Text = lineList[3];
                RUGold1.Text = lineList[4];
                RUSilver1.Text = lineList[5];
                RUBronze1.Text = lineList[6];
                USGold2.Text = lineList[7];
                USSilver2.Text = lineList[8];
                USBronze2.Text = lineList[9];
                RUGold2.Text = lineList[10];
                RUSilver2.Text = lineList[11];
                RUBronze2.Text = lineList[12];
            }
            else if (lineList[0] == "3")
            {
                USGold1.Text = lineList[1];
                USSilver1.Text = lineList[2];
                USBronze1.Text = lineList[3];
                RUGold1.Text = lineList[4];
                RUSilver1.Text = lineList[5];
                RUBronze1.Text = lineList[6];
                USGold2.Text = lineList[7];
                USSilver2.Text = lineList[8];
                USBronze2.Text = lineList[9];
                RUGold2.Text = lineList[10];
                RUSilver2.Text = lineList[11];
                RUBronze2.Text = lineList[12];
                USGold3.Text = lineList[13];
                USSilver3.Text = lineList[14];
                USBronze3.Text = lineList[15];
                RUGold3.Text = lineList[16];
                RUSilver3.Text = lineList[17];
                RUBronze3.Text = lineList[18];
            }
            else if (lineList[0] == "4")
            {
                USGold1.Text = lineList[1];
                USSilver1.Text = lineList[2];
                USBronze1.Text = lineList[3];
                RUGold1.Text = lineList[4];
                RUSilver1.Text = lineList[5];
                RUBronze1.Text = lineList[6];
                USGold2.Text = lineList[7];
                USSilver2.Text = lineList[8];
                USBronze2.Text = lineList[9];
                RUGold2.Text = lineList[10];
                RUSilver2.Text = lineList[11];
                RUBronze2.Text = lineList[12];
                USGold3.Text = lineList[13];
                USSilver3.Text = lineList[14];
                USBronze3.Text = lineList[15];
                RUGold3.Text = lineList[16];
                RUSilver3.Text = lineList[17];
                RUBronze3.Text = lineList[18];
                USGold4.Text = lineList[19];
                USSilver4.Text = lineList[20];
                USBronze4.Text = lineList[21];
                RUGold4.Text = lineList[22];
                RUSilver4.Text = lineList[23];
                RUBronze4.Text = lineList[24];
            }
            else if(lineList[0] == "5")
            {
                USGold1.Text = lineList[1];
                USSilver1.Text = lineList[2];
                USBronze1.Text = lineList[3];
                RUGold1.Text = lineList[4];
                RUSilver1.Text = lineList[5];
                RUBronze1.Text = lineList[6];
                USGold2.Text = lineList[7];
                USSilver2.Text = lineList[8];
                USBronze2.Text = lineList[9];
                RUGold2.Text = lineList[10];
                RUSilver2.Text = lineList[11];
                RUBronze2.Text = lineList[12];
                USGold3.Text = lineList[13];
                USSilver3.Text = lineList[14];
                USBronze3.Text = lineList[15];
                RUGold3.Text = lineList[16];
                RUSilver3.Text = lineList[17];
                RUBronze3.Text = lineList[18];
                USGold4.Text = lineList[19];
                USSilver4.Text = lineList[20];
                USBronze4.Text = lineList[21];
                RUGold4.Text = lineList[22];
                RUSilver4.Text = lineList[23];
                RUBronze4.Text = lineList[24];
                USGold5.Text = lineList[25];
                USSilver5.Text = lineList[26];
                USBronze5.Text = lineList[27];
                RUGold5.Text = lineList[28];
                RUSilver5.Text = lineList[29];
                RUBronze5.Text = lineList[30];
            }
            else
            {
                MessageBox.Show("MAX OF 5 ROWS");
            }

            print_Winner(lineList);

        }

        private void calculate_Winner(List<string> lineList)
        {
            int tempUSA = 0;
            int tempRUS = 0;
            int winnerBoxIndex = 0;
            for (int i = 1; i < lineList.Count; i+=6)
            {
                tempUSA = Int32.Parse(lineList[i]) + Int32.Parse(lineList[i + 1]) + Int32.Parse(lineList[i + 2]);
                tempRUS = Int32.Parse(lineList[i + 3]) + Int32.Parse(lineList[i + 4]) + Int32.Parse(lineList[i + 5]);
                PictureBox winnerBox = pictureBoxList[winnerBoxIndex];
                winnerBoxIndex++;
                if (tempUSA > tempRUS)
                {
                    winnerBox.Image = Image.FromFile("C:\\Users\\ryang\\Desktop\\Windows Program\\Assignment3\\USFlag.png");
                    winnerBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Console.WriteLine("USA wins by count");
                }
                else
                {
                    winnerBox.Image = Image.FromFile("C:\\Users\\ryang\\Desktop\\Windows Program\\Assignment3\\RussiaFlag.png");
                    winnerBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Console.WriteLine("Russia wins by count");
                }

                if (Int32.Parse(lineList[i]) > Int32.Parse(lineList[i + 3]))
                {
                    Console.WriteLine("USA wins by color");
                }
                else if (Int32.Parse(lineList[i]) < Int32.Parse(lineList[i + 3]))
                {
                    Console.WriteLine("Russia wins by color");
                }
                else if (Int32.Parse(lineList[i]) == Int32.Parse(lineList[i + 3]))
                {
                    if (Int32.Parse(lineList[i + 1]) > Int32.Parse(lineList[i + 4]))
                    {
                        Console.WriteLine("USA wins by color");
                    }
                    else if (Int32.Parse(lineList[i + 1]) < Int32.Parse(lineList[i + 4]))
                    {
                        Console.WriteLine("Russia wins by color");
                    }
                    else if (Int32.Parse(lineList[i + 1]) == Int32.Parse(lineList[i + 4]))
                    {
                        if (Int32.Parse(lineList[i + 2]) > Int32.Parse(lineList[i + 5]))
                        {
                            Console.WriteLine("USA wins by color");
                        }
                        else if (Int32.Parse(lineList[i + 2]) < Int32.Parse(lineList[i + 5]))
                        {
                            Console.WriteLine("Russia wins by color");
                        }
                        else if (Int32.Parse(lineList[i + 2]) == Int32.Parse(lineList[i + 5]))
                        {
                            Console.WriteLine("It is a tie by color");
                        }
                    }
                }
            }
        }

        private void print_Winner(List<string> lineList)
        {
            if (lineList[0] == "1")
            {
                calculate_Winner(lineList);
                for (int i = 1; i < lineList.Count; i += 6)
                {
                    Console.WriteLine("USA Scores: " + lineList[i] + " " + lineList[i + 1] + " " + lineList[i + 2] + "  Russia Scores: " + lineList[i + 3] + " " + lineList[i + 4] + " " + lineList[i + 5]);
                }
                Console.WriteLine("-----------------------------------------------");
            }
            else if (lineList[0] == "2")
            {
                calculate_Winner(lineList);
                for (int i = 1; i < lineList.Count; i += 6)
                {
                    Console.WriteLine("USA Scores: " + lineList[i] + " " + lineList[i + 1] + " " + lineList[i + 2] + "  Russia Scores: " + lineList[i + 3] + " " + lineList[i + 4] + " " + lineList[i + 5]);
                }
                Console.WriteLine("-----------------------------------------------");
            }
            else if (lineList[0] == "3")
            {
                calculate_Winner(lineList);
                for (int i = 1; i < lineList.Count; i += 6)
                {
                    Console.WriteLine("USA Scores: " + lineList[i] + " " + lineList[i + 1] + " " + lineList[i + 2] + "  Russia Scores: " + lineList[i + 3] + " " + lineList[i + 4] + " " + lineList[i + 5]);
                }
                Console.WriteLine("-----------------------------------------------");
            }
            else if (lineList[0] == "4")
            {
                calculate_Winner(lineList);
                for (int i = 1; i < lineList.Count; i += 6)
                {
                    Console.WriteLine("USA Scores: " + lineList[i] + " " + lineList[i + 1] + " " + lineList[i + 2] + "  Russia Scores: " + lineList[i + 3] + " " + lineList[i + 4] + " " + lineList[i + 5]);
                }
                Console.WriteLine("-----------------------------------------------");
            }
            else if (lineList[0] == "5")
            {
                calculate_Winner(lineList);
                for(int i = 1; i < lineList.Count; i+=6)
                {
                    Console.WriteLine("USA Scores: " + lineList[i] + " " + lineList[i + 1] + " " + lineList[i + 2] + "  Russia Scores: " + lineList[i + 3] + " " + lineList[i + 4] + " " + lineList[i + 5]);
                }
                Console.WriteLine("-----------------------------------------------");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USGold1.ResetText();
            USSilver1.ResetText();
            USBronze1.ResetText();
            RUGold1.ResetText();
            RUSilver1.ResetText();
            RUBronze1.ResetText();
            USGold2.ResetText();
            USSilver2.ResetText();
            USBronze2.ResetText();
            RUGold2.ResetText();
            RUSilver2.ResetText();
            RUBronze2.ResetText();
            USGold3.ResetText();
            USSilver3.ResetText();
            USBronze3.ResetText();
            RUGold3.ResetText();
            RUSilver3.ResetText();
            RUBronze3.ResetText();
            USGold4.ResetText();
            USSilver4.ResetText();
            USBronze4.ResetText();
            RUGold4.ResetText();
            RUSilver4.ResetText();
            RUBronze4.ResetText();
            USGold5.ResetText();
            USSilver5.ResetText();
            USBronze5.ResetText();
            RUGold5.ResetText();
            RUSilver5.ResetText();
            RUBronze5.ResetText();
            WinnerBox1.Image = null;
            WinnerBox2.Image = null;
            WinnerBox3.Image = null;
            WinnerBox4.Image = null;
            WinnerBox5.Image = null;
        }
    }
}
