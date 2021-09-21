using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taskk.Models.Entity;
namespace Taskk.Controllers
{
    public class PhoneController : Controller
    {
        TaskDatabaseEntities1 db = new TaskDatabaseEntities1();
        // GET: Phone
        public ActionResult PhoneList()
        {
            var degerler = db.Phones.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddPhone()
        {
            List<SelectListItem> degerler = (from i in db.Personals.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Name,
                                                 Value = i.ID.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult AddPhone(Phone p1)
        {
            var prs = db.Personals.Where(m => m.ID == p1.Personal1.ID).FirstOrDefault();
            p1.Personal1 = prs;
            db.Phones.Add(p1);
            db.SaveChanges();
            return RedirectToAction("PhoneList");
        }
        public ActionResult DeletePhone(int id)
        {
            var phone = db.Phones.Find(id);
            db.Phones.Remove(phone);
            db.SaveChanges();
            return RedirectToAction("PhoneList");
        }
    }
}