namespace PlanetEnum
{
    internal class Planet
    {

        public enum Planett
        {
            MERCURY, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
        }

        public string Name { get; set; }
        public double GravityFactor { get; set; }

        public Planet(string name, double gravityFactor)
        {
            this.Name = name;
            this.GravityFactor = gravityFactor;
        }

       
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>()
        {
            new Planet("MERCURY" , 0.38),
            new Planet("VENUS" , 0.91),
            new Planet("EARTH" , 1.0),
            new Planet("MARS" , 0.38),
            new Planet("SATURN" , 1.06),
            new Planet("URANUS" , 0.92),
            new Planet("NEPTUNE" , 1.19),
        };
            Console.WriteLine("enter weight on earth");


            double weightOnEarth = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < planets.Count; i++)
            {
                double newWeight = weightOnEarth * planets[i].GravityFactor;
                Console.WriteLine($"Weight on {planets[i].Name} is {newWeight:F2}");
            }
        }
    }
}
