using aussiesky;
using System;
using System.Windows.Forms;
using static aussiesky.Variables;

namespace App_assignment
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Variables.Loadingchoice = "";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }
        public void hidePanels()
        {
            panelMenu.Visible = false;
            panelSetting.Visible = false;
        }

        private void buttonsetting_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelSetting.Visible = true;
            panelAppsetting.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelMenu.Visible = true;
        }

        private void buttonMonday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Monday";
            Variables.Loadingchoice = "Monday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonTuesday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Tuesday";
            Variables.Loadingchoice = "Tuesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonWednesday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Wednesday";
            Variables.Loadingchoice = "Wednesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonThursday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Thursday";
            Variables.Loadingchoice = "Thursday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonFriday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Friday";
            Variables.Loadingchoice = "Friday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSaturday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Saturday";
            Variables.Loadingchoice = "Saturday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSunday_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Sunday";
            Variables.Loadingchoice = "Sunday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        public void settinghidepanel()
        {
            panelAppsetting.Visible = false;
        }
        private void buttonappset_Click(object sender, EventArgs e)
        {
            settinghidepanel();
            panelAppsetting.Visible = true;
        }

        private void buttonMTimetable_Click(object sender, EventArgs e)
        {
            settinghidepanel();
        }
    }
}
