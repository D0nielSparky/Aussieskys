using aussiesky;
using aussiesky.Properties;
using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace App_assignment
{
    public partial class MaxMainscreen : Form
    {
        public MaxMainscreen()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //
        //Minimize button
        //
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        //Resize button
        //
        private void buttonResize_Click(object sender, EventArgs e)
        {
            Variables.maxscreen = false;
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            Visible = false;
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
                    Variables.Loadingchoice = null;
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
        //Timetable Select
        //
        private void TimetableSelect_Click(object sender, EventArgs e)
        {
            hidePanels();
            TimeTable.Visible = true;
        }
        private void TimetableFav_Click(object sender, EventArgs e)
        {
            if (FavTimetable.Visible == true)
            {
                FavTimetable.Visible = false;
            }
            else
            {
                FavTimetable.Visible = true;
            }
        }
        //
        //Calculator button
        //
        private void CalendarSelect_Click(object sender, EventArgs e)
        {
            hidePanels();
            Calendar.Visible = true;
        }
        private void CalendarFav_Click(object sender, EventArgs e)
        {
            if (FavCalendar.Visible == true)
            {
                FavCalendar.Visible = false;
            }
            else
            {
                FavCalendar.Visible = true;
            }
        }
        //
        //Sidebar Game button
        //
        private void buttonGamess_Click(object sender, EventArgs e)
        {
        }
        //
        //Calculator button
        //
        private void CalculatorSelect_Click(object sender, EventArgs e)
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
                if (Variables.debugging == false)
                {
                    Variables.Loadingchoice = "STimetable";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Account Debug";
                    popup.ContentText = "Accounts Are currently Disabled, Plz use Local Mode";
                    popup.Popup();
                }

            }
            else if (TimetableModeSelect.Text == "Local Save")
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
        //Calendar
        //
        private void CalendarModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CalendarModeSelect.Text == "Server Save")
            {
                CalendarPlay.Text = "Server";
            }
            else
            {
                CalendarPlay.Text = "Local";
            }

        }
        //Calendar Play
        private void CalendarPlay_Click(object sender, EventArgs e)
        {
            if (CalendarModeSelect.Text == "Server Save")
            {
                if (Variables.debugging == false)
                {
                    Variables.Loadingchoice = "SCalendar";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
                else
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Account Debug";
                    popup.ContentText = "Accounts Are currently Disabled, Plz use Local Mode";
                    popup.Popup();
                }
            }
            else if (CalendarModeSelect.Text == "Local Save")
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
    }
}
