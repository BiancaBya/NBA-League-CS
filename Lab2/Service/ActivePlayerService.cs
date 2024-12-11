using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class ActivePlayerService : Service<int, ActivePlayer>
{
    public ActivePlayerService(IRepository<int, ActivePlayer> repository) : base(repository)
    {
    }
}

