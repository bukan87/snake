using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int rTop, int rBotom, char sym)
        {
            objectType = ObjectTypes.WALL;
            pList = new List<Point>();
            for (int y = rTop; y <= rBotom; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
    }
}
