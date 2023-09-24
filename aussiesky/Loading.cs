using aussiesky;
using Npgsql;
using System;
using System.Windows.Forms;
using static aussiesky.Variables;

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
                            Variables.Loadingchoice = "";
                            Loading loading = new Loading();
                            loading.Show();
                            Visible = false;
                        }
                }
                //
                //Timetable loading
                //
                else if (Variables.Loadingchoice == "STimetable")
                {
                    if (Variables.sign == true)
                    {
                        using (NpgsqlConnection conn = new NpgsqlConnection(SDbConnection))
                            try
                            {
                                conn.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand("select * from tt_" + Variables.username.ToLower(), conn);
                                try
                                {
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Timetable timetable = new Timetable();
                                timetable.Show();
                                Visible = false;
                                }
                                catch
                                {
                                    NpgsqlCommand cmd1 = new NpgsqlCommand("CREATE TABLE " + "tt_" + Variables.username.ToLower() + " (title VARCHAR primary key,description VARCHAR, day VARCHAR, start_time VARCHAR, end_time VARCHAR)", conn);
                                    try
                                    {
                                        cmd1.ExecuteNonQuery();
                                        conn.Close();
                                        Timetable timetable = new Timetable();
                                        timetable.Show();
                                        Visible = false;
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
                }

                //Local Timetable
                else if (Variables.Loadingchoice == "LTimetable")
                {
                    Timetable timetable = new Timetable();
                    timetable.Show();
                    Visible = false;
                }

                //
                //Timetable choice
                //
                else if (Variables.Loadingchoice == "Monday" || Variables.Loadingchoice == "Tuesday" || Variables.Loadingchoice == "Wednesday" || Variables.Loadingchoice == "Thursday" || Variables.Loadingchoice == "Friday" || Variables.Loadingchoice == "Saturday" || Variables.Loadingchoice == "Sunday")
                {
                    if (Variables.sign == true)
                    {
                        Timetableday timetableday = new Timetableday();
                        timetableday.Show();
                        Visible = false;
                    }
                    else
                    {
                        Timetableday timetableday = new Timetableday();
                        timetableday.Show();
                        Visible = false;
                    }
                }

                //
                //Calendar loading
                //
                else if (Variables.Loadingchoice == "Scalendar")
                {
                }

                //Local Calendar
                else if (Variables.Loadingchoice == "Lcalendar")
                {
                }
                //Mainscreen Loading
                //
                else
                {
                    if (maxscreen == true)
                    {
                        MaxMainscreen maxmainscreen = new MaxMainscreen();
                        maxmainscreen.Show();
                        Visible = false;
                    }
                    else
                    {
                        Mainscreen mainscreen = new Mainscreen();
                        mainscreen.Show();
                        Visible = false;
                    }
                }
            }
        }
    }
}
