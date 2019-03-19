using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClinicNetCore.Models;
using System.Data.SqlClient;

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
    }
}
