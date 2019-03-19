using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicNetCore.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
}
