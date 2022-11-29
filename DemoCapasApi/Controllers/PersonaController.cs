using CapaDatos;
using CapaNegocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoCapasApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        IPersona _persona;
        public PersonaController(IPersona persona)
        {
            _persona = persona;
        }


        // GET: api/<PersonaController>
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _persona.GetPersonas();
        }

        // GET api/<PersonaController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] Persona value)
        {
            _persona.SetPersona(value);
        }

        //// PUT api/<PersonaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PersonaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
