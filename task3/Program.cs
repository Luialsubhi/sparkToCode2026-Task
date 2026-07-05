namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Absolute Difference
            Console.WriteLine("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The absolute difference between {num1} and {num2} is: {Math.Abs(num2 - num1)}");

            ///////////////////////////////////////////////////////////////////
        }
    }
}
