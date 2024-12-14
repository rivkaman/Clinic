using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private static List<Turn> turns = new List<Turn>();
        // GET: api/<DoctorController>
        [HttpGet]
        public List<Turn> Get()
        {
            return turns;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Turn Get(string numberTurn)
        {
            var t = turns.FirstOrDefault(t => t.NumberTurn == numberTurn);
            if (t == null)
            {
                Console.WriteLine("not found");
            }
            return t;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Turn turn)
        {
            turns.Add(turn);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(string numberTurn, [FromBody] DateTime startTime,DateTime endTime,string description,Doctor doctor,Patient patient)
        {
            foreach (var t in turns)
            {
                if (t == null)
                    Console.WriteLine("not found!");
                else
                    if (t.NumberTurn == numberTurn)
                {
                    t.StartTime = startTime;
                    t.EndTime = endTime;
                    t.Description = description;
                    t.Doctor = doctor;
                    t.Patient = patient;
                }
                  
            }
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(string numberTurn)
        {
            foreach (var t in turns)
            {
                if (t == null)

                    Console.WriteLine("not found!");
                else
                if (t.NumberTurn==numberTurn)
                   turns.Remove(t);
            }
        }
    }
}
