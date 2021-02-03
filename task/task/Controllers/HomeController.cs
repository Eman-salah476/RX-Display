using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task.Models;

namespace task.Controllers
{
    public class HomeController : Controller
    {
        private DawaDozContext db = new DawaDozContext();
        public ActionResult Index()
        {
            List<RX> Rxs = db.RXes.ToList();
            ViewBag.doctors = db.Doctors.ToList();
            return View(Rxs);
        }

        //This method is related to the first solution,you can try it but remember to
       // comment the method under it.

  //      [HttpPost]
  //      public ActionResult Index(string doctorName,string patientName,string mobile, DateTime? startdate, DateTime? enddate)
  //      {
  //          try
  //          {
  //              List<RX> Rxs = db.RXes.Where(n => n.date >= startdate && n.date <= enddate  && n.Patient.name==patientName && n.Patient.mobile==mobile && n.Clinic.Doctor.name == doctorName).ToList();
  //              ViewBag.doctors = db.Doctors.ToList();
  //              return View(Rxs);
  //          }
  //          catch
  //          {
  //              return RedirectToAction("Index");
  //          }
  //          }



        [HttpPost]
        public ActionResult Index(DateTime startdate, DateTime enddate)
        {
            try { 
            List<RX> Rxs = db.RXes.Where(n=>n.date>=startdate && n.date<=enddate).ToList();
            ViewBag.doctors = db.Doctors.ToList();
            return View(Rxs);
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

            public ActionResult DisplayRX(int RXId)
        {
            List<RX_details> RXdetails = db.RX_Details.Where(n => n.RXId == RXId).ToList();
            ViewBag.RX = db.RXes.Find(RXId);

            return View(RXdetails);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}