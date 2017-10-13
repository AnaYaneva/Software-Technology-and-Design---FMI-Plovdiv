using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentManager.Models
{
    public class CommentListViewModel
    {
        public String AssignmentTitle { get; set; }
        public int AssignmentId { get; set; }

        public List<CommentViewModel> Comments { get; private set; }

        public CommentListViewModel()
        {
            Comments = new List<CommentViewModel>();
        }
    }
}