using Lab2.Domain;

namespace Lab2.Repository;

public class GameFileRepository : FileRepository<int, Game>
{
    public GameFileRepository(string fileName) : base(fileName, EntityFileMapping.LineToGame, EntityFileMapping.GameToLine)
    {
    }
}

