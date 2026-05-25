namespace Students.API.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Math { get; set; }
    public double English { get; set; }
    public double Science { get; set; }
}
