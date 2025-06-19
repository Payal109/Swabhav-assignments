namespace numberguessinggame
{
    internal class Program
 

    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Number_to_guess ; 

            int your_guess = 0;
            int Max_possible_attempts = 5;
            string play;
            int i;

                do
                {
                     Number_to_guess = rand.Next(100);

                     for (i = 0; i < Max_possible_attempts; i++)
                     {   
                            
                            Console.Write(Number_to_guess);

                            Console.Write(" enter your guess value : ");

                            your_guess = Convert.ToInt32(Console.ReadLine());

                            
                                if (your_guess > Number_to_guess)
                                {
                                    Console.WriteLine("sorry too high");

                                }

                                else if (your_guess < Number_to_guess)
                                {
                                    Console.WriteLine("sorry too low");
                                }
                                else if (your_guess == Number_to_guess)
                                {
                                    Console.WriteLine("CORRECTLY GUESSED");
                                    break;
                                   }
                     }
                if (i == Max_possible_attempts)
                { Console.WriteLine("SORRY YOU failed TO GUESS "); }

                    Console.WriteLine("Do you want to playy the game? Y/N ");

                    play = Console.ReadLine();

                } while (play == "Y");


                Console.WriteLine("GAME ENDED ! ");

        }
           
    }
}


