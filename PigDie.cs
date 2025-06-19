using System;

namespace PigDieGame
{
    internal class Pig_Die
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--WELCOME TO PIG DIE---");
            int numberOfTurns = 0;
            int totalScore = 0;
            int die;
            Random ran = new Random();
            do
            {
                int turnScore = 0;
                numberOfTurns++;
                Console.WriteLine(" TURN -- " + numberOfTurns);
                string choice = "";

                
                    Console.WriteLine("roll or hold? (r/h)");
                    choice = Console.ReadLine();
                while (choice == "r")
                {
                    die = ran.Next(1, 7);
                    Console.WriteLine("DIE : " + die);

                    if (die == 1)
                    {
                        Console.WriteLine("TURN OVER. NO SCORE");
                        turnScore = 0;
                        break;


                    }
                    else
                    {
                        turnScore = turnScore + die;
                        Console.WriteLine($"Turn score : {turnScore}");
                        Console.WriteLine("roll or hold? (r/h)");
                        choice = Console.ReadLine();


                    }
                }
                    

                
            if (choice == "h")
             {
             totalScore = totalScore + turnScore;
             Console.WriteLine($"Score for turn : {turnScore}");
              Console.WriteLine($"Total Score : {totalScore}");

             }
            } while (totalScore < 20);

            Console.WriteLine($"you finished in {numberOfTurns} turns ");
        }
    }
}
