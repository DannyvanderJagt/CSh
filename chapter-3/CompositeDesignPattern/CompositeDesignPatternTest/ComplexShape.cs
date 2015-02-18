using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class ComplexShape<T> : Shape<T> where T : IComparable
    {
        List<Shape<T>> shapeList = new List<Shape<T>>();

        public void addToShape(Shape<T> shapeToBeAdded)
        {
            shapeList.Add(shapeToBeAdded);
        }

        public Shape<T>[] ExplodeShape()
        {
            return (Shape<T>[])shapeList.ToArray();
        }

        public void ShowDetails()
        {
            foreach (Shape<T> shape in shapeList)
            {
                shape.ShowDetails();
            }

        }
    }
}
