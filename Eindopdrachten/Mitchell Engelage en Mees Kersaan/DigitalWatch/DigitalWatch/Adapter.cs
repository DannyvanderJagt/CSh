using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatch
{
    // Target interface
    interface ITarget
    {
        int[] getTime(int[] time);
    }

    //Adapter
    class TimeAdapter : ITarget
    {
        private TwelveHourNotation twelveHourNotation = new TwelveHourNotation();

        public int[] getTime(int[] time)
        {
            return twelveHourNotation.getTimeInTwelveHourNotation(time);
        }
    }

    //Adaptee TwelveHourNotation
    class TwelveHourNotation
    {
        public int[] getTimeInTwelveHourNotation(int[] time)
        {
            if (time[0] >= 12)      //Als Hour hoger is of gelijk aan 12, wordt er 12 afgehaald
                return new int[] { time[0] - 12, time[1] };
            else
                return time;
        }
    }
}
