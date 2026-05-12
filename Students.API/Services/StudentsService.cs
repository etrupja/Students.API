using Students.API.Models;

namespace Students.API.Services;

public static class StudentsService
{
    public static List<Student> fakeDbStudents = new List<Student>()
    {
        new Student()
        {
            Id = 1,
            Name = "Test 01"
        },
        new Student()
        {
            Id = 2,
            Name = "Test 02"
        }
    };

    public static List<Student> GetAllStudents()
    {
        return fakeDbStudents;
    }
    
    public static Student? GetStudentById(int id)
    {
        return fakeDbStudents.FirstOrDefault(x => x.Id == id);
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