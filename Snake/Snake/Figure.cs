using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;
        protected ObjectTypes objectType;

        // Отрисовка фигуры
        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        // Возвращение количества точек в фигуре
        public int Count()
        {
            return pList.Count;
        }
        // Возврат точки по её номеру в фигуре
        public Point GetPoint(int numPoint)
        {
            return pList[numPoint];
        }
        // Удаление фигуры
        public void Delete()
        {
            foreach(Point point in pList)
            {
                point.Clear();
            }
        }
        public ObjectTypes GetObjectType()
        {
            return objectType;
        }
    }
}
