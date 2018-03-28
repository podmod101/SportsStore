using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentManagement.Models
{
    public class StudentDetail
    {
        public int StudentDetailID { get; set; }
        public Grade Grade { get; set; }
        public County County { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public School School { get; set; }
        public Student Student { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
