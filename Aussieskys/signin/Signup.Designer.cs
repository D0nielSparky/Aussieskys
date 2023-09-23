namespace App_assignment
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.Header = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonSignin = new System.Windows.Forms.Button();
            this.buttonnextandSignup = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.panelpart2 = new System.Windows.Forms.Panel();
            this.labelerrorgender = new System.Windows.Forms.Label();
            this.labelerroremail = new System.Windows.Forms.Label();
            this.labelerrorlname = new System.Windows.Forms.Label();
            this.labelerrorfname = new System.Windows.Forms.Label();
            this.labelfname = new System.Windows.Forms.Label();
            this.labellname = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.labeldob = new System.Windows.Forms.Label();
            this.textBoxfname = new System.Windows.Forms.TextBox();
            this.textBoxlname = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.panelpart1 = new System.Windows.Forms.Panel();
            this.labelerrorpass = new System.Windows.Forms.Label();
            this.labelerroruser = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelconpassword = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxconpassword = new System.Windows.Forms.TextBox();
            this.panelpart3 = new System.Windows.Forms.Panel();
            this.labelerrorsecquest = new System.Windows.Forms.Label();
            this.labelerrorsecansw = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelpart2.SuspendLayout();
            this.panelpart1.SuspendLayout();
            this.panelpart3.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(800, 46);
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
            this.labelTitle.Size = new System.Drawing.Size(295, 37);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Aussiesky Sign up";
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.Controls.Add(this.buttonClose);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(727, 0);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ButtonSignin);
            this.panel1.Controls.Add(this.buttonnextandSignup);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.panelpart1);
            this.panel1.Controls.Add(this.panelpart2);
            this.panel1.Controls.Add(this.panelpart3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 404);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Aussieskys.Properties.Resources.Untitled_removebg_preview;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(263, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 71);
            this.panel2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(351, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aussiesky";
            // 
            // ButtonSignin
            // 
            this.ButtonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ButtonSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSignin.FlatAppearance.BorderSize = 0;
            this.ButtonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignin.ForeColor = System.Drawing.Color.White;
            this.ButtonSignin.Location = new System.Drawing.Point(332, 340);
            this.ButtonSignin.Name = "ButtonSignin";
            this.ButtonSignin.Size = new System.Drawing.Size(209, 46);
            this.ButtonSignin.TabIndex = 18;
            this.ButtonSignin.Text = "Have a account, Sign in";
            this.ButtonSignin.UseVisualStyleBackColor = false;
            this.ButtonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // buttonnextandSignup
            // 
            this.buttonnextandSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnextandSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonnextandSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnextandSignup.ForeColor = System.Drawing.Color.White;
            this.buttonnextandSignup.Location = new System.Drawing.Point(442, 288);
            this.buttonnextandSignup.Name = "buttonnextandSignup";
            this.buttonnextandSignup.Size = new System.Drawing.Size(214, 46);
            this.buttonnextandSignup.TabIndex = 17;
            this.buttonnextandSignup.Text = "Next";
            this.buttonnextandSignup.UseVisualStyleBackColor = false;
            this.buttonnextandSignup.Click += new System.EventHandler(this.buttonnextandSignup_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.ForeColor = System.Drawing.Color.White;
            this.buttonback.Location = new System.Drawing.Point(225, 288);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(214, 46);
            this.buttonback.TabIndex = 18;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Visible = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // panelpart2
            // 
            this.panelpart2.Controls.Add(this.labelerrorgender);
            this.panelpart2.Controls.Add(this.labelerroremail);
            this.panelpart2.Controls.Add(this.labelerrorlname);
            this.panelpart2.Controls.Add(this.labelerrorfname);
            this.panelpart2.Controls.Add(this.labelfname);
            this.panelpart2.Controls.Add(this.labellname);
            this.panelpart2.Controls.Add(this.labelemail);
            this.panelpart2.Controls.Add(this.labelgender);
            this.panelpart2.Controls.Add(this.labeldob);
            this.panelpart2.Controls.Add(this.textBoxfname);
            this.panelpart2.Controls.Add(this.textBoxlname);
            this.panelpart2.Controls.Add(this.textBoxemail);
            this.panelpart2.Controls.Add(this.comboBoxgender);
            this.panelpart2.Controls.Add(this.dateTimePickerdob);
            this.panelpart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpart2.Location = new System.Drawing.Point(0, 0);
            this.panelpart2.Name = "panelpart2";
            this.panelpart2.Size = new System.Drawing.Size(800, 404);
            this.panelpart2.TabIndex = 10;
            this.panelpart2.Visible = false;
            // 
            // labelerrorgender
            // 
            this.labelerrorgender.AutoSize = true;
            this.labelerrorgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorgender.ForeColor = System.Drawing.Color.Red;
            this.labelerrorgender.Location = new System.Drawing.Point(488, 215);
            this.labelerrorgender.Name = "labelerrorgender";
            this.labelerrorgender.Size = new System.Drawing.Size(122, 20);
            this.labelerrorgender.TabIndex = 32;
            this.labelerrorgender.Text = "Invalid gender";
            this.labelerrorgender.Visible = false;
            // 
            // labelerroremail
            // 
            this.labelerroremail.AutoSize = true;
            this.labelerroremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerroremail.ForeColor = System.Drawing.Color.Red;
            this.labelerroremail.Location = new System.Drawing.Point(561, 179);
            this.labelerroremail.Name = "labelerroremail";
            this.labelerroremail.Size = new System.Drawing.Size(108, 20);
            this.labelerroremail.TabIndex = 31;
            this.labelerroremail.Text = "Invalid email";
            this.labelerroremail.Visible = false;
            // 
            // labelerrorlname
            // 
            this.labelerrorlname.AutoSize = true;
            this.labelerrorlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorlname.ForeColor = System.Drawing.Color.Red;
            this.labelerrorlname.Location = new System.Drawing.Point(561, 147);
            this.labelerrorlname.Name = "labelerrorlname";
            this.labelerrorlname.Size = new System.Drawing.Size(110, 20);
            this.labelerrorlname.TabIndex = 30;
            this.labelerrorlname.Text = "Invalid name";
            this.labelerrorlname.Visible = false;
            // 
            // labelerrorfname
            // 
            this.labelerrorfname.AutoSize = true;
            this.labelerrorfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorfname.ForeColor = System.Drawing.Color.Red;
            this.labelerrorfname.Location = new System.Drawing.Point(561, 113);
            this.labelerrorfname.Name = "labelerrorfname";
            this.labelerrorfname.Size = new System.Drawing.Size(110, 20);
            this.labelerrorfname.TabIndex = 29;
            this.labelerrorfname.Text = "Invalid name";
            this.labelerrorfname.Visible = false;
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfname.ForeColor = System.Drawing.Color.White;
            this.labelfname.Location = new System.Drawing.Point(259, 113);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(103, 20);
            this.labelfname.TabIndex = 10;
            this.labelfname.Text = "First Name*";
            // 
            // labellname
            // 
            this.labellname.AutoSize = true;
            this.labellname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellname.ForeColor = System.Drawing.Color.White;
            this.labellname.Location = new System.Drawing.Point(257, 148);
            this.labellname.Name = "labellname";
            this.labellname.Size = new System.Drawing.Size(102, 20);
            this.labellname.TabIndex = 11;
            this.labellname.Text = "Last Name*";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.White;
            this.labelemail.Location = new System.Drawing.Point(231, 179);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(131, 20);
            this.labelemail.TabIndex = 28;
            this.labelemail.Text = "Email Address*";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.ForeColor = System.Drawing.Color.White;
            this.labelgender.Location = new System.Drawing.Point(283, 212);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(76, 20);
            this.labelgender.TabIndex = 12;
            this.labelgender.Text = "Gender*";
            // 
            // labeldob
            // 
            this.labeldob.AutoSize = true;
            this.labeldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldob.ForeColor = System.Drawing.Color.White;
            this.labeldob.Location = new System.Drawing.Point(240, 247);
            this.labeldob.Name = "labeldob";
            this.labeldob.Size = new System.Drawing.Size(119, 20);
            this.labeldob.TabIndex = 13;
            this.labeldob.Text = "Date of Birth*";
            // 
            // textBoxfname
            // 
            this.textBoxfname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxfname.ForeColor = System.Drawing.Color.White;
            this.textBoxfname.Location = new System.Drawing.Point(361, 111);
            this.textBoxfname.Name = "textBoxfname";
            this.textBoxfname.Size = new System.Drawing.Size(197, 26);
            this.textBoxfname.TabIndex = 3;
            // 
            // textBoxlname
            // 
            this.textBoxlname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxlname.ForeColor = System.Drawing.Color.White;
            this.textBoxlname.Location = new System.Drawing.Point(361, 144);
            this.textBoxlname.Name = "textBoxlname";
            this.textBoxlname.Size = new System.Drawing.Size(197, 26);
            this.textBoxlname.TabIndex = 4;
            // 
            // textBoxemail
            // 
            this.textBoxemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxemail.ForeColor = System.Drawing.Color.White;
            this.textBoxemail.Location = new System.Drawing.Point(361, 176);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(197, 26);
            this.textBoxemail.TabIndex = 27;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.comboBoxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxgender.ForeColor = System.Drawing.Color.White;
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Prefer not to answer"});
            this.comboBoxgender.Location = new System.Drawing.Point(361, 208);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxgender.TabIndex = 5;
            this.comboBoxgender.Tag = "";
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickerdob.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerdob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerdob.Location = new System.Drawing.Point(361, 244);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.ShowUpDown = true;
            this.dateTimePickerdob.Size = new System.Drawing.Size(106, 26);
            this.dateTimePickerdob.TabIndex = 6;
            this.dateTimePickerdob.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // panelpart1
            // 
            this.panelpart1.Controls.Add(this.labelerrorpass);
            this.panelpart1.Controls.Add(this.labelerroruser);
            this.panelpart1.Controls.Add(this.labelusername);
            this.panelpart1.Controls.Add(this.labelpassword);
            this.panelpart1.Controls.Add(this.labelconpassword);
            this.panelpart1.Controls.Add(this.textBoxusername);
            this.panelpart1.Controls.Add(this.textBoxpassword);
            this.panelpart1.Controls.Add(this.textBoxconpassword);
            this.panelpart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpart1.Location = new System.Drawing.Point(0, 0);
            this.panelpart1.Name = "panelpart1";
            this.panelpart1.Size = new System.Drawing.Size(800, 404);
            this.panelpart1.TabIndex = 29;
            // 
            // labelerrorpass
            // 
            this.labelerrorpass.AutoSize = true;
            this.labelerrorpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorpass.ForeColor = System.Drawing.Color.Red;
            this.labelerrorpass.Location = new System.Drawing.Point(561, 202);
            this.labelerrorpass.Name = "labelerrorpass";
            this.labelerrorpass.Size = new System.Drawing.Size(215, 20);
            this.labelerrorpass.TabIndex = 11;
            this.labelerrorpass.Text = "Passwords arn\'t the same";
            this.labelerrorpass.Visible = false;
            // 
            // labelerroruser
            // 
            this.labelerroruser.AutoSize = true;
            this.labelerroruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerroruser.ForeColor = System.Drawing.Color.Red;
            this.labelerroruser.Location = new System.Drawing.Point(561, 151);
            this.labelerroruser.Name = "labelerroruser";
            this.labelerroruser.Size = new System.Drawing.Size(198, 20);
            this.labelerroruser.TabIndex = 10;
            this.labelerroruser.Text = "Username already used";
            this.labelerroruser.Visible = false;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(259, 151);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(100, 20);
            this.labelusername.TabIndex = 7;
            this.labelusername.Text = "UserName*";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(266, 184);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(93, 20);
            this.labelpassword.TabIndex = 8;
            this.labelpassword.Text = "Password*";
            // 
            // labelconpassword
            // 
            this.labelconpassword.AutoSize = true;
            this.labelconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconpassword.ForeColor = System.Drawing.Color.White;
            this.labelconpassword.Location = new System.Drawing.Point(199, 217);
            this.labelconpassword.Name = "labelconpassword";
            this.labelconpassword.Size = new System.Drawing.Size(160, 20);
            this.labelconpassword.TabIndex = 9;
            this.labelconpassword.Text = "Confirm Password*";
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxusername.ForeColor = System.Drawing.Color.White;
            this.textBoxusername.Location = new System.Drawing.Point(358, 149);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(197, 26);
            this.textBoxusername.TabIndex = 0;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxpassword.Location = new System.Drawing.Point(358, 182);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxpassword.TabIndex = 1;
            // 
            // textBoxconpassword
            // 
            this.textBoxconpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxconpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxconpassword.Location = new System.Drawing.Point(358, 215);
            this.textBoxconpassword.Name = "textBoxconpassword";
            this.textBoxconpassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxconpassword.TabIndex = 2;
            // 
            // panelpart3
            // 
            this.panelpart3.Controls.Add(this.labelerrorsecquest);
            this.panelpart3.Controls.Add(this.labelerrorsecansw);
            this.panelpart3.Controls.Add(this.comboBox1);
            this.panelpart3.Controls.Add(this.label1);
            this.panelpart3.Controls.Add(this.label2);
            this.panelpart3.Controls.Add(this.textBox1);
            this.panelpart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpart3.Location = new System.Drawing.Point(0, 0);
            this.panelpart3.Name = "panelpart3";
            this.panelpart3.Size = new System.Drawing.Size(800, 404);
            this.panelpart3.TabIndex = 10;
            this.panelpart3.Visible = false;
            // 
            // labelerrorsecquest
            // 
            this.labelerrorsecquest.AutoSize = true;
            this.labelerrorsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorsecquest.ForeColor = System.Drawing.Color.Red;
            this.labelerrorsecquest.Location = new System.Drawing.Point(677, 149);
            this.labelerrorsecquest.Name = "labelerrorsecquest";
            this.labelerrorsecquest.Size = new System.Drawing.Size(118, 20);
            this.labelerrorsecquest.TabIndex = 32;
            this.labelerrorsecquest.Text = "Invalid choice";
            this.labelerrorsecquest.Visible = false;
            // 
            // labelerrorsecansw
            // 
            this.labelerrorsecansw.AutoSize = true;
            this.labelerrorsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorsecansw.ForeColor = System.Drawing.Color.Red;
            this.labelerrorsecansw.Location = new System.Drawing.Point(561, 209);
            this.labelerrorsecansw.Name = "labelerrorsecansw";
            this.labelerrorsecansw.Size = new System.Drawing.Size(123, 20);
            this.labelerrorsecansw.TabIndex = 31;
            this.labelerrorsecansw.Text = "Invalid answer";
            this.labelerrorsecansw.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "In what city were you born?",
            "What is the name of your favorite pet?",
            "What is your mother\'s maiden name?",
            "What high school did you attend?",
            "What was the name of your elementary school?",
            "What was the make of your first car?",
            "What was your favorite food as a child?",
            "Where did you meet your spouse?",
            "What year was your father (or mother) born?"});
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In what city were you born?",
            "What is the name of your favorite pet?",
            "What is your mother\'s maiden name?",
            "What high school did you attend?",
            "What was the name of your elementary school?",
            "What was the make of your first car?",
            "What was your favorite food as a child?",
            "Where did you meet your spouse?",
            "What year was your father (or mother) born?"});
            this.comboBox1.Location = new System.Drawing.Point(351, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Security question*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Security answer*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(351, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 9;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelpart2.ResumeLayout(false);
            this.panelpart2.PerformLayout();
            this.panelpart1.ResumeLayout(false);
            this.panelpart1.PerformLayout();
            this.panelpart3.ResumeLayout(false);
            this.panelpart3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeldob;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.Label labellname;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label labelconpassword;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.TextBox textBoxlname;
        private System.Windows.Forms.TextBox textBoxfname;
        private System.Windows.Forms.TextBox textBoxconpassword;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonnextandSignup;
        private System.Windows.Forms.Button ButtonSignin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Panel panelpart1;
        private System.Windows.Forms.Panel panelpart2;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.Panel panelpart3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelerroruser;
        private System.Windows.Forms.Label labelerrorpass;
        private System.Windows.Forms.Label labelerroremail;
        private System.Windows.Forms.Label labelerrorlname;
        private System.Windows.Forms.Label labelerrorfname;
        private System.Windows.Forms.Label labelerrorgender;
        private System.Windows.Forms.Label labelerrorsecquest;
        private System.Windows.Forms.Label labelerrorsecansw;
    }
}