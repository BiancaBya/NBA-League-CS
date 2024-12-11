using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class TeamService : Service<int, Team>
{
    public TeamService(IRepository<int, Team> repository) : base(repository)
    {
    }
}

