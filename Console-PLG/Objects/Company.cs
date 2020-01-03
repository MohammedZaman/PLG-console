using System;
using System.Collections.Generic;

namespace ConsolePLG.Objects
{
    public class Company
    {
        public Guid companyId { get; set; }
        public string companyName { get; set; }
        public string comments { get; set; }
        public DateTime dateAdded { get; set; }
        public ICollection<CompanyCountry> RestrictedCountries { get; set; }
    }
}
