using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DistributedPart1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            //Session["a"] = 1;
            Label1.Text = Session.IsNewSession + "___" + Session.SessionID + "_" + Session["key"];

            if (Session["key"] != null)
            {
                Response.Redirect("/M/Home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            hidGoUrl.Value = "";
            if (txtName.Text == "abc" && txtPwd.Text == "abc")
            {
                //FormsAuthentication.RedirectFromLoginPage(txtName.Text, false);
                FormsAuthentication.SetAuthCookie(txtName.Text, false);
                Session["key"] = DateTime.Now;
                hidGoUrl.Value = "/M/Home.aspx";
                //Response.Redirect("/M/Home.aspx");
            }
        }
    }
}