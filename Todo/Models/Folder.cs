using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string FolderName { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}