using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SingleLinkedListImplementation
    {
        private int value;
        private SingleLinkedListImplementation node;
        //public static int count = 0;
        static SingleLinkedListImplementation currentValue = null;

        public SingleLinkedListImplementation(int value)
        {
            this.value = value;
            this.node = null;

        }
        public void insertValue(int value)
        {
            if (currentValue == null)
            {
                SingleLinkedListImplementation a = new SingleLinkedListImplementation(value);
                currentValue = a;

            }
            else
            {
                SingleLinkedListImplementation a = new SingleLinkedListImplementation(value);
                currentValue.node = a;
                //LinkedList1.count++;                
            }
        }
    }
}
