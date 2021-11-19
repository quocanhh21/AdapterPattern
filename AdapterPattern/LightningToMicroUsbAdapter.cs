using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class LightningToMicroUsbAdapter:MicroUsbPhone
    {
        private readonly Lightning lightningPhone;
        public LightningToMicroUsbAdapter(Lightning lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }
        public void useMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            lightningPhone.useLightning();
        }
        public void recharge()
        {
            lightningPhone.recharge();
        }

    }
}
