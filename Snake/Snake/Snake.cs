using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lengh, Direction direction)
        {
            pList = new List<Point>();
            for(int i = 0; i < lengh; i++)
            {
                // Пересоздаём точку и передвигаем её, тем самым рисуя змейку
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
