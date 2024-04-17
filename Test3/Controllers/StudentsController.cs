using BLL.StudentBLL;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentBLL _studentBLL;

        public StudentsController(IStudentBLL studentBLL)
        { 
            _studentBLL = studentBLL;
        }
        /// <summary>
        /// Method to add a new student
        /// </summary>
        /// <returns>Student Number</returns>
        [HttpPost("AddNewStudent")]
        public IActionResult AddNewStudent([FromBody] StudentDTO student)
        {

            try
            {
                if (student == null) return BadRequest();
                var result = _studentBLL.Add(student);
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Method to get all students
        /// </summary>
        /// <returns>List of students</returns>
        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var result = _studentBLL.GetAllStudents();
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Method to remove a student
        /// </summary>
        /// <returns>Student Numner</returns>
        [HttpDelete("{studentNo}")]
        public IActionResult RemoveStudent([FromRoute]string studentNo)
        {
            try
            {
                var result = _studentBLL.DeleteStudent(studentNo);
              
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
