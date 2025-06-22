namespace WeekEnum
{
    internal class Week
    {
        public enum Day
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday }
        
        static void Main(string[] args)
        {
            Day today = Day.Monday;
            Console.WriteLine(today);
            Console.WriteLine("enter a number (1-7)");
            int input = Convert.ToInt32(Console.ReadLine());
            Day selectedday = (Day)input;
            Console.WriteLine($"Day is : {selectedday}");
        }
    }
}
