using System.Collections.Generic;
using System.Linq;
using Steag.Framework.Authentication;
using Steag.Framework.Model;

namespace Steag.Data
{
    public class CompanyDataSession : DataSession
    {
        public CompanyDataSession(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public CompanyDataSession(User user, IDataSource dataSource)
            : base(user, dataSource)
        {

        }

        public Company GetCompanyByID(long id)
        {
            return DataContext.Company.SingleOrDefault(c => c.ID == id);
        }

        public Company GetCompanyByName(string companyName)
        {
            return DataContext.Company.SingleOrDefault(c => c.CompanyName == companyName);
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return from c in DataContext.Company select c;
        }

        public IEnumerable<Company> GetAllUsers(bool isActive)
        {
            return from c in DataContext.Company where c.IsActive == isActive select c;
        }

        public void AddCompany(Company company)
        {
            DataContext.Company.InsertOnSubmit(company);
        }

        public void Addcompanies(IEnumerable<Company> companies)
        {
            DataContext.Company.InsertAllOnSubmit(companies);
        }

        public void DeleteCompany(Company company)
        {
            DataContext.Company.DeleteOnSubmit(company);
        }
    }
}
