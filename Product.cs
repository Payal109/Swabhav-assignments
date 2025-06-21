namespace ProductApp
{
    internal class Product
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            { if (value < 0)
                    throw new ArgumentOutOfRangeException("value cant be negavtive");
            
            else  id = value; 
            }

            }
        
       
        public string Name { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("value of price cant be negavtive");
                else price = value;
            }
        }
        private double discountpercentage;
        public double DiscountPercentage
        {
            get { return discountpercentage; }
            set
            {
                if (value >= 100)
                    throw new ArgumentOutOfRangeException("value of discount is unacceptable");
                else discountpercentage = value;
            }
        }

        public Product() { }
        public Product(int id, string name, double price, double discountPercentage)
        {
            this.Id = id;
            this.Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double ReturnCost( double Price, double DiscountPercentage)
        {  
            double FinalPrice = Price - (Price * (DiscountPercentage/100));
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
            Console.WriteLine("enter price of product 2 ");
            int pp = Convert.ToInt32(Console.ReadLine());
            prod2.Price = pp;
           
            prod2.DiscountPercentage = 20;

            double dis_price1 = prod1.ReturnCost(prod1.Price, prod1.DiscountPercentage);

            double dis_price2 = prod2.ReturnCost(pp, prod2.DiscountPercentage);


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
