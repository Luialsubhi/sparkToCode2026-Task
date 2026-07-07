namespace Task4
{
    internal class Program
    {

        public static void PrintWelcome(string name)

        {
            Console.WriteLine("welcome " + name);

        }

        public static int aSquare(int num)
        {
            return num * num;

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

        public static int IsEven(int x)
        {
            return x % 2;

        }

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return (2 * width) + (2 * length);
        }

        public static string GetGreadeLetter(int g)
        {
            if (g >= 90) { return "A"; }
            else if (g >= 80) { return "B"; }
            else if (g >= 70) { return "C"; }
            else if (g >= 60) { return "D"; }
            else { return "F"; }
        }
        public static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i + "");

            }
            Console.WriteLine();
        }

        public static double add(double fnum, double snum)
        {
            return fnum + snum; }
        public static double sub(double fnum, double snum) 
        {
            return fnum - snum; }
        public static double multiply(double fnum, double snum) { 
            return fnum* snum; }
        public static double divid(double fnum, double snum)
        {
            try
            {
                if (snum == 0)
                    throw new DataMisalignedException();

                return fnum / snum;
            }
            catch (DataMisalignedException)
            {
                Console.WriteLine("cannot divide by 0 ");
                return 0;
            }
        }
        public static void displayResult(string operation, double result) 
        {
            Console.WriteLine(operation + "Result " + result);
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

            ////Gred Letter Function
            //Console.WriteLine("enter your grade");
            //int grade = Convert.ToInt32(Console.ReadLine());
            //string usergrede = GetGreadeLetter(grade);
            //Console.WriteLine("your grade is : " + usergrede);

            //////////////////////////////////////////////////////////
            /////
            ////task8

            //Console.WriteLine(" enter the number");
            //int startnum = Convert.ToInt32(Console.ReadLine());
            //Countdown(startnum);

            /////////////////////////////////////////////////////////////////

            //function-based calculator
            Console.WriteLine("ENTER the frist number ");
            double fnum =double.Parse(Console.ReadLine());
            Console.WriteLine("enter the  secend number");
            double snum = double.Parse(Console.ReadLine());

            
                
            add(fnum, snum);
            sub(fnum, snum);
            multiply(fnum, snum);
            divid(fnum, snum);

            Console.WriteLine("add :"+add(fnum, snum));
            Console.WriteLine("sub  :"+sub(fnum, snum));
            Console.WriteLine("muit  :"+multiply(fnum, snum));
            Console.WriteLine("div   :"+divid(fnum, snum));

        }
    }
}
