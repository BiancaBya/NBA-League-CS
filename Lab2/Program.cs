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



/*
 Temas:
1, Houston Rockets  
2, Los Angeles Lakers  
3, LA Clippers  
4, Chicago Bulls  
5, Cleveland Cavaliers  
6, Utah Jazz  
7, Brooklyn Nets  
8, New Orleans Pelicans  
9, Indiana Pacers  
10, Toronto Raptors  
11, Charlotte Hornets  
12, Phoenix Suns  
13, Portland TrailBlazers  
14, Golden State Warriors  
15, Washington Wizards  
16, San Antonio Spurs  
17, Orlando Magic  
18, Denver Nuggets  
19, Detroit Pistons  
20, Atlanta Hawks  
21, Dallas Mavericks  
22, Sacramento Kings  
23, Oklahoma City Thunder  
24, Boston Celtics  
25, New York Knicks  
26, Minnesota Timberwolves  
27, Miami Heat  
28, Milwaukee Bucks  



Students:
1, Elev1 , Scoala Gimnaziala “Horea”  
2, Elev2 , Scoala Gimnaziala “Horea”  
3, Elev3 , Scoala Gimnaziala “Horea”  
4, Elev4 , Scoala Gimnaziala “Horea”  
5, Elev5 , Scoala Gimnaziala “Horea”  
6, Elev6 , Scoala Gimnaziala “Horea”  
7, Elev7 , Scoala Gimnaziala “Horea”  
8, Elev8 , Scoala Gimnaziala “Horea”  
9, Elev9 , Scoala Gimnaziala “Horea”  
10, Elev10 , Scoala Gimnaziala “Horea”  
11, Elev11 , Scoala Gimnaziala “Horea”  
12, Elev12 , Scoala Gimnaziala “Horea”  
13, Elev13 , Scoala Gimnaziala “Horea”  
14, Elev14 , Scoala Gimnaziala “Horea”  
15, Elev15, Scoala Gimnaziala “Horea”  
16, Student1 , Scoala Gimnaziala "Octavian Goga"  
17, Student2 , Scoala Gimnaziala "Octavian Goga"  
18, Student3 , Scoala Gimnaziala "Octavian Goga"  
19, Student4 , Scoala Gimnaziala "Octavian Goga"  
20, Student5 , Scoala Gimnaziala "Octavian Goga"  
21, Student6 , Scoala Gimnaziala "Octavian Goga"  
22, Student7 , Scoala Gimnaziala "Octavian Goga"  
23, Student8 , Scoala Gimnaziala "Octavian Goga"  
24, Student9 , Scoala Gimnaziala "Octavian Goga"  
25, Student10 , Scoala Gimnaziala "Octavian Goga"  
26, Student11 , Scoala Gimnaziala "Octavian Goga"  
27, Student12 , Scoala Gimnaziala "Octavian Goga"  
28, Student13 , Scoala Gimnaziala "Octavian Goga"  
29, Student14 , Scoala Gimnaziala "Octavian Goga"  
30, Student15 , Scoala Gimnaziala "Octavian Goga"  
31, Nume1 , Liceul Teoretic "Lucian Blaga"  
32, Nume2 , Liceul Teoretic "Lucian Blaga"  
33, Nume3 , Liceul Teoretic "Lucian Blaga"  
34, Nume4 , Liceul Teoretic "Lucian Blaga"  
35, Nume5 , Liceul Teoretic "Lucian Blaga"  
36, Nume6 , Liceul Teoretic "Lucian Blaga"  
37, Nume7 , Liceul Teoretic "Lucian Blaga"  
38, Nume8 , Liceul Teoretic "Lucian Blaga"  
39, Nume9 , Liceul Teoretic "Lucian Blaga"  
40, Nume10 , Liceul Teoretic "Lucian Blaga"  
41, Nume11 , Liceul Teoretic "Lucian Blaga"  
42, Nume12 , Liceul Teoretic "Lucian Blaga"  
43, Nume13 , Liceul Teoretic "Lucian Blaga"  
44, Nume14 , Liceul Teoretic "Lucian Blaga"  
45, Nume15 , Liceul Teoretic "Lucian Blaga"  

Players:
1, Elev1 , Scoala Gimnaziala “Horea”, 1, Houston Rockets   
2, Elev2 , Scoala Gimnaziala “Horea”, 1, Houston Rockets   
3, Elev3 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
4, Elev4 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
5, Elev5 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
6, Elev6 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
7, Elev7 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
8, Elev8 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
9, Elev9 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
10, Elev10 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
11, Elev11 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
12, Elev12 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
13, Elev13 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
14, Elev14 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
15, Elev15, Scoala Gimnaziala “Horea”  , 1, Houston Rockets 
16, Student1 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers    
17, Student2 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers  
18, Student3 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers  
19, Student4 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
20, Student5 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
21, Student6 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
22, Student7 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
23, Student8 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
24, Student9 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
25, Student10 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
26, Student11 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
27, Student12 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
28, Student13 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
29, Student14 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
30, Student15 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers 
31, Nume1 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
32, Nume2 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
33, Nume3 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
34, Nume4 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
35, Nume5 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
36, Nume6 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
37, Nume7 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
38, Nume8 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
39, Nume9 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
40, Nume10 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
41, Nume11 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
42, Nume12 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
43, Nume13 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
44, Nume14 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 
45, Nume15 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers 

Active Players:
1, Elev1 , Scoala Gimnaziala “Horea”, 1, Houston Rockets, 1, 10, Participant   
2, Elev2 , Scoala Gimnaziala “Horea”, 1, Houston Rockets, 1, 5, Participant   
3, Elev3 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 1, 2, Participant 
4, Elev4 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 1, 10, Participant 
5, Elev5 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 1, 0, Substitute 
6, Elev6 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 1, 0, Substitute  
7, Elev7 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 2, 1, Substitute 
8, Elev8 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets, 2, 10, Participant 
9, Elev9 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 10, Participant 
10, Elev10 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 8, Participant 
11, Elev11 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 9, Participant 
12, Elev12 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 2, Participant 
13, Elev13 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 3, Participant 
14, Elev14 , Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 5, Participant 
15, Elev15, Scoala Gimnaziala “Horea”  , 1, Houston Rockets , 2, 4, Participant 
16, Student1 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers,  1, 10, Participant   
17, Student2 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers  ,  1, 5, Participant 
18, Student3 , Scoala Gimnaziala "Octavian Goga" , 2, Los Angeles Lakers  ,  1, 4, Substitute 
19, Student4 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 0, Participant 
20, Student5 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 2, Substitute
21, Student6 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 5, Participant 
22, Student7 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 9, Participant 
23, Student8 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 1, Participant 
24, Student9 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers ,  1, 2, Participant 
25, Student10 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 5, Participant
26, Student11 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 5, Participant
27, Student12 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 2, Substitute
28, Student13 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 4, Participant
29, Student14 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 2, Participant
30, Student15 , Scoala Gimnaziala "Octavian Goga"  , 2, Los Angeles Lakers , 3, 1, Participant
31, Nume1 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 10, Participant
32, Nume2 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 1, Participant
33, Nume3 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 2, Participant
34, Nume4 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 7, Participant
35, Nume5 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 10, Substitute
36, Nume6 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 6, Participant
37, Nume7 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 4, Substitute
38, Nume8 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 5, Participant
39, Nume9 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 10, Participant
40, Nume10 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 2, 10, Substitute
41, Nume11 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 3, 5, Participant
42, Nume12 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 3, 5, Participant
43, Nume13 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 3, 5, Participant
44, Nume14 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 3, 5, Participant
45, Nume15 , Liceul Teoretic "Lucian Blaga"  , 3, LA Clippers , 3, 5, Participant


Games:
1, Houston Rockets , Los Angeles Lakers ,10/10/2024   
2, Houston Rockets, LA Clippers ,12/12/2025    
3, Los Angeles Lakers , LA Clippers ,10/10/2024   

*/