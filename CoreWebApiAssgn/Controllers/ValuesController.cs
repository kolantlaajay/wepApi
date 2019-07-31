using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiAssgn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> studentList = new List<Student> { new Student(10, "ajay", "kolantla", "cmd", "A"),
            new Student(11, "karthik", "goud", "search", "A")
          ,new Student(12, "shiny", "gera", "cmd", "A"),
            new Student(13, "charan", "mallemala", "search", "A+")};
        
        
        // GET api/values
        [HttpGet]
        public List<Student> Get()
        {
           
            
            

            List<Student> getStudent = studentList;
            return getStudent;



        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            studentList.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {

            studentList.FirstOrDefault(c => c.id == id).grade = value.grade;
            studentList.FirstOrDefault(c => c.id == id).firstName = value.firstName;
            studentList.FirstOrDefault(c => c.id == id).lastName = value.lastName;
            studentList.FirstOrDefault(c => c.id == id).division = value.division;
            studentList.FirstOrDefault(c => c.id == id).id = value.id;
                       

            List<Student> a = studentList;
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentList.Remove(studentList.FirstOrDefault(c => c.id == id));

        }

        

        
       
    }
}
