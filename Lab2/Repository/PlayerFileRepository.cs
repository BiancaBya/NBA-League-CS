using Lab2.Domain;

namespace Lab2.Repository;

public class PlayerFileRepository : FileRepository<int, Player>
{
    public PlayerFileRepository(string fileName) : base(fileName, EntityFileMapping.LineToPlayer, EntityFileMapping.PlayerToLine)
    {
    }
}

