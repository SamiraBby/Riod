using Microsoft.AspNetCore.Mvc;
using Riode.WebUI.Models.DataContexts;
using Riode.WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly RiodDbContext db;
        public HomeController(RiodDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = "Sizin sorğunuz qəbul edilmişdir.Tezliklə geri dönüş edəcəyik.";
                return View();
            }
            return View(contact);

        }
        public IActionResult FAQS()
        {
            return View();
        }
    }
}
