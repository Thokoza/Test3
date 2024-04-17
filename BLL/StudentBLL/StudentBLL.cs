using DAL.Models;
using DAL.StudentDAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.StudentBLL
{
    public class StudentBLL : IStudentBLL
    {
        private readonly IStudentDAL _studentDAL;

        public StudentBLL (IStudentDAL studentDAL)
        {
            _studentDAL = studentDAL;
        }

        public string Add(StudentDTO student)
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999);
            string studentNo = myRandomNo.ToString();
            var check = _studentDAL.GetStudent(studentNo);
            if (check.StudentId == 0)
            {

                return _studentDAL.Add(student, studentNo);
            }
            else
            {
                throw new Exception ( "Student  " + studentNo + "Already exists!" );
            }
        }

        public string DeleteStudent(string StudentNumber)
        {
            return _studentDAL.DeleteStudent(StudentNumber);
        }

        public List<StudentResponse> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }

        public StudentResponse GetStudent(string studentNumber)
        {
            return _studentDAL.GetStudent(studentNumber);   
        }

        public StudentResponse UpdateStudent(StudentDTO studentNumber, string studentNo)
        {
           return _studentDAL.UpdateStudent(studentNumber,studentNo); 
        }
    }
}
