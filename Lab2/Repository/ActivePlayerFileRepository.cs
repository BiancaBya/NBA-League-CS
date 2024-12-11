using Lab2.Domain;

namespace Lab2.Repository;

public class ActivePlayerFileRepository : FileRepository<int, ActivePlayer>
{
    public ActivePlayerFileRepository(string fileName) : base(fileName, EntityFileMapping.LineToActivePlayer, EntityFileMapping.ActivePlayerToLine)
    {
    }
}

