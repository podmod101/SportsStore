using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TournamentManagement.Models
{
    public class Tournament
    {
        public int TournamentID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Boolean StateChampionship { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<StudentTournamentDetail> StudentTournamentDetails { get; set; }
        public ICollection<SchoolTournamentDetail> SchoolTournamentDetails { get; set; }
    }
}
