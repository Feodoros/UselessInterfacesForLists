using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useless_Interfaces_for_Lists
{
    class Item_of_List
    {
        public Item_of_List next;
        public int num;
        public string stats;
        public int value;
        //public string value1;

        public Item_of_List(int value /*string value1*/)
        {
            this.value = value;
            //this.value1 = value1;
            next = null;
        }

        /*public Item_of_List(string value, int num)
        {
            this.value = value;
            this.num = num;
        }*/

        public Item_of_List(int value /*string value1*/, Item_of_List next)
        {
            this.value = value;
            //this.value1 = value1;
            this.next = next;
        }

        public string GetStats()
        {
            stats = num + " " + value;
            return stats;
        }
    }
}
