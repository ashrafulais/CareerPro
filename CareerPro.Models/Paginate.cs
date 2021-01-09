using System;
using System.Collections.Generic;
using System.Text;

namespace CareerPro.Model
{
    public class Paginate
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public int PaginateCount { get; set; } = 0;
    }
}
