namespace ProductApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int DiscountPercentage {  get; set; }

        public Product() { }
        public Product (int id, string name, double price, int discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        } 

        public double ReturnCost( double Price, int DiscountPercentage)
        {  
            double FinalPrice = Price - (Price * DiscountPercentage/100);
            return FinalPrice;
        }
        
    }
    internal class Test
    {

        static void Main(string[] args)
        {    //create 1st product ka object
            Product prod1 = new Product();
            prod1.Id = 1;
            prod1.Name = "Perfume";
            prod1.Price = 100;
            prod1.DiscountPercentage = 10;

            //create second product ka object
            Product prod2 = new Product();
            prod2.Id = 2;
            prod2.Name = "Phone";
            prod2.Price = 17000;
            prod2.DiscountPercentage = 20;

            double dis_price1 = prod1.ReturnCost(prod1.Price, prod1.DiscountPercentage);

            double dis_price2 = prod2.ReturnCost(prod2.Price, prod2.DiscountPercentage);


            Console.WriteLine($" Product ID : {prod1.Id}");
            Console.WriteLine($" Product name : {prod1.Name}");
            Console.WriteLine($" Product Price original : {prod1.Price}");
            Console.WriteLine($" Discounted Price : {dis_price1}");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($" Product ID : {prod2.Id}");
            Console.WriteLine($" Product name : {prod2.Name}");
            Console.WriteLine($" Product Price original : {prod2.Price}");
            Console.WriteLine($" Discounted Price : {dis_price2}");



        }



    }
}
