using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class RunClass
    {
        static void Main(string[] args)
        {
            Line<int> top = new Line<int>(0, 0, 1, 1);
            Line<int> bottom = new Line<int>(-3, -3, -2, -2);
            Line<int> left = new Line<int>(3, 3, 4, 4);
            Line<int> right = new Line<int>(5, 5, 6, 6);

            Rectangle<int> rectangle = new Rectangle<int>(top, bottom, right, left);

            ComplexShape<int> complexShape = new ComplexShape<int>();
            complexShape.addToShape(top);
            complexShape.addToShape(bottom);
            complexShape.addToShape(left);
            complexShape.addToShape(right);
            complexShape.addToShape(rectangle);

            Console.WriteLine("Dit is een voorbeeld van een Line object\n");
            top.ShowDetails();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dit is een voorbeeld van een Rectangle object\n");
            rectangle.ShowDetails();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dit is een voorbeeld van een ComplexShape object\n");
            complexShape.ShowDetails();
            Console.ReadKey();
        }

    }
}
