using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaslList.Models;

 
namespace TaslList.MyDB
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 18), TaskString = "Заплатить за интернет", IsTaskDone = true });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 19), TaskString = "Оплатить штраф в ГАИ", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 20), TaskString = "Скосить траву", IsTaskDone = false });

            base.Seed(db);
        }

    }
}