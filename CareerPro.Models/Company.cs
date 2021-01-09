namespace CareerPro.Model
{
    public class Company
    {
        public AppUser CompanyID { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public bool OpenToRecruit { get; set; }
    }
}
