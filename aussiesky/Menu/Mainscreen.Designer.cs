using System.Windows.Forms;

namespace App_assignment
{
    partial class Mainscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainscreen));
            this.Header = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonUsernameandSignin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelBottomapplications = new System.Windows.Forms.Panel();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelTopapplications = new System.Windows.Forms.Panel();
            this.buttonGamess = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonTimetable = new System.Windows.Forms.Button();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.panelTimetable = new System.Windows.Forms.Panel();
            this.panelBottomlefttimetable = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.labelDesciptiontitle = new System.Windows.Forms.Label();
            this.panelToplefttimetable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimetabletitle = new System.Windows.Forms.Label();
            this.buttonPlaytimetable = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelBottomleftCalendar = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelDescriptionCalendar = new System.Windows.Forms.Label();
            this.panelTopleftcalendar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCalendartitle = new System.Windows.Forms.Label();
            this.buttonPlaycalendar = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelBottomapplications.SuspendLayout();
            this.panelTopapplications.SuspendLayout();
            this.panelTimetable.SuspendLayout();
            this.panelBottomlefttimetable.SuspendLayout();
            this.panelToplefttimetable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelBottomleftCalendar.SuspendLayout();
            this.panelTopleftcalendar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.Header.Controls.Add(this.panelHeader);
            this.Header.Controls.Add(this.labelTitle);
            this.Header.Controls.Add(this.ControlBox);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(95, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(573, 46);
            this.Header.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonUsernameandSignin);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeader.Location = new System.Drawing.Point(276, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(200, 46);
            this.panelHeader.TabIndex = 4;
            // 
            // buttonUsernameandSignin
            // 
            this.buttonUsernameandSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.buttonUsernameandSignin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUsernameandSignin.FlatAppearance.BorderSize = 0;
            this.buttonUsernameandSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsernameandSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonUsernameandSignin.ForeColor = System.Drawing.Color.White;
            this.buttonUsernameandSignin.Location = new System.Drawing.Point(0, 0);
            this.buttonUsernameandSignin.Name = "buttonUsernameandSignin";
            this.buttonUsernameandSignin.Size = new System.Drawing.Size(200, 46);
            this.buttonUsernameandSignin.TabIndex = 0;
            this.buttonUsernameandSignin.Text = "Sign In";
            this.buttonUsernameandSignin.UseVisualStyleBackColor = false;
            this.buttonUsernameandSignin.Click += new System.EventHandler(this.buttonUsernameandSignin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(5, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 37);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Aussiesky";
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.Controls.Add(this.buttonMinimize);
            this.ControlBox.Controls.Add(this.buttonResize);
            this.ControlBox.Controls.Add(this.buttonClose);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(476, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(97, 46);
            this.ControlBox.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(13, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(28, 46);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.Color.Transparent;
            this.buttonResize.BackgroundImage = global::aussiesky.Properties.Resources.Gears;
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonResize.FlatAppearance.BorderSize = 0;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Location = new System.Drawing.Point(41, 0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(28, 46);
            this.buttonResize.TabIndex = 2;
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(69, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 46);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panelSide.Controls.Add(this.panelBottomapplications);
            this.panelSide.Controls.Add(this.panelTopapplications);
            this.panelSide.Controls.Add(this.panelIcon);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(95, 714);
            this.panelSide.TabIndex = 1;
            // 
            // panelBottomapplications
            // 
            this.panelBottomapplications.Controls.Add(this.buttonAccount);
            this.panelBottomapplications.Controls.Add(this.buttonNotification);
            this.panelBottomapplications.Controls.Add(this.buttonSetting);
            this.panelBottomapplications.Location = new System.Drawing.Point(3, 472);
            this.panelBottomapplications.Name = "panelBottomapplications";
            this.panelBottomapplications.Size = new System.Drawing.Size(92, 239);
            this.panelBottomapplications.TabIndex = 28;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(0, 80);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(92, 80);
            this.buttonAccount.TabIndex = 8;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            // 
            // buttonNotification
            // 
            this.buttonNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotification.FlatAppearance.BorderSize = 0;
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotification.ForeColor = System.Drawing.Color.White;
            this.buttonNotification.Location = new System.Drawing.Point(0, 0);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(92, 80);
            this.buttonNotification.TabIndex = 6;
            this.buttonNotification.Text = "Notifications";
            this.buttonNotification.UseVisualStyleBackColor = false;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Location = new System.Drawing.Point(0, 159);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(92, 80);
            this.buttonSetting.TabIndex = 9;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = false;
            // 
            // panelTopapplications
            // 
            this.panelTopapplications.Controls.Add(this.buttonGamess);
            this.panelTopapplications.Controls.Add(this.buttonCalculator);
            this.panelTopapplications.Controls.Add(this.buttonCalendar);
            this.panelTopapplications.Controls.Add(this.buttonTimetable);
            this.panelTopapplications.Location = new System.Drawing.Point(3, 80);
            this.panelTopapplications.Name = "panelTopapplications";
            this.panelTopapplications.Size = new System.Drawing.Size(92, 322);
            this.panelTopapplications.TabIndex = 27;
            // 
            // buttonGamess
            // 
            this.buttonGamess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonGamess.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGamess.FlatAppearance.BorderSize = 0;
            this.buttonGamess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGamess.ForeColor = System.Drawing.Color.White;
            this.buttonGamess.Location = new System.Drawing.Point(0, 240);
            this.buttonGamess.Name = "buttonGamess";
            this.buttonGamess.Size = new System.Drawing.Size(92, 80);
            this.buttonGamess.TabIndex = 5;
            this.buttonGamess.Text = "Games";
            this.buttonGamess.UseVisualStyleBackColor = false;
            this.buttonGamess.Click += new System.EventHandler(this.buttonGamess_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculator.ForeColor = System.Drawing.Color.White;
            this.buttonCalculator.Location = new System.Drawing.Point(0, 160);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(92, 80);
            this.buttonCalculator.TabIndex = 4;
            this.buttonCalculator.Text = "Calculator";
            this.buttonCalculator.UseVisualStyleBackColor = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.ForeColor = System.Drawing.Color.White;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 80);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(92, 80);
            this.buttonCalendar.TabIndex = 3;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonTimetable
            // 
            this.buttonTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimetable.FlatAppearance.BorderSize = 0;
            this.buttonTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimetable.ForeColor = System.Drawing.Color.White;
            this.buttonTimetable.Location = new System.Drawing.Point(0, 0);
            this.buttonTimetable.Name = "buttonTimetable";
            this.buttonTimetable.Size = new System.Drawing.Size(92, 80);
            this.buttonTimetable.TabIndex = 2;
            this.buttonTimetable.Text = "Timetable";
            this.buttonTimetable.UseVisualStyleBackColor = false;
            this.buttonTimetable.Click += new System.EventHandler(this.buttonTimetable_Click);
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = global::aussiesky.Properties.Resources.Untitled_removebg_preview;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.Location = new System.Drawing.Point(0, 3);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(95, 71);
            this.panelIcon.TabIndex = 26;
            // 
            // panelTimetable
            // 
            this.panelTimetable.BackColor = System.Drawing.Color.Transparent;
            this.panelTimetable.Controls.Add(this.panelBottomlefttimetable);
            this.panelTimetable.Controls.Add(this.panelToplefttimetable);
            this.panelTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimetable.Location = new System.Drawing.Point(95, 46);
            this.panelTimetable.Name = "panelTimetable";
            this.panelTimetable.Size = new System.Drawing.Size(573, 671);
            this.panelTimetable.TabIndex = 2;
            // 
            // panelBottomlefttimetable
            // 
            this.panelBottomlefttimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.panelBottomlefttimetable.Controls.Add(this.listBox4);
            this.panelBottomlefttimetable.Controls.Add(this.labelDesciptiontitle);
            this.panelBottomlefttimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomlefttimetable.Location = new System.Drawing.Point(0, 293);
            this.panelBottomlefttimetable.Name = "panelBottomlefttimetable";
            this.panelBottomlefttimetable.Size = new System.Drawing.Size(573, 378);
            this.panelBottomlefttimetable.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.listBox4.ForeColor = System.Drawing.Color.White;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 32;
            this.listBox4.Items.AddRange(new object[] {
            "In this Timetable app you can create",
            "a school timetable that will be saved",
            "to your account",
            "",
            "NOTE:",
            "User must have an Account",
            "All data will autosave once created"});
            this.listBox4.Location = new System.Drawing.Point(12, 48);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(554, 288);
            this.listBox4.TabIndex = 1;
            // 
            // labelDesciptiontitle
            // 
            this.labelDesciptiontitle.AutoSize = true;
            this.labelDesciptiontitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelDesciptiontitle.ForeColor = System.Drawing.Color.White;
            this.labelDesciptiontitle.Location = new System.Drawing.Point(209, 13);
            this.labelDesciptiontitle.Name = "labelDesciptiontitle";
            this.labelDesciptiontitle.Size = new System.Drawing.Size(166, 32);
            this.labelDesciptiontitle.TabIndex = 0;
            this.labelDesciptiontitle.Text = "Description";
            // 
            // panelToplefttimetable
            // 
            this.panelToplefttimetable.BackColor = System.Drawing.Color.Silver;
            this.panelToplefttimetable.Controls.Add(this.panel1);
            this.panelToplefttimetable.Controls.Add(this.labelTimetabletitle);
            this.panelToplefttimetable.Controls.Add(this.buttonPlaytimetable);
            this.panelToplefttimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToplefttimetable.Location = new System.Drawing.Point(0, 0);
            this.panelToplefttimetable.Name = "panelToplefttimetable";
            this.panelToplefttimetable.Size = new System.Drawing.Size(573, 293);
            this.panelToplefttimetable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 63);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Local Save",
            "Server Save"});
            this.comboBox1.Location = new System.Drawing.Point(143, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(430, 62);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Local Save";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode:";
            // 
            // labelTimetabletitle
            // 
            this.labelTimetabletitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTimetabletitle.AutoSize = true;
            this.labelTimetabletitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelTimetabletitle.Location = new System.Drawing.Point(193, 28);
            this.labelTimetabletitle.Name = "labelTimetabletitle";
            this.labelTimetabletitle.Size = new System.Drawing.Size(183, 41);
            this.labelTimetabletitle.TabIndex = 1;
            this.labelTimetabletitle.Text = "TimeTable";
            // 
            // buttonPlaytimetable
            // 
            this.buttonPlaytimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaytimetable.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPlaytimetable.FlatAppearance.BorderSize = 0;
            this.buttonPlaytimetable.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonPlaytimetable.Location = new System.Drawing.Point(173, 116);
            this.buttonPlaytimetable.Name = "buttonPlaytimetable";
            this.buttonPlaytimetable.Size = new System.Drawing.Size(193, 49);
            this.buttonPlaytimetable.TabIndex = 0;
            this.buttonPlaytimetable.Text = "Local";
            this.buttonPlaytimetable.UseVisualStyleBackColor = false;
            this.buttonPlaytimetable.Click += new System.EventHandler(this.buttonPlaytimetable_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.Color.Transparent;
            this.panelCalendar.Controls.Add(this.panelBottomleftCalendar);
            this.panelCalendar.Controls.Add(this.panelTopleftcalendar);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalendar.Location = new System.Drawing.Point(95, 717);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(573, 671);
            this.panelCalendar.TabIndex = 3;
            this.panelCalendar.Visible = false;
            // 
            // panelBottomleftCalendar
            // 
            this.panelBottomleftCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.panelBottomleftCalendar.Controls.Add(this.listBox2);
            this.panelBottomleftCalendar.Controls.Add(this.labelDescriptionCalendar);
            this.panelBottomleftCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomleftCalendar.Location = new System.Drawing.Point(0, 293);
            this.panelBottomleftCalendar.Name = "panelBottomleftCalendar";
            this.panelBottomleftCalendar.Size = new System.Drawing.Size(573, 378);
            this.panelBottomleftCalendar.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Items.AddRange(new object[] {
            "In this Calendar, you can create Events",
            "that would be saved on your account.",
            "",
            "NOTE:",
            "Must have a Account",
            "All data autosaves once created"});
            this.listBox2.Location = new System.Drawing.Point(12, 48);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(554, 288);
            this.listBox2.TabIndex = 1;
            // 
            // labelDescriptionCalendar
            // 
            this.labelDescriptionCalendar.AutoSize = true;
            this.labelDescriptionCalendar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelDescriptionCalendar.ForeColor = System.Drawing.Color.White;
            this.labelDescriptionCalendar.Location = new System.Drawing.Point(209, 13);
            this.labelDescriptionCalendar.Name = "labelDescriptionCalendar";
            this.labelDescriptionCalendar.Size = new System.Drawing.Size(166, 32);
            this.labelDescriptionCalendar.TabIndex = 0;
            this.labelDescriptionCalendar.Text = "Description";
            // 
            // panelTopleftcalendar
            // 
            this.panelTopleftcalendar.BackColor = System.Drawing.Color.Silver;
            this.panelTopleftcalendar.Controls.Add(this.panel2);
            this.panelTopleftcalendar.Controls.Add(this.labelCalendartitle);
            this.panelTopleftcalendar.Controls.Add(this.buttonPlaycalendar);
            this.panelTopleftcalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopleftcalendar.Location = new System.Drawing.Point(0, 0);
            this.panelTopleftcalendar.Name = "panelTopleftcalendar";
            this.panelTopleftcalendar.Size = new System.Drawing.Size(573, 293);
            this.panelTopleftcalendar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 64);
            this.panel2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Local Save",
            "Server Save"});
            this.comboBox2.Location = new System.Drawing.Point(143, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(430, 62);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Local Save";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mode:";
            // 
            // labelCalendartitle
            // 
            this.labelCalendartitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCalendartitle.AutoSize = true;
            this.labelCalendartitle.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelCalendartitle.Location = new System.Drawing.Point(209, 20);
            this.labelCalendartitle.Name = "labelCalendartitle";
            this.labelCalendartitle.Size = new System.Drawing.Size(164, 41);
            this.labelCalendartitle.TabIndex = 1;
            this.labelCalendartitle.Text = "Calendar";
            // 
            // buttonPlaycalendar
            // 
            this.buttonPlaycalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaycalendar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPlaycalendar.FlatAppearance.BorderSize = 0;
            this.buttonPlaycalendar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.buttonPlaycalendar.Location = new System.Drawing.Point(215, 106);
            this.buttonPlaycalendar.Name = "buttonPlaycalendar";
            this.buttonPlaycalendar.Size = new System.Drawing.Size(151, 49);
            this.buttonPlaycalendar.TabIndex = 0;
            this.buttonPlaycalendar.Text = "Local";
            this.buttonPlaycalendar.UseVisualStyleBackColor = false;
            this.buttonPlaycalendar.Click += new System.EventHandler(this.buttonPlaycalendar_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(668, 714);
            this.Controls.Add(this.panelCalendar);
            this.Controls.Add(this.panelTimetable);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ControlBox.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelBottomapplications.ResumeLayout(false);
            this.panelTopapplications.ResumeLayout(false);
            this.panelTimetable.ResumeLayout(false);
            this.panelBottomlefttimetable.ResumeLayout(false);
            this.panelBottomlefttimetable.PerformLayout();
            this.panelToplefttimetable.ResumeLayout(false);
            this.panelToplefttimetable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCalendar.ResumeLayout(false);
            this.panelBottomleftCalendar.ResumeLayout(false);
            this.panelBottomleftCalendar.PerformLayout();
            this.panelTopleftcalendar.ResumeLayout(false);
            this.panelTopleftcalendar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonUsernameandSignin;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Button buttonTimetable;
        private System.Windows.Forms.Panel panelTopapplications;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.Button buttonGamess;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Panel panelBottomapplications;
        private System.Windows.Forms.Panel panelTimetable;
        private System.Windows.Forms.Panel panelBottomlefttimetable;
        private System.Windows.Forms.Panel panelToplefttimetable;
        private System.Windows.Forms.Label labelTimetabletitle;
        private System.Windows.Forms.Button buttonPlaytimetable;
        private System.Windows.Forms.Label labelDesciptiontitle;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Panel panelBottomleftCalendar;
        private System.Windows.Forms.Label labelDescriptionCalendar;
        private System.Windows.Forms.Panel panelTopleftcalendar;
        private System.Windows.Forms.Label labelCalendartitle;
        private System.Windows.Forms.Button buttonPlaycalendar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox4;
        private Button buttonResize;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox2;
    }
}