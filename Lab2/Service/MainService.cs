using Lab2.Domain;

namespace Lab2.Service;

public class MainService
{
    private readonly TeamService _teamService;
    private readonly GameService _gameService;
    private readonly StudentService _studentService;
    private readonly PlayerService _playerService;
    private readonly ActivePlayerService _activePlayerService;

    public MainService(TeamService teamService, GameService gameService, StudentService studentService, PlayerService playerService, ActivePlayerService activePlayerService)
    {
        this._teamService = teamService;
        this._gameService = gameService;
        this._studentService = studentService;
        this._playerService = playerService;
        this._activePlayerService = activePlayerService;
    }

    
    public List<Player> GetTeamPlayers(Team team)
    {
        return _playerService.FindAll().Where(player => player.PlayerTeam.Id.Equals(team.Id)).ToList();
    }
    
    
    public List<ActivePlayer> GetActivePlayersFromGame(Game game, Team team)
    {
        return _activePlayerService.FindAll().Where(player => player.IdGame.Equals(game.Id) 
                                                             && player.PlayerTeam.Id.Equals(team.Id)).ToList();
    }
    
    
    public List<Game> GetGamesFromDates(DateTime startDate, DateTime endDate)
    {
        return _gameService.FindAll().Where(game => game.Date >= startDate && game.Date <= endDate).ToList();
    }
    
    
    public Tuple<int, int> GetScoreFromGame(Game game)
    {
        var scoreTeam1 = _activePlayerService.FindAll().Where(player => player.IdGame.Equals(game.Id)
                                                                       && player.PlayerTeam.Id.Equals(game.FirstTeam.Id)
                                                                       && player.PlayerType.Equals(PlayerType.Participant))
                                                        .Sum(player => player.NrPoints);
        var scoreTeam2 = _activePlayerService.FindAll().Where(player => player.IdGame.Equals(game.Id)
                                                                       && player.PlayerTeam.Id.Equals(game.SecondTeam.Id)
                                                                       && player.PlayerType.Equals(PlayerType.Participant))
                                                        .Sum(player => player.NrPoints);
        return Tuple.Create(scoreTeam1, scoreTeam2);
    }


    public Team? FindTeamByName(string teamName)
    {
        return _teamService.FindAll().FirstOrDefault(team => team.Name.Equals(teamName));
    }

    public Game? FindGameByTeamsNames(string firstTeamName, string secondTeamName)
    {
        return _gameService.FindAll().FirstOrDefault(game => game.FirstTeam.Name.Equals(firstTeamName) &&
                                                             game.SecondTeam.Name.Equals(secondTeamName));

    }

    public void Init()
    {
        foreach (var game in _gameService.FindAll())
        {
            var firstTeam = _teamService.FindOne(game.FirstTeam.Id);
            if (firstTeam != null)
                _gameService.FindOne(game.Id)!.FirstTeam = firstTeam;
            var secondTeam = _teamService.FindOne(game.SecondTeam.Id);
            if (secondTeam != null)
                _gameService.FindOne(game.Id)!.SecondTeam = secondTeam;
        }

        foreach (var player in _playerService.FindAll())
        {
            var team = _teamService.FindOne(player.PlayerTeam.Id);
            if(team != null)
                _playerService.FindOne(player.Id)!.PlayerTeam = team;
        }

        foreach (var activePlayer in _activePlayerService.FindAll())
        {
            var team = _teamService.FindOne(activePlayer.PlayerTeam.Id);
            if(team != null)
                _activePlayerService.FindOne(activePlayer.Id)!.PlayerTeam = team;
        }
    }
    
}


