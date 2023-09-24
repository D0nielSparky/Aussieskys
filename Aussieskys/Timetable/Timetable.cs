using System;
using System.Windows.Forms;
using static App_assignment.Mainscreen;

namespace App_assignment
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }
        public class Varibles
        {
            public static string daypick;
            public static string title;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Loadingchoice.loadingchoice = "";
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
            Varibles.daypick = "Monday";
            Loadingchoice.loadingchoice = "Monday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonTuesday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Tuesday";
            Loadingchoice.loadingchoice = "Tuesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonWednesday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Wednesday";
            Loadingchoice.loadingchoice = "Wednesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonThursday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Thursday";
            Loadingchoice.loadingchoice = "Thursday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonFriday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Friday";
            Loadingchoice.loadingchoice = "Friday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSaturday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Saturday";
            Loadingchoice.loadingchoice = "Saturday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSunday_Click(object sender, EventArgs e)
        {
            Varibles.daypick = "Sunday";
            Loadingchoice.loadingchoice = "Sunday";
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
