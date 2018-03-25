using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class StudentDetail
    {
        public int StudentDetailID { get; set; }
        public Student Student { get; set; }
        public School School { get; set; }
        public Grade Grade { get; set; }
        public County County { get; set; }

    }
}
