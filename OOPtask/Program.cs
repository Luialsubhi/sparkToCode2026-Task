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

    }
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
