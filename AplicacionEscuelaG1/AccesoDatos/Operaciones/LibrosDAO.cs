using AccesoDatos.Context;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Operaciones
{
    public class LibroDAO
    {
        private EscuelaContext contexto = new EscuelaContext();

        public List<Book> SeleccionarTodos()
        {
            var libros = contexto.Books.ToList();
            return libros;
        }

        public List<Book> SeleccionarTodosConAutores()
        {
            var libros = contexto.Books
                .Include(book => book.Author) // Incluir información del autor
                .ToList();
            return libros;
        }

        public Book SeleccionarPorId(int id)
        {
            var libro = contexto.Books
                .Include(book => book.Author) // Incluir información del autor
                .FirstOrDefault(book => book.BookId == id);

            return libro;
        }

        public void Insertar(Book nuevoLibro)
        {
            contexto.Books.Add(nuevoLibro);
            contexto.SaveChanges(); // Guardar cambios en la base de datos
        }
    }
}
