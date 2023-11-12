// Author.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccesoDatos.Models
{
    public class Author
    {
        
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}