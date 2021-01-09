using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface ICompanyRepo
    {
        public IEnumerable<Company> GetCompanies();
        public Company GetCompany(string companyid);
    }
}
