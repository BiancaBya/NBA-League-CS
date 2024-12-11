namespace Lab2.Repository;

public class File
{
    public delegate E LineToEntity<E>(string? line);
    
    public delegate string EntityToLine<E>(E entity);

    public static List<E> ReadAll<E>(string fileName, LineToEntity<E> lineToEntity)
    {
        using var reader = new StreamReader(fileName);
        List<E> entities = new List<E>();
        string? line;
        
        while ((line = reader.ReadLine()) != null)
        {
            var entity = lineToEntity(line);
            entities.Add(entity);
        }
        
        return entities;
    }
}

