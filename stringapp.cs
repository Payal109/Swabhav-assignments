namespace StringManipulation
{
    internal class StringTask
    {
        static void Main(string[] args)
        {
            string input = args[0];
            string[] parts = input.Split(',');

            Console.WriteLine("Developer name is : " + parts[0]);
            Console.WriteLine("Company name is : " + parts[1]);
            Console.WriteLine($"Location is : {parts[2]}"); 
        }
    }
}
