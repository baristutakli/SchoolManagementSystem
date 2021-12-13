using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Student> GetAllByGno(byte min,byte max);
        List<Student> GelAllByClassroom(string classroom);

       
    }
}
