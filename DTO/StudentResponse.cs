using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class StudentResponse
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string StudentNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
