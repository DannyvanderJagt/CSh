using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Rectangle <T> : Shape<T> where T : IComparable
    {
        Shape<T>[] rectangleEdges = new Shape<T>[4];

        public Rectangle(Line<T> top, Line<T> bottom, Line<T> right, Line<T> left)
        {
            rectangleEdges[0] = top;
            rectangleEdges[1] = bottom;
            rectangleEdges[2] = right;
            rectangleEdges[3] = left;
        }

        public Shape<T>[] ExplodeShape()
        {
            return rectangleEdges;
        }

        public void ShowDetails()
        {
            string detail = "Dit is een Rectangle object dat bestaat uit de volgende "+rectangleEdges.Length+" objecten: \n";
            Console.WriteLine(detail);
            foreach (Shape<T> shape in rectangleEdges)
            {
                shape.ShowDetails();
            }
        }
    }
}
