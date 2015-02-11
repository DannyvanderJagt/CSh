using System;

namespace ProtectionProxyPattern
{
    public class ProxyATM : ATMInterface
    {
        private string name;
        private string pincode = "1234";

        public ProxyATM(string name)
        {
            this.name = name;
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Please enter your PIN.");
            string pin = Console.ReadLine();

            if (pin == pincode)
            {
                Console.WriteLine("Your PIN is correct.");

                RealATM realATM = new RealATM(name);
                realATM.WithdrawMoney();
            }
            else
            {
                Console.WriteLine("Your PIN is incorrect.");
            }
        }
    }
}
