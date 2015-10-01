using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lengh, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for(int i = 0; i < lengh; i++)
            {
                // Пересоздаём точку и передвигаем её, тем самым рисуя змейку
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            Point head = GetNextPoint();
            // Удаляем хвостовую точку и затираем её
            pList.Remove(tail);
            tail.Clear();
            // Добавми новую точку в голову и отрисуем её
            pList.Add(head);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point nextLast = new Point(pList.Last());
            nextLast.Move(1, direction);
            return nextLast;
        }
        // Задание направления
        public void setDirection(Direction _direction)
        {
            direction = _direction;
        }
        // Измененение направления змейки в соответствии с нажатиепм кнопки
        public void HandelKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                setDirection(Direction.LEFT);
            }
            else if (key == ConsoleKey.RightArrow)
            {
                setDirection(Direction.RIGHT);
            }
            else if (key == ConsoleKey.DownArrow)
            {
                setDirection(Direction.DOWN);
            }
            else if (key == ConsoleKey.UpArrow)
            {
                setDirection(Direction.UP);
            }
        }
    }
}
