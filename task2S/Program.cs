

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// countdown Timer
            //Console.WriteLine("enter a starting number :");
            //int sN = Convert.ToInt32(Console.ReadLine());

            //for (int i = sN; i >= 1; i--)
            //{
            //    Console.WriteLine(i);

            //}
            ////////////////////////////////////////////////////////////////

            ////sum of numbers from 1 to N
            //Console.WriteLine("enter a positive whole number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= N; i++)
            //{

            //    sum += i;

            //}
            //Console.WriteLine("sum =" + sum);

            ////////////////////////////////////////////////////////////////////

            ////multiplication table 

            //Console.WriteLine("enter a number to get its multiplication table");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //}
            ///////////////////////////////////////////////////////////////////////

            //// Password Retry
            //string password = "Spark2026";
            //string userInput = "";
            //while (userInput != password)
            //{
            //    Console.WriteLine("enter your password");
            //    userInput = Console.ReadLine();
            //    if (userInput != password)
            //    {
            //        Console.WriteLine("wrong password, try again");
            //    }
            //    else
            //    {
            //        Console.WriteLine("correct");

            //    }

            //}
            //////////////////////////////////////////////////////////////////

            ////number Guessing Game
            //int pn = 42;
            //int guess;
            //int attempts = 0;
            //do
            //{
            //    Console.WriteLine("enter your guess");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    attempts = pn + 1;

            //} 
            //while (guess != 0);

            //if (guess < pn)
            //{
            //    Console.WriteLine("too low");
            //}
            //else if (guess > pn)
            //{
            //    Console.WriteLine("too high");
            //}
            //else
            //{
            //    Console.WriteLine("correct! you guessed it in " + attempts + " attempts.");

            //}
            ////////////////////////////////////////////////////////////

            ////Safe Division Calculator
            //Console.WriteLine("enter the frist numper");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter the second number");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //for (int i = 0; i < 1; i++)
            //{
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //    else
            //    {
            //        double result = num1 / num2;
            //        Console.WriteLine("Result: " + result);
            //    }
            //    /////////////////////////////////////////////////////////////////////////////////

            //    //Repeating Menu with Exit Option

            //    bool exit = false;

            //    while (exit)
            //    {
            //        Console.WriteLine("Menu:");
            //        Console.WriteLine("1. Option 1");
            //        Console.WriteLine("2. Option 2");
            //        Console.WriteLine("3. Option 3");
            //        Console.WriteLine("chose tne one optine ");

            //    }
            //    try
            //    {
            //        Console.WriteLine("enter your choice");
            //        int choice = Convert.ToInt32(Console.ReadLine());
            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("you chose option 1");
            //                break;
            //            case 2:
            //                Console.WriteLine("you chose option 2");
            //                break;
            //            case 3:
            //                Console.WriteLine("you chose option 3");
            //                break;
            //            default:
            //                Console.WriteLine("invalid choice, please try again.");
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");

            //    }
            ///////////////////////////////////////////////////////////////////
            ///
            // Sum Even numper only
            //Console.WriteLine("enter a whole number :");
            //int number = int.Parse(Console.ReadLine());

            //int sum3 = 0;


            //for (int k = 0; k <= number; k++)

            //{

            //if (number% 2 != 0) ;
            //    {
            //       Console.WriteLine("the number is odd");

            //}
            //if (number % 2 == 0)
            //{
            //    sum3 += k;
            //}


            //Console.WriteLine("sum of even numbers from 1 to " + number + " is: " + sum3);
            //}

            ////////////////////////////////////////////////////////////////////////////
            ///
            // vaildated positive number inpt 

            //Console.WriteLine("enter the whil postive number :");
            //int positiveNumber2 = int.Parse(Console.ReadLine());

            //int sum4= 0;

            //do
            //{
            //    if (positiveNumber2 > 0 && positiveNumber2 % 2 != 0) ;
            //    {
            //        Console.WriteLine("invalid input, please enter a positive number :");
            //        positiveNumber2 = int.Parse(Console.ReadLine());
            //    }
            //} while (positiveNumber2 > 0 && positiveNumber2 % 2 != 0);
            //{
            //    for (int i = 0; i <= positiveNumber2; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            sum4 += i;
            //        }
            //    }
            //    sum4 += positiveNumber2;
            //}
            //Console.WriteLine("sum of positive numbers is: " + sum4);
            //////////////////////////////////////////////////////////////////////
            ///
            //Simple ATM Simulation

            int c = 3333;
            double balance = 100.000;
            int attempts = 0;
            bool pinCorrect = false;

            while (attempts < 3)
            {
                try
                {
                    Console.WriteLine("Enter your PIN:");
                    int enteredPin = Convert.ToInt32(Console.ReadLine());
                    if (enteredPin == c)
                    {
                        pinCorrect = true;
                        Console.WriteLine("PIN correct. Welcome!");
                        break;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Incorrect PIN. Attempts left: " + (3 - attempts));
                    }
                }
                catch
                {
                    attempts++;
                    Console.WriteLine("Invalid input. Please enter a numeric PIN. Attempts left: " + (3 - attempts));
                }

            }
            if (!pinCorrect)
            {
                Console.WriteLine("Too many incorrect attempts. Exiting.");
                return;
            }
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. check Balance");
                Console.WriteLine("4. Exit");

                int choice;

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }
                switch (choice)
                {
                    case 1:

                        try
                        {
                            Console.WriteLine("Enter amount to deposit:");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            if (depositAmount <= 0)
                            {
                                Console.WriteLine("Deposit amount must be positive.");
                            }
                            else
                            {
                                balance += depositAmount;
                                Console.WriteLine("Deposited: " + depositAmount + ". New balance: " + balance);
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");

                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Enter amount to withdraw:");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            if (withdrawAmount <= 0)
                            {
                                Console.WriteLine("Withdrawal amount must be positive.");
                            }
                            else if (withdrawAmount > balance)
                            {
                                Console.WriteLine("Insufficient funds. Current balance: " + balance);
                            }
                            else
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine("Withdrew: " + withdrawAmount + ". New balance: " + balance);
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Current balance: " + balance);
                        break;
                    case 4:
                        Console.WriteLine("Exiting. Thank you for using the ATM.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }

            }




        }


    }
}


