using System;
using System.Collections.Generic;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>()
                .HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<BookCategoryModel>().HasData(
                new List<BookCategoryModel>
                {
                    new()
                    {
                        Id = new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), Name = "Data", CreatedAt = DateTime.Now
                    },
                    new()
                    {
                        Id = new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), Name = "Development",
                        CreatedAt = DateTime.Now
                    },
                    new()
                    {
                        Id = new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), Name = "General",
                        CreatedAt = DateTime.Now
                    }
                }
            );
            modelBuilder.Entity<BookModel>()
                .HasData(new List<BookModel>
                {
                    // Data 
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"),
                        Name = "Getting Started with Natural Language Processing",
                        Author = "Ekaterina Kochmar",
                        Price = new decimal(19.99),
                        CreatedAt = DateTime.Now
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"),
                        Name = "Inside Deep Learning",
                        Author = "Edward Raff",
                        Price = new decimal(19.99),
                        CreatedAt = DateTime.Now
                    },

                    // Development
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"),
                        Name = "Grokking Functional Programming",
                        Author = "Michał Płachta",
                        Price = new decimal(28.79),
                        CreatedAt = DateTime.Now
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"),
                        Name = "Functional Design and Architecture",
                        Author = "Alexander Granin",
                        Price = new decimal(28.79),
                        CreatedAt = DateTime.Now
                    },

                    // General
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"),
                        Name = "Making Sense of Cyber Security",
                        Author = "Thomas Kranz",
                        Price = new decimal(28.79),
                        CreatedAt = DateTime.Now
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"),
                        Name = "Geometry for Programmers",
                        Author = "Oleksandr Kaleniuk",
                        Price = new decimal(28.79),
                        CreatedAt = DateTime.Now
                    },
                });
        }
    }
}
