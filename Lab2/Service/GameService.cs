using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class GameService : Service<int, Game>
{
    public GameService(IRepository<int, Game> repository) : base(repository)
    {
    }
}

