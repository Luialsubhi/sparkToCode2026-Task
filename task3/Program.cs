using System.Reflection.Metadata;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Absolute Difference
            //Console.WriteLine("Enter the first number:");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //float num2 = float.Parse(Console.ReadLine());

            //Console.WriteLine($"The absolute difference between {num1} and {num2} is: {Math.Abs(num2 - num1)}");

            ///////////////////////////////////////////////////////////////////

            //power and root example
            //Console.WriteLine("Enter the number:");
            //float number = float.Parse(Console.ReadLine());

            //Console.WriteLine("the power of the number is: " + Math.Pow(number, 2));
            //Console.WriteLine("the root of the number is: " + Math.Sqrt(number));

            /////////////////////////////////////////////////////////////////////

            ////Name Formatter
            //Console.WriteLine("Enter your full name:");
            //string fullName = Console.ReadLine();

            //string input = fullName.ToUpper();
            //string input2 = fullName.ToLower();
            //int length = fullName.Length;

            //Console.WriteLine("Your name in uppercase: " + input);
            //Console.WriteLine("Your name in lowercase: " + input2);
            //Console.WriteLine("The length of your name is: " + length);

            ////////////////////////////////////////////////////////////////////////

            ////Subscription End Date

            //Console.WriteLine("Enter the number of days of a free trial:");

            //try
            //{
            //    int days = int.Parse(Console.ReadLine());
            //    DateTime currentDate = DateTime.Now;
            //    DateTime endDate = currentDate.AddDays(days);
            //    Console.WriteLine($"Your free trial will end on: {endDate.ToShortDateString()}");

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. ");
            //}
            ////////////////////////////////////////////////////////////////////

            ////Grade Rounding System

            //Console.WriteLine("Enter your grade (0-100):");
            //double grade = double.Parse(Console.ReadLine());

            //Console.WriteLine("Your rounded grade is: " + Math.Round(grade));

            //if (grade > 60)
            //{
            //    Console.WriteLine("You have passed.");

            //}
            //else
            //{
            //    Console.WriteLine("You have failed.");
            //}
            //////////////////////////////////////////////////////////////////////

            //Password Strength Checker
            
            Console.WriteLine("Enter password:");
            string pas = Console.ReadLine();
           
            bool islongEnough = pas.Length >= 8;
            bool wpas = pas.ToUpper().Contains("password");

            if (islongEnough && wpas)
            {
                Console.WriteLine("Password is strong.");
            }
            
            else
            {
                Console.WriteLine("Password is weak.");
            }
            ///////////////////////////////////////////////////////////////////////////////////////

            //Clean Name Comparator
            Console.WriteLine("Enter the  name:");
            string name1 = Console.ReadLine().Trim();

            Console.WriteLine("Enter the  name:");
            string name2 = Console.ReadLine().Trim();
            name1 = name1.ToUpper();
            name2 = name2.ToUpper();
            if (name1==name2)
            { 
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            ///////////////////////////////////////////////////////////////////////////////


        }
    }
}
