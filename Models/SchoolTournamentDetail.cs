using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SchoolTournamentDetail
    {
        public int SchoolTournamentDetailID { get; set; }
        public ShootDay ShootDay { get; set; }
        public string Comment { get; set; }
        public int ShootTime { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<School> Schools { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
    }
}
