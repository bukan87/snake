using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameObjects
    {
        protected List<Figure> gameObjects;
        // Отрисовка объектов
        public void Draw()
        {
            foreach(var obj in gameObjects)
            {
                obj.Draw();
            }
        }
        
        public List<Figure> GetObjectList()
        {
            return gameObjects;
        }

        public Figure GetObject(int objectNum)
        {
            return gameObjects[objectNum];
        }
        // Определение пересёкся ли один объект с одним из других
        public bool Intersect(Figure figure)
        {
            foreach(Figure obj in gameObjects)
            {
                if (Intersect(figure, obj))
                {
                    return true;
                }
            }
            return false;
        }

        // Определение пересечения двух объектов между собой
        public bool Intersect(Figure figure1, Figure figure2)
        {
            for(int i1 = 0; i1 <= figure1.Count() - 1; i1++)
            {
                int i2;
                if (Equals(figure1.GetType(), figure2.GetType()))
                {
                    i2 = i1 + 1;
                }
                else
                {
                    i2 = 0;
                }
                while(i2 <= figure2.Count() - 1)
                //for (i2 <= figure2.Count() - 1; i2++)
                {
                    if(figure1.GetPoint(i1).IsHit(figure2.GetPoint(i2)))
                    {
                        return true;
                    }
                    i2++;
                }
            }
            return false;
        }
        // Удаление указанного объекта
        public void DeleteObject(int objectNum)
        {
            //gameObjects[objectNum].Delete();
            gameObjects.RemoveAt(objectNum);
        }
        // Добавление объекта
        public void Add(Figure figure)
        {
            try
            {
                int dummy = gameObjects.Count();
            }
            catch (ArgumentNullException e)
            {
                gameObjects = new List<Figure>();
            }

            gameObjects.Add(figure);
            
        }
        // Добавление объектов
        public void Add(List<Figure> figures)
        {
            foreach (Figure figure in figures)
            {
                Add(figure);
            }
        }
        public void Add(GameObjects gameObjects)
        {
            Add(gameObjects.GetObjectList());
        }
        
        //  Определение номер объекта, с которым произошло пересечение
        public int GetIntersectObjectNum(Figure figure)
        {
            for (int ii = 0; ii <= gameObjects.Count - 1; ii++)
            {
                if (Intersect(figure, gameObjects[ii]))
                {
                    return ii;
                }
            }
            return -1;
        }
    }
}
