using Students.API.Data;
using Students.API.Models;

namespace Students.API.Services;

public class StudentsService(AppDbContext context)
{
    public List<Student> GetAllStudents()
    {
        return context.Students.ToList();
    }

    public Student? GetStudentById(int id)
    {
        return context.Students.FirstOrDefault(x => x.Id == id);
    }

    public Student AddStudent(Student student)
    {
        context.Students.Add(student);
        context.SaveChanges();
        return student;
    }

    public Student? UpdateStudent(Student student)
    {
        var existingStudent = context.Students.FirstOrDefault(x => x.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.Name = student.Name;
            existingStudent.Math = student.Math;
            existingStudent.English = student.English;
            existingStudent.Science = student.Science;
            context.SaveChanges();
            return existingStudent;
        }

        return null;
    }

    public void DeleteStudent(int id)
    {
        var student = context.Students.FirstOrDefault(x => x.Id == id);
        if (student != null)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
