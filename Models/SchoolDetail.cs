using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SchoolDetail
    {
        public int SchoolDetailID { get; set; }
        public School School { get; set; }
        public Sector Sector { get; set; }
        public Division Division { get; set; }
        public Level Level { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
