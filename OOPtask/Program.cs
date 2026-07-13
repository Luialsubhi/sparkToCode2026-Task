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

            Console.WriteLine("object created successfully");
            Console.ReadLine();

            ///////////////////////////////////////////////////////////////
            ////case 1
            //Console.WriteLine("choose");
            //Console.WriteLine("1.Karim");
            //Console.WriteLine("2. Ali");

            //int choice = Convert.ToInt32(Console.ReadLine());
            //if (choice == 1)
            //{
            //    account1.ChaeckBalance();
            //}
            //else if (choice == 2) 
            //{ 
            //    account2.ChaeckBalance();
            //}
            //else
            //{
            //    Console.WriteLine("invalid choise");
            //}
            //Console.ReadLine();

            ///////////////////////////////////////////////////////////////
            ////case 2
            //Console.WriteLine("choose");
            //Console.WriteLine("1.Ali");
            //Console.WriteLine("2. Ahmed");

            //int choice2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the new adderse");
            //string newAddress = Console.ReadLine();

            //if (choice2 == 1)
            //{
            //    student1.Address = newAddress;
            //    Console.WriteLine("new adders   " + student1.Address);

            //}
            //else if (choice2 == 2)
            //{
            //    student2.Address = newAddress;
            //    Console.WriteLine("new addres" + student2.Address);
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            ///////////////////////////////////////////////////////////
            ////case 3
            //Console.WriteLine("choose");
            //Console.WriteLine("1.Karim");
            //Console.WriteLine("2. Ali");

            //int choice3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the amount ");
            //double amount = Convert.ToDouble(Console.ReadLine());

            //if (choice == 1)
            //{
            //    account1.Deposit(amount);
            //    Console.WriteLine("holder" + account1.HolderName);
            //    Console.WriteLine("balance" + account1.Balance);

            //}
            //else if (choice == 2)
            //{
            //    account1.Deposit(amount);
            //    Console.WriteLine("holder" + account2.HolderName);
            //    Console.WriteLine("balance" + account2.Balance);
            //}
            //else
            //{
            //    Console.WriteLine("invalid choise");
            //}
            ///////////////////////////////////////////////////////////////
            ////case 4
            //Console.WriteLine("choose");
            //Console.WriteLine("1.Karim");
            //Console.WriteLine("2. Ali");

            //int choice4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the withdraw ");
            //double amount4 = Convert.ToDouble(Console.ReadLine());

            //if (choice == 1)
            //{
            //    account1.Withdraw(amount4);

            //    Console.WriteLine("balance" + account1.Balance);

            //}
            //else if (choice == 2)
            //{
            //    account1.Withdraw(amount4);

            //    Console.WriteLine("balance" + account2.Balance);
            //}
            //else
            //{
            //    Console.WriteLine("invalid choise");
            //}
            //////////////////////////////////////////////////////////////
            ////case 5
            //Console.WriteLine("choose");
            //Console.WriteLine("mose");
            //Console.WriteLine("kebord");

            //int choice5 = Convert.ToInt32(Console.ReadLine());
            //if (choice5 == 1)
            //{
            //    Console.WriteLine("inventory value" + product1.GetInventoryValue());
            //}
            //else if (choice5 == 2) 
            //{
            //    Console.WriteLine("inventory value" + product2.GetInventoryValue());
            //}
            //else { Console.WriteLine("invald"); }
            /////////////////////////////////////////////////////////////////////////
            ////case6
            //Console.WriteLine("choose");
            //Console.WriteLine("1.Ali");
            //Console.WriteLine("2.Ahmed");

            //int choice6 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter email");
            //string email = Console.ReadLine();

            //if (choice6 == 1)
            //{
            //    student1.Register(email);
            //    Console.WriteLine("student registered successfully");
            //}
            //else if (choice6 == 2)
            //{

            //    student2.Register(email);
            //    Console.WriteLine("student registered successfully");
            //} 
            //else 
            //{
            //    Console.WriteLine("invalid");
            //}
            /////////////////////////////////////////////////////////////////
            //case 7

            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + "  more meny");
            }
            else if(account1.Balance < account2.Balance)
            {
                Console.WriteLine(account2.HolderName + "  more many");
            }
            else
            {
                Console.WriteLine("equal");
            }
            ///////////////////////////////////////////////////////////////////
                
            
        }
    }
}
