using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatch
{
    //Beheren en updaten nieuwe status voor segmenten
    class SegmentDisplay
    {
        public Segment[] segments = new Segment[7];

        //Waarden voor segmenten per cijfer
        private int[,] digitSegments = {
            {1,1,1,0,1,1,1},
            {0,0,1,0,0,1,0},
            {1,0,1,1,1,0,1},
            {1,0,1,1,0,1,1},
            {0,1,1,1,0,1,0},
            {1,1,0,1,0,1,1},
            {1,1,0,1,1,1,1},
            {1,0,1,0,0,1,0},
            {1,1,1,1,1,1,1},
            {1,1,1,1,0,1,1}
        };

        public SegmentDisplay()
        {
            for (int i = 0; i < this.segments.Length; i++)
            {
                this.segments[i] = new Segment();
            }
        }

        //Geeft segmenten nieuwe waarden mee a.d.h.v. value
        public void update(int value)
        {
            for (int i = 0; i < this.segments.Length; i++)
            {
                this.segments[i].off();
                if (this.digitSegments[value, i] == 1)
                {
                    this.segments[i].on();
                }
            }
        }
    }
}
