namespace Lab2.Domain;

public class Team : Entity<int>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Team: {{ Name: {Name} }}";
    }
}

