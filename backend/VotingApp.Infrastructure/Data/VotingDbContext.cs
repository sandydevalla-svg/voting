
using Microsoft.EntityFrameworkCore;

public class VotingDbContext : DbContext
{
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Voter> Voters { get; set; }
    public DbSet<Vote> Votes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vote>()
            .HasIndex(v => v.VoterId)
            .IsUnique();
    }
}
