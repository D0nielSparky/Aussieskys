using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;
using static Aussieskys.Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App_assignment
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private string DbConnection = "Server=219.90.188.204;Port=5433;Database=accounts;User ID=postgres;Password=mysecretpassword";
            
        //
        //Varibles
        //
        public class Variables
        {
            public static bool sign = false;
            public static string username;
            public static bool tt_loaded = false;
        }
        //
        //Header
        //
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Variables.Loadingchoice = "";
            Loading loading = new Loading();
            loading.Show();
            Visible = false;
        }
        //
        //Show password
        //
        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpass.Checked)
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
        }
        //
        //Sign up
        //
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Visible = false;
        }
        //
        //Signin button
        private void buttonSignin_Click(object sender, EventArgs e)
        {
            //Null input check
            if (textBoxusername.Text == null)
            {
                MessageBox.Show("Enter Username");
            }
            if (textBoxpassword.Text == null)
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                try
                {
                    //connection to database
                    NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                    //NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5433; Database = postgres; User Id = postgres; Password = mysecretpassword;");
                    conn.Open();
                    try
                    {
                        //checking database
                        NpgsqlCommand cmd = new NpgsqlCommand("select ac_username, ac_password from account where ac_username = @Username and ac_password = @Password", conn);
                        cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxpassword.Text);
                        try
                        {
                            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            if(dt.Rows.Count > 0)
                            {
                                conn.Close();
                                Variables.username = textBoxusername.Text;
                                labelloginerror.Visible = false;
                                Variables.sign = true;
                                //Variables.Loadingchoice = null;
                                Loading loading = new Loading();
                                loading.Show();
                                Visible = false;
                            }
                            //errors/catchs
                            else
                            {
                                labelloginerror.Visible = true;
                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Login Error {0}",f.Message);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to connect to table");
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to connect to server");
                    Thread.Sleep(1000);
                    MaxMainscreen_signedin maxmainscreen = new MaxMainscreen_signedin();
                    maxmainscreen.Show();
                }
            }
        }
        //
        //reset button
        //
        private void buttonreset_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword == null)
            {
                labelNewpassworderror.Visible = true;
                MessageBox.Show("New password is null");
            }
            if (textBoxNewPassword.Text != textBoxConfirmNewpassword.Text)
            {
                labelNewpassworderror.Visible = true;
                MessageBox.Show("New password is not the same");
            }
            else
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("update account set ac_password=@Password where ac_username =@Username", conn);
                        cmd.Parameters.AddWithValue("@Username", textBoxsecusername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxNewPassword.Text);
                        cmd.ExecuteNonQuery();

                        try
                        {   
                            conn.Close();
                            Visible = false;
                            Signin signin = new Signin();
                            signin.Show();
                            labelNewpassworderror.Visible = false;
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Password Reset Error {0}", f.Message);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to connect to table");
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to connect to server");
                    Thread.Sleep(1000);
                    MaxMainscreen_signedin maxmainscreen = new MaxMainscreen_signedin();
                    maxmainscreen.Show();
                }
            }
        }
        //
        //reset password
        //
        private void buttonresetpassword_Click(object sender, EventArgs e)
        {
            panelsignin.Visible = false;
            panelresetpassword.Visible = true;
            buttonSignin.Text = "next";

            //null check
            if (textBoxsecusername.Text == null)
            {
                MessageBox.Show("Enter Username");
            }
            else if (textBoxsecansw.Text == null)
            {
                MessageBox.Show("Enter Security answer");
            }
        }
        //
        //next button
        //
        private void buttonnext_Click(object sender, EventArgs e)
        {
            if (textBoxsecusername.Text == "")
            {
                labelerrorusername.Visible = true;
            }
            if (textBoxsecansw.Text == "")
            {
                labelanswerror.Visible = true;
            }
            else if (panelresetpassword.Visible == true)
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                    conn.Open();
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand("select ac_securityanswer from account where ac_username = @Username and ac_securityanswer = @securityAnswer", conn);
                        cmd.Parameters.AddWithValue("@Username", textBoxsecusername.Text);
                        cmd.Parameters.AddWithValue("@securityAnswer", textBoxsecansw.Text);
                        try
                        {
                            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                conn.Close();
                                panelresetpassword.Visible = false;
                                panelresetpassword2.Visible = true;
                                labelanswerror.Visible = false;
                            }
                            //errors/catchs
                            else
                            {
                                labelanswerror.Visible = true;
                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Password Reset Error {0}", f.Message);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to connect to table");
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to connect to server");
                    Thread.Sleep(1000);
                    MaxMainscreen_signedin maxmainscreen = new MaxMainscreen_signedin();
                    maxmainscreen.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                conn.Open();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("select ac_username, ac_password,ac_securityquestion,ac_securityanswer from account where ac_username = @ac_username", conn);
                    cmd.Parameters.AddWithValue("@ac_username", textBoxsecusername.Text);
                    try
                    {
                        NpgsqlDataAdapter dataadaptor = new NpgsqlDataAdapter(cmd);
                        DataTable datatable = new DataTable();

                        dataadaptor.Fill(datatable);

                        if (datatable.Rows.Count > 0)
                        {
                            NpgsqlDataReader da = cmd.ExecuteReader();
                            while (da.Read())
                            {
                                textBoxsecquest.Text = da.GetValue(2).ToString();
                            }
                        }
                        else
                        {
                            labelanswerror.Visible = true;
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Login Error {0}", f.Message);
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to connect to table");
                }
                
            }
            catch
            {
                MessageBox.Show("Unable to connect to server");
                Thread.Sleep(1000);
                MaxMainscreen_signedin maxmainscreen = new MaxMainscreen_signedin();
                maxmainscreen.Show();
            }
        }
    }
}
