using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWatch.NetworkTime;

namespace DigitalWatch
{
    //Subject interface       
    interface IAPI
    {
        int[] doAction(NetworkTimeClient networkTimeClient);
    }

    //Real subject
    class API : IAPI
    {
        public int[] doAction(NetworkTimeClient networkTimeClient)
        {
            DateTime ntcTime = networkTimeClient.Time;

            return new int[2] { networkTimeClient.Time.Hour, networkTimeClient.Time.Minute };
        }
    }

    // Proxy klasse
    class Proxy : IAPI
    {
        private IAPI api;

        public Proxy()
        {
            api = new API();
        }

        public int[] doAction(NetworkTimeClient networkTimeClient)
        {
            int[] time;
            networkTimeClient.connect();
            if (networkTimeClient.checkConnection()) //Controleren connectie
            {
                time = api.doAction(networkTimeClient);
            }
            else    //Als er geen connectie is, system time returnen
            {
                time = new int[2] { DateTime.Now.Hour, DateTime.Now.Minute };
            }
            return time;
        }
    }
}
