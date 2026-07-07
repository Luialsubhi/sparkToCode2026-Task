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

        public static int  IsEven(int  x)
        {
            return x % 2 ;
            
        }

        public static double CalculateArea(double length,double width) 
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return (2 * width) + (2 * length);
        }

        public static int GetGreadeLetter(int g) 
        {
            return g;
        }
        public static void Countdown(int start)
        {
            for (int i = start; i>=1; i--)
            {
                Console.WriteLine(i+"");

            }
            Console.WriteLine();
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

            //DisplayMenu();

            //////////////////////////////////////////////////////////////

            //// Even or Odd Function

            //Console.WriteLine("enter the number ");
            //int input3=int.Parse(Console.ReadLine());
            //int r = IsEven(input3); 

            //if (r==0)
            //{
            //    Console.WriteLine("the number even" );
            //}
            //else 
            //{
            //    Console.WriteLine("the number odd");
            //}
            ///////////////////////////////////////////////////////

            ////Rectangle aree and Perimeter Functions
            //Console.WriteLine("enter the lenth");
            //double inputl=double.Parse(Console.ReadLine());

            //Console.WriteLine("enter the width");
            //double inputw = double.Parse(Console.ReadLine());

            //double A=CalculateArea(inputl, inputw);
            //double P=CalculatePerimeter(inputl,inputw);

            //Console.WriteLine("the area is :" + A);
            //Console.WriteLine("the perimeter is " + P);

            /////////////////////////////////////////////////////
           
            //Gred Letter Function
            Console.WriteLine("enter your greae");
            int gred = int.Parse(Console.ReadLine());
            if (gred > 90)
            {
                Console.WriteLine("A");
            }
            if (gred < 90 && gred > 80) 
            {
                Console.WriteLine("B");
            }
            if (gred < 80 && gred > 65) 
            {
                Console.WriteLine("C");  
            }
            if (gred < 65 && gred > 50)
            {
               Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            ////////////////////////////////////////////////////////
            
            Console.WriteLine(" enter the number");
            int startnum = Convert.ToInt32(Console.ReadLine());
            Countdown(startnum);
        }
    }
}
