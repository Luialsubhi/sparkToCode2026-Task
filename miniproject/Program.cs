using static System.Runtime.InteropServices.JavaScript.JSType;

namespace miniproject
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Apply Interest To All");
                Console.WriteLine("7. List All Account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        ApplyInterestToAll();

                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        ListAllAccounts();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("enter the customer name");
            string Name = Console.ReadLine();

            Console.WriteLine("enter account Number");
            string accNumber = Console.ReadLine();

            if (accountNumbers.Contains(accNumber))
            {
                Console.WriteLine("ERROR and do not add anything");
                return;
            }
            Console.WriteLine("enter deposit amount");
            double initialBalance;
            if (double.TryParse(Console.ReadLine(),out initialBalance)||initialBalance<0)
            {
                Console.WriteLine("ERROR");
                return;
            }
            customerNames.Add(Name);
            accountNumbers.Add(accNumber);
            balances.Add(initialBalance);
            
        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("enter account Number");
            string accNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNumber);
            if (index == -1)
            {
                Console.WriteLine("ERROR");
                return;
            }
            Console.WriteLine("enter the Deposit Money ");
            double amount;

            if(!double.TryParse(Console.ReadLine(),out amount) || amount <= 0)
            {
                Console.WriteLine("ERROR");
                return;
            }
            balances[index] += amount;
            Console.WriteLine("deposit  :"+balances[index] );


        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("enter account Number");
            string accNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNumber);
            if (index == -1)
            {
                Console.WriteLine("ERROR");
                return;
            }
            Console.WriteLine("enter the Withdraw Money ");
            double amount;

            if(!double.TryParse(Console.ReadLine(),out amount) || amount <= 0 || amount > balances[index])
            {
                Console.WriteLine("ERROR");
                return;
            }
            balances[index] -= amount;
            Console.WriteLine(" Withdraw Money  :" + balances[index]);

        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("enter account Number");
            string accNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNumber);
            if (index == -1)
            {
                Console.WriteLine("ERROR");
                return;
            }
            Console.WriteLine("customer name : " + customerNames[index]);
            Console.WriteLine("account number : " + accountNumbers[index]);
            Console.WriteLine("current balance :  " + balances[index]);
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("enter sender account number");
            string senderaccount = Console.ReadLine();

            Console.WriteLine("enter receiver account number ");
            string recaccount = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderaccount);
            int recIndex = accountNumbers.IndexOf(recaccount);

            if (senderIndex == -1 || recIndex == -1)
            {
                Console.WriteLine("ERROR");
                return;
            }
            Console.WriteLine("enter Transfer amount");
            double amount;

            if (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0 || amount > balances[senderIndex])
            {
                Console.WriteLine("ERROR");
                return;
            }
            balances[senderIndex] -= amount;
            balances[recIndex] += amount;

            Console.WriteLine("sender : " + customerNames[senderIndex] + "   new balance : " + balances[senderIndex]);
            Console.WriteLine(" receiver : " + customerNames[recIndex] + "   new balance : " + balances[recIndex]);
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        static void ApplyInterestToAll()
        {
            Console.WriteLine("applay 1% interest to all accunts");

            if (customerNames.Count == 0)
            {
                Console.WriteLine("no account found to apply interest");
                return;
            }
            for(int i = 0; i < balances.Count; i++)
            {
                double interest = balances[i] * 0.01;
                balances[i] += interest;
                Console.WriteLine("account : " + accountNumbers[i] + "  " + customerNames[i] + " added " + interest + "-> new balance: " + balances[i]);
            }
            Console.WriteLine("Successfully 1%");

        }
        /////////////////////////////////////////////////////////////////////////
        static void ListAllAccounts()
        {
            Console.WriteLine(" List All Accounts");
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No account ");
                return;
            }
            for (int k = 0;k < customerNames.Count; k++)
            {
                Console.WriteLine(k + k + " name :" + customerNames[k] + "acc no:" + accountNumbers[k] + "balance: " + balances[k]);
            }
        }

    }
}





