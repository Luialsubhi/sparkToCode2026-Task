namespace OOPtask
{
     public class BankAccount
    {
        public int AccountNumber; 
        public string HolderName;
        public double Balance;

        public void Deposit (double amount) 
        { 
            Balance += amount;
            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("insufficent balance");
            }
        }
        public double ChaeckBalance()
        {
            printInformation();
            return Balance;

        }
        public void printInformation()
        {
            Console.WriteLine("holder name" + HolderName);
            Console.WriteLine("balance: "+Balance);
        }
        public void SendEmail()
        {
            Console.WriteLine("email intinfication sent ");
        }
    }
    public class Student
    {
        public int Grade;
        public string Name;
        public string Address;

        private string email;
        int age;

        public void Register(string Email)
        {
            email= Email;
            SendEmail();
            
        }
        public void SendEmail()
        {
            Console.WriteLine("Registration email  sent ");
        }
    }
    public class product
    {
        public string productName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("not enough stock");

            }
            LogTransaction();

        }
        public void Restock(int quantity) 
        { 
            StockQuantity += quantity;
        
        }
        public double GetInventoryValue() 
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        public void PrintDetails() 
        {
            Console.WriteLine("product" + productName);
            Console.WriteLine("price"+Price);
            Console.WriteLine("stock" + StockQuantity);
        }
        public void LogTransaction()
        { 
            Console.WriteLine("Transaction logged");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
