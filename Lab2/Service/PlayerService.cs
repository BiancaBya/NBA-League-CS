using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class PlayerService : Service<int, Player>
{
    public PlayerService(IRepository<int, Player> repository) : base(repository)
    {
    }
}
