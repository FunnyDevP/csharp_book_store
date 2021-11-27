using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("book_categories")]
    public class BookCategoryModel
    {
        public Guid Id { get; set; }

        [Column("name", TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column("created_at")] public DateTime CreatedAt { get; set; }
    }
}
