using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentManager.Entities
{
    public class Assignment:BaseEntity
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public bool IsDone { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}