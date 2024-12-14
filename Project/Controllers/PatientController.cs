using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static List<Patient> patients = new List<Patient>();
        // GET: api/<DoctorController>
        [HttpGet]
        public List<Patient> Get()
        {
            return patients;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Patient Get(string id)
        {
            var p = patients.FirstOrDefault(p => p.Id == id);
            if (p == null)
            {
                Console.WriteLine("not found");
            }
            return p;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            patients.Add(patient);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            foreach (var p in patients)
            {
                if (p == null)
                    Console.WriteLine("not found!");
                else
                    if (p.Id == id)
                    p.Name = value;
            }
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            foreach (var p in patients)
            {
                if (p == null)
                    Console.WriteLine("not found!");
                else
                if (p.Id == id)
                    patients.Remove(p);
            }
        }

    }
}
