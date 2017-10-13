using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentManager.Entities
{
    public class Comment:BaseEntity
    {
        public String Content { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }

    }
}