using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsolePLG.Objects;
using Newtonsoft.Json;

namespace ConsolePLG
{

    public partial class ViewByCountry : System.Web.UI.Page
    {
        private AccessAPI api = new AccessAPI("https://companymanagementapi.azurewebsites.net/");
        protected override void OnLoad(EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("ViewByCompany.aspx");
            }
            if (!Page.IsPostBack)
            {
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(api.getCountries());
                for (int i = 0; i < countries.Count; i++)
                {
                    countriesDropDown.Items.Add(new ListItem(countries[i].countryName, countries[i].countryId.ToString()));
                

                }
                SortListControl(countriesDropDown, true);
                countriesDropDown.Items.Insert(0, (new ListItem("Select Country", "-1")));

            }

        }


        protected void getCompanies__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companiesDropDown.SelectedValue != "-1")
            {
                companiesDropDown.Items.Clear();
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(api.getCountryByID(countriesDropDown.SelectedValue));


                foreach (Country c in countries)
                {
                    CompanyCountry[] x = c.restrictedCompanies.ToArray();

                    for (int i = 0; i < x.Count(); i++)
                    {


                        companiesDropDown.Items.Add(new ListItem(c.restrictedCompanies.ElementAt(i).company.companyName, c.restrictedCompanies.ElementAt(i).company.companyId.ToString()));

                        comments.InnerHtml = "Comments:" + c.restrictedCompanies.ElementAt(i).company.comments + "</br>";
                       
                    }


                }
                SortListControl(countriesDropDown, true);
            }
            else { companiesDropDown.Items.Clear(); }

        }
        protected void filter_Click(object sender, EventArgs e)
        {

            if (filter.Text == "Ascending")
            {
                SortListControl(companiesDropDown, false);
                filter.Text = "Decending";
                companiesDropDown.SelectedIndex = 1;

            }
            else if (filter.Text == "Decending")
            {
                filter.Text = "Ascending";
                SortListControl(companiesDropDown, true);
                companiesDropDown.SelectedIndex = 1;

            }
        }

        public static void SortListControl(ListControl control, bool isAscending)
        {
            List<ListItem> collection;

            if (isAscending)
                collection = control.Items.Cast<ListItem>()
                    .Select(x => x)
                    .OrderBy(x => x.Text)
                    .ToList();
            else
                collection = control.Items.Cast<ListItem>()
                    .Select(x => x)
                    .OrderByDescending(x => x.Text)
                    .ToList();

            control.Items.Clear();

            foreach (ListItem item in collection)
                control.Items.Add(item);
        }
    }
}
