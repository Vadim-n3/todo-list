using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToDoListV2.Models
{
    public class DoingDbInitializer : DropCreateDatabaseIfModelChanges<DoingContext>
    {
        protected override void Seed(DoingContext db)
        {
            db.Doings.Add(new Doing { DoingDate = new DateTime(2018, 8, 18), DoingString = "Заплатить за интернет", isDoingDone = true });
            db.Doings.Add(new Doing { DoingDate = new DateTime(2018, 8, 19), DoingString = "Оплатить штраф в ГАИ", isDoingDone = false });
            db.Doings.Add(new Doing { DoingDate = new DateTime(2018, 8, 20), DoingString = "Скосить траву", isDoingDone = false });

            base.Seed(db);
        }
    }
}