using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpatterns_Digitalwatch
{
    class CommandPattern
    {
        //Constructor
        public CommandPattern(String optie, Time time, Gui gui, Originator<int> orig = null, int state = 0)
        {
            //Benodigde dingen aanmaken
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            //Het command doorgeven aan de invoker
            invoker.SetCommand(command);

            //Aan de hand van de keuze een command aanmaken
            if (optie == "12")
            {
                invoker.twelveCommand(time);
            }
            else if (optie == "24")
            {
                invoker.twentFourCommand(time);
            }
            else if (optie == "RED")
            {
                invoker.redBackgound(gui);
            }
            else if (optie == "Green")
            {
                invoker.greenBackgound(gui);
            }
            else if (optie == "Blue")
            {
                invoker.blueBackgound(gui);
            }
            else if (optie == "saveState")
            {
                invoker.saveState(orig, state);
            }
        }

        //voor ophalen van een state
        public int getState(Originator<int> orig)
        {
            //Benodigde variables aanmaken
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            //Status ophalen uit de orig
            return orig.getState();
        }

        //Command klasse
        class ConcreteCommand : Command
        {
            public ConcreteCommand(Receiver receiver)
                : base(receiver)
            {

            }

            //Methodes die de receiver aanspreken
            public override void twelve(Time time)
            {
                receiver.twelve(time);
            }

            public override void twentyfour(Time time)
            {
                receiver.twentyfour(time);
            }
            public override void redBackgound(Gui gui)
            {
                receiver.redBackgound(gui);
            }
            public override void greenBackgound(Gui gui)
            {
                receiver.greenBackgound(gui);
            }
            public override void blueBackgound(Gui gui)
            {
                receiver.blueBackgound(gui);
            }
            public override void saveState(Originator<int> orig, int state)
            {
                receiver.saveState(orig, state);
            }
            public override int getState(Originator<int> orig)
            {
                return receiver.getState(orig);
            }
        }

        //Command klasse die overridden wordt
        abstract class Command
        {
            //Recevier
            protected Receiver receiver;

            //constructor
            public Command(Receiver receiver)
            {
                //receiver zetten
                this.receiver = receiver;
            }

            //Methodes 
            public abstract void twelve(Time time);
            public abstract void twentyfour(Time time);
            public abstract void redBackgound(Gui gui);
            public abstract void greenBackgound(Gui gui);
            public abstract void blueBackgound(Gui gui);
            public abstract void saveState(Originator<int> orig, int state);
            public abstract int getState(Originator<int> orig);
        }

        //Receiver classe
        public class Receiver
        {
            //Uitvoerende functies
            public void twelve(Time time)
            {
                Adapter adapter = new Adapter();
                adapter.setTwelve(time);
            }
            public void twentyfour(Time time)
            {
                Adapter adapter = new Adapter();
                adapter.setTwentyfour(time);
            }
            public void redBackgound(Gui gui)
            {
                Factory f = new Factory("Red");
                gui.setBackgroundColor(f.getProduct());
            }
            public void greenBackgound(Gui gui)
            {
                Factory f = new Factory("Green");
                gui.setBackgroundColor(f.getProduct());
            }
            public void blueBackgound(Gui gui)
            {
                Factory f = new Factory("Blue");
                gui.setBackgroundColor(f.getProduct());
            }

            public void saveState(Originator<int> orig, int state)
            {
                orig.setState(state);
                Caretaker<int>.saveState(orig);
            }

            public int getState(Originator<int> orig)
            {
                Caretaker<int>.restoreState(orig, 0);
                return orig.getState();
            }
        }
        
        //Invoker klasse
        class Invoker
        {
            //Command aanmaken
            private Command _command;

            //Constructor
            public void SetCommand(Command command)
            {
                this._command = command;
            }

            public void twelveCommand(Time time)
            {
                _command.twelve(time);
            }
            public void twentFourCommand(Time time)
            {
                _command.twentyfour(time);
            }
            public void redBackgound(Gui gui)
            {
                _command.redBackgound(gui);
            }
            public void greenBackgound(Gui gui)
            {
                _command.greenBackgound(gui);
            }
            public void blueBackgound(Gui gui)
            {
                _command.blueBackgound(gui);
            }
            public void saveState(Originator<int> orig, int state)
            {
                _command.saveState(orig, state);
            }
            public int getState(Originator<int> orig)
            {
                return _command.getState(orig);
            }
        }
    }
}
