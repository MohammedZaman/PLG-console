using System;
using System.Net;

namespace ConsolePLG
{
    public class AccessAPI
    { 
            private String URL;
            public AccessAPI(String Url)
            {
                URL = Url;

            }

        public String logIn(string userName, String password)
        {
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string response = cli.UploadString(URL + "Authorisation", "{\"userName\":\"" + userName + "\",\"password\":\"" + password + "\"}");
            return response;
        }
        public String getAll()
            {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var cli = new WebClient();
              cli.Headers[HttpRequestHeader.ContentType] = "application/json";
              string response = cli.DownloadString(URL + "Company");
              return response;
            }

        public String getCompanies()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.DownloadString(URL + "Company/Company");
            return response;
        }

        public String getCountries()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.DownloadString(URL + "Country/Country");
            return response;
        }

        public String getCompanyByID(string id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.DownloadString(URL + "Company/"+id);
            return response;
        }

        public String getCountryByID(string id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            string response = cli.DownloadString(URL + "Country/" + id);
            return response;
        }

    }



  

}


    

