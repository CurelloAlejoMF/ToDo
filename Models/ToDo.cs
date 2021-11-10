using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id{ get; set; }
        public bool Done { get; set; }
        public string description { get; set; }
        public virtual ApplicationUser user { get; set; }


    }
}