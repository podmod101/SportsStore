using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class StudentTournamentDetail
    {
        public int StudentTournamentDetailID {get;set;}
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
