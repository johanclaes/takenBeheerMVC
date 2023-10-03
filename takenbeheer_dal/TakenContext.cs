using Microsoft.EntityFrameworkCore;
using takenbeheer_models;


namespace takenbeheer_dal
{
    public class TakenContext : DbContext
    {
        public DbSet<ToDoTaak> ToDoTaken { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ToDoTakenBeheerDB2;Trusted_Connection=True;");
        }


    }
}