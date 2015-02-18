using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
   public interface Shape<T> where T : IComparable
    {
        //Comment nog invullen
        void ShowDetails();

        //Comment nog invullen
        Shape<T>[] ExplodeShape();

    }
}
