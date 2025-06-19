using System;

namespace BookDiscountCalculator
{
    class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool isBestSeller { get; set; }
        static void Main(string[] args)
        {
            Book obj1 = new Book();

            Console.WriteLine("enter details for book 1 ");
            Console.WriteLine("Title : ");
            obj1.Title = Console.ReadLine();

            Console.WriteLine("Enter author name");
            obj1.Author = Console.ReadLine();

            Console.WriteLine("Enter price");
            obj1.Price= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("IS bestseller (Y/N)");
            string input = Console.ReadLine();
            obj1.isBestSeller = input.ToUpper() == "Y";
          


            Book obj2 = new Book();

            Console.WriteLine("Enter details for book 2");
            Console.WriteLine("Title : ");
            obj2.Title = Console.ReadLine();

            Console.WriteLine("Enter author name");
            obj2.Author = Console.ReadLine();

            Console.WriteLine("Enter price");
            obj2.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("IS bestseller (Y/N)");
            string input2 = Console.ReadLine();
            obj2.isBestSeller = input2.ToUpper() == "Y";

            double discountBook1 = obj1.DiscountedPriceCalulator();
            double discountBook2 = obj2.DiscountedPriceCalulator();

            Console.WriteLine(" BOOK 1 ");
            Console.WriteLine(" TITLE : " + obj1.Title);
            Console.WriteLine(" AUTHOR : " + obj1.Author);
            Console.WriteLine(" ORGINAL PRICE : " + obj1.Price);
            Console.WriteLine("DISCOUNTED PRICE : " + discountBook1);

            Console.WriteLine(" BOOK 2 ");
            Console.WriteLine(" TITLE : " + obj2.Title);
            Console.WriteLine(" AUTHOR : " + obj2.Author);
            Console.WriteLine(" ORGINAL PRICE : " + obj2.Price);
            Console.WriteLine("DISCOUNTED PRICE : " + discountBook2);

        }

        public double DiscountedPriceCalulator()
        {
            double DiscountedPrice = Price;

            if(isBestSeller && Price > 500)
            {
                DiscountedPrice = Price - Price * 0.10;
                DiscountedPrice = DiscountedPrice - DiscountedPrice * 0.05;
            }

            else if (isBestSeller)
            {
                DiscountedPrice = Price - Price * 0.10;
               
            }


            else if (Price > 500)
            {
                DiscountedPrice = Price - Price * 0.05;
            }
                
            return DiscountedPrice;
        
        
        }
    }
}
