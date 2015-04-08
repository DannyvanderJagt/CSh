using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace Designpatterns_Digitalwatch
{
    class Watch
    {
        //Variables
        private Gui gui;
        private Time time;
        private String mode;
        private int option, TimeEplapsed;
        private Timer Stopwatch;
        private Originator<int> orig;

        //Constructor
        public Watch(Gui gui)
        {
            //Stopwatch aanmaken
            Stopwatch = new Timer();
            Stopwatch.Elapsed += new ElapsedEventHandler(Stopwatch_tick);
            Stopwatch.Interval = 1000;

            //Een nieuwe originator aanmaken voor het memento pattern
            orig = new Originator<int>();

            //Tijd verstreken voor de stopwatch
            TimeEplapsed = 0;

            //De tijd klasse die de tijd bijhoud, deze kent de GUI
            this.time = new Time(gui);

            //De Gui opslaan
            this.gui = gui;

            //De huidige mode van de stopwatch op TIME zetten
            mode = "time";

            option = 0;
        }

        //Getter om de mode op te halen
        public String getMode()
        {
            return mode;
        }

        //Rechter knop ingedrukt event handler, deze is vaak voor het menu
        public void ButtonRightPressed()
        {

            if(option < 1 || TimeEplapsed > 0)//zit in een andere mode
            {
                //Als de mode al op tijd staat komt de tijd notitie inbeeld
                if (mode == "time")
                {
                    //Mode aanpassen
                    mode = "setTimeNotation";

                    //Tijd op verborgen zetten
                    gui.timeVisible(false);

                    //Tekst weergeven
                    gui.displayText("Change timenotation?");
                }//mode aanpassen
                else if (mode == "setTimeNotation")
                {
                    //"
                    mode = "setColor";
                    gui.displayText("Change backgroundcolor?");
                }//mode aanpassen
                else if (mode == "setColor")
                {
                    //"
                    mode = "setStopwatch";
                    gui.displayText("Stopwatch mode?");
                }//mode aanpassen
                else if (mode == "setStopwatch")
                {
                    //Als er al een tijd beschikbaar is
                    if (TimeEplapsed > 0)
                    {
                        //De timer(klok) starten
                        time.startTimer();

                        //State opslaan in de memento mbv de command
                        CommandPattern command = new CommandPattern("saveState", time, gui, orig, TimeEplapsed);

                        //Tijd enzo resetten
                        TimeEplapsed = 0;
                        option = 0;
                    }

                    //Mode terug zetten op tijd.
                    mode = "time";

                    //Display tekst leegmaken.
                    gui.displayText("");

                    //Tijd op zichtbaar zetten.
                    gui.timeVisible(true);
                }
            }//Als deze gewoon normaal 
            else if (TimeEplapsed == 0 && mode == "setStopwatch" && option > 0)
            {
                //Tijd aanzetten
                time.startTimer();
                
                //Optie op 0 zetten
                option = 0;
               
                //Mode terugzetten naar tijd
                mode = "time";

                //Displaytekst leeg zetten
                gui.displayText("");

                //Tijd dingen zichbaar zetten
                gui.timeVisible(true);
            }
            Console.WriteLine("Mode: " + mode);
        }

        //Linker knop listener 
        public void ButtonLeftPressed()
        {
            //mode selecteren
            if (mode == "setTimeNotation")
            {
                //als de optie 2 is, andere optie tonen
                if (option == 2)
                {
                    //Optie aanpassen
                    option = 1;

                    //Tekst weergeven
                    gui.displayText("24 uur notatie?");

                }
                else if (option == 1)
                {
                    //"
                    option = 2;
                    gui.displayText("12 uur notatie?");
                }
            }//mode selecteren
            else if (mode == "setColor")
            {//Per optie een antwoord geven
                if (option == 1)
                {
                    gui.displayText("Red");
                    this.option = 2;
                }
                else if (option == 2)
                {
                    gui.displayText("Green");
                    option = 3;
                }
                else if (option == 3)
                {
                    gui.displayText("Blue");
                    option = 1;
                }
            }//Stopwatch reset knop
            else if (mode == "setStopwatch")
            {
                //Command pattern gebruiken om de state in de memento op 0 te zetten
                CommandPattern command = new CommandPattern("saveState", time, gui, orig, 0);
                TimeEplapsed = 0;//tijd terug op 0 zetten

                //Gui updaten
                gui.updateStopwatch(TimeEplapsed);
            }
        }

        public void resetToTime()
        {
            option = 0;

            mode = "setStopwatch";

            ButtonRightPressed();
        }

        public void Stopwatch_tick(object sender, EventArgs e)
        {
            TimeEplapsed++;
            gui.updateStopwatch(TimeEplapsed);

            Console.WriteLine(TimeEplapsed.ToString());
        }

        public void ButtonCenterPressed()
        {
            if (mode == "setTimeNotation" && option == 0)
            {
                option = 1;
                gui.displayText("24 uur notatie?");
            }
            else if (mode == "setTimeNotation" && option > 0)
            {
                if (option == 1)
                {
                    //24
                    CommandPattern command = new CommandPattern("24", time, gui);
                }
                else
                {
                    CommandPattern command = new CommandPattern("12", time, gui);
                }

                this.resetToTime();
            } else if (mode == "setColor" && option == 0)
            {
                option = 2;
                gui.displayText("Red");
            }
            else if (mode == "setColor" && option > 0)
            {
                if (option == 2)
                {
                    CommandPattern command = new CommandPattern("RED", time, gui);
                }
                else if (option == 3)
                {
                    CommandPattern command = new CommandPattern("Green", time, gui);
                }
                else if (option == 1)
                {
                    CommandPattern command = new CommandPattern("Blue", time, gui);
                }

                this.resetToTime();

                option = 0;

            }
            else if (mode == "setStopwatch" && option == 0)
            {
                time.pauzeTimer();
                gui.resetDisplay();

                try
                {
                    CommandPattern com = new CommandPattern("", time, gui, orig);
                    TimeEplapsed = com.getState(orig);
                    gui.updateStopwatch(TimeEplapsed);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                gui.displayText("");
                gui.timeVisible(true);
                gui.setTimeZone("0");

                option = 1;
            }
            else if (mode == "setStopwatch" && option == 1 || option == 2)
            {
                if (option == 1)
                {
                    //start
                    option = 2;//is gestart
                    Stopwatch.Start();
                }
                else if (option == 2)
                {
                    option = 1;//is gestopt
                    Stopwatch.Stop();
                }
            }
        }
    }
}