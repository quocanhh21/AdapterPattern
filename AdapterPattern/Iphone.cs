using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Iphone : Lightning
    {
        private bool connector;
        public void useLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }
        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }
}
