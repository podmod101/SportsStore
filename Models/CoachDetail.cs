using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class CoachDetail
    {
        public int CoachDetailID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public School School { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
