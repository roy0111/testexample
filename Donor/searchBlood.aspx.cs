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
    public partial class searchBlood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public bool CheckFieldValidity(string textFelid)
        {
            if (textFelid==null)
            {
                return false;
            }
            return true;
        }

        public bool CheckBloodAvaiability(string bloodGroup,string areaName) {

            try
            {
                DataClassesDataContext dbconn = new DataClassesDataContext();
                var user = from usr in dbconn.user_profile_infos
                           where usr.bloodGroup == bloodGroup && usr.userAddress == areaName
                           select usr;
                dbconn.Connection.Close();


                if (user.Count()== 0)
                {
                    Label2.Text = "'" + bloodGroup + "' Blood Donor are not available this area '" + areaName + "'";
                    return false;
                }
                else
                {
                    GridView1.DataSource = user;
                    GridView1.DataBind();
                    return true;
                }
            }
            catch (Exception)
            {
                //Label2.Text = " !!! Try Later";
                return false;
            }
            
        }



        public bool CheckBloodGroupDonorAvailableOrNot(string bloodGroup)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();

                string query1 = "select * from user_profile_info where bloodGroup='" + bloodGroup + "'";
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


        public bool CheckAreaAvailableOrNot(string area)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();

                string query1 = "select * from user_profile_info where userAddress='" + area + "'";
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


        public bool CheckBloodAvailableInParticulerAreaOrNot(string bloodgroup, string area)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-IOODRMA;Initial Catalog=bloodBank;Integrated Security=True;");
                sqlconn.Open();

                string query1 = "select * from user_profile_info where userAddress='" + area + "' AND bloodGroup= '"+ bloodgroup + "'";
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


        public void SearchBloodFunction(string bloodGroup , string areaName)
        {
            bool flag = true;
            if (!CheckFieldValidity(bloodGroup))
            {
                flag = false;
            }
            if (!CheckFieldValidity(areaName))
            {
                    flag = false;
            }

            if (CheckBloodAvaiability(bloodGroup,areaName))
            {


            }
            else
            {
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            SearchBloodFunction(DropDownList1.Text,DropDownList2.Text);
        }
    }
}