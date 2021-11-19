using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iPhone = new Iphone();
            Console.WriteLine("Recharging android with MicroUsb");
            rechargeMicroUsbPhone(android);
            Console.WriteLine("Recharging iPhone with Lightning");
            rechargeLightningPhone(iPhone);
            Console.WriteLine("Recharging iPhone with MicroUsb");
            rechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone));
        }
        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.useMicroUsb();
            phone.recharge();
        }
        static void rechargeLightningPhone(Lightning phone)
        {
            phone.useLightning();
            phone.recharge();
        }
    
    }
}
