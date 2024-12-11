namespace Lab2.Domain;

public class Player : Student
{
    public Team PlayerTeam { get; set; } = new Team();

    public override string ToString()
    {
        return $"Player: {{ Name: {Name}, School: {School}, Team: {PlayerTeam} }}";
    }
}

