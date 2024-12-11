using Lab2.Domain;

namespace Lab2.Repository;

public interface IRepository<Id, E> where E : Entity<Id>
{
    E? FindOne(Id id);
    IEnumerable<E> FindAll();
    E? Save(E entity);
    E? Delete(Id id);
    E? Update(E entity);
}

