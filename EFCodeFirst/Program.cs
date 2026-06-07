using Microsoft.EntityFrameworkCore;


using (var context = new SchoolContext())
{
    // Creates the database and Students table if they don't exist yet
    context.Database.EnsureCreated();

    // Create a new Student object
    var student = new Student
    {
        Name = "Saaffe Algarib",
        Major = "Computer Science"
    };

    // Add it to the Students table
    context.Students.Add(student);

    // Save changes — this is what actually fires the SQL INSERT
    context.SaveChanges();

    Console.WriteLine("Student added successfully!");
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Major: {student.Major}");
}

public class Student
{
    public int StudentId { get; set; }  
    public string Name { get; set; }
    public string Major { get; set; }
}


public class SchoolContext : DbContext
{
    // This property tells EF: "make a Students table based on the Student class"
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // SQLite will create a local database file called school.db
        options.UseSqlite("Data Source=school.db");
    }
}
