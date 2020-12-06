using Books.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    public class BookContext : DbContext 
    {
        public DbSet<Livro> TB_LIVROS { get; set }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = LariBooks; Integrated Security = True");
        }

    }
}
