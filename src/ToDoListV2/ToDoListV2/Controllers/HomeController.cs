using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListV2.Models;

namespace ToDoListV2.Controllers
{
    public class HomeController : Controller
    {

        DoingContext db = new DoingContext();


        public ActionResult Index()
        {
            IEnumerable<Doing> doings = db.Doings;
            ViewBag.Doings = doings;
            return View();
        }


        [HttpGet]
        public ActionResult AddDoing()
        {
            return View();
        }


        [HttpPost]
        public string AddDoing(Doing doing)
        {
            db.Doings.Add(doing);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Новая запись в планировщик успешно добавлена";
        }
        /*public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}