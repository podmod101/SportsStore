using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SchoolTournamentDetail
    {
        public int SchoolTournamentDetailID { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
