// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace SnakeAndLadder;

class Program
{
    static void Main(string[] args)
    {
        //Initializing player's position to 0
        int playerPosition = 0;
        Console.WriteLine("Player's current position : " + playerPosition);
        
        Random random = new Random();

        

        while(playerPosition < 100)
        {
            int valueOnDie = random.Next(1, 7);
            Console.WriteLine("Value on Die : " + valueOnDie);

            int option = random.Next(0, 3);
            Console.WriteLine("Option : " + option);

            switch (option)
            {
                case 0:  //option is no play
                    Console.WriteLine("No Play");
                    break;
                case 1:  //option is ladder
                    Console.WriteLine("Encountered Ladder");                    
                    playerPosition += valueOnDie;
                    break;
                case 2:  //option is snake
                    Console.WriteLine("Encountered Snake");
                    if (playerPosition - valueOnDie >= 0)
                        playerPosition -= valueOnDie;
                    else
                        playerPosition = 0;

                    break;
                
            }
            Console.WriteLine("Player's new position : " + playerPosition);
            Console.WriteLine("-------------------------------------");
        }
        
       
    }
}

