using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaslList.Models;

 
namespace TaslList.MyDB
{
    public class TaskDbInitializer : CreateDatabaseIfNotExists<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 18), TaskString = "Заплатить за интернет", IsTaskDone = true });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 19), TaskString = "Оплатить штраф в ГАИ", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 8, 20), TaskString = "Скосить траву", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 9, 4), TaskString = "Купить лампочки", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 9, 10), TaskString = "Купить подарок на день рождения", IsTaskDone = true });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 9, 11), TaskString = "Поздравить с днем рождения Андрея", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 9, 18), TaskString = "Проверить посылки на почте", IsTaskDone = false });
            db.Tasks.Add(new Task { TaskDate = new DateTime(2018, 9, 17), TaskString = "Прийти на собеседование", IsTaskDone = false });

            base.Seed(db);
        }

    }
}