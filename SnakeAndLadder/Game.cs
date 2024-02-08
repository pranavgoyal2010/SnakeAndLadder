using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Game
    {
        private Player[] players;
        private int numOfPlayers;

        public Game(int numOfPlayers)
        {
            this.numOfPlayers = numOfPlayers;
            players = new Player[this.numOfPlayers];
            for (int i = 0; i < this.numOfPlayers; i++)
            {
                players[i] = new Player(i + 1);
            }
        }

        public void Play()
        {
            int currentPlayer = 0;

            Random random = new Random();

            int countOfDieThrows = 0;

            while (true)
            {
                
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

                        players[currentPlayer].PlayerPosition += valueOnDie;

                        if (players[currentPlayer].PlayerPosition == 100)
                            break;

                        else if (players[currentPlayer].PlayerPosition > 100)
                            players[currentPlayer].PlayerPosition -= valueOnDie;

                        Console.WriteLine(players[currentPlayer].ToString() + " new position : " + players[currentPlayer].PlayerPosition);
                        Console.WriteLine(players[currentPlayer].ToString() + " gets to play again");
                        Console.WriteLine("-------------------------------------");

                        continue;

                    case 2:  //option is snake
                        Console.WriteLine("Encountered Snake");
                        //if (players[currentPlayer].PlayerPosition - valueOnDie >= 0)
                        players[currentPlayer].PlayerPosition -= valueOnDie;
                        if (players[currentPlayer].PlayerPosition < 0)
                            players[currentPlayer].PlayerPosition = 0;


                        break;

                }

                Console.WriteLine(players[currentPlayer].ToString() + " new position : " + players[currentPlayer].PlayerPosition);
                Console.WriteLine("-------------------------------------");

                if (players[currentPlayer].PlayerPosition == 100)
                {
                    Console.WriteLine(players[currentPlayer] + " Wins");
                    break;
                }

                currentPlayer = (currentPlayer + 1) % numOfPlayers;

            }


            Console.WriteLine("The number of times die was played : " + countOfDieThrows);
        }
    }
}
    

