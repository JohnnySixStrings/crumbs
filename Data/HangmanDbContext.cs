using Microsoft.EntityFrameworkCore;
namespace crumbs.Data;

public class HangmanDbContext : DbContext
{

    public HangmanDbContext (DbContextOptions<HangmanDbContext> options)  
        : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Highscore> Highscores { get; set; }
    public DbSet<Word> Words { get; set; }
}