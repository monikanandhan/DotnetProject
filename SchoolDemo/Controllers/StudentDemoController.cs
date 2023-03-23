
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace SchoolDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
   public class StudentDemoController : ControllerBase
    {
        private readonly SchoolDemoContext schoolDemoCont;
        public StudentDemoController(SchoolDemoContext schoolDemoContext)
        {
               schoolDemoCont=schoolDemoContext;
        }


        [HttpPost]
      public Student CreateStudent(Student student)
      {
       schoolDemoCont.Stud.Add(student);
       schoolDemoCont.SaveChanges();
       return student;
      }

      [HttpGet]
      public List<Student> GetStudent()
      {
            List<Student> demo = schoolDemoCont.Stud.ToList();
            return  demo;
      }

        [HttpGet("{id}")]
        public Student GetByID(int id)
            {
            var result= schoolDemoCont.Stud.Find(id);
            schoolDemoCont.SaveChanges();
            return result;  
            }

            [HttpPut]
            public Student UpdateById(int id,Student student)
            {
                var result= schoolDemoCont.Stud.Find(id);
                if(result!=null)
                {
                    
                    student.Name=result.Name;
                    student.Age=result.Age;
                    schoolDemoCont.SaveChanges();
                }

                return student;
            }

            
        [HttpDelete("{id}")]
        public List<Student> DeleteById(int id)
        {
            var result = schoolDemoCont.Stud.Find(id);
            schoolDemoCont.Stud.Remove(result);
            schoolDemoCont.SaveChanges();
            List<Student> demo = schoolDemoCont.Stud.ToList();

            return demo;


        }


    }
}