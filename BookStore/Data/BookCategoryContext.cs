using System;
using System.Collections.Generic;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookCategoryContext : DbContext
    {
        public BookCategoryContext(DbContextOptions<BookCategoryContext> options) : base(options)
        {
        }

        public DbSet<BookCategoryModel> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategoryModel>()
                .HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<BookCategoryModel>()
                .HasData(new List<BookCategoryModel>
                {
                    new() { Id = Guid.NewGuid(), Name = "Data", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Development", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "General", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Java/JVM", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Microsoft &.NET", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Operations & Cloud", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Programming", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Python", CreatedAt = DateTime.Now },
                    new() { Id = Guid.NewGuid(), Name = "Web", CreatedAt = DateTime.Now }
                });
        }
    }
}
