using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class GameDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=GGL-Games;UserId=postgres;Password=1qw23er45");
        }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasKey(e => e.id);
            modelBuilder.Entity<Game>().HasData(SeedGameData());

        }
        public List<Game> SeedGameData()
        { 
            var games = new List<Game>();

            using (StreamReader r = new StreamReader(@"..\infrastructure\seeding\games.json"))
            { 
                string json = r.ReadToEnd();
                games = JsonConvert.DeserializeObject<List<Game>>(json);

                for (int i = 0; i < games.Count; i++)
                {
                    games[i].id = i + 1;
                }
                return games;
            }
        }
    }
}
