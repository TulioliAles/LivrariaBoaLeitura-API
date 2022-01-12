using LivrariaBoaLeitura.API.Mapping;
using LivrariaBoaLeitura.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaBoaLeitura.API.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions option)
            : base(option)
        {

        }

        public DbSet<Livro> todoLivros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMap());
        }
    }
}
