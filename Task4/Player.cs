public class Player
{
    public string playerName;
    public int level;
    public double health;

    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    public Player(string playerName, int level, double health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}
