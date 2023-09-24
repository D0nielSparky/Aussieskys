namespace App_assignment
{
    partial class Timetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timetable));
            this.Header = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTimetablemainscreen = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelheader2 = new System.Windows.Forms.Panel();
            this.labelheadertext2 = new System.Windows.Forms.Label();
            this.buttonsetting = new System.Windows.Forms.Button();
            this.panelDOTW = new System.Windows.Forms.Panel();
            this.buttonSunday = new System.Windows.Forms.Button();
            this.buttonSaturday = new System.Windows.Forms.Button();
            this.buttonFriday = new System.Windows.Forms.Button();
            this.buttonThursday = new System.Windows.Forms.Button();
            this.buttonWednesday = new System.Windows.Forms.Button();
            this.buttonTuesday = new System.Windows.Forms.Button();
            this.buttonMonday = new System.Windows.Forms.Button();
            this.panelTablechoice = new System.Windows.Forms.Panel();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelpanel = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonNotif = new System.Windows.Forms.Button();
            this.buttonMData = new System.Windows.Forms.Button();
            this.buttonMTimetable = new System.Windows.Forms.Button();
            this.buttonappset = new System.Windows.Forms.Button();
            this.panelAppsetting = new System.Windows.Forms.Panel();
            this.labelsetting12hour = new System.Windows.Forms.Label();
            this.labelAutoswitchweeks = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelmanagetables = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelsettingmanagetitle = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.panelTimetablemainscreen.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelheader2.SuspendLayout();
            this.panelDOTW.SuspendLayout();
            this.panelTablechoice.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panelpanel.SuspendLayout();
            this.panelAppsetting.SuspendLayout();
            this.panelmanagetables.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.Header.Controls.Add(this.labelTitle);
            this.Header.Controls.Add(this.ControlBox);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1000, 46);
            this.Header.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(5, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(328, 37);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Aussiesky Timetable";
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.Controls.Add(this.buttonClose);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(927, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(73, 46);
            this.ControlBox.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::Aussieskys.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(42, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 28);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTimetablemainscreen
            // 
            this.panelTimetablemainscreen.Controls.Add(this.panelMenu);
            this.panelTimetablemainscreen.Controls.Add(this.panelSetting);
            this.panelTimetablemainscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimetablemainscreen.Location = new System.Drawing.Point(0, 46);
            this.panelTimetablemainscreen.Name = "panelTimetablemainscreen";
            this.panelTimetablemainscreen.Size = new System.Drawing.Size(1000, 681);
            this.panelTimetablemainscreen.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelheader2);
            this.panelMenu.Controls.Add(this.panelDOTW);
            this.panelMenu.Controls.Add(this.panelTablechoice);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1000, 681);
            this.panelMenu.TabIndex = 1;
            // 
            // panelheader2
            // 
            this.panelheader2.Controls.Add(this.labelheadertext2);
            this.panelheader2.Controls.Add(this.buttonsetting);
            this.panelheader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader2.Location = new System.Drawing.Point(0, 0);
            this.panelheader2.Name = "panelheader2";
            this.panelheader2.Size = new System.Drawing.Size(1000, 40);
            this.panelheader2.TabIndex = 2;
            // 
            // labelheadertext2
            // 
            this.labelheadertext2.AutoSize = true;
            this.labelheadertext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheadertext2.ForeColor = System.Drawing.Color.White;
            this.labelheadertext2.Location = new System.Drawing.Point(12, 4);
            this.labelheadertext2.Name = "labelheadertext2";
            this.labelheadertext2.Size = new System.Drawing.Size(165, 31);
            this.labelheadertext2.TabIndex = 2;
            this.labelheadertext2.Text = "My Classes";
            // 
            // buttonsetting
            // 
            this.buttonsetting.BackColor = System.Drawing.Color.Transparent;
            this.buttonsetting.BackgroundImage = global::Aussieskys.Properties.Resources.Gears;
            this.buttonsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsetting.FlatAppearance.BorderSize = 0;
            this.buttonsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetting.Location = new System.Drawing.Point(960, 6);
            this.buttonsetting.Name = "buttonsetting";
            this.buttonsetting.Size = new System.Drawing.Size(28, 28);
            this.buttonsetting.TabIndex = 1;
            this.buttonsetting.UseVisualStyleBackColor = false;
            this.buttonsetting.Click += new System.EventHandler(this.buttonsetting_Click);
            // 
            // panelDOTW
            // 
            this.panelDOTW.Controls.Add(this.buttonSunday);
            this.panelDOTW.Controls.Add(this.buttonSaturday);
            this.panelDOTW.Controls.Add(this.buttonFriday);
            this.panelDOTW.Controls.Add(this.buttonThursday);
            this.panelDOTW.Controls.Add(this.buttonWednesday);
            this.panelDOTW.Controls.Add(this.buttonTuesday);
            this.panelDOTW.Controls.Add(this.buttonMonday);
            this.panelDOTW.Location = new System.Drawing.Point(82, 73);
            this.panelDOTW.Name = "panelDOTW";
            this.panelDOTW.Size = new System.Drawing.Size(842, 74);
            this.panelDOTW.TabIndex = 0;
            // 
            // buttonSunday
            // 
            this.buttonSunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSunday.FlatAppearance.BorderSize = 0;
            this.buttonSunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonSunday.ForeColor = System.Drawing.Color.White;
            this.buttonSunday.Location = new System.Drawing.Point(738, 0);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(101, 72);
            this.buttonSunday.TabIndex = 6;
            this.buttonSunday.Text = "Sunday";
            this.buttonSunday.UseVisualStyleBackColor = false;
            this.buttonSunday.Click += new System.EventHandler(this.buttonSunday_Click);
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSaturday.FlatAppearance.BorderSize = 0;
            this.buttonSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonSaturday.ForeColor = System.Drawing.Color.White;
            this.buttonSaturday.Location = new System.Drawing.Point(625, -1);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(107, 72);
            this.buttonSaturday.TabIndex = 5;
            this.buttonSaturday.Text = "Saturday";
            this.buttonSaturday.UseVisualStyleBackColor = false;
            this.buttonSaturday.Click += new System.EventHandler(this.buttonSaturday_Click);
            // 
            // buttonFriday
            // 
            this.buttonFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonFriday.FlatAppearance.BorderSize = 0;
            this.buttonFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonFriday.ForeColor = System.Drawing.Color.White;
            this.buttonFriday.Location = new System.Drawing.Point(502, -1);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(117, 72);
            this.buttonFriday.TabIndex = 4;
            this.buttonFriday.Text = "Friday";
            this.buttonFriday.UseVisualStyleBackColor = false;
            this.buttonFriday.Click += new System.EventHandler(this.buttonFriday_Click);
            // 
            // buttonThursday
            // 
            this.buttonThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonThursday.FlatAppearance.BorderSize = 0;
            this.buttonThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonThursday.ForeColor = System.Drawing.Color.White;
            this.buttonThursday.Location = new System.Drawing.Point(374, 0);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(122, 72);
            this.buttonThursday.TabIndex = 3;
            this.buttonThursday.Text = "Thursday";
            this.buttonThursday.UseVisualStyleBackColor = false;
            this.buttonThursday.Click += new System.EventHandler(this.buttonThursday_Click);
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonWednesday.FlatAppearance.BorderSize = 0;
            this.buttonWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonWednesday.ForeColor = System.Drawing.Color.White;
            this.buttonWednesday.Location = new System.Drawing.Point(251, -1);
            this.buttonWednesday.Name = "buttonWednesday";
            this.buttonWednesday.Size = new System.Drawing.Size(117, 72);
            this.buttonWednesday.TabIndex = 2;
            this.buttonWednesday.Text = "Wednesday";
            this.buttonWednesday.UseVisualStyleBackColor = false;
            this.buttonWednesday.Click += new System.EventHandler(this.buttonWednesday_Click);
            // 
            // buttonTuesday
            // 
            this.buttonTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonTuesday.FlatAppearance.BorderSize = 0;
            this.buttonTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonTuesday.ForeColor = System.Drawing.Color.White;
            this.buttonTuesday.Location = new System.Drawing.Point(119, 0);
            this.buttonTuesday.Name = "buttonTuesday";
            this.buttonTuesday.Size = new System.Drawing.Size(126, 74);
            this.buttonTuesday.TabIndex = 1;
            this.buttonTuesday.Text = "Tuesday";
            this.buttonTuesday.UseVisualStyleBackColor = false;
            this.buttonTuesday.Click += new System.EventHandler(this.buttonTuesday_Click);
            // 
            // buttonMonday
            // 
            this.buttonMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonMonday.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMonday.FlatAppearance.BorderSize = 0;
            this.buttonMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonday.ForeColor = System.Drawing.Color.White;
            this.buttonMonday.Location = new System.Drawing.Point(0, 0);
            this.buttonMonday.Name = "buttonMonday";
            this.buttonMonday.Size = new System.Drawing.Size(113, 74);
            this.buttonMonday.TabIndex = 0;
            this.buttonMonday.Text = "Monday";
            this.buttonMonday.UseVisualStyleBackColor = false;
            this.buttonMonday.Click += new System.EventHandler(this.buttonMonday_Click);
            // 
            // panelTablechoice
            // 
            this.panelTablechoice.Controls.Add(this.buttonWeek);
            this.panelTablechoice.Controls.Add(this.buttonToday);
            this.panelTablechoice.Location = new System.Drawing.Point(365, 234);
            this.panelTablechoice.Name = "panelTablechoice";
            this.panelTablechoice.Size = new System.Drawing.Size(269, 158);
            this.panelTablechoice.TabIndex = 3;
            // 
            // buttonWeek
            // 
            this.buttonWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonWeek.FlatAppearance.BorderSize = 0;
            this.buttonWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonWeek.ForeColor = System.Drawing.Color.White;
            this.buttonWeek.Location = new System.Drawing.Point(0, 80);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(269, 74);
            this.buttonWeek.TabIndex = 1;
            this.buttonWeek.Text = "View Week";
            this.buttonWeek.UseVisualStyleBackColor = false;
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonToday.ForeColor = System.Drawing.Color.White;
            this.buttonToday.Location = new System.Drawing.Point(0, 0);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(269, 74);
            this.buttonToday.TabIndex = 0;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = false;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.panelmanagetables);
            this.panelSetting.Controls.Add(this.panelAppsetting);
            this.panelSetting.Controls.Add(this.panelpanel);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(1000, 681);
            this.panelSetting.TabIndex = 3;
            // 
            // panelpanel
            // 
            this.panelpanel.Controls.Add(this.buttonBack);
            this.panelpanel.Controls.Add(this.buttonAbout);
            this.panelpanel.Controls.Add(this.buttonNotif);
            this.panelpanel.Controls.Add(this.buttonMData);
            this.panelpanel.Controls.Add(this.buttonMTimetable);
            this.panelpanel.Controls.Add(this.buttonappset);
            this.panelpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelpanel.Location = new System.Drawing.Point(0, 0);
            this.panelpanel.Name = "panelpanel";
            this.panelpanel.Size = new System.Drawing.Size(225, 681);
            this.panelpanel.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(0, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(225, 78);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(0, 336);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(225, 78);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "About App";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // buttonNotif
            // 
            this.buttonNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonNotif.FlatAppearance.BorderSize = 0;
            this.buttonNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotif.ForeColor = System.Drawing.Color.White;
            this.buttonNotif.Location = new System.Drawing.Point(0, 252);
            this.buttonNotif.Name = "buttonNotif";
            this.buttonNotif.Size = new System.Drawing.Size(225, 78);
            this.buttonNotif.TabIndex = 3;
            this.buttonNotif.Text = "Notification Setting";
            this.buttonNotif.UseVisualStyleBackColor = false;
            // 
            // buttonMData
            // 
            this.buttonMData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonMData.FlatAppearance.BorderSize = 0;
            this.buttonMData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMData.ForeColor = System.Drawing.Color.White;
            this.buttonMData.Location = new System.Drawing.Point(0, 168);
            this.buttonMData.Name = "buttonMData";
            this.buttonMData.Size = new System.Drawing.Size(225, 78);
            this.buttonMData.TabIndex = 2;
            this.buttonMData.Text = "Mangage Data";
            this.buttonMData.UseVisualStyleBackColor = false;
            // 
            // buttonMTimetable
            // 
            this.buttonMTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonMTimetable.FlatAppearance.BorderSize = 0;
            this.buttonMTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMTimetable.ForeColor = System.Drawing.Color.White;
            this.buttonMTimetable.Location = new System.Drawing.Point(1, 84);
            this.buttonMTimetable.Name = "buttonMTimetable";
            this.buttonMTimetable.Size = new System.Drawing.Size(225, 78);
            this.buttonMTimetable.TabIndex = 1;
            this.buttonMTimetable.Text = "Manage Timetables";
            this.buttonMTimetable.UseVisualStyleBackColor = false;
            this.buttonMTimetable.Click += new System.EventHandler(this.buttonMTimetable_Click);
            // 
            // buttonappset
            // 
            this.buttonappset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonappset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonappset.FlatAppearance.BorderSize = 0;
            this.buttonappset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonappset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonappset.ForeColor = System.Drawing.Color.White;
            this.buttonappset.Location = new System.Drawing.Point(0, 0);
            this.buttonappset.Name = "buttonappset";
            this.buttonappset.Size = new System.Drawing.Size(225, 78);
            this.buttonappset.TabIndex = 0;
            this.buttonappset.Text = "Application Settings";
            this.buttonappset.UseVisualStyleBackColor = false;
            this.buttonappset.Click += new System.EventHandler(this.buttonappset_Click);
            // 
            // panelAppsetting
            // 
            this.panelAppsetting.Controls.Add(this.button3);
            this.panelAppsetting.Controls.Add(this.button2);
            this.panelAppsetting.Controls.Add(this.button1);
            this.panelAppsetting.Controls.Add(this.labelTheme);
            this.panelAppsetting.Controls.Add(this.labelAutoswitchweeks);
            this.panelAppsetting.Controls.Add(this.labelsetting12hour);
            this.panelAppsetting.Location = new System.Drawing.Point(226, 1);
            this.panelAppsetting.Name = "panelAppsetting";
            this.panelAppsetting.Size = new System.Drawing.Size(772, 678);
            this.panelAppsetting.TabIndex = 1;
            this.panelAppsetting.Visible = false;
            // 
            // labelsetting12hour
            // 
            this.labelsetting12hour.AutoSize = true;
            this.labelsetting12hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelsetting12hour.ForeColor = System.Drawing.Color.White;
            this.labelsetting12hour.Location = new System.Drawing.Point(104, 66);
            this.labelsetting12hour.Name = "labelsetting12hour";
            this.labelsetting12hour.Size = new System.Drawing.Size(116, 20);
            this.labelsetting12hour.TabIndex = 0;
            this.labelsetting12hour.Text = "12 Hour Time";
            // 
            // labelAutoswitchweeks
            // 
            this.labelAutoswitchweeks.AutoSize = true;
            this.labelAutoswitchweeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAutoswitchweeks.ForeColor = System.Drawing.Color.White;
            this.labelAutoswitchweeks.Location = new System.Drawing.Point(56, 102);
            this.labelAutoswitchweeks.Name = "labelAutoswitchweeks";
            this.labelAutoswitchweeks.Size = new System.Drawing.Size(164, 20);
            this.labelAutoswitchweeks.TabIndex = 1;
            this.labelAutoswitchweeks.Text = "Auto Switch Weeks";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTheme.ForeColor = System.Drawing.Color.White;
            this.labelTheme.Location = new System.Drawing.Point(118, 141);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(100, 20);
            this.labelTheme.TabIndex = 2;
            this.labelTheme.Text = "App Theme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelmanagetables
            // 
            this.panelmanagetables.Controls.Add(this.panel1);
            this.panelmanagetables.Controls.Add(this.listBox1);
            this.panelmanagetables.Location = new System.Drawing.Point(226, 0);
            this.panelmanagetables.Name = "panelmanagetables";
            this.panelmanagetables.Size = new System.Drawing.Size(774, 678);
            this.panelmanagetables.TabIndex = 6;
            this.panelmanagetables.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.Gray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Timetable 1",
            "Timetable Slot"});
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(750, 600);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.labelsettingmanagetitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 46);
            this.panel1.TabIndex = 1;
            // 
            // labelsettingmanagetitle
            // 
            this.labelsettingmanagetitle.AutoSize = true;
            this.labelsettingmanagetitle.BackColor = System.Drawing.Color.Transparent;
            this.labelsettingmanagetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsettingmanagetitle.ForeColor = System.Drawing.Color.White;
            this.labelsettingmanagetitle.Location = new System.Drawing.Point(5, 3);
            this.labelsettingmanagetitle.Name = "labelsettingmanagetitle";
            this.labelsettingmanagetitle.Size = new System.Drawing.Size(315, 37);
            this.labelsettingmanagetitle.TabIndex = 3;
            this.labelsettingmanagetitle.Text = "manage Timetables";
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1000, 727);
            this.Controls.Add(this.panelTimetablemainscreen);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.panelTimetablemainscreen.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelheader2.ResumeLayout(false);
            this.panelheader2.PerformLayout();
            this.panelDOTW.ResumeLayout(false);
            this.panelTablechoice.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panelpanel.ResumeLayout(false);
            this.panelAppsetting.ResumeLayout(false);
            this.panelAppsetting.PerformLayout();
            this.panelmanagetables.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UsernameandSignin;
        private System.Windows.Forms.Panel panelTimetablemainscreen;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelheader2;
        private System.Windows.Forms.Label labelheadertext2;
        private System.Windows.Forms.Button buttonsetting;
        private System.Windows.Forms.Panel panelDOTW;
        private System.Windows.Forms.Button buttonSunday;
        private System.Windows.Forms.Button buttonSaturday;
        private System.Windows.Forms.Button buttonFriday;
        private System.Windows.Forms.Button buttonThursday;
        private System.Windows.Forms.Button buttonWednesday;
        private System.Windows.Forms.Button buttonTuesday;
        private System.Windows.Forms.Button buttonMonday;
        private System.Windows.Forms.Panel panelTablechoice;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panelpanel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonNotif;
        private System.Windows.Forms.Button buttonMData;
        private System.Windows.Forms.Button buttonMTimetable;
        private System.Windows.Forms.Button buttonappset;
        private System.Windows.Forms.Panel panelAppsetting;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Label labelAutoswitchweeks;
        private System.Windows.Forms.Label labelsetting12hour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelmanagetables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelsettingmanagetitle;
        private System.Windows.Forms.ListBox listBox1;
    }
}