using CareerPro.Model;
using System.Collections.Generic;
using System.Linq;

namespace CareerPro.Service.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        private IEnumerable<Company> Companies = new List<Company>();

        public CompanyRepo()
        {
            Companies = new List<Company>()
            {
                new Company()
                {
                    CompanyID = new AppUser()
                    {
                        Id = "userid4"
                    },
                    Title = "ABC Corp. Int.",
                    Overview = "We are an offshore company operating in multiple regions like Asia, Europe etc.",
                    OpenToRecruit = true
                },
                new Company()
                {
                    CompanyID = new AppUser()
                    {
                        Id = "userid5"
                    },
                    Title = "Smart Software",
                    Overview = "We are a multinational Software company provides different software solutions for every type of organization.",
                    OpenToRecruit = true
                }
            };
        }

        public IEnumerable<Company> GetCompanies()
        {
            return Companies;
        }

        public Company GetCompany(string companyid)
        {
            return Companies.FirstOrDefault(c => c.CompanyID.Id == companyid);
        }
    }
}
