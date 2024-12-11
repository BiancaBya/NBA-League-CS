namespace Lab2.Domain;

public class Entity<TId>
{
    public TId Id { get; set; }

    public override string ToString()
    {
        return Id.ToString();
    }
}

