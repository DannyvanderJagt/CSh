using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatch
{
    // Klasse Time houdt de tijd bij en levert functies voor getten en setten van time
    class Time
    {   
        private int time;
        private int limit;

        public Time(int time, int limit)
        {
            this.time = time;
            this.limit = limit;
        }

        //Returnen van time
        public int getTime()
        {
            return time;
        }

        //Increment time met 1, als limit bereikt is resetten.
        public void incrementTime()
        {
            if (time == limit)
            {
                time = 0;
            }
            else
            {
                time++;
            }
        }

        //Setten van time
        public void setTime(int time)
        {
            this.time = time;
        }
    }
}
