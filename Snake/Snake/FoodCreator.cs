using System;
using System.Collections.Generic;

namespace Snake
{
    class FoodCreator : GameObjects
    {
        int mapWidht;
        int mapHeight;
        char sym;

        public FoodCreator(char sym)
        {
            gameObjects = new List<Figure>();
            this.mapWidht = Console.BufferWidth - 2;
            this.mapHeight = Console.BufferHeight - 2;
            this.sym = sym;
        }

        public void CreateFood(GameObjects gameObjects, int count)
        {
            int createdFood = 0;
            while(createdFood < count)
            {
                Food food = new Food(sym);
                food.CreatFood();
                // Если еда не пересецается ни с одним из других объектов, то отрисуем их
                if (!gameObjects.Intersect(food) && !Intersect(food))
                {
                    this.gameObjects.Add(food);
                    food.Draw();
                    createdFood++;
                }
            }
        }
    }
}
