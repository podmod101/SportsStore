using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int LastFourSSN { get; set; }
        public string HuntingLicenseNumber { get; set; }
        
    }
}
