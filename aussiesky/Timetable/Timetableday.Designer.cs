using System;
using System.Windows.Forms;

namespace App_assignment
{
    partial class Timetableday
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timetableday));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.paneltable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelheader2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelheadertext2 = new System.Windows.Forms.Label();
            this.panelDay = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.buttonFri = new System.Windows.Forms.Button();
            this.buttonThur = new System.Windows.Forms.Button();
            this.buttonWed = new System.Windows.Forms.Button();
            this.buttonTues = new System.Windows.Forms.Button();
            this.buttonMon = new System.Windows.Forms.Button();
            this.buttonsetting = new System.Windows.Forms.Button();
            this.paneladddata = new System.Windows.Forms.Panel();
            this.labelAddingerror = new System.Windows.Forms.Label();
            this.dateTimePickeraddendtime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.dateTimePickeraddstarttime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxaddday = new System.Windows.Forms.ComboBox();
            this.textBoxadddescription = new System.Windows.Forms.TextBox();
            this.textBoxaddtitle = new System.Windows.Forms.TextBox();
            this.labelAddscheduleTime = new System.Windows.Forms.Label();
            this.labelAddscheduleDay = new System.Windows.Forms.Label();
            this.labelAddscheduleDescription = new System.Windows.Forms.Label();
            this.labelAddscheduleTitle = new System.Windows.Forms.Label();
            this.labeladdTitle = new System.Windows.Forms.Label();
            this.paneleditdata = new System.Windows.Forms.Panel();
            this.labelEditingerror = new System.Windows.Forms.Label();
            this.buttoneditdelete = new System.Windows.Forms.Button();
            this.buttoneditcancel = new System.Windows.Forms.Button();
            this.buttoneditupdate = new System.Windows.Forms.Button();
            this.comboBoxeditdaypick = new System.Windows.Forms.ComboBox();
            this.dateTimePickereditetime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickereditstime = new System.Windows.Forms.DateTimePicker();
            this.textBoxeditdesc = new System.Windows.Forms.TextBox();
            this.textBoxedittitle = new System.Windows.Forms.TextBox();
            this.labeleditetime = new System.Windows.Forms.Label();
            this.labeleditstime = new System.Windows.Forms.Label();
            this.labeleditdesc = new System.Windows.Forms.Label();
            this.labeledittitles = new System.Windows.Forms.Label();
            this.labeledittitle = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.accountsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader.SuspendLayout();
            this.paneltable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelheader2.SuspendLayout();
            this.panelDay.SuspendLayout();
            this.paneladddata.SuspendLayout();
            this.paneleditdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.BackgroundImage = global::aussiesky.Properties.Resources.Untitled_removebg_preview;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(95, 85);
            this.panelIcon.TabIndex = 26;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(101, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 37);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Aussiesky";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelIcon);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(901, 85);
            this.panelHeader.TabIndex = 28;
            // 
            // paneltable
            // 
            this.paneltable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.paneltable.Controls.Add(this.dataGridView1);
            this.paneltable.Location = new System.Drawing.Point(0, 154);
            this.paneltable.Name = "paneltable";
            this.paneltable.Size = new System.Drawing.Size(901, 476);
            this.paneltable.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dataGridView1.Location = new System.Drawing.Point(-41, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(939, 473);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            // 
            // panelheader2
            // 
            this.panelheader2.Controls.Add(this.buttonClose);
            this.panelheader2.Controls.Add(this.labelheadertext2);
            this.panelheader2.Controls.Add(this.panelDay);
            this.panelheader2.Controls.Add(this.buttonsetting);
            this.panelheader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader2.Location = new System.Drawing.Point(0, 85);
            this.panelheader2.Name = "panelheader2";
            this.panelheader2.Size = new System.Drawing.Size(901, 68);
            this.panelheader2.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::aussiesky.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(870, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 28);
            this.buttonClose.TabIndex = 28;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelheadertext2
            // 
            this.labelheadertext2.AutoSize = true;
            this.labelheadertext2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelheadertext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheadertext2.ForeColor = System.Drawing.Color.White;
            this.labelheadertext2.Location = new System.Drawing.Point(0, 0);
            this.labelheadertext2.Name = "labelheadertext2";
            this.labelheadertext2.Size = new System.Drawing.Size(165, 31);
            this.labelheadertext2.TabIndex = 2;
            this.labelheadertext2.Text = "My Classes";
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.button2);
            this.panelDay.Controls.Add(this.button1);
            this.panelDay.Controls.Add(this.buttonSun);
            this.panelDay.Controls.Add(this.buttonSat);
            this.panelDay.Controls.Add(this.buttonFri);
            this.panelDay.Controls.Add(this.buttonThur);
            this.panelDay.Controls.Add(this.buttonWed);
            this.panelDay.Controls.Add(this.buttonTues);
            this.panelDay.Controls.Add(this.buttonMon);
            this.panelDay.Location = new System.Drawing.Point(0, 34);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(901, 35);
            this.panelDay.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(40, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonSun
            // 
            this.buttonSun.FlatAppearance.BorderSize = 0;
            this.buttonSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSun.ForeColor = System.Drawing.Color.White;
            this.buttonSun.Location = new System.Drawing.Point(685, 6);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(75, 23);
            this.buttonSun.TabIndex = 6;
            this.buttonSun.Text = "Sunday";
            this.buttonSun.UseVisualStyleBackColor = true;
            this.buttonSun.Click += new System.EventHandler(this.buttonSun_Click);
            // 
            // buttonSat
            // 
            this.buttonSat.FlatAppearance.BorderSize = 0;
            this.buttonSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSat.ForeColor = System.Drawing.Color.White;
            this.buttonSat.Location = new System.Drawing.Point(604, 6);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(75, 23);
            this.buttonSat.TabIndex = 5;
            this.buttonSat.Text = "Saturday";
            this.buttonSat.UseVisualStyleBackColor = true;
            this.buttonSat.Click += new System.EventHandler(this.buttonSat_Click);
            // 
            // buttonFri
            // 
            this.buttonFri.FlatAppearance.BorderSize = 0;
            this.buttonFri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFri.ForeColor = System.Drawing.Color.White;
            this.buttonFri.Location = new System.Drawing.Point(523, 6);
            this.buttonFri.Name = "buttonFri";
            this.buttonFri.Size = new System.Drawing.Size(75, 23);
            this.buttonFri.TabIndex = 4;
            this.buttonFri.Text = "Friday";
            this.buttonFri.UseVisualStyleBackColor = true;
            this.buttonFri.Click += new System.EventHandler(this.buttonFri_Click);
            // 
            // buttonThur
            // 
            this.buttonThur.FlatAppearance.BorderSize = 0;
            this.buttonThur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThur.ForeColor = System.Drawing.Color.White;
            this.buttonThur.Location = new System.Drawing.Point(442, 6);
            this.buttonThur.Name = "buttonThur";
            this.buttonThur.Size = new System.Drawing.Size(75, 23);
            this.buttonThur.TabIndex = 3;
            this.buttonThur.Text = "Thursday";
            this.buttonThur.UseVisualStyleBackColor = true;
            this.buttonThur.Click += new System.EventHandler(this.buttonThur_Click);
            // 
            // buttonWed
            // 
            this.buttonWed.FlatAppearance.BorderSize = 0;
            this.buttonWed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWed.ForeColor = System.Drawing.Color.White;
            this.buttonWed.Location = new System.Drawing.Point(361, 6);
            this.buttonWed.Name = "buttonWed";
            this.buttonWed.Size = new System.Drawing.Size(75, 23);
            this.buttonWed.TabIndex = 2;
            this.buttonWed.Text = "Wednesday";
            this.buttonWed.UseVisualStyleBackColor = true;
            this.buttonWed.Click += new System.EventHandler(this.buttonWed_Click);
            // 
            // buttonTues
            // 
            this.buttonTues.FlatAppearance.BorderSize = 0;
            this.buttonTues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTues.ForeColor = System.Drawing.Color.White;
            this.buttonTues.Location = new System.Drawing.Point(280, 6);
            this.buttonTues.Name = "buttonTues";
            this.buttonTues.Size = new System.Drawing.Size(75, 23);
            this.buttonTues.TabIndex = 1;
            this.buttonTues.Text = "Tuesday";
            this.buttonTues.UseVisualStyleBackColor = true;
            this.buttonTues.Click += new System.EventHandler(this.buttonTues_Click);
            // 
            // buttonMon
            // 
            this.buttonMon.FlatAppearance.BorderSize = 0;
            this.buttonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMon.ForeColor = System.Drawing.Color.White;
            this.buttonMon.Location = new System.Drawing.Point(199, 6);
            this.buttonMon.Name = "buttonMon";
            this.buttonMon.Size = new System.Drawing.Size(75, 23);
            this.buttonMon.TabIndex = 0;
            this.buttonMon.Text = "Monday";
            this.buttonMon.UseVisualStyleBackColor = true;
            this.buttonMon.Click += new System.EventHandler(this.buttonMon_Click);
            // 
            // buttonsetting
            // 
            this.buttonsetting.BackColor = System.Drawing.Color.Transparent;
            this.buttonsetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsetting.BackgroundImage")));
            this.buttonsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonsetting.FlatAppearance.BorderSize = 0;
            this.buttonsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetting.Location = new System.Drawing.Point(836, 3);
            this.buttonsetting.Name = "buttonsetting";
            this.buttonsetting.Size = new System.Drawing.Size(28, 28);
            this.buttonsetting.TabIndex = 1;
            this.buttonsetting.UseVisualStyleBackColor = false;
            // 
            // paneladddata
            // 
            this.paneladddata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.paneladddata.Controls.Add(this.labelAddingerror);
            this.paneladddata.Controls.Add(this.dateTimePickeraddendtime);
            this.paneladddata.Controls.Add(this.label1);
            this.paneladddata.Controls.Add(this.buttoncancel);
            this.paneladddata.Controls.Add(this.buttonadd);
            this.paneladddata.Controls.Add(this.dateTimePickeraddstarttime);
            this.paneladddata.Controls.Add(this.comboBoxaddday);
            this.paneladddata.Controls.Add(this.textBoxadddescription);
            this.paneladddata.Controls.Add(this.textBoxaddtitle);
            this.paneladddata.Controls.Add(this.labelAddscheduleTime);
            this.paneladddata.Controls.Add(this.labelAddscheduleDay);
            this.paneladddata.Controls.Add(this.labelAddscheduleDescription);
            this.paneladddata.Controls.Add(this.labelAddscheduleTitle);
            this.paneladddata.Controls.Add(this.labeladdTitle);
            this.paneladddata.Location = new System.Drawing.Point(0, 85);
            this.paneladddata.Name = "paneladddata";
            this.paneladddata.Size = new System.Drawing.Size(901, 545);
            this.paneladddata.TabIndex = 7;
            this.paneladddata.Visible = false;
            // 
            // labelAddingerror
            // 
            this.labelAddingerror.AutoSize = true;
            this.labelAddingerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddingerror.ForeColor = System.Drawing.Color.Red;
            this.labelAddingerror.Location = new System.Drawing.Point(310, 306);
            this.labelAddingerror.Name = "labelAddingerror";
            this.labelAddingerror.Size = new System.Drawing.Size(306, 20);
            this.labelAddingerror.TabIndex = 12;
            this.labelAddingerror.Text = "Invalid Title, Description, Day or Time";
            this.labelAddingerror.Visible = false;
            // 
            // dateTimePickeraddendtime
            // 
            this.dateTimePickeraddendtime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickeraddendtime.Checked = false;
            this.dateTimePickeraddendtime.CustomFormat = "hh:mm";
            this.dateTimePickeraddendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickeraddendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickeraddendtime.Location = new System.Drawing.Point(378, 275);
            this.dateTimePickeraddendtime.Name = "dateTimePickeraddendtime";
            this.dateTimePickeraddendtime.ShowUpDown = true;
            this.dateTimePickeraddendtime.Size = new System.Drawing.Size(69, 26);
            this.dateTimePickeraddendtime.TabIndex = 11;
            this.dateTimePickeraddendtime.Value = new System.DateTime(2022, 10, 12, 12, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "End Time";
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttoncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttoncancel.ForeColor = System.Drawing.Color.White;
            this.buttoncancel.Location = new System.Drawing.Point(276, 335);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(171, 45);
            this.buttoncancel.TabIndex = 9;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.Location = new System.Drawing.Point(466, 335);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(171, 45);
            this.buttonadd.TabIndex = 8;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // dateTimePickeraddstarttime
            // 
            this.dateTimePickeraddstarttime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickeraddstarttime.Checked = false;
            this.dateTimePickeraddstarttime.CustomFormat = "hh:mm";
            this.dateTimePickeraddstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickeraddstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickeraddstarttime.Location = new System.Drawing.Point(378, 247);
            this.dateTimePickeraddstarttime.Name = "dateTimePickeraddstarttime";
            this.dateTimePickeraddstarttime.ShowUpDown = true;
            this.dateTimePickeraddstarttime.Size = new System.Drawing.Size(69, 26);
            this.dateTimePickeraddstarttime.TabIndex = 6;
            this.dateTimePickeraddstarttime.Value = new System.DateTime(2022, 10, 12, 12, 0, 0, 0);
            // 
            // comboBoxaddday
            // 
            this.comboBoxaddday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.comboBoxaddday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxaddday.ForeColor = System.Drawing.Color.White;
            this.comboBoxaddday.FormattingEnabled = true;
            this.comboBoxaddday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxaddday.Location = new System.Drawing.Point(378, 213);
            this.comboBoxaddday.Name = "comboBoxaddday";
            this.comboBoxaddday.Size = new System.Drawing.Size(197, 28);
            this.comboBoxaddday.TabIndex = 7;
            this.comboBoxaddday.Text = "Monday";
            // 
            // textBoxadddescription
            // 
            this.textBoxadddescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxadddescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxadddescription.ForeColor = System.Drawing.Color.White;
            this.textBoxadddescription.Location = new System.Drawing.Point(378, 179);
            this.textBoxadddescription.Name = "textBoxadddescription";
            this.textBoxadddescription.Size = new System.Drawing.Size(305, 26);
            this.textBoxadddescription.TabIndex = 6;
            // 
            // textBoxaddtitle
            // 
            this.textBoxaddtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxaddtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxaddtitle.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxaddtitle.Location = new System.Drawing.Point(378, 147);
            this.textBoxaddtitle.Name = "textBoxaddtitle";
            this.textBoxaddtitle.Size = new System.Drawing.Size(197, 26);
            this.textBoxaddtitle.TabIndex = 5;
            // 
            // labelAddscheduleTime
            // 
            this.labelAddscheduleTime.AutoSize = true;
            this.labelAddscheduleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddscheduleTime.ForeColor = System.Drawing.Color.White;
            this.labelAddscheduleTime.Location = new System.Drawing.Point(280, 247);
            this.labelAddscheduleTime.Name = "labelAddscheduleTime";
            this.labelAddscheduleTime.Size = new System.Drawing.Size(92, 20);
            this.labelAddscheduleTime.TabIndex = 4;
            this.labelAddscheduleTime.Text = "Start Time";
            // 
            // labelAddscheduleDay
            // 
            this.labelAddscheduleDay.AutoSize = true;
            this.labelAddscheduleDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddscheduleDay.ForeColor = System.Drawing.Color.White;
            this.labelAddscheduleDay.Location = new System.Drawing.Point(332, 216);
            this.labelAddscheduleDay.Name = "labelAddscheduleDay";
            this.labelAddscheduleDay.Size = new System.Drawing.Size(40, 20);
            this.labelAddscheduleDay.TabIndex = 3;
            this.labelAddscheduleDay.Text = "Day";
            // 
            // labelAddscheduleDescription
            // 
            this.labelAddscheduleDescription.AutoSize = true;
            this.labelAddscheduleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddscheduleDescription.ForeColor = System.Drawing.Color.White;
            this.labelAddscheduleDescription.Location = new System.Drawing.Point(272, 182);
            this.labelAddscheduleDescription.Name = "labelAddscheduleDescription";
            this.labelAddscheduleDescription.Size = new System.Drawing.Size(100, 20);
            this.labelAddscheduleDescription.TabIndex = 2;
            this.labelAddscheduleDescription.Text = "Description";
            // 
            // labelAddscheduleTitle
            // 
            this.labelAddscheduleTitle.AutoSize = true;
            this.labelAddscheduleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelAddscheduleTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddscheduleTitle.Location = new System.Drawing.Point(329, 150);
            this.labelAddscheduleTitle.Name = "labelAddscheduleTitle";
            this.labelAddscheduleTitle.Size = new System.Drawing.Size(43, 20);
            this.labelAddscheduleTitle.TabIndex = 1;
            this.labelAddscheduleTitle.Text = "Title";
            // 
            // labeladdTitle
            // 
            this.labeladdTitle.AutoSize = true;
            this.labeladdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labeladdTitle.ForeColor = System.Drawing.Color.White;
            this.labeladdTitle.Location = new System.Drawing.Point(315, 100);
            this.labeladdTitle.Name = "labeladdTitle";
            this.labeladdTitle.Size = new System.Drawing.Size(228, 37);
            this.labeladdTitle.TabIndex = 0;
            this.labeladdTitle.Text = "Add Schedule";
            // 
            // paneleditdata
            // 
            this.paneleditdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.paneleditdata.Controls.Add(this.labelEditingerror);
            this.paneleditdata.Controls.Add(this.buttoneditdelete);
            this.paneleditdata.Controls.Add(this.buttoneditcancel);
            this.paneleditdata.Controls.Add(this.buttoneditupdate);
            this.paneleditdata.Controls.Add(this.comboBoxeditdaypick);
            this.paneleditdata.Controls.Add(this.dateTimePickereditetime);
            this.paneleditdata.Controls.Add(this.dateTimePickereditstime);
            this.paneleditdata.Controls.Add(this.textBoxeditdesc);
            this.paneleditdata.Controls.Add(this.textBoxedittitle);
            this.paneleditdata.Controls.Add(this.labeleditetime);
            this.paneleditdata.Controls.Add(this.labeleditstime);
            this.paneleditdata.Controls.Add(this.labeleditdesc);
            this.paneleditdata.Controls.Add(this.labeledittitles);
            this.paneleditdata.Controls.Add(this.labeledittitle);
            this.paneleditdata.Controls.Add(this.dataGridView2);
            this.paneleditdata.Location = new System.Drawing.Point(0, 85);
            this.paneleditdata.Name = "paneleditdata";
            this.paneleditdata.Size = new System.Drawing.Size(901, 545);
            this.paneleditdata.TabIndex = 12;
            this.paneleditdata.Visible = false;
            // 
            // labelEditingerror
            // 
            this.labelEditingerror.AutoSize = true;
            this.labelEditingerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelEditingerror.ForeColor = System.Drawing.Color.Red;
            this.labelEditingerror.Location = new System.Drawing.Point(127, 365);
            this.labelEditingerror.Name = "labelEditingerror";
            this.labelEditingerror.Size = new System.Drawing.Size(265, 20);
            this.labelEditingerror.TabIndex = 9;
            this.labelEditingerror.Text = "Invalid Title, Description or Time";
            this.labelEditingerror.Visible = false;
            // 
            // buttoneditdelete
            // 
            this.buttoneditdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttoneditdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttoneditdelete.ForeColor = System.Drawing.Color.White;
            this.buttoneditdelete.Location = new System.Drawing.Point(58, 393);
            this.buttoneditdelete.Name = "buttoneditdelete";
            this.buttoneditdelete.Size = new System.Drawing.Size(171, 45);
            this.buttoneditdelete.TabIndex = 5;
            this.buttoneditdelete.Text = "Delete";
            this.buttoneditdelete.UseVisualStyleBackColor = false;
            this.buttoneditdelete.Click += new System.EventHandler(this.buttoneditdelete_Click);
            // 
            // buttoneditcancel
            // 
            this.buttoneditcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttoneditcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttoneditcancel.ForeColor = System.Drawing.Color.White;
            this.buttoneditcancel.Location = new System.Drawing.Point(127, 464);
            this.buttoneditcancel.Name = "buttoneditcancel";
            this.buttoneditcancel.Size = new System.Drawing.Size(171, 45);
            this.buttoneditcancel.TabIndex = 7;
            this.buttoneditcancel.Text = "Cancel";
            this.buttoneditcancel.UseVisualStyleBackColor = false;
            this.buttoneditcancel.Click += new System.EventHandler(this.buttoneditcancel_Click);
            // 
            // buttoneditupdate
            // 
            this.buttoneditupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.buttoneditupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttoneditupdate.ForeColor = System.Drawing.Color.White;
            this.buttoneditupdate.Location = new System.Drawing.Point(274, 393);
            this.buttoneditupdate.Name = "buttoneditupdate";
            this.buttoneditupdate.Size = new System.Drawing.Size(171, 45);
            this.buttoneditupdate.TabIndex = 6;
            this.buttoneditupdate.Text = "Update";
            this.buttoneditupdate.UseVisualStyleBackColor = false;
            this.buttoneditupdate.Click += new System.EventHandler(this.buttoneditupdate_Click);
            // 
            // comboBoxeditdaypick
            // 
            this.comboBoxeditdaypick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.comboBoxeditdaypick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxeditdaypick.ForeColor = System.Drawing.Color.White;
            this.comboBoxeditdaypick.FormattingEnabled = true;
            this.comboBoxeditdaypick.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxeditdaypick.Location = new System.Drawing.Point(477, 100);
            this.comboBoxeditdaypick.Name = "comboBoxeditdaypick";
            this.comboBoxeditdaypick.Size = new System.Drawing.Size(121, 28);
            this.comboBoxeditdaypick.TabIndex = 8;
            this.comboBoxeditdaypick.Text = "Monday";
            // 
            // dateTimePickereditetime
            // 
            this.dateTimePickereditetime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickereditetime.CustomFormat = "HH:mm";
            this.dateTimePickereditetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickereditetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickereditetime.Location = new System.Drawing.Point(140, 332);
            this.dateTimePickereditetime.Name = "dateTimePickereditetime";
            this.dateTimePickereditetime.ShowUpDown = true;
            this.dateTimePickereditetime.Size = new System.Drawing.Size(69, 26);
            this.dateTimePickereditetime.TabIndex = 4;
            // 
            // dateTimePickereditstime
            // 
            this.dateTimePickereditstime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dateTimePickereditstime.CustomFormat = "HH:mm";
            this.dateTimePickereditstime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickereditstime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickereditstime.Location = new System.Drawing.Point(140, 300);
            this.dateTimePickereditstime.Name = "dateTimePickereditstime";
            this.dateTimePickereditstime.ShowUpDown = true;
            this.dateTimePickereditstime.Size = new System.Drawing.Size(69, 26);
            this.dateTimePickereditstime.TabIndex = 3;
            // 
            // textBoxeditdesc
            // 
            this.textBoxeditdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxeditdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxeditdesc.ForeColor = System.Drawing.Color.White;
            this.textBoxeditdesc.Location = new System.Drawing.Point(140, 248);
            this.textBoxeditdesc.Multiline = true;
            this.textBoxeditdesc.Name = "textBoxeditdesc";
            this.textBoxeditdesc.Size = new System.Drawing.Size(305, 47);
            this.textBoxeditdesc.TabIndex = 1;
            // 
            // textBoxedittitle
            // 
            this.textBoxedittitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.textBoxedittitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxedittitle.ForeColor = System.Drawing.Color.White;
            this.textBoxedittitle.Location = new System.Drawing.Point(140, 216);
            this.textBoxedittitle.Name = "textBoxedittitle";
            this.textBoxedittitle.Size = new System.Drawing.Size(197, 26);
            this.textBoxedittitle.TabIndex = 0;
            // 
            // labeleditetime
            // 
            this.labeleditetime.AutoSize = true;
            this.labeleditetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labeleditetime.ForeColor = System.Drawing.Color.White;
            this.labeleditetime.Location = new System.Drawing.Point(37, 332);
            this.labeleditetime.Name = "labeleditetime";
            this.labeleditetime.Size = new System.Drawing.Size(84, 20);
            this.labeleditetime.TabIndex = 5;
            this.labeleditetime.Text = "End Time";
            // 
            // labeleditstime
            // 
            this.labeleditstime.AutoSize = true;
            this.labeleditstime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labeleditstime.ForeColor = System.Drawing.Color.White;
            this.labeleditstime.Location = new System.Drawing.Point(29, 300);
            this.labeleditstime.Name = "labeleditstime";
            this.labeleditstime.Size = new System.Drawing.Size(92, 20);
            this.labeleditstime.TabIndex = 4;
            this.labeleditstime.Text = "Start Time";
            // 
            // labeleditdesc
            // 
            this.labeleditdesc.AutoSize = true;
            this.labeleditdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labeleditdesc.ForeColor = System.Drawing.Color.White;
            this.labeleditdesc.Location = new System.Drawing.Point(21, 248);
            this.labeleditdesc.Name = "labeleditdesc";
            this.labeleditdesc.Size = new System.Drawing.Size(100, 20);
            this.labeleditdesc.TabIndex = 3;
            this.labeleditdesc.Text = "Description";
            // 
            // labeledittitles
            // 
            this.labeledittitles.AutoSize = true;
            this.labeledittitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labeledittitles.ForeColor = System.Drawing.Color.White;
            this.labeledittitles.Location = new System.Drawing.Point(67, 219);
            this.labeledittitles.Name = "labeledittitles";
            this.labeledittitles.Size = new System.Drawing.Size(43, 20);
            this.labeledittitles.TabIndex = 2;
            this.labeledittitles.Text = "Title";
            // 
            // labeledittitle
            // 
            this.labeledittitle.AutoSize = true;
            this.labeledittitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labeledittitle.ForeColor = System.Drawing.Color.White;
            this.labeledittitle.Location = new System.Drawing.Point(132, 161);
            this.labeledittitle.Name = "labeledittitle";
            this.labeledittitle.Size = new System.Drawing.Size(226, 37);
            this.labeledittitle.TabIndex = 3;
            this.labeledittitle.Text = "Edit Schedule";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.dataGridView2.Location = new System.Drawing.Point(477, 134);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(412, 375);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Timetableday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(901, 630);
            this.Controls.Add(this.panelheader2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.paneladddata);
            this.Controls.Add(this.paneltable);
            this.Controls.Add(this.paneleditdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timetableday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "errors";
            this.Load += new System.EventHandler(this.Timetableday_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.paneltable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelheader2.ResumeLayout(false);
            this.panelheader2.PerformLayout();
            this.panelDay.ResumeLayout(false);
            this.paneladddata.ResumeLayout(false);
            this.paneladddata.PerformLayout();
            this.paneleditdata.ResumeLayout(false);
            this.paneleditdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel paneltable;
        private System.Windows.Forms.Panel panelheader2;
        private System.Windows.Forms.Label labelheadertext2;
        private System.Windows.Forms.Button buttonsetting;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Button buttonSun;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Button buttonFri;
        private System.Windows.Forms.Button buttonThur;
        private System.Windows.Forms.Button buttonWed;
        private System.Windows.Forms.Button buttonTues;
        private System.Windows.Forms.Button buttonMon;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel paneladddata;
        private System.Windows.Forms.DateTimePicker dateTimePickeraddstarttime;
        private System.Windows.Forms.ComboBox comboBoxaddday;
        private System.Windows.Forms.TextBox textBoxadddescription;
        private System.Windows.Forms.TextBox textBoxaddtitle;
        private System.Windows.Forms.Label labelAddscheduleTime;
        private System.Windows.Forms.Label labelAddscheduleDay;
        private System.Windows.Forms.Label labelAddscheduleDescription;
        private System.Windows.Forms.Label labelAddscheduleTitle;
        private System.Windows.Forms.Label labeladdTitle;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickeraddendtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource accountsDataSetBindingSource;
        private Panel paneleditdata;
        private ComboBox comboBoxeditdaypick;
        private DateTimePicker dateTimePickereditetime;
        private DateTimePicker dateTimePickereditstime;
        private TextBox textBoxeditdesc;
        private TextBox textBoxedittitle;
        private Label labeleditetime;
        private Label labeleditstime;
        private Label labeleditdesc;
        private Label labeledittitles;
        private Label labeledittitle;
        private DataGridView dataGridView2;
        private Button buttoneditcancel;
        private Button buttoneditupdate;
        private Button buttoneditdelete;
        private Label labelEditingerror;
        private Label labelAddingerror;
    }
}