namespace BankAppGame
{
    internal class BankAccount
    {
        public int AccountHolder {  get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountholder, double balance)
        {
            this.AccountHolder = accountholder;
            this.Balance = balance;
        }

        public void withdraw(double amount)
        {
            
            Balance = Balance - amount;
        }

        public void deposit(double amount)
        {
            
            Balance = Balance + amount;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            BankAccount account1 = new BankAccount(1, rand.Next(5000, 10000));
            BankAccount account2 = new BankAccount(2, rand.Next(5000, 10000));

            // rand.Next jo upar braces me h me usko alag variable me bhi rakh skti hu 
            // like 


            //double b1,b2;


            //b1 = rand.Next(5000, 10001);
            //b2 = rand.Next(5000, 10001);
            //BankAccount account1 = new BankAccount(1, b1);
            //BankAccount account2 = new BankAccount(2, b2);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ROUND : " + (i + 1));
                Console.WriteLine($"Account {account1.AccountHolder} - withdraw or deposit(w/d)?");
                string action = Console.ReadLine();
                Console.WriteLine("Enter amount : ");
                double amount = Convert.ToInt32(Console.ReadLine());

                if (action == "w")
                {
                    account1.withdraw(amount);
                }

                else if (action == "d")
                {
                    account1.deposit(amount);
                }

                
                Console.WriteLine($"Account {account2.AccountHolder} - withdraw or deposit(w/d)?");
                string action1 = Console.ReadLine();
                Console.WriteLine("Enter amount : ");
                double amount1 = Convert.ToInt32(Console.ReadLine());

                if (action1 == "w")
                {
                    account2.withdraw(amount1);
                }

                else if (action1 == "d")
                {
                    account2.deposit(amount);
                }
            }


            Console.WriteLine("--AFTER 3 ROUNDS_____");
            Console.WriteLine($" account {account1.AccountHolder} balance = {account1.Balance}");
            Console.WriteLine($" account {account2.AccountHolder} balance = {account2.Balance}");

            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine("Account 1 WINS");
            }

            else if (account1.Balance < account2.Balance)
            {
                Console.WriteLine("Account 2 WINS");
            }

            else
            {
                Console.WriteLine("ITS A tie");
            }
        }
    }
}
