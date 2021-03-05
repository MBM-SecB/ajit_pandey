
using Microsoft.AspNetCore.Mvc;
[Route("students")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] { "Dipesh", "Swostika" };
        students = null;
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }
}