using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Designpatterns_Digitalwatch
{
    public class Time
    {
        //Variables
        Timer incrementer;
        Gui form;
        int timeNotation;
        String tz;

        //Constructor
        public Time(Gui form)
        {   
            timeNotation = 24;

            //Formulier doorgeven ivb controls.
            this.form = form;

            //Een timer starten die elke seconde af gaat.
            incrementer = new Timer();//Timer aanmaken
            incrementer.Tick += new EventHandler(incrementer_Tick);//Event handler toevoegen
            incrementer.Interval = 1000;//Interval op 1 sec zetten.
            incrementer.Start();//Timer een aanzetten
        }

        //Haal de tijd op
        public String getTime()
        {
            //Secondes uit de system time halen
            String seconds = DateTime.Now.Second.ToString();

            //Als de secondes maar de lengte van een heeft er een 0 voorplakken
            if (seconds.Length == 1)
            {
                seconds = "0" + seconds;
            }

            //"
            String minutes = DateTime.Now.Minute.ToString();
            if (minutes.Length == 1)
            {
                minutes = "0" + minutes;
            }
            //"
            int Hour = DateTime.Now.Hour;

            //Als de tijdnotatie een 12 uur klok is
            if (timeNotation == 12)
            {
                //Als de uur hoger dan 12 is wordt het Past Morning en anders At Morning
                if (Hour >= 12)
                {
                    tz = "PM";
                }
                else
                {
                    tz = "AM";
                }
                //Tijdzone instellen
                form.setTimeZone(tz);

                //Als het 13 uur is de tijd splitsen.
                if(Hour >= 13)
                {
                    Hour = (Hour % 12);
                }
            }
            else
            {
                //Timezone op 0 zetten, dus 24 uur notatie(default)
                form.setTimeZone("0");
            }

            //van de uren een string maken
            String SHour = Hour.ToString();

            //Controle op lengte
            if (SHour.Length == 1)
            {
                SHour = "0" + SHour;
            }

            //Alles in een string achter elkaar terug sturen.
            return SHour + "" + minutes + "" + seconds;
        }
        
        //Timer pauzen
        public void pauzeTimer()
        {
            incrementer.Stop();
        }

        //Timer starten
        public void startTimer()
        {
            incrementer.Start();
        }

        //Tijd notatie instellen
        public void setTimeNotation(int timeNot)
        {
            timeNotation = timeNot;
        }

        //Als de seconde van de timer verstreken is wordt deze functie aangeroepen.
        private void incrementer_Tick(object sender, EventArgs e)
        {
            //Het display update met de method setDisplay met de waarde die getTime terug geeft.
            form.setDisplay(getTime());
        }
    }
}
