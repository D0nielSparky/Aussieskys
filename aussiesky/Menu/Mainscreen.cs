using aussiesky;
using aussiesky.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace App_assignment
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
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
                if (Variables.debugging == true)
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Account Debug";
                    popup.ContentText = "Accounts Are currently Disabled, Plz use Local Mode";
                    popup.Popup();

                }
                else
                {
                    Variables.Loadingchoice = "Signin";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to sign out of " + Variables.username, "Sign out", MessageBoxButtons.YesNo);
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
            hidePanels();
            panelCalendar.Visible = true;
            panelCalendar.Location = new Point(95, 43);
        }

        //
        //Launch timetable
        //
        private void buttonPlaytimetable_Click(object sender, EventArgs e)
        {
            //check if signed in
            if (comboBox1.Text == "Server Save")
            {
                if (Variables.debugging == false)
                {
                    Variables.Loadingchoice = "STimetable";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
                else
                {

                }
            }
            else if (comboBox1.Text == "Local Save")
            {
                Variables.Loadingchoice = "LTimetable";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else
            {
            }
        }

        //
        //Launch Calendar
        //
        private void buttonPlaycalendar_Click(object sender, EventArgs e)
        {
            //check if signed in
            if (comboBox1.Text == "Server Save")
            {
                Variables.Loadingchoice = "SCalendar";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else if (comboBox1.Text == "Local Save")
            {
                Variables.Loadingchoice = "LCalendar";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
            else
            {
            }
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            Variables.maxscreen = true;
            MaxMainscreen maxmainscreen = new MaxMainscreen();
            maxmainscreen.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Server Save")
            {
                buttonPlaytimetable.Text = "Server";
            }
            else
            {
                buttonPlaytimetable.Text = "Local";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Server Save")
            {
                buttonPlaycalendar.Text = "Server";
            }
            else
            {
                buttonPlaycalendar.Text = "Local";
            }
        }
    }
}
