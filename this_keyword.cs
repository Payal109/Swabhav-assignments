namespace thisKeyword
{
     class This_keyword
    {
        //these are fields i.e varibales declared inside class but outside a method
        public string Name { get; set; }
        public double Price { get; set; }

        //
        public This_keyword(string name, double price)
        {
            this.Name = name; //this.Name refers to field and name is the paramter passed while calling
            this.Price = price;
        }

        public void display()
        {
            Console.WriteLine($"Car Brand : {this.Name}");
            Console.WriteLine($"Price : {this.Price}");

        }
        static void Main(string[] args)
        {
            This_keyword car1 = new This_keyword("Toyota", 45000);
            car1.display();
            Console.WriteLine("enter 2nd car name and price");
            string input = Console.ReadLine();
            double input2 = Convert.ToInt32(Console.ReadLine());
            This_keyword car2 = new This_keyword(input, input2);
            car2.display();
        }
    }
}
