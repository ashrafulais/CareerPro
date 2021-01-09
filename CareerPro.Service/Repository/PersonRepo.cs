using CareerPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerPro.Service.Repository
{
    public class PersonRepo : IPersonRepo
    {
        private IEnumerable<Person> PersonList = new List<Person>();
        public PersonRepo()
        {
            PersonList = new List<Person>()
            {
                new Person()
                {
                    UserID = new AppUser() 
                    { 
                        Id = "userid1"
                    },
                    FullName = "John Smith",
                    DateofBirth = DateTime.Parse("10/11/1999"),
                    CareerObjective = "I want to be a chef",
                    ResumeFileUrl = "resumefile.pdf",
                    OpenToOffer=true
                },
                new Person()
                {
                    UserID = new AppUser()
                    {
                        Id = "userid2"
                    },
                    FullName = "Doe Sup",
                    DateofBirth = DateTime.Parse("1/15/2001"),
                    CareerObjective = "I want to be an Elite",
                    ResumeFileUrl = "resumefile.pdf",
                    OpenToOffer=true
                }
            };
        }

        public Person GetPerson(string userid)
        {
            return PersonList.FirstOrDefault(s => s.UserID.Id == userid);
        }

        public IEnumerable<Person> GetPersonList()
        {
            return PersonList.Where(x => x.UserID.ActiveUser = true);
        }
    }
}
