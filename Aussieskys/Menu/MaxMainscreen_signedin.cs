using Aussieskys;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Aussieskys.Variables;

namespace App_assignment
{
    public partial class MaxMainscreen_signedin : Form
    {
        public MaxMainscreen_signedin()
        {
            InitializeComponent();
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
                /*
                Loadingchoice.loadingchoice = "Signin";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
                */
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to sign out of "+Variables.username, "Sign out", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    /*
                    Variables.sign = false;
                    Variables.username = null;
                    Loadingchoice.loadingchoice = null;
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                    */
                }
            }
        }
        //
        //Hide panels
        //
        public void hidePanels()
        {
            TimeTable.Visible = false;
            Calendar.Visible = false;
        }
        //
        //Sidebar Home button
        //
        private void buttonHome_Click(object sender, EventArgs e)
        {
            hidePanels();
        }

        //
        //Sidebar Timetable button
        //
        private void buttonTimetable_Click(object sender, EventArgs e)
        {
            hidePanels();
            TimeTable.Visible = true;
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
            
            hidePanels();
            Calendar.Visible = true;
        }

        //
        //timetable
        //
        //Timetable Mode Config
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TimetableModeSelect.Text == "Server Save")
            {
                TimetablePlay.Text = "Server";
            }
            else
            {
                TimetablePlay.Text = "Local";
            }
        }

        //Timetable Play
        private void TimetablPlay_Click(object sender, EventArgs e)
        {
            if (TimetableModeSelect.Text == "Server Save")
            {

            }
            else if (TimetableModeSelect.Text == "Local Save")
            {

            }
            else
            {

            }

        }
        //
        //Calendar
        //

        //Calendar Play
        private void CalendarPlay_Click(object sender, EventArgs e)
        {
            if (CalendarModeSelect.Text == "Server Save")
            {

            }
            else if (CalendarModeSelect.Text == "Local Save")
            {

            }
            else
            {

            }


        }
        private void buttonPlaytimetable_Click(object sender, EventArgs e)
        {
            //check if signed in
            /*
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
                
            }*/
        }
    }
}
