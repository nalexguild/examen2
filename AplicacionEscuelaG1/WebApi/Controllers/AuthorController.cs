using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [Route("api/autores")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private AutorDAO autorDAO = new AutorDAO();

        [HttpGet]
        public ActionResult<List<Author>> GetAutores()
        {
            var autores = autorDAO.SeleccionarTodos();
            return autores;
        }

        [HttpPost]
        public ActionResult<Author> PostAutor([FromBody] Author nuevoAutor)
        {
            if (nuevoAutor == null)
            {
                return BadRequest("Datos del autor no válidos");
            }

            autorDAO.Insertar(nuevoAutor);

            return CreatedAtAction(nameof(GetAutores), null);
        }


    }
}

