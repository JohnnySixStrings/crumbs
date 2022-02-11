using Microsoft.EntityFrameworkCore;
namespace crumbs.Data;

public class HangmanDb : DbContext
{
    public string DbPath { get; }
    public HangmanDb()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "hangman.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    public  DbSet<Highscore> Highscores { get; set; } 
    public  DbSet<Word> Words { get; set; } 
}