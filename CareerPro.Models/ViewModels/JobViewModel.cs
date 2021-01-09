using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Model.ViewModels
{
    public class JobViewModel
    {
        public string PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string PublisherEmail { get; set; }
        public string PublisherType { get; set; } //Person or Company
        public string PublisherPhoto { get; set; }
        public string JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string JobCategory { get; set; }
        public decimal Salary { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime Deadline { get; set; }
    }
}
