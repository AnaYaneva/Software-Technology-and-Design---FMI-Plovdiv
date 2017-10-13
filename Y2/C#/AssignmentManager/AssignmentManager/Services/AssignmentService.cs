using AssignmentManager.DataAccess;
using AssignmentManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AssignmentManager.Services
{
    public class AssignmentService
    {
        private AssignmentRepository repository;

        public AssignmentService()
        {
            repository=new AssignmentRepository();
        }

        public List<Assignment> GetAll(Expression<Func<Assignment, bool>> filter)
        {
            return repository.GetAll(filter);
        }

        public List<Assignment> GetAll()
        {
            return repository.GetAll();
        }

        public Assignment GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Insert(Assignment entity) 
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entity.IsDone = false;
            repository.Insert(entity);
        }

        public void Update(Assignment entity)
        {
            entity.UpdatedAt = DateTime.Now;
            repository.Update(entity);
        }

        public void Delete(Assignment entity)
        {
            repository.Delete(entity);
        }
    }
}