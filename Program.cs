using System;

namespace RockPS
{
    class Program
    {
           struct Player{
              public int score;
              public String name; 
              public Player(int myScore, String myName){
                  score = myScore;
                  name = myName;
              }
           }
        static void Main(string[] args)
        {
        
            Console.WriteLine("Player name: ");
            String playerName = Console.ReadLine();
            Player newPlayer = new Player(0,playerName);

           int myChoice = displayMenu();
           while(myChoice != 3){
           switch(myChoice){
                case 1:
                myChoice = mainGame(newPlayer);
                break;
                case 2:
                myChoice = displayMenu();
                break;
                case 3:
                break;
                }
            }
            Console.WriteLine("Thanks for Playing!");

           int displayMenu(){
           Console.Clear();
           Console.WriteLine("Menu:");
           Console.WriteLine("1: new game");
           Console.WriteLine("2: show menu");
           Console.WriteLine("3: leave the game"); 
           int playSelect=0;
           while(true){
               String myTemp = Console.ReadLine();
               if(!Int32.TryParse(myTemp, out playSelect)) {
                Console.WriteLine("must be a number on menue");
                }
                else if(playSelect > 3 || playSelect< 1){
                    Console.WriteLine("must be in range of menu");
                }
                else{
                    break;
                }
            }
            return playSelect;

            }

            int mainGame(Player thePlayer){
             int compChoice = 0;
             Random rand = new Random();
             Console.Clear();
             bool keepPlaying = true;
             while(keepPlaying){
                compChoice = rand.Next(1,4);
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.WriteLine("4: Exit");
                int playerChoice = 0;
                bool gotChoice = false;
                while(!gotChoice){
                    String myTemp = Console.ReadLine();
                    if(!Int32.TryParse(myTemp, out playerChoice)) {
                    Console.WriteLine("must be a number");
                    }
                    else if(playerChoice > 4 || playerChoice< 1){
                        Console.WriteLine("must be in range");
                    }
                    else{
                        gotChoice = true;
                    }
                }
                String playString = "";
                switch(playerChoice){
                    case 1:
                    playString = "Rock";
                    break;
                    case 2:
                    playString = "Paper";
                    break;
                    case 3:
                    playString = "Scissors";
                    break;
                    case 4:
                    break;
                    default:
                    Console.WriteLine("Error on Player Selection");
                    keepPlaying = false;
                    break;
                }
                String compString = "";
                switch(compChoice){
                    case 1:
                    compString = "Rock";
                    break;
                    case 2:
                    compString = "Paper";
                    break;
                    case 3:
                    compString = "Scirrors";
                    break;
                    default:
                    Console.WriteLine("Error on Computer Selection");
                    keepPlaying = false;
                    break;
                }
                if(playerChoice == compChoice){
                    Console.WriteLine($"You: {playString} Computer: {compString}  ");
                    Console.WriteLine($"Tie! Player score is {thePlayer.score}");
                }
                else if(playerChoice == 1 ){
                    if(compChoice == 2){
                        thePlayer.score--;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Rock had no impact, Player score is {thePlayer.score}");
                    }
                    else{
                        thePlayer.score++;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Rock was super effective! Player score is {thePlayer.score}");
                    }
                }
                else if(playerChoice == 2){
                    if(compChoice == 3){
                        thePlayer.score--;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Paper had no impact, Player score is {thePlayer.score}");
                    }
                    else{
                        thePlayer.score++;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Paper was super effective! Player score is {thePlayer.score}");
                    }
                }
                else if(playerChoice == 3){
                    if(compChoice == 1){
                        thePlayer.score--;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Scissors had no impact, Player score is {thePlayer.score}");
                    }
                    else{
                        thePlayer.score++;
                        Console.WriteLine($"You: {playString} Computer: {compString}  ");
                        Console.WriteLine($"Scissors was super effective! Player score is {thePlayer.score}");
                    }
                }

                if(playerChoice == 4){
                    Console.WriteLine("leaving game");
                    keepPlaying = false;
                }
                Console.WriteLine("");

                }
            return 2;
            }
        }
    }
}
