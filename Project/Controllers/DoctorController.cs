using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private static List<Doctor> doctors = new List<Doctor>();
        // GET: api/<DoctorController>
        [HttpGet]
        public List<Doctor> Get()
        {
            return doctors;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor Get(string id)
        {
            var doctor = doctors.FirstOrDefault(d => d.Id == id);
            if (doctor == null)
            {
                Console.WriteLine("not found");                
            }
            return doctor;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            doctors.Add(doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            foreach (var d in doctors)
            {
                if (d == null)
                    Console.WriteLine("not found!");
                else
                    if (d.Id == id)
                    d.Name = value;
            }
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            foreach (var d in doctors)
            {
                if (d == null)
                    Console.WriteLine("not found!");
                else
                if (d.Id == id)
                    doctors.Remove(d);
            }
        }
    }
}
