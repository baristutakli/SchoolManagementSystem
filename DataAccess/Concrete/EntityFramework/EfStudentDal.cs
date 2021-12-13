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
    public class EfStudentDal : IStudentDal
    {
        public void Add(Student entity)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Student entity)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return context.Set<Student>().SingleOrDefault(filter);
            }
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            using (SchoolContext context = new SchoolContext())
            {
                return filter == null ? context.Set<Student>().ToList() :
                     context.Set<Student>().Where(filter).ToList();
            }
        }

        public void Update(Student entity)
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
