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
            this.label9 = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelloginerror = new System.Windows.Forms.Label();
            this.panelsignin = new System.Windows.Forms.Panel();
            this.buttonresetpassword = new System.Windows.Forms.Button();
            this.panelresetpassword = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.labelsecusername = new System.Windows.Forms.Label();
            this.labelsecquest = new System.Windows.Forms.Label();
            this.labelsecansw = new System.Windows.Forms.Label();
            this.textBoxsecusername = new System.Windows.Forms.TextBox();
            this.textBoxsecquest = new System.Windows.Forms.TextBox();
            this.textBoxsecansw = new System.Windows.Forms.TextBox();
            this.labelerrorusername = new System.Windows.Forms.Label();
            this.labelanswerror = new System.Windows.Forms.Label();
            this.panelresetpassword2 = new System.Windows.Forms.Panel();
            this.labelNewpassworderror = new System.Windows.Forms.Label();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmNewpassword = new System.Windows.Forms.TextBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewpassword = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.panelsignin.SuspendLayout();
            this.panelresetpassword.SuspendLayout();
            this.panelresetpassword2.SuspendLayout();
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(351, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aussiesky";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(266, 180);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(86, 20);
            this.labelpassword.TabIndex = 19;
            this.labelpassword.Text = "Password";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(259, 148);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(93, 20);
            this.labelusername.TabIndex = 18;
            this.labelusername.Text = "UserName";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxpassword.Location = new System.Drawing.Point(358, 178);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxpassword.TabIndex = 16;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.ForeColor = System.Drawing.Color.White;
            this.textBoxusername.Location = new System.Drawing.Point(358, 146);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(197, 26);
            this.textBoxusername.TabIndex = 16;
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Showpass.ForeColor = System.Drawing.Color.White;
            this.Showpass.Location = new System.Drawing.Point(358, 216);
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
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(312, 320);
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
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignin.ForeColor = System.Drawing.Color.White;
            this.buttonSignin.Location = new System.Drawing.Point(296, 270);
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
            this.panel1.BackgroundImage = global::Aussieskys.Properties.Resources.Untitled_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(263, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 71);
            this.panel1.TabIndex = 25;
            // 
            // labelloginerror
            // 
            this.labelloginerror.AutoSize = true;
            this.labelloginerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelloginerror.ForeColor = System.Drawing.Color.Red;
            this.labelloginerror.Location = new System.Drawing.Point(317, 243);
            this.labelloginerror.Name = "labelloginerror";
            this.labelloginerror.Size = new System.Drawing.Size(251, 20);
            this.labelloginerror.TabIndex = 27;
            this.labelloginerror.Text = "Invalid Username or Password";
            this.labelloginerror.Visible = false;
            // 
            // panelsignin
            // 
            this.panelsignin.Controls.Add(this.buttonSignup);
            this.panelsignin.Controls.Add(this.buttonSignin);
            this.panelsignin.Controls.Add(this.labelusername);
            this.panelsignin.Controls.Add(this.labelpassword);
            this.panelsignin.Controls.Add(this.textBoxusername);
            this.panelsignin.Controls.Add(this.textBoxpassword);
            this.panelsignin.Controls.Add(this.Showpass);
            this.panelsignin.Controls.Add(this.labelloginerror);
            this.panelsignin.Controls.Add(this.buttonresetpassword);
            this.panelsignin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsignin.Location = new System.Drawing.Point(0, 46);
            this.panelsignin.Name = "panelsignin";
            this.panelsignin.Size = new System.Drawing.Size(800, 404);
            this.panelsignin.TabIndex = 28;
            // 
            // buttonresetpassword
            // 
            this.buttonresetpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.buttonresetpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonresetpassword.FlatAppearance.BorderSize = 0;
            this.buttonresetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonresetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonresetpassword.ForeColor = System.Drawing.Color.White;
            this.buttonresetpassword.Location = new System.Drawing.Point(587, 270);
            this.buttonresetpassword.Name = "buttonresetpassword";
            this.buttonresetpassword.Size = new System.Drawing.Size(141, 46);
            this.buttonresetpassword.TabIndex = 29;
            this.buttonresetpassword.Text = "Reset Password";
            this.buttonresetpassword.UseVisualStyleBackColor = false;
            this.buttonresetpassword.Click += new System.EventHandler(this.buttonresetpassword_Click);
            // 
            // panelresetpassword
            // 
            this.panelresetpassword.Controls.Add(this.button1);
            this.panelresetpassword.Controls.Add(this.buttonnext);
            this.panelresetpassword.Controls.Add(this.labelsecusername);
            this.panelresetpassword.Controls.Add(this.labelsecquest);
            this.panelresetpassword.Controls.Add(this.labelsecansw);
            this.panelresetpassword.Controls.Add(this.textBoxsecusername);
            this.panelresetpassword.Controls.Add(this.textBoxsecquest);
            this.panelresetpassword.Controls.Add(this.textBoxsecansw);
            this.panelresetpassword.Controls.Add(this.labelerrorusername);
            this.panelresetpassword.Controls.Add(this.labelanswerror);
            this.panelresetpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelresetpassword.Location = new System.Drawing.Point(0, 46);
            this.panelresetpassword.Name = "panelresetpassword";
            this.panelresetpassword.Size = new System.Drawing.Size(800, 404);
            this.panelresetpassword.TabIndex = 22;
            this.panelresetpassword.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(565, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonnext.ForeColor = System.Drawing.Color.White;
            this.buttonnext.Location = new System.Drawing.Point(296, 270);
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
            this.labelsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecusername.ForeColor = System.Drawing.Color.White;
            this.textBoxsecusername.Location = new System.Drawing.Point(358, 146);
            this.textBoxsecusername.Name = "textBoxsecusername";
            this.textBoxsecusername.Size = new System.Drawing.Size(197, 26);
            this.textBoxsecusername.TabIndex = 16;
            // 
            // textBoxsecquest
            // 
            this.textBoxsecquest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecansw.ForeColor = System.Drawing.Color.White;
            this.textBoxsecansw.Location = new System.Drawing.Point(358, 207);
            this.textBoxsecansw.Name = "textBoxsecansw";
            this.textBoxsecansw.Size = new System.Drawing.Size(197, 26);
            this.textBoxsecansw.TabIndex = 29;
            // 
            // labelerrorusername
            // 
            this.labelerrorusername.AutoSize = true;
            this.labelerrorusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelerrorusername.ForeColor = System.Drawing.Color.Red;
            this.labelerrorusername.Location = new System.Drawing.Point(372, 126);
            this.labelerrorusername.Name = "labelerrorusername";
            this.labelerrorusername.Size = new System.Drawing.Size(148, 20);
            this.labelerrorusername.TabIndex = 30;
            this.labelerrorusername.Text = "Invalid Username";
            this.labelerrorusername.Visible = false;
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
            this.panelresetpassword2.Location = new System.Drawing.Point(0, 46);
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
            this.labelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxConfirmNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxNewPassword.Location = new System.Drawing.Point(358, 178);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxNewPassword.TabIndex = 21;
            // 
            // labelNewpassword
            // 
            this.labelNewpassword.AutoSize = true;
            this.labelNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewpassword.ForeColor = System.Drawing.Color.White;
            this.labelNewpassword.Location = new System.Drawing.Point(225, 180);
            this.labelNewpassword.Name = "labelNewpassword";
            this.labelNewpassword.Size = new System.Drawing.Size(125, 20);
            this.labelNewpassword.TabIndex = 20;
            this.labelNewpassword.Text = "New Password";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsignin);
            this.Controls.Add(this.panelresetpassword);
            this.Controls.Add(this.panelresetpassword2);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.panelsignin.ResumeLayout(false);
            this.panelsignin.PerformLayout();
            this.panelresetpassword.ResumeLayout(false);
            this.panelresetpassword.PerformLayout();
            this.panelresetpassword2.ResumeLayout(false);
            this.panelresetpassword2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelloginerror;
        private System.Windows.Forms.Panel panelsignin;
        private System.Windows.Forms.Panel panelresetpassword;
        private System.Windows.Forms.TextBox textBoxsecansw;
        private System.Windows.Forms.Label labelsecansw;
        private System.Windows.Forms.Label labelsecquest;
        private System.Windows.Forms.Label labelsecusername;
        private System.Windows.Forms.TextBox textBoxsecquest;
        private System.Windows.Forms.TextBox textBoxsecusername;
        private System.Windows.Forms.Label labelanswerror;
        private System.Windows.Forms.Button buttonresetpassword;
        private System.Windows.Forms.Label labelerrorusername;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Panel panelresetpassword2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewpassword;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewpassword;
        private System.Windows.Forms.Label labelNewpassworderror;
    }
}