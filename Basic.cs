namespace BasicStatsCommandLine
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];
            int count = 0;
            int sum = 0;
            int avg = 0;
        

            for (int i = 0; i < args.Length; i++)
            {

                arr[i] = int.Parse(args[i]);
            
            
            }
            

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(arr[i]);
                //SUM
            }
            for (int i = 0; i < args.Length; i++)
            {
                sum = sum + arr[i];
            }
            //max and min
            int max = arr[0], min = arr[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (arr[i]> max)
                {
                    max = arr[i];
                }
                    }
            for (int i = 0; i < args.Length; i++)
            {
                if (arr[i] < min)
                {
                    min= arr[i];
                }
            }
            //average 
            avg = sum / arr.Length;
            Console.WriteLine("the sum is " + sum);
            Console.WriteLine("the average is" + avg);
            Console.WriteLine("the max element is " + max);
            Console.WriteLine("the min element is " + min);
            Console.WriteLine("the count of elements is " + arr.Length);
        }
    }
}
