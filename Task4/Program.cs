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
        static void Main(string[] args)
        {
            ////personailzed Welcome Function
            //Console.WriteLine("enrer your name :");
            //string userName = Console.ReadLine();
            //PrintWelcome(userName);

            ///////////////////////////////////////////////////////////////

            //spuare number function

            Console.WriteLine("enter the number");
            int input=Convert.ToInt32(Console.ReadLine());
            int result =aSquare(input);
            Console.WriteLine("the number is " + result);
            
            
            /////////////////////

            
        }
    }
}
