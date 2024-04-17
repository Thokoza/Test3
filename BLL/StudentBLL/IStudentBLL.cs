using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentBLL
{
    public interface IStudentBLL
    {
        List<StudentResponse> GetAllStudents();
        StudentResponse GetStudent(string studentNumber);
        StudentResponse UpdateStudent(StudentDTO studentNumber, string StudentNo);
        string DeleteStudent(string StudentNumber);

        string Add(StudentDTO student);
    }
}
