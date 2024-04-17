using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StudentDAL
{
    public  interface IStudentDAL
    {
        List<StudentResponse> GetAllStudents();
        StudentResponse GetStudent(string studentNumber);
        StudentResponse UpdateStudent(StudentDTO studentNumber, string StudentNo);
        string DeleteStudent(string StudentNumber);

        string Add(StudentDTO student, string studentNo);
    }
}
