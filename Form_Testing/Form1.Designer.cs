namespace Form_Testing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSouce = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonDest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBoxAllFiles = new System.Windows.Forms.CheckBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.labelFilesFound = new System.Windows.Forms.Label();
            this.textBoxFolderNameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxAllFolders = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start File Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(454, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(455, 271);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.HelpRequest += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // textBoxSouce
            // 
            this.textBoxSouce.Location = new System.Drawing.Point(144, 100);
            this.textBoxSouce.Name = "textBoxSouce";
            this.textBoxSouce.Size = new System.Drawing.Size(193, 20);
            this.textBoxSouce.TabIndex = 6;
            this.textBoxSouce.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(18, 100);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(120, 23);
            this.buttonSource.TabIndex = 7;
            this.buttonSource.Text = "Select Source Folder";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(144, 129);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.Size = new System.Drawing.Size(193, 20);
            this.textBoxDest.TabIndex = 6;
            this.textBoxDest.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonDest
            // 
            this.buttonDest.Location = new System.Drawing.Point(18, 129);
            this.buttonDest.Name = "buttonDest";
            this.buttonDest.Size = new System.Drawing.Size(120, 23);
            this.buttonDest.TabIndex = 7;
            this.buttonDest.Text = "Select Destination ";
            this.buttonDest.UseVisualStyleBackColor = true;
            this.buttonDest.Click += new System.EventHandler(this.buttonDest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Files Coppied:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(433, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // checkBoxAllFiles
            // 
            this.checkBoxAllFiles.AutoSize = true;
            this.checkBoxAllFiles.Location = new System.Drawing.Point(367, 48);
            this.checkBoxAllFiles.Name = "checkBoxAllFiles";
            this.checkBoxAllFiles.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAllFiles.TabIndex = 12;
            this.checkBoxAllFiles.Text = "All Files";
            this.checkBoxAllFiles.UseVisualStyleBackColor = true;
            this.checkBoxAllFiles.CheckedChanged += new System.EventHandler(this.checkBoxAllFiles_CheckedChanged);
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(174, 209);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(0, 13);
            this.labelDebug.TabIndex = 13;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(343, 102);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(67, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Files Found: ";
            // 
            // labelFilesFound
            // 
            this.labelFilesFound.AutoSize = true;
            this.labelFilesFound.Location = new System.Drawing.Point(407, 100);
            this.labelFilesFound.Name = "labelFilesFound";
            this.labelFilesFound.Size = new System.Drawing.Size(0, 13);
            this.labelFilesFound.TabIndex = 15;
            // 
            // textBoxFolderNameFilter
            // 
            this.textBoxFolderNameFilter.Location = new System.Drawing.Point(146, 76);
            this.textBoxFolderNameFilter.Name = "textBoxFolderNameFilter";
            this.textBoxFolderNameFilter.Size = new System.Drawing.Size(192, 20);
            this.textBoxFolderNameFilter.TabIndex = 16;
            this.textBoxFolderNameFilter.TextChanged += new System.EventHandler(this.textBoxFileNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filename Filter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Folder Name Filter";
            // 
            // checkBoxAllFolders
            // 
            this.checkBoxAllFolders.AutoSize = true;
            this.checkBoxAllFolders.Checked = true;
            this.checkBoxAllFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllFolders.Location = new System.Drawing.Point(367, 72);
            this.checkBoxAllFolders.Name = "checkBoxAllFolders";
            this.checkBoxAllFolders.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAllFolders.TabIndex = 19;
            this.checkBoxAllFolders.Text = "All Folders";
            this.checkBoxAllFolders.UseVisualStyleBackColor = true;
            this.checkBoxAllFolders.CheckedChanged += new System.EventHandler(this.checkBoxAllFolders_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 314);
            this.Controls.Add(this.checkBoxAllFolders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFolderNameFilter);
            this.Controls.Add(this.labelFilesFound);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.checkBoxAllFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDest);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.textBoxSouce);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Tree Copy Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox textBoxSouce;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Button buttonDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBoxAllFiles;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label labelFilesFound;
        private System.Windows.Forms.TextBox textBoxFolderNameFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxAllFolders;
    }
}

