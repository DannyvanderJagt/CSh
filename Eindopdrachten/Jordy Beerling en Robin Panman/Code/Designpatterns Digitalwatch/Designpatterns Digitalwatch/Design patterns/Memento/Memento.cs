using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpatterns_Digitalwatch
{
    //object that stores the historical state
    public class Memento<t>
    {
        //De state variable aanmaken
        private t state;

        //Getter state
        public t getState()
        {
            return state;
        }

        //Setter state
        public void setState(t state)
        {
            this.state = state;
        }
    }

    //the object that we want to save and restore, such as a check point in an application
    public class Originator<t>
    {
        //State in de orginater
        private t state;

        //for saving the state
        public Memento<t> createMemento()
        {
            //Memento aanmaken
            Memento<t> m = new Memento<t>();

            //Status in de memento zetten
            m.setState(state);
            
            //Memento teruggeven 
            return m;
        }

        //for restoring the state
        public void setMemento(Memento<t> m)
        {
            state = m.getState();
        }

        //change the state of the Originator
        public void setState(t state)
        {
            this.state = state;
        }

        //show the state of the Originator
        public t getState()
        {
            return this.state;
        }
    }

    //object for the client to access
    public static class Caretaker<t>
    {
        //list of states saved
        private static List<Memento<t>> mementoList = new List<Memento<t>>();

        //save state of the originator
        public static void saveState(Originator<t> orig)
        {
            mementoList.Add(orig.createMemento());
            
        }

        //restore state of the originator
        public static void restoreState(Originator<t> orig, int stateNumber)
        {
            //State ophalen
            orig.setMemento(mementoList[stateNumber]);
        }
    }
}
