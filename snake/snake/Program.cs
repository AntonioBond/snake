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
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Рисуем рамку
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            topLine.Drow();
            bottomLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            // Отрисовка точек
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.UP);
            snake.Drow();
            
            /*p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(8, 5, '$');
            p3.Draw();

            Point p4 = new Point(33, 6, '@');
            p4.Draw();*/

            



            Console.ReadLine();
            
        
        }
    }
}
