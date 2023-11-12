using AccesoDatos.Context;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos.Operaciones
{
    public class AutorDAO
    {
        private EscuelaContext contexto = new EscuelaContext();

        public List<Author> SeleccionarTodos()
        {
            var autores = contexto.Authors.ToList();
            return autores;
        }

        public void Insertar(Author nuevoAutor)
        {
            contexto.Authors.Add(nuevoAutor);
            contexto.SaveChanges();
        }


    }
}
