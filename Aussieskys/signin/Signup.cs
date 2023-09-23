using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using static App_assignment.Signin;

namespace App_assignment
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private static string DbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";

        //
        //Header
        //
        private void buttonClose_Click(object sender, EventArgs e)
        {
            MaxMainscreen_signedin mainscreen = new MaxMainscreen_signedin();
            mainscreen.Show();
            Visible = false;
        }
        //
        //Next/Signup
        //
        private void buttonnextandSignup_Click(object sender, EventArgs e)
        {
            labelerroruser.Visible = false;
            labelerrorpass.Visible = false;
            labelerrorfname.Visible = false;
            labelerrorlname.Visible = false;
            labelerroremail.Visible = false;
            labelerrorgender.Visible = false;
            labelerrorsecquest.Visible = false;
            labelerrorsecansw.Visible = false;
            if (panelpart1.Visible == true)
            {
                if (textBoxusername.Text == "")
                {
                    labelerroruser.Visible = true;

                }
                if (textBoxpassword.Text != textBoxconpassword.Text || textBoxpassword.Text == "")
                {
                    labelerrorpass.Visible = true;
                }
                else
                {
                    try
                    {
                        using (NpgsqlConnection conn = new NpgsqlConnection(DbConnection))
                        try
                        {
                                conn.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand("select ac_username from account where ac_username = @Username", conn);
                            cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                            NpgsqlDataAdapter dataadaptor = new NpgsqlDataAdapter(cmd);
                            DataTable datatable = new DataTable();
                                try
                                {
                                    dataadaptor.Fill(datatable);

                                    if (datatable.Rows.Count > 0)
                                    {
                                        labelerroruser.Visible = true;

                                    }
                                    else
                                    {
                                        buttonback.Visible = true;
                                        panelpart1.Visible = false;
                                        panelpart2.Visible = true;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Unable to fill database {0}", ex.Message);
                                }
                        }
                            catch
                            {
                                MessageBox.Show("Unable to connect database");
                            }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connect to the internet and try again");
                    }
                }
            }
            else if (panelpart2.Visible == true)
            {
                if (textBoxfname.Text == "")
                {
                    labelerrorfname.Visible = true;
                }
                if (textBoxlname.Text == "")
                {
                    labelerrorlname.Visible = true;
                }
                if (textBoxemail.Text == "")
                {
                    labelerroremail.Visible = true;
                }
                if (comboBoxgender.Text == "")
                {
                    labelerrorgender.Visible = true;
                }
                else
                {
                    panelpart2.Visible = false;
                    panelpart3.Visible = true;
                    buttonnextandSignup.Text = "Sign Up";
                }
            }
            else
            {
                if (comboBox1.Text == "")
                {
                    labelerrorsecquest.Visible = true;
                }
                if (textBox1.Text == "")
                {
                    labelerrorsecansw.Visible = true;
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into account values (@Username, @Password, @Firstname, @Lastname, @Email, @Gender, @DOB, @Secquest, @Secansw)",conn);
                        cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxpassword.Text);
                        cmd.Parameters.AddWithValue("@Firstname", textBoxfname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", textBoxlname.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxemail.Text);
                        cmd.Parameters.AddWithValue("@Gender", comboBoxgender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DOB", dateTimePickerdob.Value.Date);
                        cmd.Parameters.AddWithValue("@Secquest", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Secansw", textBox1.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Account Creation Error {0}", a.Message);
                        }
                        try
                        {
                            conn.Close();
                            Signin signin1 = new Signin();
                            signin1.Show();
                            Visible = false;
                            labelerrorsecquest.Visible = false;
                            labelerrorsecansw.Visible = false;
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Account Creation Error {0}", f.Message);
                            conn.Close();
                        }
                    }
                    catch
                    {
                        conn.Close();
                    }
                }
            }
        }
        //
        //Back
        //
        private void buttonback_Click(object sender, EventArgs e)
        {
            if (panelpart2.Visible == true)
            {
                panelpart2.Visible = false;
                panelpart1.Visible = true;
                buttonback.Visible = false;
            }
            else if (panelpart3.Visible == true)
            {
                panelpart3.Visible = false;
                buttonnextandSignup.Text = "Next";
                panelpart2.Visible = true;
                panelpart2.Location = new Point(95, 43);
            }
        }
        //
        //Signup
        //
        private void buttonSignin_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            Visible = false;
        }
    }
}
