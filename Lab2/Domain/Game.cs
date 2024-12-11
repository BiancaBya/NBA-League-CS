namespace Lab2.Domain;

public class Game : Entity<int>
{
    public Team FirstTeam { get; set; } = new Team();
    public Team SecondTeam { get; set; } = new Team();
    public DateTime Date { get; set; }
    
    public override string ToString()
    {
        return $"Game: {{ FirstTeam: {FirstTeam}, SecondTeam: {SecondTeam}, Date: {Date} }}";
    }
}


