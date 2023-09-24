using aussiesky;
using aussiesky.Properties;
using Npgsql;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace App_assignment
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private string DbConnection = Variables.SDbConnection;
        //
        //Header
        //
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Variables.Loadingchoice = "";
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
            SignupBuild.Visible = true;
            buttonback.Visible = true;
            SigninBuild.Visible = false;
            panelpart1.Visible = true;
        }
        //
        //Signin button
        private void buttonSignin_Click(object sender, EventArgs e)
        {
            //Null input check
            if (textBoxusername.Text == null)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Account Sigin Error";
                popup.ContentText = "Enter a Valid Username";
                popup.Popup();
            }
            if (textBoxpassword.Text == null)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Account Signin Error";
                popup.ContentText = "Enter a Valid Password";
                popup.Popup();
            }
            else
            {
                try
                {
                    //connection to database
                    NpgsqlConnection conn = new NpgsqlConnection(DbConnection);
                    conn.Open();
                    try
                    {
                        //checking database
                        NpgsqlCommand cmd = new NpgsqlCommand("select ac_Username, ac_Password from account where ac_Username = @Username and ac_Password = @Password", conn);
                        cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxpassword.Text);
                        try
                        {
                            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                conn.Close();
                                Variables.username = textBoxusername.Text;
                                labelloginerror.Visible = false;
                                Variables.sign = true;
                                Variables.Loadingchoice = "";
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
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Connection Error";
                            popup.ContentText = "Login Failed";
                            popup.Popup();
                        }
                    }
                    catch
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Connection Error";
                        popup.ContentText = "Unable to connect to Saves";
                        popup.Popup();
                    }
                }
                catch
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Connection Error";
                    popup.ContentText = "Unable to connect to server";
                    popup.Popup();
                    Variables.Loadingchoice = "";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
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
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Account Reset Error";
                popup.ContentText = "Invalid New Password";
                popup.Popup();
            }
            if (textBoxNewPassword.Text != textBoxConfirmNewpassword.Text)
            {
                labelNewpassworderror.Visible = true;
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Account Reset Error";
                popup.ContentText = "Passwords arn't the same";
                popup.Popup();
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
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Connection Error";
                            popup.ContentText = "Password reset Failed";
                            popup.Popup();
                        }
                    }
                    catch
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Connection Error";
                        popup.ContentText = "Unable to connect to Save";
                        popup.Popup();
                    }
                }
                catch
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Connection Error";
                    popup.ContentText = "Unable to connect to server";
                    popup.Popup();
                    Variables.Loadingchoice = "";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
                }
            }
        }
        //
        //reset password
        //
        private void buttonresetpassword_Click(object sender, EventArgs e)
        {
            SigninBuild.Visible = false;
            panelresetpassword.Visible = true;
            buttonSignin.Text = "next";

            //null check
            if (textBoxsecusername.Text == null)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Password Reset Error";
                popup.ContentText = "Invalid Username";
                popup.Popup();
            }
            else if (textBoxsecansw.Text == null)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Password Reset Error";
                popup.ContentText = "Invalid Security answer";
                popup.Popup();
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
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Password Reset Error";
                            popup.ContentText = "Password Reset Error";
                            popup.Popup();
                        }
                    }
                    catch
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Account Error";
                        popup.ContentText = "Unable to connect to Save";
                        popup.Popup();
                    }
                }
                catch
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Account Error";
                    popup.ContentText = "Unable to connect to server";
                    popup.Popup();
                    Variables.Loadingchoice = "";
                    Loading loading = new Loading();
                    loading.Show();
                    Visible = false;
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
                    NpgsqlCommand cmd = new NpgsqlCommand("select ac_Username, ac_Password,ac_securityquestion,ac_securityanswer from account where ac_Username = @ac_username", conn);
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
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Signin Error";
                        popup.ContentText = "Signing in Failed";
                        popup.Popup();
                    }
                }
                catch
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.alert;
                    popup.TitleText = "Account Error";
                    popup.ContentText = "Unable to connect to Save";
                    popup.Popup();
                }

            }
            catch
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Resources.alert;
                popup.TitleText = "Account Error";
                popup.ContentText = "Unable to connect to server";
                popup.Popup();
                Variables.Loadingchoice = "";
                Loading loading = new Loading();
                loading.Show();
                Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupBuild.Visible = false;
            buttonback.Visible = false;
            SigninBuild.Visible = true;
            panelpart1.Visible = false;
        }

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
                                    PopupNotifier popup = new PopupNotifier();
                                    popup.Image = Resources.alert;
                                    popup.TitleText = "Account Error";
                                    popup.ContentText = "Unable to fill Database";
                                    popup.Popup();
                                }
                            }
                            catch
                            {
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Resources.alert;
                                popup.TitleText = "Account Error";
                                popup.ContentText = "Unable to connect to Database";
                                popup.Popup();
                            }
                    }
                    catch (Exception)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Resources.alert;
                        popup.TitleText = "Account Error";
                        popup.ContentText = "Unable to connect to the Internet";
                        popup.Popup();
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
                        NpgsqlCommand cmd = new NpgsqlCommand("insert into account values (@Username, @Password, @Firstname, @Lastname, @Email, @Gender, @DOB, @Secquest, @Secansw)", conn);
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
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Account Error";
                            popup.ContentText = "Account failed While creating";
                            popup.Popup();
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
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Resources.alert;
                            popup.TitleText = "Account Error";
                            popup.ContentText = "Account failed While creating";
                            popup.Popup();
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
                //panelpart2.Location = new Point(95, 43);
            }
        }
    }
}
