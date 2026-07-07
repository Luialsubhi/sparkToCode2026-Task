namespace Task4
{
    internal class Program
    {
        
        public static void PrintWelcome(string name)

        {
            Console.WriteLine("welcome " + name);
            
        }
       
        public static int aSquare(int num )
        {
            return num*num;

        }

        public static double CelsiusToFahrenheit(double C) 
        {
            return (C * 9 / 5) + 32;
        }

        public static void DisplayMenu()
        { 
            Console.WriteLine("   menu  ");
            Console.WriteLine("1-Start");
            Console.WriteLine("2-Help");
            Console.WriteLine("3-EXIT");

        }



        
        static void Main(string[] args)
        {
            ////personailzed Welcome Function
            //Console.WriteLine("enrer your name :");
            //string userName = Console.ReadLine();
            //PrintWelcome(userName);

            ///////////////////////////////////////////////////////////////

            //spuare number function

            //Console.WriteLine("enter the number");
            //int input=Convert.ToInt32(Console.ReadLine());
            //int result =aSquare(input);
            //Console.WriteLine("the number is " + result);
            
            
            /////////////////////////////////////////////////////////////
            
            ////colsius to fahrenheit function

            //Console.WriteLine("enter the tempresher C : ");
            //double input2=double.Parse(Console.ReadLine());
            //double Fahrenheit = CelsiusToFahrenheit(input2);
            //Console.WriteLine("the tembrecher " + Fahrenheit + " F");

            //////////////////////////////////////////////////////////////
            
            //Fixed Menu Display Function

            DisplayMenu();

            
        }
    }
}
