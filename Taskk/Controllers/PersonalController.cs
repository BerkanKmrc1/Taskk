using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taskk.Models.Entity;
namespace Taskk.Controllers
{
    public class PersonalController : Controller
    {
        TaskDatabaseEntities1 db = new TaskDatabaseEntities1();
        // GET: Personal
        public ActionResult PersonalList()
        {
            var degerler = db.Personals.Where(m=>m.Status ==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddPersonal()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult AddPersonal(Personal p1)
        {
            if (!ModelState.IsValid)
            {
                return View("AddPersonal");
            }
            db.Personals.Add(p1);
            db.SaveChanges();
            return RedirectToAction("PersonalList");
        }
        public ActionResult DeletePersonal(int id)
        {
            var personal = db.Personals.Find(id);
            //db.Personals.Remove(personal);
            personal.Status = false;
            db.SaveChanges();
            return RedirectToAction("PersonalList");
        }
        [HttpGet]
        public ActionResult GetPersonal(int id)
        {
            var prsnl = db.Personals.Find(id);
            return View(prsnl);
        }
        [HttpPost]
        public ActionResult UpdatePersonal(Personal p1)
        {
            var personel = db.Personals.Find(p1.ID);
            personel.Name = p1.Name;
            personel.Surname = p1.Surname;
            personel.Email = p1.Email;
            personel.BirthDay = p1.BirthDay;
            db.SaveChanges();
            return RedirectToAction("PersonalList");

        }
    }
}