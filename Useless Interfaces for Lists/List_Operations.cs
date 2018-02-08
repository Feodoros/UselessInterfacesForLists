using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Useless_Interfaces_for_Lists
{
    class List_Operations : ICollection<int>, IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
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

        Item_of_List head = new Item_of_List(0), tail;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Current => throw new NotImplementedException();

        public void AddHead(int value)
        {
            Item_of_List newHead = new Item_of_List(value /*value1*/)
            {
                next = head,

            };

            head = newHead;

        }

        private int num = 1;

        public void AddTail(int value /*string value1*/)
        {

            Item_of_List newTail = new Item_of_List(value);
            tail.next = newTail;
            tail = newTail;
            newTail.num = num++;
        }

        public bool TestListAsCollection(List_Operations list1)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Какое число возможно содержится в нестандартном списке: ");
            int x = Int32.Parse(Console.ReadLine());
            bool found = false;
            Item_of_List elem = head;
            while (elem != null)
            {
                if (elem.value == x)
                {
                    found = true;
                    break;
                }
                elem = elem.next;
            }
            return found;
        }

        public void WriteAllValues()
        {
            Item_of_List elem = head;
            while (elem != null)
            {
                Console.WriteLine(elem.value);
                elem = elem.next;
            }
        }


        public Item_of_List PrintList(List_Operations list1)
        {
            int n = 0;
            foreach (int i in list1)
            {
                n++;
                Console.WriteLine(n + " " + i);
            }
            return null;
        }

        public Item_of_List Find(int n)
        {
            Item_of_List elem = head;
            while (elem.value != n | elem != null)
            {
                elem = elem.next;
            }
            if (elem.num == n) return elem;
            else return null;

        }
        /*public Item_of_List Find(string value)
        {
            Item_of_List elem = head;
            while (elem.value != value | elem != null)
            {
                elem = elem.next;
            }
            if (elem.value == value) return elem;
            else return null;

        }*/

        public void Remove(int value)
        {

            Item_of_List element = head, elementx = head;
            while (element.next != null)
            {
                if (element.value == value)
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
        /*public void Remove(int n)
        {
            Item_of_List elem = head, lastElem = head;
            while (lastElem.num != n)
            {
                if (elem.num == n)
                {
                    lastElem.next = elem.next;
                    Renum();
                    num--;
                }
                lastElem = elem;
                elem = elem.next;
            }
        }*/

        public int GetLength()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Количество элементов в списке: ");
            int i = 1;
            Item_of_List element = head;
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
            Item_of_List temp = head;

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

        /*private void Renum()
        {
            Item_of_List elem = head;
            int i = 0;
            while (elem != null)
            {
                elem.num = i++;
                elem = elem.next;
            }
        }*/

        public Item_of_List PoNomeru(int i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write("Значение по номеру: ");
            int count = 1;
            Item_of_List temp = head;

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

        bool ICollection<int>.Remove(int item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        void ICollection<int>.Add(int item)
        {
            throw new NotImplementedException();
        }

        void ICollection<int>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<int>.Contains(int item)
        {
            throw new NotImplementedException();
        }

        void ICollection<int>.CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    /*public void Sort()
    {
        bool x = true;
        while (true)
        {
            x = false;
            for (var temp = head; temp.next != null; temp = temp.next)
            {

                if (temp < temp.next)
                {
                    continue;
                }

                Swap(temp, temp.next);
                x = true;
            }
        }
    }

    private void Swap(Item_of_List temp, object next)
    {
        throw new NotImplementedException();
    }*/
}



