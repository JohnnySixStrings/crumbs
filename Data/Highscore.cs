namespace crumbs.Data;

public class Highscore
{
    public int HighscoreId { get; set; }
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public int Score { get; set; }
}