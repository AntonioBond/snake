using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figura> wallList;

        public Walls (int mapWidth, int mapHeight)
        {
            wallList = new List<Figura>();

            //Рисуем рамку
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(rightLine);
            wallList.Add(leftLine);

            /*topLine.Drow();
            bottomLine.Drow();
            leftLine.Drow();
            rightLine.Drow();*/
        }
        internal bool IsHit( Figura figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }

            }
            return false;
        }

        public void Draw()
        {
            foreach( var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
