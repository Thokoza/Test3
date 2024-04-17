using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StudentDAL
{
    public class StudentDAL : IStudentDAL
    {
        private readonly UniversityContext _context;

        public StudentDAL(UniversityContext context)
        {
            _context = context;
        }

        public string Add(StudentDTO student, string studentNo)
        {
            Student newStudent = new Student();
            newStudent.Age = student.Age;
            newStudent.FirstName = student.FirstName;   
            newStudent.Surname = student.Surname;
            newStudent.Gender = student.Gender;
            newStudent.StudentNumber = studentNo;
            _context.Add(newStudent);
            _context.SaveChanges();

            return newStudent.StudentNumber;
        }

        public string DeleteStudent(string StudentNumber)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentNumber == StudentNumber);
            try 
            {
                if (student != null)
                {

                    _context.Remove(student);
                    _context.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
         

            return StudentNumber;
        }

        public List<StudentResponse> GetAllStudents()
        {
            List<StudentResponse> list = new List<StudentResponse>();
            try
            {
                var students = _context.Students.OrderBy(x => x.StudentNumber).ToList();
                foreach (var student in students) 
                {
                    StudentResponse x = new StudentResponse();
                    x.StudentId = student.StudentId;
                    x.StudentNumber = student.StudentNumber;
                    x.FirstName = student.FirstName;
                    x.Surname = student.Surname;
                    x.Age = student.Age;
                    x.Gender = student.Gender;
                    list.Add(x);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;

        }

        public StudentResponse GetStudent(string studentNumber)
        {
            StudentResponse student = new StudentResponse();

            var result = _context.Students.FirstOrDefault(x => x.StudentNumber == studentNumber);
            if (result != null)
            { 
                student.FirstName = result.FirstName;
                student.Surname = result.Surname;
                student.Age = result.Age;
                student.Gender = result.Gender;
                student.StudentNumber = result.StudentNumber;
            }

            return student;
        }

        public StudentResponse UpdateStudent(StudentDTO student, string StudentNo)
        {
            StudentResponse studentResponse  =  new StudentResponse();
            var studentFound =  _context.Students.FirstOrDefault(x => x.StudentNumber == StudentNo);
            if (student != null)
            {
                studentFound.Surname = student.Surname;
                studentFound.Age = student.Age;
                _context.SaveChanges();
            }
            return studentResponse;
        }
    }
}

