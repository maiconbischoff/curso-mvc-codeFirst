using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context: DbContext
    {

        public DbSet<Categoria> Categorias { get; set; } //this is about a categoria table inside DB
        public DbSet<Produto> Produtos { get; set; } //set produtos table inside DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost\SQLEXPRESS;Database=Cursomvc;Integrated Security=True"); //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

        }

    }
}
