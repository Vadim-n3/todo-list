using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaslList.Models;

namespace TaslList.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            IEnumerable<Task> tasks = db.Tasks;
            tasks = tasks.OrderBy(t => t.TaskDate);
            ViewBag.Tasks = tasks;
            return View();
        }

        [HttpGet]
        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DeleteTask(int id)
        {
            db.Tasks.Remove(db.Tasks.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditTask(int id)
        {
            Task task = db.Tasks.Find(id);
            
            if (task == null)
            {
                return HttpNotFound();
            }

            ViewBag.Task = task;
            return View();
        }

        [HttpPost]
        public ActionResult EditTask(Task task)
        {
            if (ModelState.IsValid)
            {
                Task taskToEdit = db.Tasks.Find(task.Id);

                taskToEdit.TaskDate = task.TaskDate;
                taskToEdit.TaskString = task.TaskString;
                taskToEdit.IsTaskDone = task.IsTaskDone;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Не все поля заполнены.";
            return RedirectToAction("EditTask");

        }
    }
}