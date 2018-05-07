using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useless_Interfaces_for_Lists
{
    class Item_of_List<T>
    {
        public Item_of_List<T> next;
        public int num;
        public string stats;
        public T value;

        public Item_of_List(T value)
        {
            this.value = value;

            next = null;
        }


        public Item_of_List(T value, Item_of_List<T> next)
        {
            this.value = value;

            this.next = next;
        }

        public string GetStats()
        {
            stats = num + " " + value;
            return stats;
        }
    }
}
