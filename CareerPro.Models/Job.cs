using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerPro.Model
{
    public class Job
    {
        public string PostedByID { get; set; }
        [NotMapped]
        public AppUser PostedByUser { get; set; }
        [Key]
        public string JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string CategoryID { get; set; }
        [NotMapped]
        public JobCategory Category { get; set; }
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime Deadline { get; set; }
    }
}
