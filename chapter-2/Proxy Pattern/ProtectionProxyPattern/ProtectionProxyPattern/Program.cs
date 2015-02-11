using System;

namespace ProtectionProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMInterface realATM = new RealATM("Piet");
            realATM.WithdrawMoney();

            Console.WriteLine();
            
            ATMInterface proxyATM = new ProxyATM("Klaas");
            proxyATM.WithdrawMoney();

            Console.ReadLine();
        }
    }
}
