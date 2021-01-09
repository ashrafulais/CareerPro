using System;

namespace CareerPro.Model
{
    public class Person
    {
        public AppUser UserID { get; set; }
        public string FullName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string CareerObjective { get; set; }
        public string ResumeFileUrl { get; set; }
        public bool OpenToOffer { get; set; }
    }
}
