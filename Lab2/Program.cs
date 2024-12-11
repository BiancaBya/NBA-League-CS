using Lab2.Repository;
using Lab2.Service;
using Lab2.Ui;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var teamRepository = new TeamFileRepository(@"C:\Users\Next\RiderProjects\Lab2\Lab2\Data\teams.txt"); 
            var gameRepository = new GameFileRepository(@"C:\Users\Next\RiderProjects\Lab2\Lab2\Data\games.txt");
            var studentRepository = new StudentFileRepository(@"C:\Users\Next\RiderProjects\Lab2\Lab2\Data\students.txt");
            var playerRepository = new PlayerFileRepository(@"C:\Users\Next\RiderProjects\Lab2\Lab2\Data\players.txt");
            var activeplayersRepository = new ActivePlayerFileRepository(@"C:\Users\Next\RiderProjects\Lab2\Lab2\Data\activeplayers.txt");

            var teamService = new TeamService(teamRepository);
            var gameService = new GameService(gameRepository);
            var studentService = new StudentService(studentRepository);
            var playerService = new PlayerService(playerRepository);
            var activePlayerService = new ActivePlayerService(activeplayersRepository);
            
            var mainService = new MainService(teamService, gameService, studentService, playerService, activePlayerService);
            
            mainService.Init();
            
            var ui = new Ui.Ui(mainService);
            
            ui.Run();
        }
    }
}



