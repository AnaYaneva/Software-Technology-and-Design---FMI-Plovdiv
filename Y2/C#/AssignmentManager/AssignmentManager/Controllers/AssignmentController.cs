using AssignmentManager.DataAccess;
using AssignmentManager.Entities;
using AssignmentManager.Models;
using AssignmentManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentManager.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentService service;

        public AssignmentController()
        {
            service = new AssignmentService();
        }
        //
        // GET: /Assignment/
        public ActionResult Index()
        {
            //ViewBag.StdGroup1 = "I am Batman";
            List<Assignment> assignments = new List<Assignment>();
           assignments.AddRange(service.GetAll());

            var model = new AssignmentListViewModel();
            model.Header = "Our Assignments List";

            foreach (var entity in assignments)
            {
                var assignmentModel = new AssignmentViewModel()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Description = entity.Description,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt,
                    IsDone = entity.IsDone
                };

                model.Assignments.Add(assignmentModel);
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AssignmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = new Assignment();

            entity.Title = model.Title;
            entity.Description = model.Description;

            
            service.Insert(entity);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {

            Assignment entity = service.GetById(id);

            var model = new AssignmentViewModel()
            {
                Id=entity.Id,
                Title=entity.Title,
                Description=entity.Description,
                CreatedAt=entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                IsDone=entity.IsDone
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(AssignmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            var entity = new Assignment();

            entity.Id = model.Id;
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.IsDone = model.IsDone;
            entity.CreatedAt = model.CreatedAt;

            service.Update(entity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = service.GetById(id);
            service.Delete(entity);

            return RedirectToAction("Index");
        }

	}
}