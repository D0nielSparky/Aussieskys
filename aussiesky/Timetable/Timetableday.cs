using aussiesky;
using aussiesky.Properties;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace App_assignment
{
    public partial class Timetableday : Form
    {
        public Timetableday()
        {
            InitializeComponent();
        }

        private static string DbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";

        private void Timetableday_Load(object sender, EventArgs e)
        {

            NpgsqlConnection con = new NpgsqlConnection(DbConnection);
            enablebutton();

            if (Variables.daypick == "Monday")
            {
                enablebutton();
                buttonMon.Enabled = false;
            }
            else if (Variables.daypick == "Tuesday")
            {
                enablebutton();
                buttonTues.Enabled = false;
            }
            else if (Variables.daypick == "Wednesday")
            {
                enablebutton();
                buttonWed.Enabled = false;
            }
            else if (Variables.daypick == "Thursday")
            {
                enablebutton();
                buttonThur.Enabled = false;
            }
            else if (Variables.daypick == "Friday")
            {
                enablebutton();
                buttonFri.Enabled = false;
            }
            else if (Variables.daypick == "Saturday")
            {
                enablebutton();
                buttonSat.Enabled = false;
            }
            else if (Variables.daypick == "Sunday")
            {
                enablebutton();
                buttonSun.Enabled = false;
            }
            if (Variables.sign == true)
            {
                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, start_time from " + "tt_" + Variables.username.ToLower() + " where day = '"+ Variables.daypick +"' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);
                            vieweventtable.DataSource = dt;
                            vieweventtable.AutoResizeColumns();
                            vieweventtable.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Save Error";
                            popup.ContentText = "Unable to save";
                            popup.Popup();
                        }
                    }
                    catch (Exception b)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Save Error";
                        popup.ContentText = "Unable to Create Save";
                        popup.Popup();
                    }
                }
                catch (Exception ex)
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Save Error";
                    popup.ContentText = "Unable to Connect to Save";
                    popup.Popup();
                }
            }
            else
            {
                Lpopulate();

            }
        }
        void Lpopulate()
        {
            try
            {
                SqlConnection Conn = new SqlConnection(Variables.LConnect);
                try
                {
                    Conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from TableTimetable Where day = '"+ Variables.daypick + "' ORDER BY start_time", Conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    vieweventtable.DataSource = ds.Tables[0];
                    Conn.Close();
                    vieweventtable.Columns["description"].Visible = false;
                    vieweventtable.Columns["day"].Visible = false;
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Load Save Error";
                    popup.ContentText = "Unable to Load Local Save";
                    popup.Popup();
                }
            }
            catch { }
        }

        public void enablebutton()
        {
            buttonMon.Enabled = true;
            buttonTues.Enabled = true;
            buttonWed.Enabled = true;
            buttonThur.Enabled = true;
            buttonFri.Enabled = true;
            buttonSat.Enabled = true;
            buttonSun.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            enablebutton();
            Events.Visible = true;
            Variables.Loadingchoice = "Timetable";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonMon_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Monday";
            Variables.Loadingchoice = "Monday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonTues_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Tuesday";
            Variables.Loadingchoice = "Tuesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonWed_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Wednesday";
            Variables.Loadingchoice = "Wednesday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonThur_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Thursday";
            Variables.Loadingchoice = "Thursday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonFri_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Friday";
            Variables.Loadingchoice = "Friday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSat_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Saturday";
            Variables.Loadingchoice = "Saturday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Variables.daypick = "Sunday";
            Variables.Loadingchoice = "Sunday";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (addeventtitle.Text == null)
            {
                addeventerror.Visible = true;
            }
            if (addeventdesc.Text == null)
            {
                addeventerror.Visible = true;
            }
            if (addeventday == null)
            {
                addeventerror.Visible = true;
            }
            if (addeventtitle.Text.Length > 15)
            {
                addeventerror.Visible = true;
            }
            if (addeventdesc.Text.Length > 45)
            {
                addeventerror.Visible = true;
            }
            if (addeventstarttime.Value.Date.CompareTo(addeventendtime.Value.Date) > 0)
            {
                addeventerror.Visible = true;
            }
            else
            {
                addeventerror.Visible = false;
                if (Variables.sign == true)
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
                        try
                        {
                            conn.Open();
                            NpgsqlCommand cmd = new NpgsqlCommand("insert into " + "tt_" + Variables.username.ToLower() + " values (@Title, @Description, @Day, @STime, @ETime)", conn);
                            cmd.Parameters.AddWithValue("@Title", addeventtitle.Text);
                            cmd.Parameters.AddWithValue("@Description", addeventdesc.Text);
                            cmd.Parameters.AddWithValue("@Day", addeventday.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@STime", addeventstarttime.Text);
                            cmd.Parameters.AddWithValue("@ETime", addeventendtime.Text);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                Loading loading = new Loading();
                                loading.Show();
                                Visible = false;
                            }
                            catch (Exception a)
                            {
                                conn.Close();
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Resources.alert;
                                popup.TitleText = "Loading Error";
                                popup.ContentText = "Schedule Loading Error";
                                popup.Popup();
                            }

                        }
                        catch
                        {
                            conn.Close();
                        }
                }
                else
                {
                    SqlConnection Conn = new SqlConnection(Variables.LConnect);
                    try
                    {
                        Conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into TableTimetable values ('"+ addeventtitle.Text +"', '"+ addeventdesc.Text +"', '"+ addeventday.SelectedItem.ToString() +"', '"+ addeventstarttime.Text +"', '"+ addeventendtime.Text +"')", Conn);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Conn.Close();

                            Loading loading = new Loading();
                            loading.Show();
                            Visible = false;
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                            Conn.Close();
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Loading Error";
                            popup.ContentText = "Schedule Loading Error";
                            popup.Popup();
                        }
                    }
                    catch
                    {
                        Conn.Close();
                    }
                }
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Eventadd.Visible = false;
            addeventtitle.Text = "";
            addeventdesc.Text = "";
            addeventday.SelectedIndex = 0;
            addeventstarttime.Text = default;
            Events.Visible = true;
            panelheader2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Events.Visible = false;
            panelheader2.Visible = false;
            Eventadd.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Events.Visible = false;
            panelheader2.Visible = false;
            //paneleditdata.Visible = true;
            Eventview.Visible = true;
        }


        private void buttoneditcancel_Click(object sender, EventArgs e)
        {
            Eventedit.Visible = false;
            editeventtitle.Text = "";
            editeventdesc.Text = "";
            editeventstarttime.Text = "";
            editeventendtime.Text = "";
            Events.Visible = true;
            panelheader2.Visible = true;
        }

        private void buttoneditupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (editeventtitle == null)
                {
                    editeventerror.Visible = true;

                }
                if (editeventdesc == null)
                {
                    editeventerror.Visible = true;
                }
                if (editeventstarttime.Value.Hour.CompareTo(editeventendtime.Value.Hour) > 0)
                {
                    editeventerror.Visible = true;
                }
                else
                {
                    if (Variables.sign == true)
                    {
                        try
                        {
                            editeventerror.Visible = false;
                            NpgsqlConnection con = new NpgsqlConnection(DbConnection);
                            try
                            {
                                con.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand("update tt_" + Variables.username.ToLower() + " set title = @Title,description = @Description,start_time = @STime,end_time = @ETime where title = @STitle", con);
                                cmd.Parameters.AddWithValue("@Title", editeventtitle.Text);
                                cmd.Parameters.AddWithValue("@Description", editeventdesc.Text);
                                cmd.Parameters.AddWithValue("@Day", addeventday.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@STime", editeventstarttime.Text);
                                cmd.Parameters.AddWithValue("@ETime", editeventendtime.Text);
                                cmd.Parameters.AddWithValue("@STitle", Variables.title);

                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    Loading loading = new Loading();
                                    loading.Show();
                                    Visible = false;
                                }
                                catch (Exception a)
                                {
                                    con.Close();
                                    PopupNotifier popup = new PopupNotifier();
                                    popup.Image = Resources.alert;
                                    popup.TitleText = "Loading Error";
                                    popup.ContentText = "Schedule Loading Error";
                                    popup.Popup();
                                }


                            }
                            catch (Exception a)
                            {
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Resources.alert;
                                popup.TitleText = "Error";
                                popup.ContentText = "Failed";
                                popup.Popup();
                            }
                        }
                        catch (Exception b)
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Error";
                            popup.ContentText = "Failed";
                            popup.Popup();
                        }
                    }
                    else
                    {
                        try
                        {
                            SqlConnection Conn = new SqlConnection(Variables.LConnect);
                            try
                            {
                                Conn.Open();
                                SqlDataAdapter da = new SqlDataAdapter("update TableTimetable set title = '"+ editeventtitle.Text + "',description = '"+ editeventdesc.Text + "',day = '"+ addeventday.SelectedItem.ToString() + "',start_time = '"+ editeventstarttime.Text + "',end_time = '"+ editeventendtime.Text + "' where title = '"+ Variables.title + "'", Conn);
                                Conn.Close();
                            }
                            catch (Exception b)
                            {
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Resources.alert;
                                popup.TitleText = "Load Error";
                                popup.ContentText = "Unable to Load Local Save";
                                popup.Popup();
                            }
                        }
                        catch { }
                    }
                }
            }
            catch (Exception c)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Error";
                popup.ContentText = "Failed";
                popup.Popup();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            editeventtitle.Text = vieweventtitle.Text;
            editeventdesc.Text = vieweventdesc.Text;
            editeventstarttime.Text = vieweventtable.CurrentRow.Cells["start_time"].Value.ToString();
            editeventendtime.Text = vieweventtable.CurrentRow.Cells["end_time"].Value.ToString();
            Eventview.Visible = false;
            panelheader2.Visible = false;
            Eventedit.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vieweventtitle.Text = vieweventtable.CurrentRow.Cells["title"].Value.ToString();
            vieweventdesc.Text = vieweventtable.CurrentRow.Cells["description"].Value.ToString();
            vieweventstarttime.Text = "Start time: " + vieweventtable.CurrentRow.Cells["start_time"].Value.ToString();
            vieweventendtime.Text = "End time: " + vieweventtable.CurrentRow.Cells["end_time"].Value.ToString();
            Events.Visible = false;
            panelheader2.Visible = false;
            Eventview.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this schedule", "Delete Schedule", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Variables.sign == true)
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
                        try
                        {
                            conn.Open();
                            NpgsqlCommand cmd = new NpgsqlCommand("delete from tt_" + Variables.username.ToLower() + " where title = ", conn);
                            cmd.Parameters.AddWithValue("@Title", Variables.title);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            Loading loading = new Loading();
                            loading.Show();
                            Visible = false;
                        }
                        catch (Exception ex)
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Connection Error";
                            popup.ContentText = "Unable to connect to Save";
                            popup.Popup();
                        }
                }
                else
                {
                    try
                    {
                        SqlConnection Conn = new SqlConnection(Variables.LConnect);
                        try
                        {
                            Conn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("delete from TableTimetable Where title = '" + Variables.title + "', '" + vieweventdesc.Text + "'", Conn);
                            Conn.Close();
                        }
                        catch (Exception b)
                        {
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Connection Error";
                            popup.ContentText = "Unable to Load Local Save";
                            popup.Popup();
                        }
                    }
                    catch { }
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eventview.Visible = false;
            Events.Visible = true;
            panelheader2.Visible = true;
        }
    }
}