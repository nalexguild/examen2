// Book.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesoDatos.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public int Chapters { get; set; }

        public int Pages { get; set; }

        public decimal Price { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}