namespace Reverse_a_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter to REVERSE A NUM");
            int num = Convert.ToInt32 (Console.ReadLine());
            int original_num = num;
            int reverse=0;
            int digit;
            while (num > 0)
            {
                digit = num % 10;
                reverse = reverse * 10 + digit; ;
                num /= 10;

            }
        Console.WriteLine($"The reverse of {original_num} is {reverse}");
            if (reverse == original_num) 
            {
                Console.WriteLine(" The number is Palindrome");
            }
            else 
            { Console.WriteLine("Number is not a Palindrome"); }
        }
    }
}
