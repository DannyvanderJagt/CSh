using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Designpatterns_Digitalwatch
{
    public class Adapter 
    {
        //Interface target
        interface ITarget
        {
            //Tijdnotatie methode 
            void setTimeNotation(Time time);
        }

        //Methode voor de 24 uur klok
        public void setTwentyfour(Time time)
        {
            //nieuwe 24 object aanmaken
            TwentyfourNotation test = new TwentyfourNotation();
            //Tijdnotatie doorvoeren
            test.setTimeNotation(time);
        }
        //"
        public void setTwelve(Time time)
        {
            AdapterTwelve test = new AdapterTwelve();
            test.setTimeNotation(time);
        }

        //Klasse voor de twelveadapter die de Twelvenotation en iTarget gebruikt
        public class AdapterTwelve : TwelveNotation, ITarget
        {
            //Nieuwe twelvenotation aanmaken
            TwelveNotation tw = new TwelveNotation();

            //De tijd notatie zetten
            public void setTimeNotation(Time time)
            {
                //Doorvoeren in de timeklasse
                time.setTimeNotation(12);
            }
        }

        //24 uur notatie klasse die de iTarget gebruikt
        public class TwentyfourNotation : ITarget
        {
            //Zet tijd notatie functie
            public void setTimeNotation(Time time)
            {
                //Doorvoeren in de timeklasse
                time.setTimeNotation(24);
            }
        }

        //12 uur notatieklasse
        public class TwelveNotation
        {
            //Zet tijd notatie 
            public void setTimeNotation(Time time)
            {
                time.setTimeNotation(12);
            }
        }
    }
}
