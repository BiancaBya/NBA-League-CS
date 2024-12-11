using Lab2.Domain;

namespace Lab2.Repository;

public class FileRepository<Id, E> : InMemoryRepository<Id, E> where E : Entity<Id>
{
    private readonly string _fileName;
    
    private File.LineToEntity<E> _lineToEntity;
    
    private File.EntityToLine<E> _entityToLine;


    public FileRepository(string fileName, File.LineToEntity<E> lineToEntity, File.EntityToLine<E> entityToLine)
    {
        _fileName = fileName;
        _lineToEntity = lineToEntity;
        _entityToLine = entityToLine;
        ReadFromFile();
    }

    private void ReadFromFile()
    {
        List<E> entities = File.ReadAll(_fileName, _lineToEntity);
        entities.ForEach(entity => base.Save(entity));
    }

    private void WriteToFile()
    {
        using var writer = new StreamWriter(_fileName);
        foreach (var entity in FindAll())
        {
            writer.WriteLine(_entityToLine(entity));
        }
    }
    
    public override E? Save(E entity)
    {
        var saved = base.Save(entity);
        if(saved != null)
            WriteToFile();
        return saved;
    }

    public override E? Delete(Id id)
    {
        var deleted = base.Delete(id);
        if(deleted != null)
            WriteToFile();
        return deleted;
    }

    public override E? Update(E entity)
    {
        var updated =  base.Update(entity);
        if(updated != null)
            WriteToFile();
        return updated;
    }
}

