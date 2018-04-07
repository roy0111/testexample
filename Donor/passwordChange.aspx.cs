using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace BloodBankWithUnitTesting.Donor
{
    public partial class passwordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        public bool CheckOldPassowordExistance(string userMail, string oldPassword)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();
         
                string query1 = "select * from user_login where user_mail='" + userMail + "' AND user_pass='"+ oldPassword + "'";
                SqlCommand sql1 = new SqlCommand(query1, sqlconn);
                SqlDataReader sqldata = sql1.ExecuteReader();

               

               // bool row = true ;
                
               // int user =12;
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
            //return false;
        }
       
        public  bool CheckEmpty(string userpassword)
        {
            if (userpassword==null)
            {
                return true;
            }
            if(userpassword.Length<8 || userpassword.Length > 32)
            {
                return true;
            }
            return false;
        }

        public bool NewPasswordConfirmPasswordMatchingCheck(string new1, string confirm1)
        {
            if (new1==confirm1)
            {
                return true;
            }
            return false;
        }

       public bool UpdatePasswordFunction(string mail, string newPassword)
        {
            try
            {
                //Response.Write("<script>alert('" + 77777777777 + " ');</script>");
                DataClassesDataContext dbConn = new DataClassesDataContext();
                var user = (from usr in dbConn.user_logins
                           where usr.user_mail == mail
                           select usr).Single();
             
                user.user_pass = newPassword;
                
                dbConn.SubmitChanges();
                dbConn.Connection.Close();
                
                return true;

            }
            catch (Exception)
            {
                //Response.Write("<script>alert('" + 77777777777 + " ');</script>");
                return false;
            }
            //return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (CheckEmpty(TextBox1.Text))
            {
                Label1.Text = "!!! password Length (8-31)";
                flag = false;
            }
            else
            {
                Label1.Text = "";
            }

            if (CheckEmpty(TextBox2.Text))
            {
                Label2.Text = "!!! password Length (8-31)";
                flag = false;
            }
            else
            {
                Label2.Text = "";
            }



            if (flag)
            {
                if (!NewPasswordConfirmPasswordMatchingCheck(TextBox2.Text, TextBox3.Text))
                {
                    flag = false;
                    Label3.Text = "!!! Password not matched.";
                }
                else
                {
                    Label3.Text = "";
                }

                if (!CheckOldPassowordExistance(Session["user_mail"].ToString(), TextBox1.Text))
                {
                    flag = false;
                    Label1.Text = "!!! Password not matched with this account.";
                }
                else
                {
                    Label1.Text = "";
                }
            }


            if (flag)
            {
               if(UpdatePasswordFunction(Session["user_mail"].ToString(), TextBox2.Text)){
                    Label4.Text = "Password Changed successfully.";
                }

                else
                {
                    Label1.Text = "";
                    Label2.Text = "";
                    Label3.Text = "";
                    Label4.Text="Try later";
                }

            }

           

        }
    }
}