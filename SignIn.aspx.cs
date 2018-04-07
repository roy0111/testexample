using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BloodBankWithUnitTesting
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool LengthCheckOfField(string textFeild)
        {
            if (textFeild == null)
            {
                return false;
            }
            if (textFeild.Length <8 || textFeild.Length>35)
            {
                return false;
            }
            return true;
        }

        public bool ValidateUserMailExistance(string user_mail)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();

                string query1 = "select * from user_login where user_mail='" + user_mail + "'";

                SqlCommand sql1 = new SqlCommand(query1, sqlconn);
                SqlDataReader sqldata = sql1.ExecuteReader();
                while (sqldata.Read())
                {
                    sqlconn.Close();
                    //Response.Write("<script>alert('" + userMail + " ');</script>");
                    return true;
                }

                return false;

            }
            catch (Exception)
            {

                return false;
            }

           // return false;
        }


        public bool MatchUserMailPasswordExistance(string user_mail, string user_Password)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();

                string query1 = "select * from user_login where user_mail='" + user_mail + "' AND user_pass='" + user_Password + "'";

                SqlCommand sql1 = new SqlCommand(query1, sqlconn);
                SqlDataReader sqldata = sql1.ExecuteReader();
                while (sqldata.Read())
                {
                    sqlconn.Close();
                    //Response.Write("<script>alert('" + userMail + " ');</script>");
                    return true;
                }

                return false;

            }
            catch (Exception)
            {

                return false;
            }

            // return false;
        }


        public bool ValidateUserMailPasswordExistance(string user_mail, string user_password)
        {
            try
            {
                DataClassesDataContext dbConn = new DataClassesDataContext();

                var user = from usr in dbConn.user_logins
                           where usr.user_mail == user_mail
                           select usr;

                if (user.Count() == 1)
                {
                    foreach (user_login usr in user)
                    {
                        if (usr.user_pass != user_password)
                        {
                            Label2.Text = "password not matched";
                        }
                        else if (usr.user_pass == user_password)
                        {
                            var usrInfo = (from usrI in dbConn.user_profile_infos
                                           where usrI.userMail == user_mail
                                           select usrI).Single();

                            Session["user_pid"] = usrInfo.user_PID;
                            Session["user_mail"] = user_mail;
                            Session["user_bloodGroup"] = usrInfo.bloodGroup;
                            dbConn.Connection.Dispose();
                            return true;

                        }
                        else
                        {
                            dbConn.Connection.Dispose();
                            Label2.Text = "!!! Password not Matched. ";
                        }

                    }
                }
                else
                {
                    dbConn.Connection.Dispose();
                    Label1.Text = "!!! Usermail does not match";
                }

            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }

        public void  SignInFunction(string user_mail, string user_password)
        {
            bool flag = true;

            if (!LengthCheckOfField(TextBox1.Text))
            {
                flag = false;
                Label1.Text = "!!! Mail length 4-35 charecter ";
            }
            else
            {

                Label1.Text = " ";
            }

            if (!LengthCheckOfField(TextBox2.Text))
            {
                flag = false;
                Label2.Text = "!!! Password length 8-35 charecter ";
            }

            else
            {

                Label2.Text = " ";
            }

            if (flag)
            {
                if (ValidateUserMailPasswordExistance(TextBox1.Text,TextBox2.Text))
                {
                    Response.Redirect("Donor/profile.aspx");
                }
                
  
            }
            else
            {
                //Label1.Text = "!!! Usermail does not match";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

          SignInFunction(TextBox1.Text,TextBox2.Text);
        }
    }
}
