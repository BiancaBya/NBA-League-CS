using Lab2.Domain;
using Lab2.Service;

namespace Lab2.Ui;

public class Ui
{
    private MainService Service;
    
    public Ui(MainService service) => Service = service;

    private void Menu()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("1. Print team's players");
        Console.WriteLine("2. Print team's active players from a game");
        Console.WriteLine("3. Print all games from a date range");
        Console.WriteLine("4. Print game's score");
        Console.WriteLine("5. Exit");
        Console.WriteLine("---------------------------------------------------------");
    }


    public void Run()
    {
        while (true)
        {
            Menu();
            var input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        
                        Console.WriteLine("Enter team's name: ");
                        var teamName = Console.ReadLine();
                        if (teamName != null)
                        {
                            Team? team = Service.FindTeamByName(teamName.Trim());
                            if (team != null)
                            {
                                var players = Service.GetTeamPlayers(team);
                                Console.WriteLine($"Team: {teamName}, Players: ");
                                foreach (var player in players)
                                {
                                    Console.WriteLine(player);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Team doesn't exist");
                            }
                        }
                        
                            
                        break;
                    
                    case 2:
                        
                        Console.WriteLine("Enter first team's name : ");
                        var firstTeamName = Console.ReadLine();
                        Console.WriteLine("Enter second team's name : ");
                        var secondTeamName = Console.ReadLine();
                        
                        if (firstTeamName != null && secondTeamName != null)
                        {
                            Game? game = Service.FindGameByTeamsNames(firstTeamName, secondTeamName);
                            if (game != null)
                            {
                                Team? team = Service.FindTeamByName(firstTeamName.Trim());
                                var activePlayers = Service.GetActivePlayersFromGame(game, team);
                                Console.WriteLine($"Team: {firstTeamName}, Players: ");
                                foreach (var player in activePlayers)
                                {
                                    Console.WriteLine(player + " ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Game doesn't exist");
                            }
                        }
                        
                        break;
                    
                    case 3:
                        
                        Console.WriteLine("Enter start date: ");
                        string? startDate = Console.ReadLine();
                        if (!DateTime.TryParse(startDate, out DateTime startDateParsed))
                            Console.WriteLine("Invalid start date");
                        
                        Console.WriteLine("Enter end date: ");
                        string? endDate = Console.ReadLine();
                        if (!DateTime.TryParse(endDate, out DateTime endDateParsed))
                            Console.WriteLine("Invalid end date");
                        
                        var games = Service.GetGamesFromDates(startDateParsed, endDateParsed);
                        Console.WriteLine($"Games: ");
                        foreach (var game in games)
                        {
                            Console.WriteLine(game + " ");
                        }
                        
                        break;
                    
                    case 4:
                        
                        Console.WriteLine("Enter first team's name : ");
                        var firstTeamsName = Console.ReadLine();
                        Console.WriteLine("Enter second team's name : ");
                        var secondTeamsName = Console.ReadLine();
                        
                        if (firstTeamsName != null && secondTeamsName != null)
                        {
                            Game? game = Service.FindGameByTeamsNames(firstTeamsName, secondTeamsName);
                            if (game != null)
                            {
                                var score = Service.GetScoreFromGame(game);
                                Console.WriteLine($"Score: {game.FirstTeam.Name}: {score.Item1} / {game.SecondTeam.Name}: {score.Item2}");
                            }
                            else
                            {
                                Console.WriteLine("Game doesn't exist");
                            }
                        }
                        
                        break;
                    
                    case 5:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
            
            if(option == 5)
                break;
        }
    }
}

