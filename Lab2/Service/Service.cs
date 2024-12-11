using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class Service<Id, E> where E : Entity<Id>
{
    protected IRepository<Id, E> Repository;

    public Service(IRepository<Id, E> repository)
    {
        this.Repository = repository;
    }

    public E? FindOne(Id id)
    {
        return Repository.FindOne(id);
    }

    public IEnumerable<E> FindAll()
    {
        return Repository.FindAll();
    }
}

