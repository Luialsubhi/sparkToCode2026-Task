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

            ////Customer Service Queue
            //Queue<string> Enqueues = new Queue<string>();
            //for (int e= 0; e < 3; e++) 
            //{ 
            //    Console.WriteLine("enter the nume"+(e+1));
            //    string enq =Console.ReadLine();

            //    Enqueues.Enqueue(enq);

            //} 
            //string servedcust =Enqueues.Dequeue();
            //Console.WriteLine("Customer served  :" + servedcust);
            //////////////////////////////////////////////////////////////////////

            ////Array Grade Range
            //int[] g = new int[5];
            //for (int h = 0; h < g.Length; h++)
            //{
            //    Console.WriteLine("enter grade" + (h + 1));
            //    g[h] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(g);

            //int sum = 0;

            //for (int h = 0; h < g.Length; h++)
            //{
            //    sum += g[h];
            //}
            //double average = sum / 5.0;

            //Console.WriteLine("Results");
            //Console.WriteLine("LOWER GRADE  : " + g[0]);
            //Console.WriteLine("HIGHEST GRADE  : " + g[g.Length - 1]);
            //Console.WriteLine("average  : " + average);
            //////////////////////////////////////////////////////////////////////////////////////

            //Filtered Shopping List
            //List<string> shopping = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("enter item or finish write ('done') :");
            //    string it = Console.ReadLine();
            //    if (it == "done") { break; }
            //    shopping.Add(it);
            //}
            //Console.WriteLine("shopping lest before remove");
            //foreach (string it in shopping)
            //{
            //    Console.WriteLine($"{it}");
            //}
            //Console.WriteLine("enter item to remove ");
            //string removeItem = Console.ReadLine();

            //shopping.Remove(removeItem);

            //Console.WriteLine("shopping lest after remove");
            //foreach(string it in shopping)
            //{
            //    Console.WriteLine("- "+it);
            //}
            ///////////////////////////////////////////////////////////////////////////////

            //    //High Score Podium
            //    List<int> gameScores = new List<int>();

            //    for (int b = 0; b < 5; b++) 
            //    {
            //        Console.WriteLine("enter your grade");
            //        int score = int.Parse(Console.ReadLine());
            //        gameScores.Add(score);
            //    }
            //    gameScores.Sort();
            //    gameScores.Reverse();

            //    Console.WriteLine(" top 3 scores ");

            //    Console.WriteLine("1-" + gameScores[0]);
            //    Console.WriteLine("2-" + gameScores[1]);
            //    Console.WriteLine("3-" + gameScores[2]);
            //}
            ////////////////////////////////////////////////////////////////////////////

            //Undo Last Action
            Stack<string> Actions = new Stack<string>();
            while (true)
            {
                Console.WriteLine("enter actions or type 'stop'");
                string action = Console.ReadLine();

                if (action == "stop")
                {
                    break;
                }
                Actions.Push(action);

            }
            Console.WriteLine("Undo actions");

            Console.WriteLine(Actions.Pop());
            Console.WriteLine(Actions.Pop());

            Console.WriteLine("Remaining actions ");

            foreach (string action in Actions)
            {
                Console.WriteLine(action);
            }







        }
    }
}
