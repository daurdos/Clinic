using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClinicNetCore.Models
{
    public class ClinicContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public ClinicContext(DbContextOptions<ClinicContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
