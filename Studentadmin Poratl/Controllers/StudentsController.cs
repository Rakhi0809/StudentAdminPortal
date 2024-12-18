using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studentadmin_Poratl.Data;
using Studentadmin_Poratl.Models;
using Studentadmin_Poratl.Models.Entities;

namespace Studentadmin_Poratl.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase

    {
        private readonly ApplicationDbcontext dbcontext;

        public StudentsController(ApplicationDbcontext dbcontext)
        {

            this.dbcontext = dbcontext;
        }


        [HttpGet]
        public IActionResult Getallstudents()
        {
            var allStudents = dbcontext.Students.ToList();

            return Ok(allStudents);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = dbcontext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] AddStudentDto addStudentDto)
        {

            var studentEntity = new Student()
            {
                Name = addStudentDto.Name,
                Course = addStudentDto.Course,
                Rollnum = addStudentDto.Rollnum,
                Fee = addStudentDto.Fee,
            };

            dbcontext.Students.Add(studentEntity);
            dbcontext.SaveChanges();
            return Ok(studentEntity);

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateStudent(int id, UpdateStudentDto updateStudentDto)
        {
            var student = dbcontext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            student.Name = updateStudentDto.Name;
            student.Course = updateStudentDto.Course;
            student.Rollnum = updateStudentDto.Rollnum;
            student.Fee = updateStudentDto.Fee;

            dbcontext.SaveChanges();

            return Ok(student);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            var student =dbcontext.Students.Find(id);

            if(student is null)
            {
                return NotFound();
            }
             
              dbcontext.Students.Remove(student);
            dbcontext.SaveChanges();

            return Ok();
        }
    }
}
