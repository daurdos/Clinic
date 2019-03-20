using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClinicNetCore.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClinicNetCore.Controllers
{
    public class HomeController : Controller
    {
        ClinicContext db;
        public HomeController(ClinicContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Patients.ToList());
        }

        [HttpGet]
        public IActionResult FillPatient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FillPatient(Patient patient)
        {
            db.Patients.Add(patient);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult FillVisit(int id)
        {
            ViewBag.PatientId = id;
            return View();
        }
        [HttpPost]
        public IActionResult FillVisit(Visit visit)
        {
            db.Visits.Add(visit);
            visit.ColDate = DateTime.Now;
            ViewBag.ColDate = visit.ColDate;
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public void GetAllPatients()
        {
               var patients = db.Patients.ToList();
               
        }

        [HttpGet]
        public IActionResult PatientsById(int id)
        {
            return View(db.Patients.Find(id));
        }


        [HttpPost]
        public IActionResult SearchPatient(Visit visit)
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdatePatient(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.PatientId = id;
            var patient = db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePatient(int id, [Bind("Id,FName,Address,Phone")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(patient);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (patient == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }




    }
}
