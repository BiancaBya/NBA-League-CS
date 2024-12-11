using System.Collections.ObjectModel;
using Lab2.Domain;

namespace Lab2.Repository;

public class InMemoryRepository<Id, E> : IRepository<Id, E> where E : Entity<Id>
{
    private readonly Collection<E> _collection = [];
    
    public E? FindOne(Id id)
    {
        return _collection.FirstOrDefault(entity => entity.Id.Equals(id));
    }

    public IEnumerable<E> FindAll()
    {
        return _collection;
    }

    public virtual E? Save(E entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        if (_collection.Contains(entity))
            return null;
        _collection.Add(entity);
        return entity;
    }

    public virtual E? Delete(Id id)
    {
        var entity = FindOne(id);
        if (entity == null)
            return entity;
        _collection.Remove(entity);
        return entity;
    }

    public virtual E? Update(E entity)
    {
        var old = FindOne(entity.Id);
        if (old == null)
            return null;
        _collection.Remove(old);
        _collection.Add(entity);
        return entity;
    }
}

