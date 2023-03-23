
using Microsoft.EntityFrameworkCore;
using SchoolDemo;

public class SchoolDemoContext:DbContext
{

    public SchoolDemoContext(DbContextOptions<SchoolDemoContext> options):base(options)
    {

    }
    public DbSet<Student> Stud{get;set;}
    public DbSet<Course> cor{get;set;}

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// {
//     if (!optionsBuilder.IsConfigured)
//     {
//         optionsBuilder.UseInMemoryDatabase("SchoolDemo");
//     }
// }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity=>{
            entity.Property(e=>e.Id).IsRequired();
        });

        modelBuilder.Entity<Student>(entity=>
        {
        entity.Property(e=>e.Name).IsRequired();
        });
         modelBuilder.Entity<Student>(entity=>
        {
        entity.Property(e=>e.Age).IsRequired();
        });

        modelBuilder.Entity<Course>(entity=>{
            entity.Property(e=>e.courseId).IsRequired();
        });

         modelBuilder.Entity<Course>(entity=>
        {
        entity.Property(e=>e.CourseName).IsRequired();
        });
         modelBuilder.Entity<Course>(entity=>
        {
        entity.Property(e=>e.CourseFees).IsRequired();
        });
    }

}