using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _StudentDal;

        public StudentManager(IStudentDal StudentDal)
        {
            _StudentDal = StudentDal;
        }

        public List<Student> GelAllByClassroom(string classroom)
        {
            return _StudentDal.GetAll(s => s.Classroom == classroom);
        }

        public List<Student> GetAll()
        {
            return _StudentDal.GetAll();
        }

        public List<Student> GetAllByGno(byte min, byte max)
        {
            return _StudentDal.GetAll(s => s.GNO >= min && s.GNO <= max);
        }
    }
}
