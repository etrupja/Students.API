using Microsoft.EntityFrameworkCore;
using Students.API.Models;

namespace Students.API.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {}
    
    public DbSet<Student> Students { get; set; }
}