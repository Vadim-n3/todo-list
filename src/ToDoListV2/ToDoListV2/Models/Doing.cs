using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListV2.Models
{
    public class Doing
    {
        public int Id { get; set; }        // id записи в БД
        public DateTime DoingDate { get; set; } // дата дела
        public string DoingString { get; set; } // описание дела
        public bool isDoingDone { get; set; }   // статус дела (выполнено или нет)
    }
}