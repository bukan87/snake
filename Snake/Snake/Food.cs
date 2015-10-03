using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food : Figure
    {
        char sym;

        public Food(char sym)
        {
            objectType = ObjectTypes.FOOD;
            this.sym = sym;
            pList = new List<Point>();
            pList.Add(new Point());
        }
        public void CreatFood()
        {
            // Определим размеры поля игры
            int mapWidht = Console.BufferWidth - 2;
            int mapHeight = Console.BufferHeight - 2;
            // Выберем случайные координаты для еды
            Random random = new Random();
            int x = random.Next(2, mapWidht);
            int y = random.Next(2, mapHeight);

            Point point = new Point(x, y, sym);
            pList[pList.Count - 1] = point;
        }
    }
}
