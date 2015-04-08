using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatch
{
    //Update de segmentdisplays met de nieuwe waarde
    class Display
    {
        public SegmentDisplay[] segmentDisplays = new SegmentDisplay[4];
        
        public Display()
        {
            for (int i = 0; i < this.segmentDisplays.Length; i++)
            {
                this.segmentDisplays[i] = new SegmentDisplay();
            }
        }

        //Updaten van individuele segment displays met meegegeven uren en minuten
        public void updateTime(int hour, int minute)
        {
            this.segmentDisplays[0].update((hour - hour % 10) / 10);        // Linker uren segment
            this.segmentDisplays[1].update(hour % 10);                      // Rechter uren segment
            this.segmentDisplays[2].update((minute - minute % 10) / 10);    // Linker minuten segment
            this.segmentDisplays[3].update(minute % 10);                    // Rechter minuten segment
        }
    }
}
