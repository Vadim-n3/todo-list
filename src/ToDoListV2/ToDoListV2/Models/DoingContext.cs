using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToDoListV2.Models
{
    public class DoingContext : DbContext
    {
        public DbSet<Doing> Doings { get; set; }
    } 
}