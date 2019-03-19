using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicNetCore.Models;

namespace ClinicNetCore
{
    public class SampleData
    {
        public static void Initialize(ClinicContext context)
        {
            if (!context.Patients.Any())
            {
                context.Patients.AddRange(
                    new Patient
                    {
                        FName = "Dauren",
                        Address = "18/1 Syganak str.",
                        Phone = 7753982750
                    },
                    new Patient
                    {
                        FName = "Frank",
                        Address = "401 Rinngold Rd",
                        Phone = 9564562343
                    },
                    new Patient
                    {
                        FName = "Anton",
                        Address = "54 University blvd",
                        Phone = 9561237845
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
