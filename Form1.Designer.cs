﻿namespace RB3DX_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            tabPage2 = new TabPage();
            label4 = new Label();
            button1 = new Button();
            BrowseDevHDD0 = new Button();
            label3 = new Label();
            devhdd0 = new TextBox();
            RPCS3Path = new TextBox();
            BrowseRPCS3 = new Button();
            label2 = new Label();
            tabPage1 = new TabPage();
            label1 = new Label();
            comboBox1 = new ComboBox();
            UpdateButton = new Button();
            listBox1 = new ListBox();
            play = new Button();
            dxLogo = new PictureBox();
            NoLongerAHomie = new TabControl();
            tabPage4 = new TabPage();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dxLogo).BeginInit();
            NoLongerAHomie.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(1, 13, 25);
            tabPage2.BackgroundImage = Properties.Resources.headerbg;
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(BrowseDevHDD0);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(devhdd0);
            tabPage2.Controls.Add(RPCS3Path);
            tabPage2.Controls.Add(BrowseRPCS3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(23, 234);
            label4.Name = "label4";
            label4.Size = new Size(539, 30);
            label4.TabIndex = 7;
            label4.Text = "Rock Band 3 © 2010 Harmonix Music Systems.\r\nRock Band 3 Deluxe is a fan project and is not affiliated with Harmonix, MTV Games, Mad Catz, or EA.";
            // 
            // button1
            // 
            button1.Location = new Point(23, 179);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BrowseDevHDD0
            // 
            BrowseDevHDD0.Location = new Point(305, 123);
            BrowseDevHDD0.Name = "BrowseDevHDD0";
            BrowseDevHDD0.Size = new Size(75, 23);
            BrowseDevHDD0.TabIndex = 5;
            BrowseDevHDD0.Text = "Browse";
            BrowseDevHDD0.UseVisualStyleBackColor = true;
            BrowseDevHDD0.Click += BrowseDevHDD0_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "dev_hdd0";
            // 
            // devhdd0
            // 
            devhdd0.Location = new Point(23, 123);
            devhdd0.Name = "devhdd0";
            devhdd0.ReadOnly = true;
            devhdd0.Size = new Size(276, 23);
            devhdd0.TabIndex = 3;
            // 
            // RPCS3Path
            // 
            RPCS3Path.Location = new Point(23, 56);
            RPCS3Path.Name = "RPCS3Path";
            RPCS3Path.ReadOnly = true;
            RPCS3Path.Size = new Size(276, 23);
            RPCS3Path.TabIndex = 0;
            // 
            // BrowseRPCS3
            // 
            BrowseRPCS3.Location = new Point(305, 56);
            BrowseRPCS3.Name = "BrowseRPCS3";
            BrowseRPCS3.Size = new Size(75, 23);
            BrowseRPCS3.TabIndex = 2;
            BrowseRPCS3.Text = "Browse";
            BrowseRPCS3.UseVisualStyleBackColor = true;
            BrowseRPCS3.Click += BrowseRPCS3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(23, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "RPCS3.exe";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(1, 13, 25);
            tabPage1.BackgroundImage = Properties.Resources.headerbg;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(UpdateButton);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(play);
            tabPage1.Controls.Add(dxLogo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(604, 258);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 8;
            label1.Text = "Update from:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "main", "develop" });
            comboBox1.Location = new Point(604, 275);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "main";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(638, 314);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(109, 23);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Update RB3DX";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { resources.GetString("listBox1.Items"), "", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2"), "", resources.GetString("listBox1.Items3"), "", resources.GetString("listBox1.Items4") });
            listBox1.Location = new Point(9, 152);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(589, 244);
            listBox1.TabIndex = 2;
            // 
            // play
            // 
            play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            play.Location = new Point(604, 343);
            play.Name = "play";
            play.Size = new Size(181, 53);
            play.TabIndex = 1;
            play.Text = "Play!";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // dxLogo
            // 
            dxLogo.BackColor = Color.Transparent;
            dxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            dxLogo.ErrorImage = null;
            dxLogo.Image = Properties.Resources.logo;
            dxLogo.ImageLocation = "";
            dxLogo.InitialImage = null;
            dxLogo.Location = new Point(9, 6);
            dxLogo.Name = "dxLogo";
            dxLogo.Size = new Size(375, 95);
            dxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            dxLogo.TabIndex = 0;
            dxLogo.TabStop = false;
            dxLogo.UseWaitCursor = true;
            dxLogo.Click += dxLogo_Click;
            // 
            // NoLongerAHomie
            // 
            NoLongerAHomie.Controls.Add(tabPage1);
            NoLongerAHomie.Controls.Add(tabPage2);
            NoLongerAHomie.Controls.Add(tabPage4);
            NoLongerAHomie.Location = new Point(-1, 0);
            NoLongerAHomie.Name = "NoLongerAHomie";
            NoLongerAHomie.SelectedIndex = 0;
            NoLongerAHomie.Size = new Size(802, 451);
            NoLongerAHomie.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(1, 13, 25);
            tabPage4.BackgroundImage = Properties.Resources.headerbg;
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(794, 423);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Debug Settings";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image_86;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(657, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(19, 67);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 8;
            button2.Text = "Open ace.dta in Notepad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(19, 340);
            label5.Name = "label5";
            label5.Size = new Size(539, 30);
            label5.TabIndex = 7;
            label5.Text = "Rock Band 3 © 2010 Harmonix Music Systems.\r\nRock Band 3 Deluxe is a fan project and is not affiliated with Harmonix, MTV Games, Mad Catz, or EA.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(19, 26);
            label6.Name = "label6";
            label6.Size = new Size(367, 17);
            label6.TabIndex = 10;
            label6.Text = "Testing settings. Don't touch unless you know what you're doing.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 13, 25);
            ClientSize = new Size(800, 421);
            Controls.Add(NoLongerAHomie);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Rock Band 3 Deluxe Launcher";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dxLogo).EndInit();
            NoLongerAHomie.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private TabPage tabPage2;
        private Label label4;
        private Button button1;
        private Button BrowseDevHDD0;
        private Label label3;
        private TextBox devhdd0;
        private TextBox RPCS3Path;
        private Button BrowseRPCS3;
        private Label label2;
        private TabPage tabPage1;
        private Label label1;
        private ComboBox comboBox1;
        private Button UpdateButton;
        private ListBox listBox1;
        private Button play;
        private PictureBox dxLogo;
        private TabControl NoLongerAHomie;
        private TabPage tabPage4;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label6;
    }
}