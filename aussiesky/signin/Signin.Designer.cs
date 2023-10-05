using System.Windows.Forms;

namespace App_assignment
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.Header = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelloginerror = new System.Windows.Forms.Label();
            this.SigninBuild = new System.Windows.Forms.Panel();
            this.buttonresetpassword = new System.Windows.Forms.Button();
            this.panelresetpasswordQ = new System.Windows.Forms.Panel();
            this.buttonnext = new System.Windows.Forms.Button();
            this.labelsecusername = new System.Windows.Forms.Label();
            this.labelsecquest = new System.Windows.Forms.Label();
            this.labelsecansw = new System.Windows.Forms.Label();
            this.textBoxsecusername = new System.Windows.Forms.TextBox();
            this.textBoxsecquest = new System.Windows.Forms.TextBox();
            this.textBoxsecansw = new System.Windows.Forms.TextBox();
            this.labelanswerror = new System.Windows.Forms.Label();
            this.panelresetpassword2 = new System.Windows.Forms.Panel();
            this.labelNewpassworderror = new System.Windows.Forms.Label();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmNewpassword = new System.Windows.Forms.TextBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewpassword = new System.Windows.Forms.Label();
            this.SignupBuild = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonnextandSignup = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.panelpart1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelerrorpass = new System.Windows.Forms.Label();
            this.labelerroruser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelconpassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxconpassword = new System.Windows.Forms.TextBox();
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
            this.panelpart3 = new System.Windows.Forms.Panel();
            this.labelerrorsecquest = new System.Windows.Forms.Label();
            this.labelerrorsecansw = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SiginBuild = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.OnlineServerConnect = new System.Windows.Forms.CheckBox();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.panelresetpasswordFA = new System.Windows.Forms.Panel();
            this.buttonnextfa = new System.Windows.Forms.Button();
            this.textBoxfaemail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Securityanswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.SigninBuild.SuspendLayout();
            this.panelresetpasswordQ.SuspendLayout();
            this.panelresetpassword2.SuspendLayout();
            this.SignupBuild.SuspendLayout();
            this.panelpart1.SuspendLayout();
            this.panelpart2.SuspendLayout();
            this.panelpart3.SuspendLayout();
            this.SiginBuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.panelresetpasswordFA.SuspendLayout();
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
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(5, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(284, 37);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Aussiesky Sign in";
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
            this.buttonClose.BackgroundImage = global::aussiesky.Properties.Resources.close;
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
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(259, 174);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(86, 20);
            this.labelpassword.TabIndex = 19;
            this.labelpassword.Text = "Password";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(252, 143);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(93, 20);
            this.labelusername.TabIndex = 18;
            this.labelusername.Text = "UserName";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxpassword.Location = new System.Drawing.Point(345, 171);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxpassword.TabIndex = 16;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxusername.ForeColor = System.Drawing.Color.White;
            this.textBoxusername.Location = new System.Drawing.Point(345, 140);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(197, 26);
            this.textBoxusername.TabIndex = 16;
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Showpass.ForeColor = System.Drawing.Color.White;
            this.Showpass.Location = new System.Drawing.Point(266, 204);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(154, 24);
            this.Showpass.TabIndex = 21;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = true;
            this.Showpass.Click += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.buttonSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(266, 319);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(256, 46);
            this.buttonSignup.TabIndex = 24;
            this.buttonSignup.Text = "Don\'t have a Account, Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonSignin.ForeColor = System.Drawing.Color.White;
            this.buttonSignin.Location = new System.Drawing.Point(256, 269);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(285, 46);
            this.buttonSignin.TabIndex = 23;
            this.buttonSignin.Text = "Sign In";
            this.buttonSignin.UseVisualStyleBackColor = false;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::aussiesky.Properties.Resources.Untitled_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(261, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 71);
            this.panel1.TabIndex = 25;
            // 
            // labelloginerror
            // 
            this.labelloginerror.AutoSize = true;
            this.labelloginerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelloginerror.ForeColor = System.Drawing.Color.Red;
            this.labelloginerror.Location = new System.Drawing.Point(282, 248);
            this.labelloginerror.Name = "labelloginerror";
            this.labelloginerror.Size = new System.Drawing.Size(251, 20);
            this.labelloginerror.TabIndex = 27;
            this.labelloginerror.Text = "Invalid Username or Password";
            this.labelloginerror.Visible = false;
            // 
            // SigninBuild
            // 
            this.SigninBuild.Controls.Add(this.dataGridViewAccounts);
            this.SigninBuild.Controls.Add(this.OnlineServerConnect);
            this.SigninBuild.Controls.Add(this.buttonSignup);
            this.SigninBuild.Controls.Add(this.buttonSignin);
            this.SigninBuild.Controls.Add(this.labelusername);
            this.SigninBuild.Controls.Add(this.labelpassword);
            this.SigninBuild.Controls.Add(this.textBoxusername);
            this.SigninBuild.Controls.Add(this.textBoxpassword);
            this.SigninBuild.Controls.Add(this.Showpass);
            this.SigninBuild.Controls.Add(this.labelloginerror);
            this.SigninBuild.Controls.Add(this.buttonresetpassword);
            this.SigninBuild.Location = new System.Drawing.Point(0, 0);
            this.SigninBuild.Name = "SigninBuild";
            this.SigninBuild.Size = new System.Drawing.Size(800, 401);
            this.SigninBuild.TabIndex = 30;
            // 
            // buttonresetpassword
            // 
            this.buttonresetpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.buttonresetpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonresetpassword.FlatAppearance.BorderSize = 0;
            this.buttonresetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonresetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.buttonresetpassword.ForeColor = System.Drawing.Color.White;
            this.buttonresetpassword.Location = new System.Drawing.Point(548, 159);
            this.buttonresetpassword.Name = "buttonresetpassword";
            this.buttonresetpassword.Size = new System.Drawing.Size(141, 46);
            this.buttonresetpassword.TabIndex = 29;
            this.buttonresetpassword.Text = "Reset Password";
            this.buttonresetpassword.UseVisualStyleBackColor = false;
            this.buttonresetpassword.Click += new System.EventHandler(this.buttonresetpassword_Click);
            // 
            // panelresetpasswordQ
            // 
            this.panelresetpasswordQ.Controls.Add(this.buttonnext);
            this.panelresetpasswordQ.Controls.Add(this.labelsecusername);
            this.panelresetpasswordQ.Controls.Add(this.labelsecquest);
            this.panelresetpasswordQ.Controls.Add(this.labelsecansw);
            this.panelresetpasswordQ.Controls.Add(this.textBoxsecusername);
            this.panelresetpasswordQ.Controls.Add(this.textBoxsecquest);
            this.panelresetpasswordQ.Controls.Add(this.textBoxsecansw);
            this.panelresetpasswordQ.Controls.Add(this.labelanswerror);
            this.panelresetpasswordQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelresetpasswordQ.Location = new System.Drawing.Point(0, 0);
            this.panelresetpasswordQ.Name = "panelresetpasswordQ";
            this.panelresetpasswordQ.Size = new System.Drawing.Size(800, 404);
            this.panelresetpasswordQ.TabIndex = 22;
            this.panelresetpasswordQ.Visible = false;
            // 
            // buttonnext
            // 
            this.buttonnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonnext.ForeColor = System.Drawing.Color.White;
            this.buttonnext.Location = new System.Drawing.Point(303, 270);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(285, 46);
            this.buttonnext.TabIndex = 31;
            this.buttonnext.Text = "Next";
            this.buttonnext.UseVisualStyleBackColor = false;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // labelsecusername
            // 
            this.labelsecusername.AutoSize = true;
            this.labelsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelsecusername.ForeColor = System.Drawing.Color.White;
            this.labelsecusername.Location = new System.Drawing.Point(259, 148);
            this.labelsecusername.Name = "labelsecusername";
            this.labelsecusername.Size = new System.Drawing.Size(91, 20);
            this.labelsecusername.TabIndex = 18;
            this.labelsecusername.Text = "Username";
            // 
            // labelsecquest
            // 
            this.labelsecquest.AutoSize = true;
            this.labelsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelsecquest.ForeColor = System.Drawing.Color.White;
            this.labelsecquest.Location = new System.Drawing.Point(202, 180);
            this.labelsecquest.Name = "labelsecquest";
            this.labelsecquest.Size = new System.Drawing.Size(148, 20);
            this.labelsecquest.TabIndex = 19;
            this.labelsecquest.Text = "Security question";
            // 
            // labelsecansw
            // 
            this.labelsecansw.AutoSize = true;
            this.labelsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelsecansw.ForeColor = System.Drawing.Color.White;
            this.labelsecansw.Location = new System.Drawing.Point(212, 210);
            this.labelsecansw.Name = "labelsecansw";
            this.labelsecansw.Size = new System.Drawing.Size(138, 20);
            this.labelsecansw.TabIndex = 28;
            this.labelsecansw.Text = "Security Answer";
            // 
            // textBoxsecusername
            // 
            this.textBoxsecusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecusername.Enabled = false;
            this.textBoxsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxsecusername.ForeColor = System.Drawing.Color.White;
            this.textBoxsecusername.Location = new System.Drawing.Point(358, 146);
            this.textBoxsecusername.Name = "textBoxsecusername";
            this.textBoxsecusername.Size = new System.Drawing.Size(197, 26);
            this.textBoxsecusername.TabIndex = 16;
            // 
            // textBoxsecquest
            // 
            this.textBoxsecquest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxsecquest.ForeColor = System.Drawing.Color.White;
            this.textBoxsecquest.Location = new System.Drawing.Point(358, 178);
            this.textBoxsecquest.Name = "textBoxsecquest";
            this.textBoxsecquest.ReadOnly = true;
            this.textBoxsecquest.Size = new System.Drawing.Size(343, 26);
            this.textBoxsecquest.TabIndex = 17;
            // 
            // textBoxsecansw
            // 
            this.textBoxsecansw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxsecansw.ForeColor = System.Drawing.Color.White;
            this.textBoxsecansw.Location = new System.Drawing.Point(358, 207);
            this.textBoxsecansw.Name = "textBoxsecansw";
            this.textBoxsecansw.Size = new System.Drawing.Size(197, 26);
            this.textBoxsecansw.TabIndex = 29;
            // 
            // labelanswerror
            // 
            this.labelanswerror.AutoSize = true;
            this.labelanswerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelanswerror.ForeColor = System.Drawing.Color.Red;
            this.labelanswerror.Location = new System.Drawing.Point(317, 243);
            this.labelanswerror.Name = "labelanswerror";
            this.labelanswerror.Size = new System.Drawing.Size(195, 20);
            this.labelanswerror.TabIndex = 27;
            this.labelanswerror.Text = "Invalid Security Answer";
            this.labelanswerror.Visible = false;
            // 
            // panelresetpassword2
            // 
            this.panelresetpassword2.Controls.Add(this.labelNewpassworderror);
            this.panelresetpassword2.Controls.Add(this.labelConfirmNewPassword);
            this.panelresetpassword2.Controls.Add(this.textBoxConfirmNewpassword);
            this.panelresetpassword2.Controls.Add(this.buttonreset);
            this.panelresetpassword2.Controls.Add(this.textBoxNewPassword);
            this.panelresetpassword2.Controls.Add(this.labelNewpassword);
            this.panelresetpassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelresetpassword2.Location = new System.Drawing.Point(0, 0);
            this.panelresetpassword2.Name = "panelresetpassword2";
            this.panelresetpassword2.Size = new System.Drawing.Size(800, 404);
            this.panelresetpassword2.TabIndex = 32;
            this.panelresetpassword2.Visible = false;
            // 
            // labelNewpassworderror
            // 
            this.labelNewpassworderror.AutoSize = true;
            this.labelNewpassworderror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelNewpassworderror.ForeColor = System.Drawing.Color.Red;
            this.labelNewpassworderror.Location = new System.Drawing.Point(259, 247);
            this.labelNewpassworderror.Name = "labelNewpassworderror";
            this.labelNewpassworderror.Size = new System.Drawing.Size(384, 20);
            this.labelNewpassworderror.TabIndex = 35;
            this.labelNewpassworderror.Text = "Passwords arn\'t the same or Invalid Passwords";
            this.labelNewpassworderror.Visible = false;
            // 
            // labelConfirmNewPassword
            // 
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(158, 217);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(192, 20);
            this.labelConfirmNewPassword.TabIndex = 34;
            this.labelConfirmNewPassword.Text = "Confirm New Password";
            // 
            // textBoxConfirmNewpassword
            // 
            this.textBoxConfirmNewpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxConfirmNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxConfirmNewpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxConfirmNewpassword.Location = new System.Drawing.Point(358, 214);
            this.textBoxConfirmNewpassword.Name = "textBoxConfirmNewpassword";
            this.textBoxConfirmNewpassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxConfirmNewpassword.TabIndex = 33;
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonreset.ForeColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(296, 270);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(285, 46);
            this.buttonreset.TabIndex = 32;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxNewPassword.Location = new System.Drawing.Point(358, 178);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxNewPassword.TabIndex = 21;
            // 
            // labelNewpassword
            // 
            this.labelNewpassword.AutoSize = true;
            this.labelNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelNewpassword.ForeColor = System.Drawing.Color.White;
            this.labelNewpassword.Location = new System.Drawing.Point(225, 180);
            this.labelNewpassword.Name = "labelNewpassword";
            this.labelNewpassword.Size = new System.Drawing.Size(125, 20);
            this.labelNewpassword.TabIndex = 20;
            this.labelNewpassword.Text = "New Password";
            // 
            // SignupBuild
            // 
            this.SignupBuild.Controls.Add(this.label1);
            this.SignupBuild.Controls.Add(this.button2);
            this.SignupBuild.Controls.Add(this.buttonnextandSignup);
            this.SignupBuild.Controls.Add(this.buttonback);
            this.SignupBuild.Controls.Add(this.panelpart3);
            this.SignupBuild.Controls.Add(this.panelpart1);
            this.SignupBuild.Controls.Add(this.panelpart2);
            this.SignupBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignupBuild.Location = new System.Drawing.Point(0, 46);
            this.SignupBuild.Name = "SignupBuild";
            this.SignupBuild.Size = new System.Drawing.Size(800, 404);
            this.SignupBuild.TabIndex = 33;
            this.SignupBuild.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aussiesky";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(332, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "Have a account, Sign in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonnextandSignup
            // 
            this.buttonnextandSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnextandSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonnextandSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
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
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
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
            // panelpart1
            // 
            this.panelpart1.Controls.Add(this.panel3);
            this.panelpart1.Controls.Add(this.labelerrorpass);
            this.panelpart1.Controls.Add(this.labelerroruser);
            this.panelpart1.Controls.Add(this.label2);
            this.panelpart1.Controls.Add(this.label3);
            this.panelpart1.Controls.Add(this.labelconpassword);
            this.panelpart1.Controls.Add(this.textBox1);
            this.panelpart1.Controls.Add(this.textBox2);
            this.panelpart1.Controls.Add(this.textBoxconpassword);
            this.panelpart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpart1.Location = new System.Drawing.Point(0, 0);
            this.panelpart1.Name = "panelpart1";
            this.panelpart1.Size = new System.Drawing.Size(800, 404);
            this.panelpart1.TabIndex = 29;
            this.panelpart1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::aussiesky.Properties.Resources.Untitled_removebg_preview;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(260, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 71);
            this.panel3.TabIndex = 26;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password*";
            // 
            // labelconpassword
            // 
            this.labelconpassword.AutoSize = true;
            this.labelconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelconpassword.ForeColor = System.Drawing.Color.White;
            this.labelconpassword.Location = new System.Drawing.Point(199, 217);
            this.labelconpassword.Name = "labelconpassword";
            this.labelconpassword.Size = new System.Drawing.Size(160, 20);
            this.labelconpassword.TabIndex = 9;
            this.labelconpassword.Text = "Confirm Password*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(358, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(358, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 26);
            this.textBox2.TabIndex = 1;
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
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            this.labellname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            this.labeldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            // panelpart3
            // 
            this.panelpart3.Controls.Add(this.labelerrorsecquest);
            this.panelpart3.Controls.Add(this.labelerrorsecansw);
            this.panelpart3.Controls.Add(this.comboBox1);
            this.panelpart3.Controls.Add(this.label4);
            this.panelpart3.Controls.Add(this.label5);
            this.panelpart3.Controls.Add(this.textBox3);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(197, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Security question*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security answer*";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(351, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 26);
            this.textBox3.TabIndex = 9;
            // 
            // SiginBuild
            // 
            this.SiginBuild.Controls.Add(this.label9);
            this.SiginBuild.Controls.Add(this.panel1);
            this.SiginBuild.Controls.Add(this.panelresetpasswordQ);
            this.SiginBuild.Controls.Add(this.SigninBuild);
            this.SiginBuild.Controls.Add(this.panelresetpasswordFA);
            this.SiginBuild.Controls.Add(this.panelresetpassword2);
            this.SiginBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiginBuild.Location = new System.Drawing.Point(0, 46);
            this.SiginBuild.Name = "SiginBuild";
            this.SiginBuild.Size = new System.Drawing.Size(800, 404);
            this.SiginBuild.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(372, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aussiesky";
            // 
            // OnlineServerConnect
            // 
            this.OnlineServerConnect.AutoSize = true;
            this.OnlineServerConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OnlineServerConnect.ForeColor = System.Drawing.Color.White;
            this.OnlineServerConnect.Location = new System.Drawing.Point(266, 228);
            this.OnlineServerConnect.Name = "OnlineServerConnect";
            this.OnlineServerConnect.Size = new System.Drawing.Size(134, 24);
            this.OnlineServerConnect.TabIndex = 30;
            this.OnlineServerConnect.Text = "Online Signin";
            this.OnlineServerConnect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(561, 3);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewAccounts.TabIndex = 31;
            this.dataGridViewAccounts.Visible = false;
            // 
            // panelresetpasswordFA
            // 
            this.panelresetpasswordFA.Controls.Add(this.label6);
            this.panelresetpasswordFA.Controls.Add(this.label7);
            this.panelresetpasswordFA.Controls.Add(this.label8);
            this.panelresetpasswordFA.Controls.Add(this.buttonnextfa);
            this.panelresetpasswordFA.Controls.Add(this.textBoxfaemail);
            this.panelresetpasswordFA.Controls.Add(this.Securityanswer);
            this.panelresetpasswordFA.Controls.Add(this.label11);
            this.panelresetpasswordFA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelresetpasswordFA.Location = new System.Drawing.Point(0, 0);
            this.panelresetpasswordFA.Name = "panelresetpasswordFA";
            this.panelresetpasswordFA.Size = new System.Drawing.Size(800, 404);
            this.panelresetpasswordFA.TabIndex = 33;
            this.panelresetpasswordFA.Visible = false;
            // 
            // buttonnextfa
            // 
            this.buttonnextfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnextfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonnextfa.ForeColor = System.Drawing.Color.White;
            this.buttonnextfa.Location = new System.Drawing.Point(303, 270);
            this.buttonnextfa.Name = "buttonnextfa";
            this.buttonnextfa.Size = new System.Drawing.Size(285, 46);
            this.buttonnextfa.TabIndex = 31;
            this.buttonnextfa.Text = "Next";
            this.buttonnextfa.UseVisualStyleBackColor = false;
            // 
            // textBoxfaemail
            // 
            this.textBoxfaemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxfaemail.Enabled = false;
            this.textBoxfaemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxfaemail.ForeColor = System.Drawing.Color.White;
            this.textBoxfaemail.Location = new System.Drawing.Point(358, 173);
            this.textBoxfaemail.Name = "textBoxfaemail";
            this.textBoxfaemail.Size = new System.Drawing.Size(197, 26);
            this.textBoxfaemail.TabIndex = 16;
            this.textBoxfaemail.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(404, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Invalid Code";
            this.label11.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(257, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(212, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Security Answer";
            // 
            // Securityanswer
            // 
            this.Securityanswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.Securityanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Securityanswer.ForeColor = System.Drawing.Color.White;
            this.Securityanswer.Location = new System.Drawing.Point(358, 207);
            this.Securityanswer.Name = "Securityanswer";
            this.Securityanswer.Size = new System.Drawing.Size(197, 26);
            this.Securityanswer.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Security code have been sent to account email";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SiginBuild);
            this.Controls.Add(this.SignupBuild);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.SigninBuild.ResumeLayout(false);
            this.SigninBuild.PerformLayout();
            this.panelresetpasswordQ.ResumeLayout(false);
            this.panelresetpasswordQ.PerformLayout();
            this.panelresetpassword2.ResumeLayout(false);
            this.panelresetpassword2.PerformLayout();
            this.SignupBuild.ResumeLayout(false);
            this.SignupBuild.PerformLayout();
            this.panelpart1.ResumeLayout(false);
            this.panelpart1.PerformLayout();
            this.panelpart2.ResumeLayout(false);
            this.panelpart2.PerformLayout();
            this.panelpart3.ResumeLayout(false);
            this.panelpart3.PerformLayout();
            this.SiginBuild.ResumeLayout(false);
            this.SiginBuild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.panelresetpasswordFA.ResumeLayout(false);
            this.panelresetpasswordFA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelloginerror;
        private System.Windows.Forms.Panel panelresetpasswordQ;
        private System.Windows.Forms.TextBox textBoxsecansw;
        private System.Windows.Forms.Label labelsecansw;
        private System.Windows.Forms.Label labelsecquest;
        private System.Windows.Forms.Label labelsecusername;
        private System.Windows.Forms.TextBox textBoxsecquest;
        private System.Windows.Forms.TextBox textBoxsecusername;
        private System.Windows.Forms.Label labelanswerror;
        private System.Windows.Forms.Button buttonresetpassword;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Panel panelresetpassword2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewpassword;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewpassword;
        private System.Windows.Forms.Label labelNewpassworderror;
        private Panel SigninBuild;
        private Panel SignupBuild;
        private Label label1;
        private Button button2;
        private Button buttonnextandSignup;
        private Button buttonback;
        private Panel panelpart1;
        private Panel panel3;
        private Label labelerrorpass;
        private Label labelerroruser;
        private Label label2;
        private Label label3;
        private Label labelconpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxconpassword;
        private Panel panelpart2;
        private Label labelerrorgender;
        private Label labelerroremail;
        private Label labelerrorlname;
        private Label labelerrorfname;
        private Label labelfname;
        private Label labellname;
        private Label labelemail;
        private Label labelgender;
        private Label labeldob;
        private TextBox textBoxfname;
        private TextBox textBoxlname;
        private TextBox textBoxemail;
        private ComboBox comboBoxgender;
        private DateTimePicker dateTimePickerdob;
        private Panel panelpart3;
        private Label labelerrorsecquest;
        private Label labelerrorsecansw;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Panel SiginBuild;
        private Label label9;
        private CheckBox OnlineServerConnect;
        private DataGridView dataGridViewAccounts;
        private Panel panelresetpasswordFA;
        private Button buttonnextfa;
        private TextBox textBoxfaemail;
        private Label label11;
        private Label label7;
        private Label label8;
        private TextBox Securityanswer;
        private Label label6;
    }
}