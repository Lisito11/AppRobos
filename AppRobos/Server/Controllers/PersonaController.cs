using AppRobos.Server.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRobos.Server.Controllers {
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : Controller {
        private readonly ApplicationDbContext context;

        public PersonaController(ApplicationDbContext context) {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get() {
            return context.Personas.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerPersona")]
        public ActionResult<Persona> Get(int id) {
            var autor = context.Personas.FirstOrDefault(x => x.Id == id);

            if (autor == null) {
                return NotFound();
            }

            return autor;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Persona persona) {
            context.Personas.Add(persona);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerPersona", new { id = persona.Id }, persona);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Persona value) {
            if (id != value.Id) {
                return BadRequest();
            }

            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Persona> Delete(int id) {
            var persona = context.Personas.FirstOrDefault(x => x.Id == id);

            if (persona == null) {
                return NotFound();
            }

            context.Personas.Remove(persona);
            context.SaveChanges();
            return persona;
        }
    }
}
