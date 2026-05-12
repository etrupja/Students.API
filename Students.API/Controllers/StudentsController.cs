using Microsoft.AspNetCore.Mvc;
using Students.API.Models;
using Students.API.Services;

namespace Students.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    [HttpGet("GetAll")]
    public IActionResult GetAllStudents()
    {
        var allStudents = StudentsService.GetAllStudents();
        return Ok(allStudents);
    }
    
    [HttpGet("GetById")]
    public IActionResult GetStudentById(int id)
    {
        var student = StudentsService.GetStudentById(id);
        return Ok(student);
    }
    
    [HttpPost("AddNew")]
    public IActionResult CreateStudent([FromBody]Student payload)
    {
        var addedStudent = StudentsService.AddStudent(payload);
        return Ok(addedStudent);
    }

    [HttpPut("Update")]
    public IActionResult UpdateStudent([FromBody] Student payload)
    {
        var updatedStudent = StudentsService.UpdateStudent(payload);
        return Ok(updatedStudent);
    }

    [HttpDelete("Delete")]
    public IActionResult DeleteStudent(int id)
    {
        StudentsService.DeleteStudent(id);
        return Ok("Student deleted");
    }
}