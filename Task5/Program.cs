namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fixed Grade Array
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            { 
                Console.WriteLine("enter the grade :"+(i+1));
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nstudent grade :");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            
        }
    }
}
