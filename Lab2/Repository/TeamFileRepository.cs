using Lab2.Domain;

namespace Lab2.Repository;

public class TeamFileRepository : FileRepository<int, Team>
{
    public TeamFileRepository(string fileName) : base(fileName, EntityFileMapping.LineToTeam, EntityFileMapping.TeamToLine)
    {
    }
}

