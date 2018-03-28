using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentManagement.Models
{
    public class StudentTournamentDetail
    {
        public int StudentTournamentDetailID { get; set; }
        public Student Student { get; set; }
        public Tournament Tournament { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
