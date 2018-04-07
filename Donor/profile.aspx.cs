using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodBankWithUnitTesting.Donor
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                DataClassesDataContext dbCon = new DataClassesDataContext();
                var user = (from usr in dbCon.user_profile_infos
                            where usr.user_PID == Session["user_pid"].ToString()
                            select usr).Single();
                Label1.Text = user.userName;
                Label2.Text = user.userMail;
                Label3.Text = user.dob.ToString();
                Label4.Text = user.bloodGroup;
                Label5.Text = user.gender;
                Label6.Text = user.userAddress;
                Label7.Text = user.phoneNumber;

                Label8.Text = "Name  ";
                Label9.Text = "Mail  ";
                Label10.Text = "Date Of Birth  ";
                Label11.Text = "Blood group  ";
                Label12.Text = "Gender  ";
                Label13.Text = "Address  ";
                Label14.Text = "Phone Number  ";
            }
            catch (Exception)
            {


            }


        }
    }

}