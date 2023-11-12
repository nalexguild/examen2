using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [Route("api/libros")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private LibroDAO libroDAO = new LibroDAO();

        [HttpGet]
        public ActionResult<List<Book>> GetLibros()
        {
            var libros = libroDAO.SeleccionarTodosConAutores();
            return libros;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetLibroPorId(int id)
        {
            var libro = libroDAO.SeleccionarPorId(id);

            if (libro == null)
            {
                return NotFound();
            }

            return libro;
        }

        [HttpPost]
        public ActionResult<Book> PostLibro([FromBody] Book nuevoLibro)
        {
            if (nuevoLibro == null)
            {
                return BadRequest("Datos del libro no válidos");
            }

            libroDAO.Insertar(nuevoLibro);

            return CreatedAtAction(nameof(GetLibroPorId), new { id = nuevoLibro.BookId }, nuevoLibro);
        }
    }
}
