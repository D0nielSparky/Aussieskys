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
            this.Header.SuspendLayout();
            this.ControlBox.SuspendLayout();
            this.SigninBuild.SuspendLayout();
            this.panelresetpassword.SuspendLayout();
            this.panelresetpassword2.SuspendLayout();
            this.SignupBuild.SuspendLayout();
            this.panelpart1.SuspendLayout();
            this.panelpart2.SuspendLayout();
            this.panelpart3.SuspendLayout();
            this.SiginBuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.Header.Controls.Add(this.labelTitle);
            this.Header.Controls.Add(this.ControlBox);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(933, 53);
            this.Header.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(6, 3);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ControlBox.Location = new System.Drawing.Point(848, 0);
            this.ControlBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(85, 53);
            this.ControlBox.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::aussiesky.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(49, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(308, 212);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(86, 20);
            this.labelpassword.TabIndex = 19;
            this.labelpassword.Text = "Password";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(301, 174);
            this.labelusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(93, 20);
            this.labelusername.TabIndex = 18;
            this.labelusername.Text = "UserName";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxpassword.Location = new System.Drawing.Point(402, 204);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(229, 29);
            this.textBoxpassword.TabIndex = 16;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxusername.ForeColor = System.Drawing.Color.White;
            this.textBoxusername.Location = new System.Drawing.Point(402, 168);
            this.textBoxusername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(229, 26);
            this.textBoxusername.TabIndex = 16;
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Showpass.ForeColor = System.Drawing.Color.White;
            this.Showpass.Location = new System.Drawing.Point(310, 242);
            this.Showpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(310, 362);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(299, 53);
            this.buttonSignup.TabIndex = 24;
            this.buttonSignup.Text = "Don\'t have a Account, Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSignin.ForeColor = System.Drawing.Color.White;
            this.buttonSignin.Location = new System.Drawing.Point(299, 303);
            this.buttonSignin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(332, 53);
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
            this.panel1.Location = new System.Drawing.Point(307, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 82);
            this.panel1.TabIndex = 25;
            // 
            // labelloginerror
            // 
            this.labelloginerror.AutoSize = true;
            this.labelloginerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelloginerror.ForeColor = System.Drawing.Color.Red;
            this.labelloginerror.Location = new System.Drawing.Point(345, 271);
            this.labelloginerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelloginerror.Name = "labelloginerror";
            this.labelloginerror.Size = new System.Drawing.Size(251, 20);
            this.labelloginerror.TabIndex = 27;
            this.labelloginerror.Text = "Invalid Username or Password";
            this.labelloginerror.Visible = false;
            // 
            // SigninBuild
            // 
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
            this.SigninBuild.Size = new System.Drawing.Size(933, 463);
            this.SigninBuild.TabIndex = 30;
            // 
            // buttonresetpassword
            // 
            this.buttonresetpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.buttonresetpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonresetpassword.FlatAppearance.BorderSize = 0;
            this.buttonresetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonresetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.buttonresetpassword.ForeColor = System.Drawing.Color.White;
            this.buttonresetpassword.Location = new System.Drawing.Point(639, 190);
            this.buttonresetpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonresetpassword.Name = "buttonresetpassword";
            this.buttonresetpassword.Size = new System.Drawing.Size(164, 53);
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
            this.panelresetpassword.Location = new System.Drawing.Point(0, 0);
            this.panelresetpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelresetpassword.Name = "panelresetpassword";
            this.panelresetpassword.Size = new System.Drawing.Size(933, 466);
            this.panelresetpassword.TabIndex = 22;
            this.panelresetpassword.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(659, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonnext.ForeColor = System.Drawing.Color.White;
            this.buttonnext.Location = new System.Drawing.Point(354, 312);
            this.buttonnext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(332, 53);
            this.buttonnext.TabIndex = 31;
            this.buttonnext.Text = "Next";
            this.buttonnext.UseVisualStyleBackColor = false;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // labelsecusername
            // 
            this.labelsecusername.AutoSize = true;
            this.labelsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsecusername.ForeColor = System.Drawing.Color.White;
            this.labelsecusername.Location = new System.Drawing.Point(302, 171);
            this.labelsecusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsecusername.Name = "labelsecusername";
            this.labelsecusername.Size = new System.Drawing.Size(91, 20);
            this.labelsecusername.TabIndex = 18;
            this.labelsecusername.Text = "Username";
            // 
            // labelsecquest
            // 
            this.labelsecquest.AutoSize = true;
            this.labelsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsecquest.ForeColor = System.Drawing.Color.White;
            this.labelsecquest.Location = new System.Drawing.Point(236, 208);
            this.labelsecquest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsecquest.Name = "labelsecquest";
            this.labelsecquest.Size = new System.Drawing.Size(148, 20);
            this.labelsecquest.TabIndex = 19;
            this.labelsecquest.Text = "Security question";
            // 
            // labelsecansw
            // 
            this.labelsecansw.AutoSize = true;
            this.labelsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsecansw.ForeColor = System.Drawing.Color.White;
            this.labelsecansw.Location = new System.Drawing.Point(247, 242);
            this.labelsecansw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsecansw.Name = "labelsecansw";
            this.labelsecansw.Size = new System.Drawing.Size(138, 20);
            this.labelsecansw.TabIndex = 28;
            this.labelsecansw.Text = "Security Answer";
            // 
            // textBoxsecusername
            // 
            this.textBoxsecusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxsecusername.ForeColor = System.Drawing.Color.White;
            this.textBoxsecusername.Location = new System.Drawing.Point(418, 168);
            this.textBoxsecusername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxsecusername.Name = "textBoxsecusername";
            this.textBoxsecusername.Size = new System.Drawing.Size(229, 26);
            this.textBoxsecusername.TabIndex = 16;
            // 
            // textBoxsecquest
            // 
            this.textBoxsecquest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxsecquest.ForeColor = System.Drawing.Color.White;
            this.textBoxsecquest.Location = new System.Drawing.Point(418, 205);
            this.textBoxsecquest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxsecquest.Name = "textBoxsecquest";
            this.textBoxsecquest.ReadOnly = true;
            this.textBoxsecquest.Size = new System.Drawing.Size(400, 26);
            this.textBoxsecquest.TabIndex = 17;
            // 
            // textBoxsecansw
            // 
            this.textBoxsecansw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxsecansw.ForeColor = System.Drawing.Color.White;
            this.textBoxsecansw.Location = new System.Drawing.Point(418, 239);
            this.textBoxsecansw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxsecansw.Name = "textBoxsecansw";
            this.textBoxsecansw.Size = new System.Drawing.Size(229, 26);
            this.textBoxsecansw.TabIndex = 29;
            // 
            // labelerrorusername
            // 
            this.labelerrorusername.AutoSize = true;
            this.labelerrorusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorusername.ForeColor = System.Drawing.Color.Red;
            this.labelerrorusername.Location = new System.Drawing.Point(434, 145);
            this.labelerrorusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorusername.Name = "labelerrorusername";
            this.labelerrorusername.Size = new System.Drawing.Size(148, 20);
            this.labelerrorusername.TabIndex = 30;
            this.labelerrorusername.Text = "Invalid Username";
            this.labelerrorusername.Visible = false;
            // 
            // labelanswerror
            // 
            this.labelanswerror.AutoSize = true;
            this.labelanswerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanswerror.ForeColor = System.Drawing.Color.Red;
            this.labelanswerror.Location = new System.Drawing.Point(370, 280);
            this.labelanswerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panelresetpassword2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelresetpassword2.Name = "panelresetpassword2";
            this.panelresetpassword2.Size = new System.Drawing.Size(933, 466);
            this.panelresetpassword2.TabIndex = 32;
            this.panelresetpassword2.Visible = false;
            // 
            // labelNewpassworderror
            // 
            this.labelNewpassworderror.AutoSize = true;
            this.labelNewpassworderror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewpassworderror.ForeColor = System.Drawing.Color.Red;
            this.labelNewpassworderror.Location = new System.Drawing.Point(302, 285);
            this.labelNewpassworderror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewpassworderror.Name = "labelNewpassworderror";
            this.labelNewpassworderror.Size = new System.Drawing.Size(384, 20);
            this.labelNewpassworderror.TabIndex = 35;
            this.labelNewpassworderror.Text = "Passwords arn\'t the same or Invalid Passwords";
            this.labelNewpassworderror.Visible = false;
            // 
            // labelConfirmNewPassword
            // 
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(184, 250);
            this.labelConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(192, 20);
            this.labelConfirmNewPassword.TabIndex = 34;
            this.labelConfirmNewPassword.Text = "Confirm New Password";
            // 
            // textBoxConfirmNewpassword
            // 
            this.textBoxConfirmNewpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxConfirmNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConfirmNewpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxConfirmNewpassword.Location = new System.Drawing.Point(418, 247);
            this.textBoxConfirmNewpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxConfirmNewpassword.Name = "textBoxConfirmNewpassword";
            this.textBoxConfirmNewpassword.Size = new System.Drawing.Size(229, 26);
            this.textBoxConfirmNewpassword.TabIndex = 33;
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonreset.ForeColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(345, 312);
            this.buttonreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(332, 53);
            this.buttonreset.TabIndex = 32;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxNewPassword.Location = new System.Drawing.Point(418, 205);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(229, 26);
            this.textBoxNewPassword.TabIndex = 21;
            // 
            // labelNewpassword
            // 
            this.labelNewpassword.AutoSize = true;
            this.labelNewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewpassword.ForeColor = System.Drawing.Color.White;
            this.labelNewpassword.Location = new System.Drawing.Point(262, 208);
            this.labelNewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.SignupBuild.Controls.Add(this.panelpart1);
            this.SignupBuild.Controls.Add(this.panelpart2);
            this.SignupBuild.Controls.Add(this.panelpart3);
            this.SignupBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignupBuild.Location = new System.Drawing.Point(0, 53);
            this.SignupBuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SignupBuild.Name = "SignupBuild";
            this.SignupBuild.Size = new System.Drawing.Size(933, 466);
            this.SignupBuild.TabIndex = 33;
            this.SignupBuild.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 53);
            this.button2.TabIndex = 18;
            this.button2.Text = "Have a account, Sign in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonnextandSignup
            // 
            this.buttonnextandSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonnextandSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonnextandSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonnextandSignup.ForeColor = System.Drawing.Color.White;
            this.buttonnextandSignup.Location = new System.Drawing.Point(516, 332);
            this.buttonnextandSignup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonnextandSignup.Name = "buttonnextandSignup";
            this.buttonnextandSignup.Size = new System.Drawing.Size(250, 53);
            this.buttonnextandSignup.TabIndex = 17;
            this.buttonnextandSignup.Text = "Next";
            this.buttonnextandSignup.UseVisualStyleBackColor = false;
            this.buttonnextandSignup.Click += new System.EventHandler(this.buttonnextandSignup_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonback.ForeColor = System.Drawing.Color.White;
            this.buttonback.Location = new System.Drawing.Point(262, 332);
            this.buttonback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(250, 53);
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
            this.panelpart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelpart1.Name = "panelpart1";
            this.panelpart1.Size = new System.Drawing.Size(933, 466);
            this.panelpart1.TabIndex = 29;
            this.panelpart1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::aussiesky.Properties.Resources.Untitled_removebg_preview;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(303, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 82);
            this.panel3.TabIndex = 26;
            // 
            // labelerrorpass
            // 
            this.labelerrorpass.AutoSize = true;
            this.labelerrorpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorpass.ForeColor = System.Drawing.Color.Red;
            this.labelerrorpass.Location = new System.Drawing.Point(654, 233);
            this.labelerrorpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorpass.Name = "labelerrorpass";
            this.labelerrorpass.Size = new System.Drawing.Size(215, 20);
            this.labelerrorpass.TabIndex = 11;
            this.labelerrorpass.Text = "Passwords arn\'t the same";
            this.labelerrorpass.Visible = false;
            // 
            // labelerroruser
            // 
            this.labelerroruser.AutoSize = true;
            this.labelerroruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerroruser.ForeColor = System.Drawing.Color.Red;
            this.labelerroruser.Location = new System.Drawing.Point(654, 174);
            this.labelerroruser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerroruser.Name = "labelerroruser";
            this.labelerroruser.Size = new System.Drawing.Size(198, 20);
            this.labelerroruser.TabIndex = 10;
            this.labelerroruser.Text = "Username already used";
            this.labelerroruser.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password*";
            // 
            // labelconpassword
            // 
            this.labelconpassword.AutoSize = true;
            this.labelconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelconpassword.ForeColor = System.Drawing.Color.White;
            this.labelconpassword.Location = new System.Drawing.Point(232, 250);
            this.labelconpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelconpassword.Name = "labelconpassword";
            this.labelconpassword.Size = new System.Drawing.Size(160, 20);
            this.labelconpassword.TabIndex = 9;
            this.labelconpassword.Text = "Confirm Password*";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(418, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(418, 210);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBoxconpassword
            // 
            this.textBoxconpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxconpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxconpassword.ForeColor = System.Drawing.Color.White;
            this.textBoxconpassword.Location = new System.Drawing.Point(418, 248);
            this.textBoxconpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxconpassword.Name = "textBoxconpassword";
            this.textBoxconpassword.Size = new System.Drawing.Size(229, 26);
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
            this.panelpart2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelpart2.Name = "panelpart2";
            this.panelpart2.Size = new System.Drawing.Size(933, 466);
            this.panelpart2.TabIndex = 10;
            this.panelpart2.Visible = false;
            // 
            // labelerrorgender
            // 
            this.labelerrorgender.AutoSize = true;
            this.labelerrorgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorgender.ForeColor = System.Drawing.Color.Red;
            this.labelerrorgender.Location = new System.Drawing.Point(569, 248);
            this.labelerrorgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorgender.Name = "labelerrorgender";
            this.labelerrorgender.Size = new System.Drawing.Size(122, 20);
            this.labelerrorgender.TabIndex = 32;
            this.labelerrorgender.Text = "Invalid gender";
            this.labelerrorgender.Visible = false;
            // 
            // labelerroremail
            // 
            this.labelerroremail.AutoSize = true;
            this.labelerroremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerroremail.ForeColor = System.Drawing.Color.Red;
            this.labelerroremail.Location = new System.Drawing.Point(654, 207);
            this.labelerroremail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerroremail.Name = "labelerroremail";
            this.labelerroremail.Size = new System.Drawing.Size(108, 20);
            this.labelerroremail.TabIndex = 31;
            this.labelerroremail.Text = "Invalid email";
            this.labelerroremail.Visible = false;
            // 
            // labelerrorlname
            // 
            this.labelerrorlname.AutoSize = true;
            this.labelerrorlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorlname.ForeColor = System.Drawing.Color.Red;
            this.labelerrorlname.Location = new System.Drawing.Point(654, 170);
            this.labelerrorlname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorlname.Name = "labelerrorlname";
            this.labelerrorlname.Size = new System.Drawing.Size(110, 20);
            this.labelerrorlname.TabIndex = 30;
            this.labelerrorlname.Text = "Invalid name";
            this.labelerrorlname.Visible = false;
            // 
            // labelerrorfname
            // 
            this.labelerrorfname.AutoSize = true;
            this.labelerrorfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorfname.ForeColor = System.Drawing.Color.Red;
            this.labelerrorfname.Location = new System.Drawing.Point(654, 130);
            this.labelerrorfname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorfname.Name = "labelerrorfname";
            this.labelerrorfname.Size = new System.Drawing.Size(110, 20);
            this.labelerrorfname.TabIndex = 29;
            this.labelerrorfname.Text = "Invalid name";
            this.labelerrorfname.Visible = false;
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfname.ForeColor = System.Drawing.Color.White;
            this.labelfname.Location = new System.Drawing.Point(302, 130);
            this.labelfname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(103, 20);
            this.labelfname.TabIndex = 10;
            this.labelfname.Text = "First Name*";
            // 
            // labellname
            // 
            this.labellname.AutoSize = true;
            this.labellname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellname.ForeColor = System.Drawing.Color.White;
            this.labellname.Location = new System.Drawing.Point(300, 171);
            this.labellname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labellname.Name = "labellname";
            this.labellname.Size = new System.Drawing.Size(102, 20);
            this.labellname.TabIndex = 11;
            this.labellname.Text = "Last Name*";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelemail.ForeColor = System.Drawing.Color.White;
            this.labelemail.Location = new System.Drawing.Point(270, 207);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(131, 20);
            this.labelemail.TabIndex = 28;
            this.labelemail.Text = "Email Address*";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelgender.ForeColor = System.Drawing.Color.White;
            this.labelgender.Location = new System.Drawing.Point(330, 245);
            this.labelgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(76, 20);
            this.labelgender.TabIndex = 12;
            this.labelgender.Text = "Gender*";
            // 
            // labeldob
            // 
            this.labeldob.AutoSize = true;
            this.labeldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldob.ForeColor = System.Drawing.Color.White;
            this.labeldob.Location = new System.Drawing.Point(280, 285);
            this.labeldob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldob.Name = "labeldob";
            this.labeldob.Size = new System.Drawing.Size(119, 20);
            this.labeldob.TabIndex = 13;
            this.labeldob.Text = "Date of Birth*";
            // 
            // textBoxfname
            // 
            this.textBoxfname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxfname.ForeColor = System.Drawing.Color.White;
            this.textBoxfname.Location = new System.Drawing.Point(421, 128);
            this.textBoxfname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxfname.Name = "textBoxfname";
            this.textBoxfname.Size = new System.Drawing.Size(229, 26);
            this.textBoxfname.TabIndex = 3;
            // 
            // textBoxlname
            // 
            this.textBoxlname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxlname.ForeColor = System.Drawing.Color.White;
            this.textBoxlname.Location = new System.Drawing.Point(421, 166);
            this.textBoxlname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxlname.Name = "textBoxlname";
            this.textBoxlname.Size = new System.Drawing.Size(229, 26);
            this.textBoxlname.TabIndex = 4;
            // 
            // textBoxemail
            // 
            this.textBoxemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxemail.ForeColor = System.Drawing.Color.White;
            this.textBoxemail.Location = new System.Drawing.Point(421, 203);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(229, 26);
            this.textBoxemail.TabIndex = 27;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.comboBoxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxgender.ForeColor = System.Drawing.Color.White;
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Prefer not to answer"});
            this.comboBoxgender.Location = new System.Drawing.Point(421, 240);
            this.comboBoxgender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(140, 28);
            this.comboBoxgender.TabIndex = 5;
            this.comboBoxgender.Tag = "";
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickerdob.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerdob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerdob.Location = new System.Drawing.Point(421, 282);
            this.dateTimePickerdob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.ShowUpDown = true;
            this.dateTimePickerdob.Size = new System.Drawing.Size(123, 26);
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
            this.panelpart3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelpart3.Name = "panelpart3";
            this.panelpart3.Size = new System.Drawing.Size(933, 466);
            this.panelpart3.TabIndex = 10;
            this.panelpart3.Visible = false;
            // 
            // labelerrorsecquest
            // 
            this.labelerrorsecquest.AutoSize = true;
            this.labelerrorsecquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorsecquest.ForeColor = System.Drawing.Color.Red;
            this.labelerrorsecquest.Location = new System.Drawing.Point(790, 172);
            this.labelerrorsecquest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelerrorsecquest.Name = "labelerrorsecquest";
            this.labelerrorsecquest.Size = new System.Drawing.Size(118, 20);
            this.labelerrorsecquest.TabIndex = 32;
            this.labelerrorsecquest.Text = "Invalid choice";
            this.labelerrorsecquest.Visible = false;
            // 
            // labelerrorsecansw
            // 
            this.labelerrorsecansw.AutoSize = true;
            this.labelerrorsecansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerrorsecansw.ForeColor = System.Drawing.Color.Red;
            this.labelerrorsecansw.Location = new System.Drawing.Point(654, 241);
            this.labelerrorsecansw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.comboBox1.Location = new System.Drawing.Point(410, 197);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Security question*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security answer*";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(410, 238);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 26);
            this.textBox3.TabIndex = 9;
            // 
            // SiginBuild
            // 
            this.SiginBuild.Controls.Add(this.panel1);
            this.SiginBuild.Controls.Add(this.label9);
            this.SiginBuild.Controls.Add(this.SigninBuild);
            this.SiginBuild.Controls.Add(this.panelresetpassword);
            this.SiginBuild.Controls.Add(this.panelresetpassword2);
            this.SiginBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SiginBuild.Location = new System.Drawing.Point(0, 53);
            this.SiginBuild.Name = "SiginBuild";
            this.SiginBuild.Size = new System.Drawing.Size(933, 466);
            this.SiginBuild.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(434, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aussiesky";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.SignupBuild);
            this.Controls.Add(this.SiginBuild);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signin";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.SigninBuild.ResumeLayout(false);
            this.SigninBuild.PerformLayout();
            this.panelresetpassword.ResumeLayout(false);
            this.panelresetpassword.PerformLayout();
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
    }
}