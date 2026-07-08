using Microsoft.AspNetCore.Mvc;
using Students.API.Models;
using Students.API.Services;

namespace Students.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController(StudentsService studentsService) : ControllerBase
{
    [HttpGet("GetAll")]
    public IActionResult GetAllStudents()
    {
        var allStudents = studentsService.GetAllStudents();
        return Ok(allStudents);
    }

    [HttpGet("GetById")]
    public IActionResult GetStudentById(int id)
    {
        var student = studentsService.GetStudentById(id);
        return Ok(student);
    }

    [HttpPost("AddNew")]
    public IActionResult CreateStudent([FromBody]Student payload)
    {
        var addedStudent = studentsService.AddStudent(payload);
        return Ok(addedStudent);
    }

    [HttpPut("Update")]
    public IActionResult UpdateStudent([FromBody] Student payload)
    {
        var updatedStudent = studentsService.UpdateStudent(payload);
        return Ok(updatedStudent);
    }

    [HttpDelete("Delete")]
    public IActionResult DeleteStudent(int id)
    {
        studentsService.DeleteStudent(id);
        return Ok("Student deleted");
    }
}
