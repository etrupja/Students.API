using Microsoft.EntityFrameworkCore;
using Students.API.Data;
using Students.API.Models;

namespace Students.API.Services;

public class StudentsService(AppDbContext context)
{
    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await context.Students.ToListAsync();
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await context.Students.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Student> AddStudentAsync(Student student)
    {
        context.Students.Add(student);
        await context.SaveChangesAsync();
        return student;
    }

    public async Task<Student?> UpdateStudentAsync(Student student)
    {
        var existingStudent = await context.Students
            .FirstOrDefaultAsync(x => x.Id == student.Id);

        if (existingStudent != null)
        {
            existingStudent.Name = student.Name;
            existingStudent.Math = student.Math;
            existingStudent.English = student.English;
            existingStudent.Science = student.Science;
            await context.SaveChangesAsync();
            return existingStudent;
        }

        return null;
    }

    public async Task DeleteStudentAsync(int id)
    {
        var student = await context.Students.FirstOrDefaultAsync(x => x.Id == id);
        if (student != null)
        {
            context.Students.Remove(student);
            await context.SaveChangesAsync();
        }
    }
}