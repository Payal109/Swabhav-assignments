namespace TrafficSignalEnum
{
    //created a class signal first
    internal class Signal
    {
        public enum TrafficLight //this is our enum 
        {
            RED, YELLOW, GREEN
        };

        public void display(TrafficLight traf) //display method to show what driver must do
            //traf indicates the user value jo dega and it must be of type TrafficLight(enum) to compare it with our enums
        {
            if (traf == TrafficLight.RED)   

            {
                Console.WriteLine("Driver should stop!");

            }
            if (traf == TrafficLight.GREEN)

            {
                Console.WriteLine("Driver should go!");

            }
            if (traf == TrafficLight.YELLOW)

            {
                Console.WriteLine("Driver should speed up!");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter signal color (RED, YELLOW, GREEN)");
            string input = Console.ReadLine().ToUpper(); //convert lower to uppper
            TrafficLight traf; //created a variable traf of type trafficlight

            if (Enum.TryParse(input, out traf)) // tries parsing input of user to Enum type, if its successful it stores it in traf and executes the blocks below
            {
                Signal sigobj = new Signal();
                sigobj.display(traf);

            }

            else {

                Console.WriteLine("wrong signal value mentioned"); //if parsing to enum is not successful i.e the user input is not inside our enum it will print this
            }
            


        }
    }
}
