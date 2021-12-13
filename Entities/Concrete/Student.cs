using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student : IEntity
    {
        public short ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Tel { get; set; }
        public string NationaltyId { get; set; }
        public byte GNO { get; set; }
        public string Classroom { get; set; }

    }
    
}
