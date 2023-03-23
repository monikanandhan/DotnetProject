using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace SchoolDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseDemoController : ControllerBase
    {
        private readonly SchoolDemoContext schoolDemoCont;
        public CourseDemoController(SchoolDemoContext schoolDemoContext)
        {
            schoolDemoCont = schoolDemoContext;
        }


        [HttpPost]
        public Course CreateCourse(Course course)
        {
            schoolDemoCont.cor.Add(course);
            schoolDemoCont.SaveChanges();
            return course;

        }


        [HttpGet]
        public List<Course> GetCourse()
        {
            List<Course> demo = schoolDemoCont.cor.ToList();
            return demo;
        }

        [HttpGet("{id}")]
        public Course GetByID(int id)
        {
            var result = schoolDemoCont.cor.Find(id);
            schoolDemoCont.SaveChanges();
            return result;
        }



        [HttpDelete("{CourseId}")]
        public List<Course> DeleteById(int CourseId)
        {
            var result = schoolDemoCont.cor.Find(CourseId);
            schoolDemoCont.cor.Remove(result);
            schoolDemoCont.SaveChanges();
            List<Course> demo = schoolDemoCont.cor.ToList();

            return demo;


        }

    }
}