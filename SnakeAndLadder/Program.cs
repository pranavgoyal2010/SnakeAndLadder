// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Transactions;

namespace SnakeAndLadder;

class Program
{
    static void Main(string[] args)
    {



        /*Console.WriteLine(player1.ToString() + " current position : " + player1.PlayerPosition);
        Console.WriteLine(player2.ToString() + " current position : " + player2.PlayerPosition);

        Random random = new Random();

        int countOfDieThrows = 0;
        
        int currentPlayer = 0;

        while(player1.PlayerPosition<100 && player2.PlayerPosition<100)
        {
            //Console.WriteLine();
            int valueOnDie = random.Next(1, 7);
            Console.WriteLine("Value on Die : " + valueOnDie);
            countOfDieThrows++;

            int option = random.Next(0, 3);
            Console.WriteLine("Option : " + option);

            switch (option)
            {
                case 0:  //option is no play
                    Console.WriteLine("No Play");
                    break;
                case 1:  //option is ladder
                    Console.WriteLine("Encountered Ladder");
                    
                    if(currentPlayer==0)
                    
                    player1.PlayerPosition += valueOnDie;
                    
                    if (player1.PlayerPosition > 100)
                        player1.PlayerPosition -= valueOnDie;
                    
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

        Console.WriteLine("Number of times the die was played : " + countOfDieThrows);*/

        Game game = new Game(2);
        game.Play();
    }
}

