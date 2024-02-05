using EFC.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFC;

public class PlayerContext: DbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<HoleScore> HoleScores { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\olabl\\RiderProjects\\Exam2023\\EFC\\Players.db");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>()
            .HasKey(p => p.Id);

    }
}