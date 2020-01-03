using System;
namespace ConsolePLG.Objects
{
    public class CompanyCountry
    {
        public Guid countryId { get; set; }
        public Country country { get; set; }
        public Guid companyId { get; set; }
        public Company company { get; set; }
    }
}
