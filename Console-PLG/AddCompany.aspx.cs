using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsolePLG.Objects;
using Newtonsoft.Json;

namespace ConsolePLG
{

    public partial class AddCompany : System.Web.UI.Page
    {
        private AccessAPI api = new AccessAPI("https://companymanagementapi.azurewebsites.net/");
        protected override void OnLoad(EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(api.getCountries());
                for (int i = 0; i < countries.Count; i++)
                {
                    CountriesCBList.Items.Add(new ListItem(countries[i].countryName, countries[i].countryId.ToString()));



                }

               
            
            }
             

        }
            protected void Add_Click(object sender, EventArgs e)
        {

            Countries countries = new Countries();

            countries.companyName = compTxtBox.Text;
            countries.comments = commentTxtBox.Text;
            List<String> cString = new List<String>();
            foreach (ListItem item in CountriesCBList.Items)
            {
                if (item.Selected == true) {
                    cString.Add(item.Text);
                }
            }
            countries.countries = cString.ToArray();
            List<Countries> cList = new List<Countries>();
            cList.Add(countries);
            api.addCompany(cList);
            DisplayAlert("Company Added");

        }
        protected void DisplayAlert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
        }



    }
}
