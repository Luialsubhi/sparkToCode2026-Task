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
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "Karim";
            account1.Balance= 120;

            BankAccount account2 = new BankAccount();
            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

            Student student1 = new Student();
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade= 65;

            Student student2 = new Student();
            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;

            product product1=new product();
            product1.productName = "wireless mouse";
            product1.Price =5.500;
            product1.StockQuantity = 50;

            product product2=new product();
            product2.productName = "mechanical keyboard";
            product2.Price = 16.750;
            product2.StockQuantity =20;

            Console.WriteLine("object created successfully";
            Console.ReadLine();

        }
    }
}
