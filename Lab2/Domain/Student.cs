namespace Lab2.Domain;

public class Student : Entity<int>
{
    public string Name { get; set; }
    public string School { get; set; }

    public override string ToString()
    {
        return $"Student: {{ Name: {Name}, School: {School} }}";
    }
}

