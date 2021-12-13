using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInstructorDal : IInstructorDal
    {
        public void Add(Instructor entity)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Instructor entity)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Set<Instructor>().SingleOrDefault(filter);
            }
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return filter == null ? context.Set<Instructor>().ToList() :
                     context.Set<Instructor>().Where(filter).ToList();
            }
        }

        public void Update(Instructor entity)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
