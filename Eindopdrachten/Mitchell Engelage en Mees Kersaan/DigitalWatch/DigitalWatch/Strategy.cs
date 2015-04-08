using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWatch.NetworkTime;

namespace DigitalWatch
{
    //Strategy interface
    interface IStrategy
    {
        int[] doAction(int[] time);
    }

    //Strategy getTime
    class GetTime : IStrategy
    {
        public int[] doAction(int[] time) //Doet verder niks met time
        {
            IAPI proxy = new Proxy();
            NetworkTimeClient networkTimeClient = new NetworkTimeClient();

            return proxy.doAction(networkTimeClient);
        }
    }

    //Strategy getTwelveHourNotation 
    class GetTwelveHourNotation : IStrategy
    {
        public int[] doAction(int[] time)
        {
            ITarget adapter = new TimeAdapter();

            return adapter.getTime(time);
        }
    }
}
