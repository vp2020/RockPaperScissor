using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            int draw = 0;

            while (scoreCPU < 3 && scorePlayer < 3)
            {
                Console.WriteLine("Choose between ROCK, PAPER, SCISSOR");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();
                if (inputPlayer == "EXIT")
                {
                    Console.WriteLine("PLAYER CHOSE TO EXIT");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);
                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("CPU chose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            Console.Write("DRAW!!\n\n");
                            draw++;
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.Write("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.Write("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("CPU chose PAPER");
                        if (inputPlayer == "ROCK")
                        {
                            Console.Write("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.Write("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.Write("DRAW!!\n\n");
                            draw++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSOR";
                        Console.WriteLine("CPU chose SCISSOR");
                        if (inputPlayer == "ROCK")
                        {
                            Console.Write("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.Write("DRAW!!\n\n");
                            draw++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.Write("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            }

            Console.WriteLine("SCORE OF CPU: " + scoreCPU);
            Console.WriteLine("SCORE OF PLAYER: " + scorePlayer);
            Console.WriteLine("TOTAL DRAWS: " + draw);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            if (scorePlayer == 3)
            {
                Console.WriteLine("WOAH!!! PLAYER WINS");
            }
            if (scoreCPU == 3)
            {
                Console.WriteLine("WOAH!!! CPU WINS");
            }
            Console.ReadLine();
        }
    }
}
