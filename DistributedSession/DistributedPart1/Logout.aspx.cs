using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DistributedPart1
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies.Clear();
            Response.Buffer = true;
            Response.ExpiresAbsolute = System.DateTime.Now.AddSeconds(-1);
            Response.Expires = 0;
            Response.CacheControl = "no-cache";
            Response.AddHeader("Pragma", "No-Cache");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Session.Clear();

            //FormsAuthentication.RedirectToLoginPage();
            FormsAuthentication.SignOut();
            Response.Redirect("/Login.aspx");
        }
    }
}