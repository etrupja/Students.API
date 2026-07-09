using Microsoft.AspNetCore.Mvc;
using Students.API.Models;
using Students.API.Services;

namespace Students.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController(StudentsService studentsService) : ControllerBase
{
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllStudents()
    {
        var allStudents = await studentsService.GetAllStudentsAsync();
        return Ok(allStudents);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetStudentById(int id)
    {
        var student = await studentsService.GetStudentByIdAsync(id);
        return Ok(student);
    }

    [HttpPost("AddNew")]
    public async Task<IActionResult> CreateStudent([FromBody] Student payload)
    {
        var addedStudent = await studentsService.AddStudentAsync(payload);
        return Ok(addedStudent);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateStudent([FromBody] Student payload)
    {
        var updatedStudent = await studentsService.UpdateStudentAsync(payload);
        return Ok(updatedStudent);
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        await studentsService.DeleteStudentAsync(id);
        return Ok("Student deleted");
    }
}