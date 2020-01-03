using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using ConsolePLG.Objects;
using Newtonsoft.Json;
using System.Linq;

namespace ConsolePLG
{

    public partial class Default : System.Web.UI.Page
    {

        private AccessAPI api = new AccessAPI("https://customermanagementapi.azurewebsites.net/");
      
        protected override void OnLoad(EventArgs e)
        {

            if (Session["id"] != null)
            {
                Response.Redirect("ViewByCompany.aspx");
            }



        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Authorisation auth = JsonConvert.DeserializeObject<Authorisation>(api.logIn(uTxtBox.Text, passwordTxtBox.Text));
            if (auth.isAuthorized == true)
            {
                Session["id"] = auth.customerId;
                DisplayAlert("Success");
                Response.Redirect("ViewByCompany.aspx");

            }
            else
            {
                DisplayAlert("incorrect username and password");
            }
        }

        protected void DisplayAlert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
        }






    }
}

