using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodBankWithUnitTesting.Donor
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user_pid"] = null;
            Session["user_mail"] = null;
            Session["user_bloodGroup"] = null;
            Session.Clear();
            Response.Redirect("../SignIn.aspx");

        }
    }
}