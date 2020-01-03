using System;
using System.Collections.Generic;

namespace ConsolePLG.Objects
{
    public class Country
    {
        public Guid countryId { get; set; }
        public string countryName { get; set; }
        public ICollection<CompanyCountry> restrictedCompanies { get; set; }
    }
}
