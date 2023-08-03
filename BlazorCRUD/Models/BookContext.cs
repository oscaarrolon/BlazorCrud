using System;
using Microsoft.EntityFrameworkCore;
namespace BlazorCRUD.Models
{
	public class BookContext : DbContext
	{
        public string Url = "Server=localhost;Initial Catalog=Databases;TrustServerCertificate=True; Connection Timeout=30 ;user=SA;Password=Password.1";

		public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Url);
        }

    }
}

