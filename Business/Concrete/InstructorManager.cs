using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _ınstructorDal;

        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }

        public List<Instructor> GelAllByBranch(string branch)
        {
            return _ınstructorDal.GetAll(ı => ı.Branch == branch);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

      
    }
}
