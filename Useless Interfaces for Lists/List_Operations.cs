using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Useless_Interfaces_for_Lists
{
    class List_Operations<T> : ICollection<T>, IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            if (head == null) yield break;
            var host = head;
            while (true)
            {
                yield return host.value;
                if (host.next == null) yield break;
                else host = host.next;
            }
        }

        public List_Operations()
        {
            tail = head;
        }

        Item_of_List<T> head = new Item_of_List<T>(default(T)), tail;

        public void AddHead(T value)
        {
            Item_of_List<T> newHead = new Item_of_List<T>(value)
            {
                next = head,

            };

            head = newHead;

        }

        private int num = 1;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void AddTail(T value)
        {
            Item_of_List<T> newTail = new Item_of_List<T>(value);
            tail.next = newTail;
            tail = newTail;
            newTail.num = num++;
        }



        public bool TestListAsCollection(List_Operations<T> list1)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Какой элемент возможно содержится в нестандартном списке: ");
            var x = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            bool found = false;
            Item_of_List<T> elem = head;
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            foreach (T i in list1)
            {
                if (i.Equals(x))
                {
                    found = true;
                    break;
                }
            }
            myStopwatch.Stop();
            Console.WriteLine("Метод отработал за время {0}", myStopwatch.Elapsed);
            return found;
        }

        public void WriteAllValues()
        {
            Item_of_List<T> elem = head;
            while (elem != null)
            {
                Console.WriteLine(elem.value);
                elem = elem.next;
            }
        }


        public Item_of_List<T> PrintList(List_Operations<T> list1)
        {
            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int n = 0;
            foreach (T i in list1)
            {
                n++;
                Console.WriteLine(n + " " + i);
            }
            myStopwatch.Stop();
            Console.WriteLine("Метод отработал за время {0}", myStopwatch.Elapsed);
            return null;
        }

        public void Remove(T value)
        {

            Item_of_List<T> element = head, elementx = head;
            while (element.next != null)
            {
                if (element.value.Equals(value))
                {
                    elementx.next = element.next;
                    element = element.next;
                }
                else
                {
                    elementx = element;
                    element = element.next;
                }


            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("После удаления: ");
            Console.ForegroundColor = ConsoleColor.Green;

        }

        public int GetLength()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Количество элементов в списке: ");
            int i = 1;
            Item_of_List<T> element = head;
            while (element.next != null)
            {
                i++;
                element = element.next;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(i);
            return i;
        }

        public void Input_Output(int i)
        {
            int count = 1;
            Item_of_List<T> temp = head;

            while (temp.next != null)
            {
                if (count == i)
                {
                    Console.WriteLine(temp.value);
                    break;
                }
                else
                    count++;
                temp = temp.next;
            }
            if (temp.next == null)
            {
                if (count == i)
                    Console.WriteLine(temp.value);

            }

        }

        public Item_of_List<T> PoNomeru(int i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write("Значение по номеру: ");
            int count = 1;
            Item_of_List<T> temp = head;

            while (temp.next != null)
            {
                if (count == i)
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    return temp;
                    // Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    count++;
                }
                temp = temp.next;
            }
            if (temp.next == null)
            {
                if (count == i)
                    return temp;

            }
            return null;

        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }



        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}



