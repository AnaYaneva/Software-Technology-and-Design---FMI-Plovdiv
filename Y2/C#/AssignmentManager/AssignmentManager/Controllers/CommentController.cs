using AssignmentManager.DataAccess;
using AssignmentManager.Entities;
using AssignmentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentManager.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/
        public ActionResult Index(int id)
        {

            var commentsRepository = new CommentsRepository();
            var commentsList = new List<Comment>();

            var commentsFromRepo = commentsRepository.GetAll(comment=>comment.AssignmentId==id);

            // var commentsFromRepo = commentsRepository.GetAll();
            //foreach (var comment in commentsFromRepo)
            //{
            //    if (comment.AssignmentId == id)
            //    {
            //        commentsList.Add(comment);
            //    }
            //}
           
            commentsList.AddRange(commentsFromRepo);

            var assignmentRepository = new AssignmentRepository();

            var model = new CommentListViewModel();
            
            model.AssignmentTitle = assignmentRepository.GetById(id).Title;
            model.AssignmentId = id;

            foreach (var entity in commentsList)
            {
                var commentModel = new CommentViewModel()
                    {
                        Id = entity.Id,
                        AssignmentId = entity.AssignmentId,
                        Content = entity.Content,
                        CreatedAt = entity.CreatedAt,
                        UpdatedAt = entity.UpdatedAt
                    };

                model.Comments.Add(commentModel);
            }


            return View(model);
        }

        [HttpGet]
        public ActionResult Create(int id)
        {
            var model = new CommentViewModel()
            {
                AssignmentId = id
            };


            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = new Comment();

            //entity.Id = model.Id;
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.Content = model.Content;
            entity.AssignmentId = model.AssignmentId;

            var commentsRepository = new CommentsRepository();
            commentsRepository.Insert(entity);

            return RedirectToAction("Index/"+entity.AssignmentId);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var commentsRepository = new CommentsRepository();
            var entity=commentsRepository.GetById(id);

            var model = new CommentViewModel()
            {
                Id=entity.Id,
                AssignmentId=entity.AssignmentId,
                Content=entity.Content,
                CreatedAt=entity.CreatedAt,
                UpdatedAt=entity.UpdatedAt
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(CommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = new Comment();

            entity.UpdatedAt = DateTime.Now;
            entity.Id = model.Id;
            entity.AssignmentId = model.AssignmentId;
            entity.Content = model.Content;
            entity.CreatedAt = model.CreatedAt;

            var commentRepository = new CommentsRepository();
            commentRepository.Update(entity);

            return RedirectToAction("Index/" + entity.AssignmentId);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var commentRepository = new CommentsRepository();
            var entity = commentRepository.GetById(id);
            commentRepository.Delete(entity);

            return RedirectToAction("Index/" + entity.AssignmentId);
        }

	}
}