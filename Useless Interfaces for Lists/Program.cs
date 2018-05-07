using System;
using System.Collections;
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
            LinkedList<int> numbers = new LinkedList<int>();
            List_Operations<int> list = new List_Operations<int>();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 100; i++)
            {
                list.AddTail(i);
                numbers.AddLast(i);
            }

            list.PrintList(list);

            Console.WriteLine(list.TestListAsCollection(list));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            PrintList(numbers);

            Console.WriteLine(TestListAsCollection(numbers));
            Console.ReadKey();



            bool TestListAsCollection(LinkedList<int> list1)
            {               
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Какой элемент возможно содержится в стандартном списке: ");                
                int x = Int32.Parse(Console.ReadLine());
                var myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                bool found = false;
                foreach (int i in list1)
                {
                    if (i==x)
                    {
                        found = true;
                        break;
                    }
                }
                myStopwatch.Stop();
                Console.WriteLine("Метод отработал за время {0}", myStopwatch.Elapsed);
                return found;
            }

            void PrintList(LinkedList<int> list1)
            {  
                var myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                int n = 0;
                foreach (int i in list1)
                {
                    n++;
                    Console.WriteLine(n + " " + i);
                }
                myStopwatch.Stop();
                Console.WriteLine("Метод отработал за время {0}", myStopwatch.Elapsed);
            }
        }
    }
}
