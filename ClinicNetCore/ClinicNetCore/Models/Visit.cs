using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicNetCore.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public string Specialist { get; set; } 
        public string Complaints { get; set; } 
        public string Diagnosis { get; set; } 

        public int PatientId { get; set; } 
        public Patient Patient { get; set; }

    }
}
