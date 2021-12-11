using firstwebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstwebapp.Controllers
{
    public class HomeController : Controller
    {
        readonly FacultyEntities db = new FacultyEntities();
        public ActionResult Index()
        {
            List<Department> list = db.Departments.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }  
        
        public ActionResult Students(int id)
        {
            List<Student> students = db.Students.Where(x=>x.DeptID == id).ToList();

            return View(students);
        }

        public ActionResult Contact()
        {
            WebsiteDescription description = db.WebsiteDescriptions.FirstOrDefault();


            return View(description);
        }
    }
}