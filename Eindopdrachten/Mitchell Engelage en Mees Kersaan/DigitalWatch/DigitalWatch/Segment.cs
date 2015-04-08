using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatch
{
    //Status aanpassen van segment aan/uit en returnen
    class Segment
    {
        private bool state = false;

        public Segment()
        {
        }

        public void on()
        {
            state = true;
        }

        public void off()
        {
            state = false;
        }

        public bool getState()
        {
            return state;
        }
    }
}
