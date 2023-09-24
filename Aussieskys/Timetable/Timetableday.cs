using Npgsql;
using System;
using System.Data;
using System.Dynamic;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Data.Common;
using static Aussieskys.Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Aussieskys;

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
            if (Variables.sign == true)
            {
                string DbConnection = Variables.SDbConnection;
            }
            else
            {
                string DbConnection = Variables.LDbConnection;
            }
            NpgsqlConnection con = new NpgsqlConnection(DbConnection);
            enablebutton();

            if (Variables.daypick == "Monday")
            {
                enablebutton();
                buttonMon.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from "+"tt_"+ Variables.username.ToLower()+" where day = 'Monday' ORDER BY start_time", con);
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
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Tuesday")
            {
                enablebutton();
                buttonTues.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from " + "tt_" + Variables.username.ToLower() + " where day = 'Tuesday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();

                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Wednesday")
            {
                enablebutton();
                buttonWed.Enabled = false;
                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from " + "tt_" + Variables.username.ToLower() + " where day = 'Wednesday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Thursday")
            {
                enablebutton();
                buttonThur.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from "+"tt_"+ Variables.username.ToLower()+" where day = 'Thursday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);                              
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Friday")
            {
                enablebutton();
                buttonFri.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from "+"tt_"+ Variables.username.ToLower()+" where day = 'Friday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);                              
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Saturday")
            {
                enablebutton();
                buttonSat.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from "+"tt_"+ Variables.username.ToLower()+" where day = 'Saturday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);                              
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
            else if (Variables.daypick == "Sunday")
            {
                enablebutton();
                buttonSun.Enabled = false;

                try
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select title, description, start_time, end_time from "+"tt_"+ Variables.username.ToLower()+" where day = 'Sunday' ORDER BY start_time", con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        try
                        {
                            da.Fill(dt);                              
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoResizeRows();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Unable to fill table {0}");
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message, "Unable to create table {0}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to table {0}");
                }
            }
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
                using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
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
                            MessageBox.Show("schedule loading Error {0}", a.Message);
                        }

                    }
                    catch
                    {
                        conn.Close();
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
            paneladddata.Visible=true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            paneltable.Visible=false;
            panelheader2.Visible=false;
            paneleditdata.Visible=true;
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
                    try
                    {
                        labelEditingerror.Visible = false;
                        NpgsqlConnection con = new NpgsqlConnection(DbConnection);
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
                                MessageBox.Show("schedule loading Error {0}", a.Message);
                            }


                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("error {0}", a.Message);
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show("error2 {0}", b.Message);
                    }
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("error3 {0}", c.Message);
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
        private static string DDbConnection = "Server=219.90.164.254;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";
        private void buttoneditdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete this schedule", "Delete Schedule", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(DDbConnection))
                    try
                    {
                        conn.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand("delete from tt_" + Variables.username.ToLower() + " where title = ",conn);
                        cmd.Parameters.AddWithValue("@Title", Variables.title);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        Loading loading = new Loading();
                        loading.Show();
                        Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"{0} Unable to connect");
                    }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}