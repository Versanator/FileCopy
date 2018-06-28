using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Form_Testing
{
    public partial class Form1 : Form
    {
        //string destPath = (@"C:\Users\asutphin\Desktop\Copy_Temp");



        public Form1()
        {
            InitializeComponent();
            ToolTip textBoxTip = new ToolTip();
            //  ToolTip Tip = new ToolTip();
            //  ToolTip textBoxTip = new ToolTip();
            //  ToolTip textBoxTip = new ToolTip();
            textBoxTip.SetToolTip(this.textBox1, "All characters typed here will be used to search for files\n" +
                "with the search term anywhere in their name.\n" +
                "Ex: \"PERF\" will copy all of the following files: ADC_PERF1.txt, PERFORMANCE.csv, PERF_REAL_SPURS.");
            label2.Hide();
            labelFilesFound.Hide();
            Label4.Hide();
            progressBar1.Hide();

            if (checkBoxAllFolders.Checked)
            {
                textBoxFolderNameFilter.Clear();
                textBoxFolderNameFilter.ReadOnly = true;
            }
            else
                textBoxFolderNameFilter.ReadOnly = false;
        }
        public string GetDateTime()
        {
            DateTime d = DateTime.Now;
            string k = d.ToString();
            return k;
        }



        public void FileFind()
        {


            
            string originPath = (textBoxSouce.Text);
            string destPath = (textBoxDest.Text);


            string[] temp = null;
            string[] temp2 = null;
            int fileCount = 0;
            
           
            
            try
            {   //Initial Board level directories
                var watch = Stopwatch.StartNew();
                string[] boardDirs = Directory.GetDirectories(originPath, "*");

                if (boardDirs.Length > 0)
                {

                    temp2 = GetDir(boardDirs);
                    //creating directory tree in the destination and coppying wanted files over.

                    if (textBox1.Text != "" && !checkBoxAllFiles.Checked)
                    {
                        temp = Directory.GetFiles(originPath, "*" + textBox1.Text + "*");
                        fileCount = temp.Length;
                        if (fileCount > 0)
                            CopyFiles(originPath, destPath, temp, fileCount);
                    }
                    else if (checkBoxAllFiles.Checked)
                    {
                        temp = Directory.GetFiles(originPath, "*");
                        fileCount = temp.Length;
                        if (fileCount > 0)
                            CopyFiles(originPath, destPath, temp, fileCount);
                    }
                    fileCount = temp.Length;
                    labelFilesFound.Text = fileCount.ToString();
                    



                    for (int i = 0; i < temp2.Length; i++)
                    {
                        Directory.CreateDirectory(destPath + temp2[i].Substring(originPath.Length));
                        if (textBox1.Text != "" && !checkBoxAllFiles.Checked)
                        {
                            temp = Directory.GetFiles(temp2[i], "*" + textBox1.Text + "*");
                        }
                        else if(checkBoxAllFiles.Checked)
                        {
                            temp = Directory.GetFiles(temp2[i], "*");


                        }

                        fileCount = temp2.Length;
                        labelFilesFound.Text = fileCount.ToString();
                        CopyFiles(originPath, destPath, temp, fileCount);



                    }
                }
                
                else
                {
                    // temp = Directory.GetFiles(originPath);
                    if (textBox1.Text != "" && !checkBoxAllFiles.Checked)
                    {
                        temp = Directory.GetFiles(originPath, "*" + textBox1.Text + "*");
                    }
                    else if (checkBoxAllFiles.Checked)
                    {
                        temp = Directory.GetFiles(originPath, "*");
                    }
                    fileCount = temp.Length;
                    labelFilesFound.Text = fileCount.ToString();
                    CopyFiles(originPath, destPath, temp, fileCount);
                    
                }
                
                watch.Stop();
                var elapsed = watch.Elapsed;

                label1.Text = "Process Finished";
                richTextBox1.AppendText("\n\t\tExicution Time(HH:MM:SS):" + elapsed.ToString() + "\n");
                richTextBox1.ScrollToCaret();

            }
            catch (Exception e)
            {
                label1.Text = "The proccess Failed.";
                richTextBox1.Text = e.ToString() + "/n";
            }
        }


        public string[] GetDir(string[] boardDirs)
        {
            string[] temp = null;
            string[] temp2 = boardDirs;
            
            List<string> FilePath = new List<string>();
            int count = 0;
            do
            {

                //geting one level deeper
                for (int i = 0; i < temp2.Length; i++)
                {
                    if(checkBoxAllFolders.Checked)
                    {
                        temp = Directory.GetDirectories(temp2[i], "*");
                    }
                    else
                    {
                        temp = Directory.GetDirectories(temp2[i], "*" + textBoxFolderNameFilter.Text + "*");
                    }

                    if (temp.Length != 0)
                    {
                        for (int k = 0; k < temp.Length; k++)
                        {
                            //appending to a list to keep from overwriting.
                            FilePath.Add(temp[k]);
                        }
                    }
                    else
                    {
                        FilePath.Add(temp2[i]);
                    }
                }
                //moving the list into a temp array to be used to get down one more level.
                temp2 = FilePath.ToArray();
                //clearing list for use in next loop
                FilePath.Clear();
                count++;
            } while (count < 4);
            
            if (temp2.Length < 1)
                return boardDirs;
            else
                return temp2;

        }

        public void CopyFiles(string originPath, string destPath, string[] temp, int fileCount)
        {
            int fileCoppied = 0;

            foreach (string a in temp)
            {
                if (File.Exists(a))
                {
                    
                    File.Copy(a, destPath + a.Substring(originPath.Length), true);
                    fileCoppied++;
                    richTextBox1.AppendText(a.Substring(originPath.Length) + "\n");
                    richTextBox1.Update();
                    richTextBox1.ScrollToCaret();
          //          progressBar1.Value = (fileCoppied / fileCount) * 100;
                  //  Thread.Sleep(10);
                   // progressBar1.Update();
                   // Thread.Sleep(10);
                }
            }
            //label3.Text = fileCoppied.ToString();
           // label3.Update();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Update();
            label3.Text = "";
            if (textBox1.Text != ""  && textBoxSouce.Text != "" && textBoxDest.Text != "" || checkBoxAllFiles.Checked)
            {
                label1.Text = "Started file Find and Transfer";
                label1.Update();
                FileFind();
            }
            else
            {
                label1.Focus();
                SystemSounds.Beep.Play();
            }


        }

    
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
           
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog2.Description = "Select Source Folder";
            folderBrowserDialog2.ShowDialog();
            textBoxSouce.Text = folderBrowserDialog2.SelectedPath;          
        }

        private void buttonDest_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Destination Folder";
            folderBrowserDialog1.ShowDialog();
            textBoxDest.Text = folderBrowserDialog1.SelectedPath;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start(@"C:\Users\asutphin\Desktop\Firmware_Update_UEFI_BIOS_putty_122613.txt");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxAllFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllFiles.Checked)
            {
                textBox1.Clear();
                textBox1.ReadOnly = true;
            }
            else
                textBox1.ReadOnly = false;
        }

        private void textBoxFileNameFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAllFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllFolders.Checked)
            {
                textBoxFolderNameFilter.Clear();
                textBoxFolderNameFilter.ReadOnly = true;
            }
            else
                textBoxFolderNameFilter.ReadOnly = false;
        }
    }
}
