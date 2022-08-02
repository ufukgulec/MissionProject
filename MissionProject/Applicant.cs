using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionProject
{
    public class Applicant //Public vs internal 
    {
        public int Age { get; set; }
        public long IdentificationNumber { get; set; }
        public int YearsOfExperience { get; set; }

        public List<string> AvailableTech = new List<string>();
    }
}
