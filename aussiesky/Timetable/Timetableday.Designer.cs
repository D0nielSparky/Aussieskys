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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timetableday));
            this.panelIcon = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Events = new System.Windows.Forms.Panel();
            this.vieweventtable = new System.Windows.Forms.DataGridView();
            this.panelheader2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelheadertext2 = new System.Windows.Forms.Label();
            this.panelDay = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.buttonFri = new System.Windows.Forms.Button();
            this.buttonThur = new System.Windows.Forms.Button();
            this.buttonWed = new System.Windows.Forms.Button();
            this.buttonTues = new System.Windows.Forms.Button();
            this.buttonMon = new System.Windows.Forms.Button();
            this.buttonsetting = new System.Windows.Forms.Button();
            this.Eventadd = new System.Windows.Forms.Panel();
            this.addeventerror = new System.Windows.Forms.Label();
            this.addeventendtime = new System.Windows.Forms.DateTimePicker();
            this.addeventL6 = new System.Windows.Forms.Label();
            this.addeventcancel = new System.Windows.Forms.Button();
            this.addeventadd = new System.Windows.Forms.Button();
            this.addeventstarttime = new System.Windows.Forms.DateTimePicker();
            this.addeventday = new System.Windows.Forms.ComboBox();
            this.addeventdesc = new System.Windows.Forms.TextBox();
            this.addeventtitle = new System.Windows.Forms.TextBox();
            this.addeventL5 = new System.Windows.Forms.Label();
            this.addeventL4 = new System.Windows.Forms.Label();
            this.addeventL3 = new System.Windows.Forms.Label();
            this.addeventL2 = new System.Windows.Forms.Label();
            this.addeventL1 = new System.Windows.Forms.Label();
            this.Eventedit = new System.Windows.Forms.Panel();
            this.editeventerror = new System.Windows.Forms.Label();
            this.editeventcancel = new System.Windows.Forms.Button();
            this.editeventupdate = new System.Windows.Forms.Button();
            this.editeventendtime = new System.Windows.Forms.DateTimePicker();
            this.editeventstarttime = new System.Windows.Forms.DateTimePicker();
            this.editeventdesc = new System.Windows.Forms.TextBox();
            this.editeventtitle = new System.Windows.Forms.TextBox();
            this.editeventL5 = new System.Windows.Forms.Label();
            this.editeventL4 = new System.Windows.Forms.Label();
            this.editeventL3 = new System.Windows.Forms.Label();
            this.editeventL2 = new System.Windows.Forms.Label();
            this.editeventL1 = new System.Windows.Forms.Label();
            this.accountsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Eventview = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vieweventtitle = new System.Windows.Forms.Label();
            this.vieweventdesc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vieweventendtime = new System.Windows.Forms.Label();
            this.vieweventstarttime = new System.Windows.Forms.Label();
            this.vieweventdelete = new System.Windows.Forms.Button();
            this.vieweventclose = new System.Windows.Forms.Button();
            this.vieweventedit = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vieweventtable)).BeginInit();
            this.panelheader2.SuspendLayout();
            this.panelDay.SuspendLayout();
            this.Eventadd.SuspendLayout();
            this.Eventedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).BeginInit();
            this.Eventview.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.Events.Controls.Add(this.vieweventtable);
            this.Events.Location = new System.Drawing.Point(0, 154);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(901, 476);
            this.Events.TabIndex = 29;
            // 
            // vieweventtable
            // 
            this.vieweventtable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.vieweventtable.AllowUserToAddRows = false;
            this.vieweventtable.AllowUserToDeleteRows = false;
            this.vieweventtable.AllowUserToResizeColumns = false;
            this.vieweventtable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vieweventtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vieweventtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vieweventtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vieweventtable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.vieweventtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vieweventtable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vieweventtable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.vieweventtable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vieweventtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vieweventtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vieweventtable.DefaultCellStyle = dataGridViewCellStyle3;
            this.vieweventtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vieweventtable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.vieweventtable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.vieweventtable.Location = new System.Drawing.Point(0, 0);
            this.vieweventtable.MultiSelect = false;
            this.vieweventtable.Name = "vieweventtable";
            this.vieweventtable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vieweventtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.vieweventtable.RowHeadersVisible = false;
            this.vieweventtable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.vieweventtable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vieweventtable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.vieweventtable.RowTemplate.Height = 40;
            this.vieweventtable.RowTemplate.ReadOnly = true;
            this.vieweventtable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vieweventtable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vieweventtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vieweventtable.ShowCellErrors = false;
            this.vieweventtable.ShowCellToolTips = false;
            this.vieweventtable.ShowEditingIcon = false;
            this.vieweventtable.ShowRowErrors = false;
            this.vieweventtable.Size = new System.Drawing.Size(901, 476);
            this.vieweventtable.TabIndex = 4;
            this.vieweventtable.TabStop = false;
            this.vieweventtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Eventadd
            // 
            this.Eventadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.Eventadd.Controls.Add(this.addeventL1);
            this.Eventadd.Controls.Add(this.addeventL2);
            this.Eventadd.Controls.Add(this.addeventL3);
            this.Eventadd.Controls.Add(this.addeventL4);
            this.Eventadd.Controls.Add(this.addeventL5);
            this.Eventadd.Controls.Add(this.addeventL6);
            this.Eventadd.Controls.Add(this.addeventerror);
            this.Eventadd.Controls.Add(this.addeventtitle);
            this.Eventadd.Controls.Add(this.addeventdesc);
            this.Eventadd.Controls.Add(this.addeventday);
            this.Eventadd.Controls.Add(this.addeventstarttime);
            this.Eventadd.Controls.Add(this.addeventendtime);
            this.Eventadd.Controls.Add(this.addeventadd);
            this.Eventadd.Controls.Add(this.addeventcancel);
            this.Eventadd.Location = new System.Drawing.Point(0, 85);
            this.Eventadd.Name = "Eventadd";
            this.Eventadd.Size = new System.Drawing.Size(901, 545);
            this.Eventadd.TabIndex = 7;
            this.Eventadd.Visible = false;
            // 
            // addeventerror
            // 
            this.addeventerror.AutoSize = true;
            this.addeventerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventerror.ForeColor = System.Drawing.Color.Red;
            this.addeventerror.Location = new System.Drawing.Point(310, 306);
            this.addeventerror.Name = "addeventerror";
            this.addeventerror.Size = new System.Drawing.Size(306, 20);
            this.addeventerror.TabIndex = 12;
            this.addeventerror.Text = "Invalid Title, Description, Day or Time";
            this.addeventerror.Visible = false;
            // 
            // addeventendtime
            // 
            this.addeventendtime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.addeventendtime.Checked = false;
            this.addeventendtime.CustomFormat = "hh:mm";
            this.addeventendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addeventendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addeventendtime.Location = new System.Drawing.Point(378, 275);
            this.addeventendtime.Name = "addeventendtime";
            this.addeventendtime.ShowUpDown = true;
            this.addeventendtime.Size = new System.Drawing.Size(69, 26);
            this.addeventendtime.TabIndex = 11;
            this.addeventendtime.Value = new System.DateTime(2022, 10, 12, 12, 0, 0, 0);
            // 
            // addeventL6
            // 
            this.addeventL6.AutoSize = true;
            this.addeventL6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventL6.ForeColor = System.Drawing.Color.White;
            this.addeventL6.Location = new System.Drawing.Point(288, 275);
            this.addeventL6.Name = "addeventL6";
            this.addeventL6.Size = new System.Drawing.Size(84, 20);
            this.addeventL6.TabIndex = 10;
            this.addeventL6.Text = "End Time";
            // 
            // addeventcancel
            // 
            this.addeventcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.addeventcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.addeventcancel.ForeColor = System.Drawing.Color.White;
            this.addeventcancel.Location = new System.Drawing.Point(470, 340);
            this.addeventcancel.Name = "addeventcancel";
            this.addeventcancel.Size = new System.Drawing.Size(171, 45);
            this.addeventcancel.TabIndex = 9;
            this.addeventcancel.Text = "Cancel";
            this.addeventcancel.UseVisualStyleBackColor = false;
            this.addeventcancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // addeventadd
            // 
            this.addeventadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.addeventadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.addeventadd.ForeColor = System.Drawing.Color.White;
            this.addeventadd.Location = new System.Drawing.Point(292, 340);
            this.addeventadd.Name = "addeventadd";
            this.addeventadd.Size = new System.Drawing.Size(171, 45);
            this.addeventadd.TabIndex = 8;
            this.addeventadd.Text = "Add";
            this.addeventadd.UseVisualStyleBackColor = false;
            this.addeventadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // addeventstarttime
            // 
            this.addeventstarttime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.addeventstarttime.Checked = false;
            this.addeventstarttime.CustomFormat = "hh:mm";
            this.addeventstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addeventstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addeventstarttime.Location = new System.Drawing.Point(378, 247);
            this.addeventstarttime.Name = "addeventstarttime";
            this.addeventstarttime.ShowUpDown = true;
            this.addeventstarttime.Size = new System.Drawing.Size(69, 26);
            this.addeventstarttime.TabIndex = 6;
            this.addeventstarttime.Value = new System.DateTime(2022, 10, 12, 12, 0, 0, 0);
            // 
            // addeventday
            // 
            this.addeventday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.addeventday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addeventday.ForeColor = System.Drawing.Color.White;
            this.addeventday.FormattingEnabled = true;
            this.addeventday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.addeventday.Location = new System.Drawing.Point(378, 213);
            this.addeventday.Name = "addeventday";
            this.addeventday.Size = new System.Drawing.Size(197, 28);
            this.addeventday.TabIndex = 7;
            this.addeventday.Text = "Monday";
            // 
            // addeventdesc
            // 
            this.addeventdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.addeventdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addeventdesc.ForeColor = System.Drawing.Color.White;
            this.addeventdesc.Location = new System.Drawing.Point(378, 179);
            this.addeventdesc.Name = "addeventdesc";
            this.addeventdesc.Size = new System.Drawing.Size(305, 26);
            this.addeventdesc.TabIndex = 6;
            // 
            // addeventtitle
            // 
            this.addeventtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.addeventtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addeventtitle.ForeColor = System.Drawing.SystemColors.Window;
            this.addeventtitle.Location = new System.Drawing.Point(378, 147);
            this.addeventtitle.Name = "addeventtitle";
            this.addeventtitle.Size = new System.Drawing.Size(197, 26);
            this.addeventtitle.TabIndex = 5;
            // 
            // addeventL5
            // 
            this.addeventL5.AutoSize = true;
            this.addeventL5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventL5.ForeColor = System.Drawing.Color.White;
            this.addeventL5.Location = new System.Drawing.Point(280, 247);
            this.addeventL5.Name = "addeventL5";
            this.addeventL5.Size = new System.Drawing.Size(92, 20);
            this.addeventL5.TabIndex = 4;
            this.addeventL5.Text = "Start Time";
            // 
            // addeventL4
            // 
            this.addeventL4.AutoSize = true;
            this.addeventL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventL4.ForeColor = System.Drawing.Color.White;
            this.addeventL4.Location = new System.Drawing.Point(332, 216);
            this.addeventL4.Name = "addeventL4";
            this.addeventL4.Size = new System.Drawing.Size(40, 20);
            this.addeventL4.TabIndex = 3;
            this.addeventL4.Text = "Day";
            // 
            // addeventL3
            // 
            this.addeventL3.AutoSize = true;
            this.addeventL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventL3.ForeColor = System.Drawing.Color.White;
            this.addeventL3.Location = new System.Drawing.Point(272, 182);
            this.addeventL3.Name = "addeventL3";
            this.addeventL3.Size = new System.Drawing.Size(100, 20);
            this.addeventL3.TabIndex = 2;
            this.addeventL3.Text = "Description";
            // 
            // addeventL2
            // 
            this.addeventL2.AutoSize = true;
            this.addeventL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addeventL2.ForeColor = System.Drawing.Color.White;
            this.addeventL2.Location = new System.Drawing.Point(329, 150);
            this.addeventL2.Name = "addeventL2";
            this.addeventL2.Size = new System.Drawing.Size(43, 20);
            this.addeventL2.TabIndex = 1;
            this.addeventL2.Text = "Title";
            // 
            // addeventL1
            // 
            this.addeventL1.AutoSize = true;
            this.addeventL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.addeventL1.ForeColor = System.Drawing.Color.White;
            this.addeventL1.Location = new System.Drawing.Point(315, 100);
            this.addeventL1.Name = "addeventL1";
            this.addeventL1.Size = new System.Drawing.Size(228, 37);
            this.addeventL1.TabIndex = 0;
            this.addeventL1.Text = "Add Schedule";
            // 
            // Eventedit
            // 
            this.Eventedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.Eventedit.Controls.Add(this.editeventL1);
            this.Eventedit.Controls.Add(this.editeventL2);
            this.Eventedit.Controls.Add(this.editeventL3);
            this.Eventedit.Controls.Add(this.editeventL4);
            this.Eventedit.Controls.Add(this.editeventL5);
            this.Eventedit.Controls.Add(this.editeventerror);
            this.Eventedit.Controls.Add(this.editeventtitle);
            this.Eventedit.Controls.Add(this.editeventdesc);
            this.Eventedit.Controls.Add(this.editeventstarttime);
            this.Eventedit.Controls.Add(this.editeventendtime);
            this.Eventedit.Controls.Add(this.editeventupdate);
            this.Eventedit.Controls.Add(this.editeventcancel);
            this.Eventedit.Location = new System.Drawing.Point(0, 85);
            this.Eventedit.Name = "Eventedit";
            this.Eventedit.Size = new System.Drawing.Size(901, 545);
            this.Eventedit.TabIndex = 12;
            this.Eventedit.Visible = false;
            // 
            // editeventerror
            // 
            this.editeventerror.AutoSize = true;
            this.editeventerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.editeventerror.ForeColor = System.Drawing.Color.Red;
            this.editeventerror.Location = new System.Drawing.Point(127, 365);
            this.editeventerror.Name = "editeventerror";
            this.editeventerror.Size = new System.Drawing.Size(265, 20);
            this.editeventerror.TabIndex = 9;
            this.editeventerror.Text = "Invalid Title, Description or Time";
            this.editeventerror.Visible = false;
            // 
            // editeventcancel
            // 
            this.editeventcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.editeventcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.editeventcancel.ForeColor = System.Drawing.Color.White;
            this.editeventcancel.Location = new System.Drawing.Point(255, 399);
            this.editeventcancel.Name = "editeventcancel";
            this.editeventcancel.Size = new System.Drawing.Size(171, 45);
            this.editeventcancel.TabIndex = 7;
            this.editeventcancel.Text = "Cancel";
            this.editeventcancel.UseVisualStyleBackColor = false;
            this.editeventcancel.Click += new System.EventHandler(this.buttoneditcancel_Click);
            // 
            // editeventupdate
            // 
            this.editeventupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.editeventupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.editeventupdate.ForeColor = System.Drawing.Color.White;
            this.editeventupdate.Location = new System.Drawing.Point(78, 399);
            this.editeventupdate.Name = "editeventupdate";
            this.editeventupdate.Size = new System.Drawing.Size(171, 45);
            this.editeventupdate.TabIndex = 6;
            this.editeventupdate.Text = "Update";
            this.editeventupdate.UseVisualStyleBackColor = false;
            this.editeventupdate.Click += new System.EventHandler(this.buttoneditupdate_Click);
            // 
            // editeventendtime
            // 
            this.editeventendtime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.editeventendtime.CustomFormat = "HH:mm";
            this.editeventendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editeventendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.editeventendtime.Location = new System.Drawing.Point(140, 332);
            this.editeventendtime.Name = "editeventendtime";
            this.editeventendtime.ShowUpDown = true;
            this.editeventendtime.Size = new System.Drawing.Size(69, 26);
            this.editeventendtime.TabIndex = 4;
            // 
            // editeventstarttime
            // 
            this.editeventstarttime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.editeventstarttime.CustomFormat = "HH:mm";
            this.editeventstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editeventstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.editeventstarttime.Location = new System.Drawing.Point(140, 300);
            this.editeventstarttime.Name = "editeventstarttime";
            this.editeventstarttime.ShowUpDown = true;
            this.editeventstarttime.Size = new System.Drawing.Size(69, 26);
            this.editeventstarttime.TabIndex = 3;
            // 
            // editeventdesc
            // 
            this.editeventdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.editeventdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editeventdesc.ForeColor = System.Drawing.Color.White;
            this.editeventdesc.Location = new System.Drawing.Point(140, 248);
            this.editeventdesc.Multiline = true;
            this.editeventdesc.Name = "editeventdesc";
            this.editeventdesc.Size = new System.Drawing.Size(305, 47);
            this.editeventdesc.TabIndex = 1;
            // 
            // editeventtitle
            // 
            this.editeventtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.editeventtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editeventtitle.ForeColor = System.Drawing.Color.White;
            this.editeventtitle.Location = new System.Drawing.Point(140, 216);
            this.editeventtitle.Name = "editeventtitle";
            this.editeventtitle.Size = new System.Drawing.Size(197, 26);
            this.editeventtitle.TabIndex = 0;
            // 
            // editeventL5
            // 
            this.editeventL5.AutoSize = true;
            this.editeventL5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.editeventL5.ForeColor = System.Drawing.Color.White;
            this.editeventL5.Location = new System.Drawing.Point(37, 332);
            this.editeventL5.Name = "editeventL5";
            this.editeventL5.Size = new System.Drawing.Size(84, 20);
            this.editeventL5.TabIndex = 5;
            this.editeventL5.Text = "End Time";
            // 
            // editeventL4
            // 
            this.editeventL4.AutoSize = true;
            this.editeventL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.editeventL4.ForeColor = System.Drawing.Color.White;
            this.editeventL4.Location = new System.Drawing.Point(29, 300);
            this.editeventL4.Name = "editeventL4";
            this.editeventL4.Size = new System.Drawing.Size(92, 20);
            this.editeventL4.TabIndex = 4;
            this.editeventL4.Text = "Start Time";
            // 
            // editeventL3
            // 
            this.editeventL3.AutoSize = true;
            this.editeventL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.editeventL3.ForeColor = System.Drawing.Color.White;
            this.editeventL3.Location = new System.Drawing.Point(21, 248);
            this.editeventL3.Name = "editeventL3";
            this.editeventL3.Size = new System.Drawing.Size(100, 20);
            this.editeventL3.TabIndex = 3;
            this.editeventL3.Text = "Description";
            // 
            // editeventL2
            // 
            this.editeventL2.AutoSize = true;
            this.editeventL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.editeventL2.ForeColor = System.Drawing.Color.White;
            this.editeventL2.Location = new System.Drawing.Point(67, 219);
            this.editeventL2.Name = "editeventL2";
            this.editeventL2.Size = new System.Drawing.Size(43, 20);
            this.editeventL2.TabIndex = 2;
            this.editeventL2.Text = "Title";
            // 
            // editeventL1
            // 
            this.editeventL1.AutoSize = true;
            this.editeventL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.editeventL1.ForeColor = System.Drawing.Color.White;
            this.editeventL1.Location = new System.Drawing.Point(72, 133);
            this.editeventL1.Name = "editeventL1";
            this.editeventL1.Size = new System.Drawing.Size(226, 37);
            this.editeventL1.TabIndex = 3;
            this.editeventL1.Text = "Edit Schedule";
            // 
            // Eventview
            // 
            this.Eventview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.Eventview.Controls.Add(this.tableLayoutPanel1);
            this.Eventview.Controls.Add(this.vieweventedit);
            this.Eventview.Controls.Add(this.vieweventclose);
            this.Eventview.Controls.Add(this.vieweventdelete);
            this.Eventview.Location = new System.Drawing.Point(0, 85);
            this.Eventview.Name = "Eventview";
            this.Eventview.Size = new System.Drawing.Size(901, 545);
            this.Eventview.TabIndex = 30;
            this.Eventview.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vieweventtitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vieweventdesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(71, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 355);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // vieweventtitle
            // 
            this.vieweventtitle.AutoSize = true;
            this.vieweventtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vieweventtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.vieweventtitle.ForeColor = System.Drawing.Color.White;
            this.vieweventtitle.Location = new System.Drawing.Point(3, 0);
            this.vieweventtitle.Name = "vieweventtitle";
            this.vieweventtitle.Size = new System.Drawing.Size(743, 37);
            this.vieweventtitle.TabIndex = 3;
            this.vieweventtitle.Text = "[event title]";
            this.vieweventtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vieweventdesc
            // 
            this.vieweventdesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.vieweventdesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vieweventdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vieweventdesc.ForeColor = System.Drawing.Color.White;
            this.vieweventdesc.Location = new System.Drawing.Point(3, 40);
            this.vieweventdesc.Multiline = true;
            this.vieweventdesc.Name = "vieweventdesc";
            this.vieweventdesc.ReadOnly = true;
            this.vieweventdesc.Size = new System.Drawing.Size(743, 269);
            this.vieweventdesc.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vieweventstarttime);
            this.panel1.Controls.Add(this.vieweventendtime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 37);
            this.panel1.TabIndex = 4;
            // 
            // vieweventendtime
            // 
            this.vieweventendtime.AutoSize = true;
            this.vieweventendtime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vieweventendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vieweventendtime.ForeColor = System.Drawing.Color.White;
            this.vieweventendtime.Location = new System.Drawing.Point(0, 17);
            this.vieweventendtime.Name = "vieweventendtime";
            this.vieweventendtime.Size = new System.Drawing.Size(138, 20);
            this.vieweventendtime.TabIndex = 5;
            this.vieweventendtime.Text = "End Time: [time]";
            // 
            // vieweventstarttime
            // 
            this.vieweventstarttime.AutoSize = true;
            this.vieweventstarttime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vieweventstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vieweventstarttime.ForeColor = System.Drawing.Color.White;
            this.vieweventstarttime.Location = new System.Drawing.Point(0, -3);
            this.vieweventstarttime.Name = "vieweventstarttime";
            this.vieweventstarttime.Size = new System.Drawing.Size(161, 20);
            this.vieweventstarttime.TabIndex = 4;
            this.vieweventstarttime.Text = "Start Time: [time]   ";
            // 
            // vieweventdelete
            // 
            this.vieweventdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.vieweventdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.vieweventdelete.ForeColor = System.Drawing.Color.White;
            this.vieweventdelete.Location = new System.Drawing.Point(549, 488);
            this.vieweventdelete.Name = "vieweventdelete";
            this.vieweventdelete.Size = new System.Drawing.Size(171, 45);
            this.vieweventdelete.TabIndex = 5;
            this.vieweventdelete.Text = "Delete";
            this.vieweventdelete.UseVisualStyleBackColor = false;
            this.vieweventdelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // vieweventclose
            // 
            this.vieweventclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.vieweventclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.vieweventclose.ForeColor = System.Drawing.Color.White;
            this.vieweventclose.Location = new System.Drawing.Point(372, 488);
            this.vieweventclose.Name = "vieweventclose";
            this.vieweventclose.Size = new System.Drawing.Size(171, 45);
            this.vieweventclose.TabIndex = 7;
            this.vieweventclose.Text = "Close";
            this.vieweventclose.UseVisualStyleBackColor = false;
            this.vieweventclose.Click += new System.EventHandler(this.button4_Click);
            // 
            // vieweventedit
            // 
            this.vieweventedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.vieweventedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.vieweventedit.ForeColor = System.Drawing.Color.White;
            this.vieweventedit.Location = new System.Drawing.Point(195, 488);
            this.vieweventedit.Name = "vieweventedit";
            this.vieweventedit.Size = new System.Drawing.Size(171, 45);
            this.vieweventedit.TabIndex = 6;
            this.vieweventedit.Text = "Edit";
            this.vieweventedit.UseVisualStyleBackColor = false;
            this.vieweventedit.Click += new System.EventHandler(this.button5_Click);
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
            this.Controls.Add(this.Events);
            this.Controls.Add(this.Eventview);
            this.Controls.Add(this.Eventedit);
            this.Controls.Add(this.Eventadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timetableday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "errors";
            this.Load += new System.EventHandler(this.Timetableday_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vieweventtable)).EndInit();
            this.panelheader2.ResumeLayout(false);
            this.panelheader2.PerformLayout();
            this.panelDay.ResumeLayout(false);
            this.Eventadd.ResumeLayout(false);
            this.Eventadd.PerformLayout();
            this.Eventedit.ResumeLayout(false);
            this.Eventedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).EndInit();
            this.Eventview.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel Events;
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
        private System.Windows.Forms.Panel Eventadd;
        private System.Windows.Forms.DateTimePicker addeventstarttime;
        private System.Windows.Forms.ComboBox addeventday;
        private System.Windows.Forms.TextBox addeventdesc;
        private System.Windows.Forms.TextBox addeventtitle;
        private System.Windows.Forms.Label addeventL5;
        private System.Windows.Forms.Label addeventL4;
        private System.Windows.Forms.Label addeventL3;
        private System.Windows.Forms.Label addeventL2;
        private System.Windows.Forms.Label addeventL1;
        private System.Windows.Forms.Button addeventcancel;
        private System.Windows.Forms.Button addeventadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker addeventendtime;
        private System.Windows.Forms.Label addeventL6;
        private System.Windows.Forms.DataGridView vieweventtable;
        private System.Windows.Forms.BindingSource accountsDataSetBindingSource;
        private Panel Eventedit;
        private DateTimePicker editeventendtime;
        private DateTimePicker editeventstarttime;
        private TextBox editeventdesc;
        private TextBox editeventtitle;
        private Label editeventL5;
        private Label editeventL4;
        private Label editeventL3;
        private Label editeventL2;
        private Label editeventL1;
        private Button editeventcancel;
        private Button editeventupdate;
        private Label editeventerror;
        private Label addeventerror;
        private Panel Eventview;
        private TableLayoutPanel tableLayoutPanel1;
        private Label vieweventtitle;
        private TextBox vieweventdesc;
        private Label vieweventstarttime;
        private Button vieweventdelete;
        private Button vieweventedit;
        private Label vieweventendtime;
        private Panel panel1;
        private Button vieweventclose;
    }
}