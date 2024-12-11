using Lab2.Domain;
namespace Lab2.Repository;

public class EntityFileMapping
{
    
    public static Team? LineToTeam(string line)
    {
        var elements = line.Split(',');
        if (line != string.Empty)
        {
            var team = new Team
            {
                Id = int.Parse(elements[0]),
                Name = elements[1].Trim()
            };
            return team;
        }
        else
        {
            return null;
        }
    }

    public static string TeamToLine(Team team)
    {
        return team.Id + "," + team.Name.Trim();
    }


    public static Student? LineToStudent(string line)
    {
        var elements = line.Split(',');
        if (line != string.Empty)
        {
            var student = new Student
            {
                Id = int.Parse(elements[0]),
                Name = elements[1].Trim(),
                School = elements[2].Trim()
            };
            return student;
        }
        else
        {
            return null;
        }
    }

    public static string StudentToLine(Student student)
    {
        return student.Id + "," + student.Name.Trim() + "," + student.School.Trim();
    }


    public static Game? LineToGame(string line)
    {
        var elements = line.Split(',');
        if (line != string.Empty)
        {
            var game = new Game
            {
                Id = int.Parse(elements[0]),
                FirstTeam = { Id = int.Parse(elements[1]) },
                SecondTeam = { Id = int.Parse(elements[2]) },
                Date = DateTime.Parse(elements[3]),
            };
            return game;
        }
        else
        {
            return null;
        }
    }

    public static string GameToLine(Game game)
    {
        return game.Id + "," + game.FirstTeam.Id + ","  + game.SecondTeam.Id + "," + game.Date.ToString("dd/MM/yyyy");
    }


    public static Player? LineToPlayer(string line)
    {
        var elements = line.Split(',');
        if (line != string.Empty)
        {
            var player = new Player
            {
                Id = int.Parse(elements[0]),
                Name = elements[1].Trim(),
                School = elements[2].Trim(),
                PlayerTeam = {Id = int.Parse(elements[3]) }
            };
            return player;
        }
        else
        {
            return null;
        }
        
    }

    public static string PlayerToLine(Player player)
    {
        return player.Id + "," + player.Name.Trim() + "," + player.School.Trim() + "," + player.PlayerTeam.Id;
    }


    public static ActivePlayer? LineToActivePlayer(string line)
    {
        var elements = line.Split(',');
        if (line != string.Empty)
        {
            var activePlayer = new ActivePlayer
            {
                Id = int.Parse(elements[0]),
                Name = elements[1].Trim(),
                School = elements[2].Trim(),
                PlayerTeam = { Id = int.Parse(elements[3]) },
                IdGame = int.Parse(elements[4]),
                NrPoints = int.Parse(elements[5]),
                PlayerType = Enum.Parse<PlayerType>(elements[6].Trim()),
            };
            return activePlayer;
        }
        else
        {
            return null;
        }
    }

    public static string ActivePlayerToLine(ActivePlayer activePlayer)
    {
        return activePlayer.Id + "," + activePlayer.Name.Trim() + "," + activePlayer.School.Trim() + "," +
               activePlayer.PlayerTeam.Id + "," + activePlayer.PlayerTeam.Name.Trim() + "," + activePlayer.IdGame +
               activePlayer.NrPoints + activePlayer.PlayerType;
    }
    
}


