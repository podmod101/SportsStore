using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentManagement.Models
{
    public class SchoolTournamentDetail
    {
        public int SchoolTournamentDetailID { get; set; }
        public string Comment { get; set; }
        public System.TimeSpan ShootTime { get; set; }
        public ShootDay ShootDay { get; set; }
        public School School { get; set; }
        public Tournament Tournament { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
