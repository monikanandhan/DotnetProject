using Microsoft.EntityFrameworkCore;
using ChangeTrackDemo;
namespace ChangeTrackDemo{
public class Student11Context:DbContext
{
    public Student11Context()
    {
    }

    public Student11Context(DbContextOptions<Student11Context> options):base(options)
    {

    }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student11>(entity=>{
            entity.Property(e=>e.ID).IsRequired();
        });

        modelBuilder.Entity<Student11>(entity=>
        {
        entity.Property(e=>e.Name).IsRequired();
        });
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseMySQL("ConnectionStrings:DefaultConnection");
    }
    }
public DbSet<Student11> students11{get;set;}    
}
}

