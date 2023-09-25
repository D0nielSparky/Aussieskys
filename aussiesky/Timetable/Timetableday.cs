using aussiesky;
using aussiesky.Properties;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        private void Timetableday_Load(object sender, EventArgs e)
        {

            NpgsqlConnection con = new NpgsqlConnection(Variables.SDbConnection);
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
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from " + "tt_" + Variables.username.ToLower() + " where day = '"+ Variables.daypick +"' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView2.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView2.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                            dataGridView1.AutoResizeRows();
                            con.Close();
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
                string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\dbTimetable.mdf;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(connection);
                try
                {
                    Conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select title, description, start_time, end_time from TableTimetable Where day = '"+ Variables.daypick + "' ORDER BY start_time", Conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView2.DataSource = ds.Tables[0];
                    Conn.Close();
                }
                catch (Exception b)
                {
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
            paneltable.Visible = true;
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
            if (textBoxaddtitle.Text == null)
            {
                labelAddingerror.Visible = true;
            }
            if (textBoxadddescription.Text == null)
            {
                labelAddingerror.Visible = true;
            }
            if (comboBoxaddday == null)
            {
                labelAddingerror.Visible = true;
            }
            if (textBoxaddtitle.Text.Length > 15)
            {
                labelAddingerror.Visible = true;
            }
            if (textBoxadddescription.Text.Length > 45)
            {
                labelAddingerror.Visible = true;
            }
            if (dateTimePickeraddstarttime.Value.Date.CompareTo(dateTimePickeraddendtime.Value.Date) > 0)
            {
                labelAddingerror.Visible = true;
            }
            else
            {
                labelAddingerror.Visible = false;
                if (Variables.sign == true)
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(Variables.SDbConnection))
                        try
                        {
                            conn.Open();
                            NpgsqlCommand cmd = new NpgsqlCommand("insert into " + "tt_" + Variables.username.ToLower() + " values (@Title, @Description, @Day, @STime, @ETime)", conn);
                            cmd.Parameters.AddWithValue("@Title", textBoxaddtitle.Text);
                            cmd.Parameters.AddWithValue("@Description", textBoxadddescription.Text);
                            cmd.Parameters.AddWithValue("@Day", comboBoxaddday.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@STime", dateTimePickeraddstarttime.Text);
                            cmd.Parameters.AddWithValue("@ETime", dateTimePickeraddendtime.Text);

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
                    string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\dbTimetable.mdf;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(connection);
                    try
                    {
                        Conn.Open();
                        SqlCommand da = new SqlCommand("insert into TableTimetable values ('"+ textBoxaddtitle.Text +"', '"+ textBoxadddescription.Text +"', '"+ comboBoxaddday.SelectedItem.ToString() +"', '"+ dateTimePickeraddstarttime.Text +"', '"+ dateTimePickeraddendtime.Text +"')", Conn);
                        da.ExecuteNonQuery();
                        Conn.Close();
                        Loading loading = new Loading();
                        loading.Show();
                        Visible = false;

                    }
                    catch (Exception a)
                    {
                        Conn.Close();
                        MessageBox.Show(a.Message);
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Loading Error";
                        popup.ContentText = "Schedule Loading Error";
                        popup.Popup();
                    }
                }
                
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            paneladddata.Visible = false;
            textBoxaddtitle.Text = "";
            textBoxadddescription.Text = "";
            comboBoxaddday.SelectedIndex = 0;
            dateTimePickeraddstarttime.Text = default;
            paneltable.Visible = true;
            panelheader2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            paneltable.Visible = false;
            panelheader2.Visible = false;
            paneladddata.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paneltable.Visible = false;
            panelheader2.Visible = false;
            paneleditdata.Visible = true;
        }


        private void buttoneditcancel_Click(object sender, EventArgs e)
        {
            paneleditdata.Visible = false;
            textBoxedittitle.Text = "";
            textBoxeditdesc.Text = "";
            comboBoxeditdaypick.SelectedIndex = 1;
            dateTimePickereditstime.Text = "";
            dateTimePickereditetime.Text = "";
            paneltable.Visible = true;
            panelheader2.Visible = true;
        }

        private void buttoneditupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxedittitle == null)
                {
                    labelEditingerror.Visible = true;

                }
                if (textBoxeditdesc == null)
                {
                    labelEditingerror.Visible = true;
                }
                if (dateTimePickereditstime.Value.Hour.CompareTo(dateTimePickereditetime.Value.Hour) > 0)
                {
                    labelEditingerror.Visible = true;
                }
                else
                {
                    if (Variables.sign == true)
                    {
                        try
                        {
                            labelEditingerror.Visible = false;
                            NpgsqlConnection con = new NpgsqlConnection(Variables.SDbConnection);
                            try
                            {
                                con.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand("update tt_" + Variables.username.ToLower() + " set title = @Title,description = @Description,start_time = @STime,end_time = @ETime where title = @STitle", con);
                                cmd.Parameters.AddWithValue("@Title", textBoxedittitle.Text);
                                cmd.Parameters.AddWithValue("@Description", textBoxeditdesc.Text);
                                cmd.Parameters.AddWithValue("@Day", comboBoxaddday.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@STime", dateTimePickereditstime.Text);
                                cmd.Parameters.AddWithValue("@ETime", dateTimePickereditetime.Text);
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
                            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\dbTimetable.mdf;Integrated Security=True";
                            SqlConnection Conn = new SqlConnection(connection);
                            try
                            {
                                Conn.Open();
                                SqlDataAdapter da = new SqlDataAdapter("update TableTimetable set title = '"+ textBoxedittitle.Text + "',description = '"+ textBoxeditdesc.Text + "',day = '"+ comboBoxaddday.SelectedItem.ToString() + "',start_time = '"+ dateTimePickereditstime.Text + "',end_time = '"+ dateTimePickereditetime.Text + "' where title = '"+ Variables.title + "'", Conn);
                                SqlCommandBuilder builder = new SqlCommandBuilder(da);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBoxedittitle.Text = row.Cells["title"].Value.ToString();
                Variables.title = textBoxedittitle.Text;
                textBoxeditdesc.Text = row.Cells["description"].Value.ToString();
                dateTimePickereditstime.Text = row.Cells["start_time"].Value.ToString();
                dateTimePickereditetime.Text = row.Cells["end_time"].Value.ToString();
            }
        }
        private void buttoneditdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this schedule", "Delete Schedule", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Variables.sign == true)
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection(Variables.SDbConnection))
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
                        string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\dbTimetable.mdf;Integrated Security=True";
                        SqlConnection Conn = new SqlConnection(connection);
                        try
                        {
                            Conn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("delete from TableTimetable Where title = '"+ Variables.title +"'", Conn);
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
    }
}