using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Designpatterns_Digitalwatch
{
    //Color interface aanmaken
    public interface iColor
    {
        Color returnColor();
    }

    class Factory
    {
        //De kleur wordt hierin opgeslagen
        private Color product;

        //Aan de hand van de kleuze een kleur aanmaken
        public Factory(String keuze)
        {
            if (keuze == "Red")
            {
                this.product = new Red().returnColor();
            }
            else if (keuze == "Green")
            {
                this.product = new Green().returnColor();
            } else if (keuze == "Blue")
            {
                this.product = new Blue().returnColor();
            }
        }
        
        //Getter om het product op te halen
        public Color getProduct()
        {
            //Return product
            return this.product;
        }
    }

    //Rode kleur klasse aanmaken met een kleurinterface
    public class Red : iColor
    {
        public Color returnColor()
        {
            return Color.Red;
        }
    }

    //groene kleur klasse aanmaken met een kleurinterface
    public class Green : iColor
    {
        public Color returnColor()
        {
            return Color.Green;
        }
    }

    //blauwe kleur klasse aanmaken met een kleurinterface
    public class Blue : iColor
    {
        public Color returnColor()
        {
            return Color.Blue;
        }
    }
}
