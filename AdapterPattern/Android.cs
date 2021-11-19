﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Android: MicroUsbPhone
    {
        private bool connector;
        public void useMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected");
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
                Console.WriteLine("Connect MicroUsb first");
            }
        }
    }
}
