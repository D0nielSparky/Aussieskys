using Aussieskys;
using Npgsql;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static Aussieskys.Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App_assignment
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            //
            //Signing in choice text change
            //
            if (Variables.Loadingchoice == "Signin" || Variables.Loadingchoice == "STimetable" || Variables.Loadingchoice == "SCalendar")
            {
                labelLoading.Text = "CONNECTING TO SERVER!";
            }
            else
            {
                labelLoading.Text = "LOADING...";
            }
        }

        private static string DbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";

        //
        //Loading timer
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoadingprogression.Width += 15;

            if (panelLoadingprogression.Width >= 599)
            {
                timer1.Stop();
                //
                //Signin loading
                //
                if (Variables.Loadingchoice == "Signin")
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
                        try
                        {
                            conn.Open();
                            Signin signin = new Signin();
                            signin.Show();
                            conn.Close();
                            Visible = false;
                        }
                        catch (NpgsqlException)
                        {
                            MessageBox.Show("Unable to connect to server!");
                            MaxMainscreen_signedin maxmainscreen = new MaxMainscreen_signedin();
                            maxmainscreen.Show();
                        }
                }
                //
                //Timetable loading
                //
                else if (Variables.Loadingchoice == "STimetable")
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
                        try
                        {
                            conn.Open();
                            NpgsqlCommand cmd = new NpgsqlCommand("select * from tt_"+ Variables.username.ToLower(), conn);
                            try
                            {/*
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Timetable timetable = new Timetable();
                                timetable.Show();
                                Visible = false;
                                */
                            }
                            catch
                            {
                                NpgsqlCommand cmd1 = new NpgsqlCommand("CREATE TABLE " + "tt_" + Variables.username.ToLower() + " (title VARCHAR primary key,description VARCHAR, day VARCHAR, start_time VARCHAR, end_time VARCHAR)", conn);
                                try
                                {
                                    /*
                                    cmd1.ExecuteNonQuery();
                                    conn.Close();
                                    Timetable timetable = new Timetable();
                                    timetable.Show();
                                    Visible = false;
                                    */
                                }
                                catch (Exception ee)
                                {
                                    MessageBox.Show("Creation error {0}", ee.Message);
                                }
                            }
                        }
                        catch (Exception d)
                        {
                            conn.Close();
                            MessageBox.Show("loading error {0}", d.Message);
                        }
                }

                //
                //Timetable choice
                //
                else if (Variables.Loadingchoice == "Monday" || Variables.Loadingchoice == "Tuesday" || Variables.Loadingchoice == "Wednesday" || Variables.Loadingchoice == "Thursday" || Variables.Loadingchoice == "Friday" || Variables.Loadingchoice == "Saturday" || Variables.Loadingchoice == "Sunday")
                {
                    /*
                    Timetableday timetableday = new Timetableday();
                    timetableday.Show();
                    Visible = false;
                    */
                }

                //
                //Calendar loading
                //
                else if (Variables.Loadingchoice == "calendar")
                {
                }
                //Mainscreen Loading
                //
                else
                {
                    /*
                    Mainscreen mainscreen = new Mainscreen();
                    mainscreen.Show();
                    Visible = false;
                    */
                }
            }
        }
    }
}
