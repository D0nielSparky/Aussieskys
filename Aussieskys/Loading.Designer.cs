namespace App_assignment
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.panelloadingbar = new System.Windows.Forms.Panel();
            this.panelLoadingprogression = new System.Windows.Forms.Panel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pictureboxIcon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelloadingbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelloadingbar
            // 
            this.panelloadingbar.Controls.Add(this.panelLoadingprogression);
            this.panelloadingbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelloadingbar.Location = new System.Drawing.Point(0, 328);
            this.panelloadingbar.Name = "panelloadingbar";
            this.panelloadingbar.Size = new System.Drawing.Size(599, 17);
            this.panelloadingbar.TabIndex = 0;
            // 
            // panelLoadingprogression
            // 
            this.panelLoadingprogression.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLoadingprogression.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoadingprogression.Location = new System.Drawing.Point(0, 0);
            this.panelLoadingprogression.Name = "panelLoadingprogression";
            this.panelLoadingprogression.Size = new System.Drawing.Size(102, 17);
            this.panelLoadingprogression.TabIndex = 0;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.LightGray;
            this.labelLoading.Location = new System.Drawing.Point(12, 290);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(171, 31);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "LOADING...";
            // 
            // pictureboxIcon
            // 
            this.pictureboxIcon.Image = global::Aussieskys.Properties.Resources.Untitled_removebg_preview;
            this.pictureboxIcon.Location = new System.Drawing.Point(235, 84);
            this.pictureboxIcon.Name = "pictureboxIcon";
            this.pictureboxIcon.Size = new System.Drawing.Size(152, 152);
            this.pictureboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxIcon.TabIndex = 2;
            this.pictureboxIcon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(599, 345);
            this.Controls.Add(this.pictureboxIcon);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelloadingbar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.panelloadingbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelloadingbar;
        private System.Windows.Forms.Panel panelLoadingprogression;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.PictureBox pictureboxIcon;
        private System.Windows.Forms.Timer timer1;
    }
}