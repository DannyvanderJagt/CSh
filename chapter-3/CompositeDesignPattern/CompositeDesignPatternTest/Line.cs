using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Line <T> : Shape<T> where T : IComparable
    {
        T PointX1 { get; set; }
        T PointY1 { get; set; }
        T PointX2 { get; set; }
        T PointY2 { get; set; }

        public Line(T pointX1, T pointY1, T pointX2, T pointY2)
        {
            PointX1 = pointX1;
            PointY1 = pointY1;
            PointX2 = pointX2;
            PointY2 = pointY2;
        }

        public Shape<T>[] ExplodeShape()
        {

            //Omdat dit een enkel object bevat zal je ook alleen dit object kunnen teruggeven
            Shape<T>[] shapeParts = {this};

            return shapeParts;
        }

        public void ShowDetails()
        {
            String detail = "Dit is een Line object met de volgende punten " + PointX1 + " " + PointY1 + " " + PointX2 + " " + PointY2+"\n";

            Console.WriteLine(detail);
        }

        

    }
}
