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
        //TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            using (TaskContext db = new TaskContext())
            {
                IEnumerable<Task> tasks = db.Tasks;
                tasks = tasks.OrderBy(t => t.TaskDate);

                return View(db.Tasks.ToList().OrderBy(t => t.TaskDate));
            }
        }

        [HttpGet]
        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            using (TaskContext db = new TaskContext())
            {
                if (ModelState.IsValid)
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            TempData["Error"] = "Не все поля заполнены.";
            return View();
        }

        [HttpGet]
        public ActionResult DeleteTask(int id)
        {
            using (TaskContext db = new TaskContext())
            {
                db.Tasks.Remove(db.Tasks.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditTask(int id)
        {
            using (TaskContext db = new TaskContext())
            {
                Task task = db.Tasks.Find(id);

                if (task == null)
                {
                    return HttpNotFound();
                }
                return View(task);
            }
        }

        [HttpPost]
        public ActionResult EditTask(Task task)
        {
            using (TaskContext db = new TaskContext())
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
            }
            TempData["Error"] = "Не все поля заполнены.";
            return View(task);

        }
    }
}