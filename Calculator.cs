namespace MethodOverloading
{
    internal class Calculator
    {

       
       

        static void Main(string[] args)
        {
            int n1 = 3;
            int n2 = 5;

            double a1 = 4.5;
            double a2 = 7.8;

            //created obj for accessing those add methods
            Calculator obj = new Calculator();

            Console.WriteLine("the sum of int values is " + obj.Add(n1, n2));

            Console.WriteLine("the sum of int values is " + obj.Add(a1, a2));

            // or directly 
            Console.WriteLine("LETS PASS PARAMS DIRECTLY");
            Console.WriteLine("the sum of int values is " + obj.Add(3, 1));

            Console.WriteLine("the sum of int values is " + obj.Add(9.2, 1.8));

            int[] arr = new int[5];
            int len = arr.Length;

            for (int i = 0; i < len; i++) 
            {

                Console.WriteLine("enter array element for adding");
                arr[i] =Convert.ToInt32(Console.ReadLine());
            
            }
          
            

            Console.WriteLine("the sum of array is " + obj.Add(arr));

        }

        public int Add(int a, int b)
        { return a + b; }

        public double Add(double a, double b) { return a + b; }


        public int Add(int[] arr)
        {
            int sum = 0;

            if (arr == null)
            {
                Console.WriteLine("input array is null or empty");
                return 0;
            
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }


    }
}
