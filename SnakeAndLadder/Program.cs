// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

namespace SnakeAndLadder;

class Program
{
    static void Main(string[] args)
    {
        //Initializing player's position to 0
        int playerPosition = 0;
        
        Random random = new Random();

        int valueOnDie = random.Next(1,7);
        Console.WriteLine(valueOnDie);
    }
}

