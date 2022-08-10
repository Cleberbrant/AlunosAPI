using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Cleber de Oliveira",
                    Email = "cleber@gmail.com",
                    Idade = 20
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Luis da Silva",
                    Email = "luis@gmail.com",
                    Idade = 19
                }
                );
        }
    }
}
