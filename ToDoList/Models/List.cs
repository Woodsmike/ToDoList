using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}