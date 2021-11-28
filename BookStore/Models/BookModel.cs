using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("books")]
    public class BookModel
    {
        public Guid Id { get; set; }

        [Column("category_id")]
        public Guid CategoryId { get; set; }

         public BookCategoryModel Category { get; set; }

        [Column("name", TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("author", TypeName = "varchar(100)")]
        [Required]
        public string Author { get; set; }

        [Column("price", TypeName = "decimal(10,2)")]
        [Required]
        public decimal Price { get; set; }

        [Column("created_at")] public DateTime CreatedAt { get; set; }
    }
}
