using System;
using System.Web;
using System.Web.UI;

namespace ConsolePLG
{

    public partial class LogOut : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ViewByCompany.aspx");
            }

            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.AppendHeader("Refresh", "1;url=Default.aspx");

        }
    }
}
