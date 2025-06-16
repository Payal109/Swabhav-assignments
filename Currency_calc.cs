namespace currency_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---currency calc---");
            Console.WriteLine("enter a value");
            int amount = Convert.ToInt32(Console.ReadLine());
            int count=0, count1=0, count2=0, count3=0;
            if (amount > 50000)

            {
                Console.WriteLine("amount should be less than 50000");
            }
            else
            {
                while (amount > 0)
                {
                    while (amount >= 2000)
                    {

                        amount = amount - 2000;
                        count++;
                    }
                    Console.WriteLine("Two thousand : " + count);

                    while (amount >= 500)
                    {

                        amount = amount - 500;
                        count1++;
                    }
                    Console.WriteLine("five hundred : " + count1);

                    while (amount >= 200)
                    {

                        amount = amount - 200;
                        count2++;
                    }
                    Console.WriteLine("five hundred : " + count2);

                    while (amount >= 100)
                    {

                        amount = amount - 100;
                        count3++;
                    }
                    Console.WriteLine("five hundred : " + count3);
                }
            }
            }
        }
    }

