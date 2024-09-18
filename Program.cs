namespace homework1

{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
           for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
           Console.WriteLine(string.Join(',',list));

            List<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);

            int sumList = 0;

            foreach (int j in list2)
            {
                sumList += j;
            }

            foreach(int i in list2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Sum of list = {sumList}");

            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict.Add("One", 1);
            dict.Add("Two", 2);
            dict.Add("THree", 3);
            dict.Add("Four", 4);
            dict.Add("Five", 5);

            foreach(var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            int sumDict = 0;

            foreach (int i in dict.Values) 
            {
                sumDict += i;
            }

            Console.WriteLine($"Sum of values in dictionary = {sumDict}");

            Queue<int> queue = new Queue<int>();    
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Initial queue");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Modified queue");

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Initial stack");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            stack.Pop();

            Console.WriteLine("Modified stack");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }        
}
