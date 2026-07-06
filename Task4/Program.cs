namespace Task4
{
    internal class Program
    {
        //personailzed Welcome Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("welcome " + name);
            
        }
        static void Main(string[] args)
        {
            //personailzed Welcome Function
            Console.WriteLine("enrer your name :");
            string userName = Console.ReadLine();
            PrintWelcome(userName);

            ///////////////////////////////////////////////////////////////
            


            
        }
    }
}
