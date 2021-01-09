using CareerPro.Model;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Service.Repository
{
    public interface IPersonRepo
    {
        public IEnumerable<Person> GetPersonList();
        public Person GetPerson(string userid);
    }
}
