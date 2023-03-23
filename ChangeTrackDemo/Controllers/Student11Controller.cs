using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ChangeTrackDemo{
    
    [ApiController]
    [Route("[controller]")]
    public class Student11Controller:ControllerBase
    {
        private readonly Student11Context studentCont;
       public Student11Controller(Student11Context studentContext)
       {
        studentCont=studentContext;
       }

       [HttpGet("{id}")]
        public Student11 GetByID(int id)
        {
              Console.WriteLine("find student");
            var result = studentCont.students11.Find(id);
          
            Console.WriteLine("Context tracking changes of {0} entity.", studentCont.ChangeTracker.Entries().Count());
            DisplayTrackedEntities(studentCont.ChangeTracker);
              studentCont.SaveChanges();
            return result;
        }

        [HttpPost]
        public Student11 CreateStudent(Student11 student)
        {
            Console.WriteLine("Add student");
            studentCont.students11.Add(student);
             Console.WriteLine("Context tracking changes of {0} entity.", studentCont.ChangeTracker.Entries().Count());
            DisplayTrackedEntities(studentCont.ChangeTracker);
            studentCont.SaveChanges();
                return student;
        }
      [HttpDelete("{id}")]
      public List<Student11> RemoveStudent(int id)
      {
        var demo=studentCont.students11.Find(id);
        studentCont.students11.Remove(demo);
          Console.WriteLine("Context tracking changes of {0} entity.", studentCont.ChangeTracker.Entries().Count());
            DisplayTrackedEntities(studentCont.ChangeTracker);
        var newDemo=studentCont.students11.ToList();
            studentCont.SaveChanges();
        return newDemo;
      }

  private static void  DisplayTrackedEntities(ChangeTracker changeTracker)
        {
            Console.WriteLine(" ");
           var entries= changeTracker.Entries();
           foreach (var entry in entries)
    {
        Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
        Console.WriteLine("Status: {0}", entry.State);
    }
     Console.WriteLine("");
    Console.WriteLine("---------------------------------------");
        }
}
}