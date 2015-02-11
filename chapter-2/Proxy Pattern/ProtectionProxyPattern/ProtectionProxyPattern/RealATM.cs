using System;

namespace ProtectionProxyPattern
{
    public class RealATM : ATMInterface
    {
        private string name;

        public RealATM(string name)
        {
            this.name = name;
        }

        public void WithdrawMoney()
        {
            Console.WriteLine(name + " withdrew 1500 euro.");
        }
    }
}
