using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useless_Interfaces_for_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List_Operations list = new List_Operations();
            Console.ForegroundColor = ConsoleColor.Green;
            list.AddTail(1);
            list.AddTail(2);
            list.AddTail(3);
            list.PrintList(list);
            Console.WriteLine(list.TestListAsCollection(list));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(0);
            numbers.AddAfter(numbers.First, 1);  
            numbers.AddLast(2);
            numbers.AddLast(3);
            void PrintList(LinkedList<int> list1)
            {
                int n = 0;
                foreach (int i in list1)
                {
                    n++;
                    Console.WriteLine(n + " " + i);
                }
            }

            bool TestListAsCollection(LinkedList<int> list1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Какое число возможно содержится в стандартном списке: ");
                int x = Int32.Parse(Console.ReadLine());
                bool found = false;
                if (list1.Contains(x))
                    found = true;
                return found;
            }

            PrintList(numbers);
            Console.WriteLine(TestListAsCollection(numbers));
            Console.ReadKey();
        }
    }
}
