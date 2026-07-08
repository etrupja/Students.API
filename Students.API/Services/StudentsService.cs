using Students.API.Data;
using Students.API.Models;

namespace Students.API.Services;

public class StudentsService(AppDbContext context)
{
    public List<Student> GetAllStudents()
    {
        return context.Students.ToList();
    }
    
    public static Student? GetStudentById(int id)
    {
        return context.FirstOrDefault(x => x.Id == id);
    }

    public static Student AddStudent(Student student)
    {
        fakeDbStudents.Add(student);
        return student;
    }

    public static Student? UpdateStudent(Student student)
    {
        var existingStudent = fakeDbStudents.FirstOrDefault(x => x.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.Name = student.Name;
            return existingStudent;
        }

        return null;
    }

    public static void DeleteStudent(int id)
    {
        var student = fakeDbStudents.FirstOrDefault(x => x.Id == id);
        if (student != null)
        {
            fakeDbStudents.Remove(student);
        }
    }
}