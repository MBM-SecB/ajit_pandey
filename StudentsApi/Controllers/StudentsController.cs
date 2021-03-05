
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;

[Route("api/students")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] { "Ram", "Shyam", "Geeta", };
        // students = null;
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentById(string name)
    {

        var students = new string[] { "Ram", "Shyam", "Geeta", };

        var student = students.Where(x => x == name).FirstOrDefault();


        // students = null;
        if (student == null)
        {

            return NotFound();
        }

        return Ok(student);
    }

    [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent(Student std)
    {

        if (std == null)
            return BadRequest();
        
        return Created("", std);
    }

}