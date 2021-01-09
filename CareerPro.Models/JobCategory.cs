using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CareerPro.Model
{
    public class JobCategory
    {
        [Key]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
