using AssignmentManager.DataAccess;
using AssignmentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentManager.Controllers
{
    public class AssignmentController : Controller
    {
        //
        // GET: /Assignment/
        public ActionResult Index()
        {
            ViewBag.StdGroup1 = "I am Batman";
            List<Assignment> assignments = new List<Assignment>();
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            assignments.AddRange(assignmentRepository.GetAll());
            return View(assignments);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Assignment entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.IsDone = false;

            var assignmentRepository = new AssignmentRepository();
            assignmentRepository.Insert(entity);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var assignmentRepository = new AssignmentRepository();
            Assignment entity = assignmentRepository.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public ActionResult Update(Assignment entity)
        {
            entity.UpdatedAt = DateTime.Now;

            var assignmentRepository = new AssignmentRepository();
            assignmentRepository.Update(entity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var assignmentRepository = new AssignmentRepository();
            var entity = assignmentRepository.GetById(id);
            assignmentRepository.Delete(entity);

            return RedirectToAction("Index");
        }

	}
}