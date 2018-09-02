using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaslList.Models
{
    public class Task
    {
        ///<summary>
        /// id записи в БД
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// дата задачи
        ///</summary>
        [Required(ErrorMessage = "Введите дату задачи")]
        public DateTime TaskDate { get; set; }

        ///<summary>
        /// описание задачи
        ///</summary>
        [Required(ErrorMessage = "Введите описание задачи")]
        public string TaskString { get; set; }

        ///<summary>
        /// статус задачи(выполнено или нет)
        ///</summary>
        public bool IsTaskDone { get; set; }
    }
}