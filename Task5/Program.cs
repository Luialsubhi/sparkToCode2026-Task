namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Fixed Grade Array
            //int[] grades = new int[5];
            //for (int i = 0; i < grades.Length; i++)
            //{ 
            //    Console.WriteLine("enter the grade :"+(i+1));
            //    grades[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("nstudent grade :");

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            /////////////////////////////////////////////////////////////
            
            ////Dynamic To-Do List
            //List<string> Items = new List<string>();
            //for (int j = 0; j < 5; j++)
            //{

            //    Console.WriteLine("enter the item " +(j+1));
            //    string item = Console.ReadLine();
            //    Items.Add(item);

            //}
            //Console.WriteLine("To-Do list:");
            //int number = 1;
            //foreach (string item in Items)
            //{
            //    Console.WriteLine(number + " - " + item);
            //    number++;
            //}
            /////////////////////////////////////////////////////////////////
            
            ////Browsing History Stack
            //Stack<string> URLs = new Stack<string>();
            //for (int k = 0; k < 3; k++)
            //{
            //    Console.WriteLine("enter the URL "+(k+1));
            //    string url =Console.ReadLine();
            //    URLs.Push(url);
            //}
            //URLs.Pop();

            //Console.WriteLine("this urls");
            //Console.WriteLine(URLs.Peek());
            /////////////////////////////////////////////////////////////////
            
            //Customer Service Queue
            Queue<string> Enqueues = new Queue<string>();
            for (int e= 0; e < 3; e++) 
            { 
                Console.WriteLine("enter the nume"+(e+1));
                string enq =Console.ReadLine();
                
                Enqueues.Enqueue(enq);

            } 
            string servedcust =Enqueues.Dequeue();
            Console.WriteLine("Customer served  :" + servedcust);

        }
    }
}
