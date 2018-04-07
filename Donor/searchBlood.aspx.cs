using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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