using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main( string[] args )
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(8, 5, '$');
            p3.Draw();

            Point p4 = new Point(33, 6, '@');
            p4.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine line1 = new VerticalLine(3, 8, 11, '*');
            line1.Drow();

            /*List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);*/


            Console.ReadLine();
            
        
        }
    }
}
