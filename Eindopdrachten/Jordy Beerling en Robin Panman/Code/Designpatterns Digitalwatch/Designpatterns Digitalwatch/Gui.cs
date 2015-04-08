using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designpatterns_Digitalwatch
{
    public partial class Gui : Form
    {
        //variables aanmaken
        private Watch watch;
        private Color watchColor;

        //Constructor
        public Gui()
        {
            InitializeComponent();

            //Form nietschaalbaar maken
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Display aanmaken d.m.v. resetfunctie
            this.resetDisplay();

            //Tekstlabel leegmaken
            TextLabel.Text = "";

            //Achtergrond kleur op blauw zetten
            watchColor = Color.Blue;

            //doorvoeren naar de gui
            this.setBackgroundColor(watchColor);

            //Een nieuwe watch aanmaken die de gui kent
            watch = new Watch(this);
        }

        //Display resetten naar 0
        public void resetDisplay()
        {
            //Alle segments op 0 zetten
            sevenSegment1.Value = "0";
            sevenSegment2.Value = "0";
            sevenSegment3.Value = "0";
            sevenSegment4.Value = "0";
            sevenSegment5.Value = "0";
            sevenSegment6.Value = "0";
        }

        //Mode om de tijd in de segments te plaatsen
        public void setDisplay(String time)
        {
            //Haal de nummers uit de time string en zet deze in een char array, hiermee kunnen ze met een index gepakt
            //worden.
            Char[] timearr = time.ToCharArray();

            
            //Plaats de getallen in de segments.
            sevenSegment1.Value = timearr[0].ToString();
            sevenSegment2.Value = timearr[1].ToString();
            sevenSegment3.Value = timearr[2].ToString();
            sevenSegment4.Value = timearr[3].ToString();
            sevenSegment5.Value = timearr[4].ToString();
            
            //Soms geeft de sevensegment een error, dan op 0 zetten
            try
            {
                sevenSegment6.Value = timearr[5].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                sevenSegment6.Value = "0";
            }
        }

        //De tijd (AM/PM) in de klok plaatsen
        public void setTimeZone(String timezone)
        {
            //Als deze op 0 is dan 24 uur notatie aanhouden
            if (timezone == "0")
            {
                //Label zichtbaarheid op false zetten
                TzLabel.Visible = false;
            }
            else
            {
                //Als de mode tijd is mag deze weer zichtbaar worden
                if (watch.getMode() == "time")
                {
                    //zichtbaarheid aanzetten van de tijdzone label
                    TzLabel.Visible = true;
                    TzLabel.Text = timezone;
                }
            }
        }

        //De stopwatch tijd updaten
        public void updateStopwatch(int i)
        {
            //Aantal uren en minuten variables aanmaken
            int min = 0;
            int hour = 0;

            //als het aantal seconden lager is dan 10 dan is er maar 1 display
            if (i < 10)
            {
                sevenSegment6.Value = i.ToString();
            }
            else if (i > 9 && i < 600)
            {
                //Aantal minuten uitrekenen
                min = (i / 60);

                //Als er minuten zijn bijgekomen moeten deze * 60 er afgehaald worden
                if (min > 0)
                {
                    //Secondes er afhalen
                    i -= (min * 60);
                }

                //Minuten en secondes naar de displays schrijven
                sevenSegment4.Value = min.ToString();
                sevenSegment5.Value = (i / 10).ToString();
                sevenSegment6.Value = (i % 10).ToString();
            }//Als er minuten komen dat in de tientallen begint
            else if (i > 599 && i < 3600)
            {
                //minuten uitrekenen enzo..
                min = (i / 60);

                if (min > 0)
                {
                    i -= (min * 60);
                }

                if (min > 9)
                {
                    sevenSegment3.Value = ((int)(min / 10)).ToString();
                    sevenSegment4.Value = (min % 10).ToString();
                } else {
                    sevenSegment4.Value = min.ToString();
                }

                sevenSegment5.Value = (i / 10).ToString();
                sevenSegment6.Value = (i % 10).ToString();
            }//Wanneer er uren bijkomen
            else if (i > 3599)
            {
                //Minuten en uren uitrekenen
                min = (i / 60);
                hour = (min / 60);

                //"
                if (min > 0)
                {
                    i -= (min * 60);
                }
                //"
                if (hour > 0)
                {
                    min -= (hour * 60);
                }

                //Als de uren hoger zijn dan 10 het tweede segment activeren
                if (hour > 9)
                {
                    sevenSegment1.Value = ((int)(hour / 10)).ToString();
                    sevenSegment2.Value = (hour % 10).ToString();
                }
                else
                {//Anders een segment aanhouden
                    sevenSegment2.Value = hour.ToString();
                }
                
                //"
                if (min > 9)
                {
                    sevenSegment3.Value = ((int)(min / 10)).ToString();
                    sevenSegment4.Value = (min % 10).ToString();
                }
                else
                {
                    sevenSegment4.Value = min.ToString();
                }

                sevenSegment5.Value = (i / 10).ToString();
                sevenSegment6.Value = (i % 10).ToString();
            }
        }

        //De achtergrondskleur naar een kleur zetten, dit wordt op alle controls doorgevoerd
        public void setBackgroundColor(Color color)
        {
            //Backcolors enzo op een kleur zetten
            pictureBox1.BackColor = color;

            sevenSegment1.ColorBackground = color;
            sevenSegment2.ColorBackground = color;
            sevenSegment3.ColorBackground = color;
            sevenSegment4.ColorBackground = color;
            sevenSegment5.ColorBackground = color;
            sevenSegment6.ColorBackground = color;

            label1.BackColor = color;

            TzLabel.BackColor = color;

            TextLabel.BackColor = color;
        }

        //Rechter knop listener
        private void Button_right_Click(object sender, EventArgs e)
        {
            watch.ButtonRightPressed();
        }

        //Tekst weergeven
        public void displayText(String text)
        {
            TextLabel.Text = text;
        }

        //Linker knop listener
        private void Button_left_Click(object sender, EventArgs e)
        {
            watch.ButtonLeftPressed();
        }
        
        //Middelste knop listener
        private void Button_center_Click(object sender, EventArgs e)
        {
            watch.ButtonCenterPressed();
        }

        //De tijd zichtbaar maken of niet.
        public void timeVisible(Boolean boolean)
        {
            sevenSegment1.Visible = boolean;
            sevenSegment2.Visible = boolean;
            sevenSegment3.Visible = boolean;
            sevenSegment4.Visible = boolean;
            sevenSegment5.Visible = boolean;
            sevenSegment6.Visible = boolean;
            label1.Visible =        boolean;
            TzLabel.Visible =       boolean;
        }
    }
}
