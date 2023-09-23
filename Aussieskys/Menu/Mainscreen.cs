using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using static App_assignment.Signin;

namespace App_assignment
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
            //
            //Sign in config
            //
            if (Variables.sign == false)
            {
                //timetable
                buttonPlaytimetable.Text = "Sign in";
                buttonPlaytimetable.BackColor = Color.IndianRed;

                //calendar
                buttonPlaycalendar.Text = "Sign in";
                buttonPlaycalendar.BackColor = Color.IndianRed;
            }
            if (Variables.sign == true)
            {
                buttonUsernameandSignin.Text = "Sign out";
                //timetable
                buttonPlaytimetable.Text = "Launch";
                buttonPlaytimetable.BackColor = Color.LimeGreen;
                //calendar
                buttonPlaycalendar.Text = "Launch";
                buttonPlaycalendar.BackColor = Color.LimeGreen;
            }
        }

        //
        //Loadingchoice varible
        //
        public class Loadingchoice
        {
            public static string loadingchoice;
        }

        //
        //Minimize button
        //
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        //Close button
        //
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Signin button
        //
        private void buttonUsernameandSignin_Click(object sender, EventArgs e)
        {
            if (Variables.sign == false)
            {
                Loadingchoice.loadingchoice = "Signin";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to sign out of "+Variables.username, "Sign out", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Variables.sign = false;
                    Variables.username = null;
                    Loadingchoice.loadingchoice = null;
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
            }
        }
        //
        //Hide panels
        //
        public void hidePanels()
        {
            panelTimetable.Visible = false;
            panelCalendar.Visible = false;
        }
        //
        //Sidebar Timetable button
        //
        private void buttonTimetable_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelTimetable.Visible = true;
            panelTimetable.Location = new Point(95, 43);
        }
        //
        //Sidebar Calculator button
        //
        private void buttonCalculator_Click(object sender, EventArgs e)
        {
        }
        //
        //Sidebar Game button
        //
        private void buttonGamess_Click(object sender, EventArgs e)
        {
        }
        //
        //Sidebar Calendar button
        //
        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            /*
            hidePanels();
            panelCalendar.Visible = true;
            panelCalendar.Location = new Point(95, 43);
            */
        }

        //
        //Launch timetable
        //
        private void buttonPlaytimetable_Click(object sender, EventArgs e)
        {
            //check if signed in
            if (buttonPlaytimetable.Text == "Sign in")
            {
                Loadingchoice.loadingchoice = "TimetableSignin";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else
            {
                Loadingchoice.loadingchoice = "Timetable";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
        }
        
        //
        //Launch Calendar
        //
        private void buttonPlaycalendar_Click(object sender, EventArgs e)
        {
            //check if signed in
            if (buttonPlaycalendar.Text == "Sign in")
            {
                Loadingchoice.loadingchoice = "CalendarSignin";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else
            {
                Loadingchoice.loadingchoice = "Signin";
                //Loading loading = new Loading();
                //loading.Show();
                //Visible = false;
            }
        }
    }
}
