using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            int speed = 100;
            GameObjects gameObjects = new GameObjects();
            char sym = '$';
            
            // Создадим и отобразим стены. Так же занесём их в список объектов
            Walls walls = new Walls('+');
            gameObjects.Add(walls);
            
            // Создадим змейку
            Snake snake = new Snake(new Point(2, 3, '*'), 3, Direction.RIGHT);
            gameObjects.Add(snake);
            // Создадим еду
            FoodCreator foodCreator = new FoodCreator('$');
            foodCreator.CreateFood(gameObjects, 1);
            gameObjects.Add(foodCreator);
                                   
            while(true)
            {
                if (gameObjects.Intersect(snake))
                {
                    Figure intersectFigure = new Figure();
                    int intersectObjectNum = gameObjects.GetIntersectObjectNum(snake);
                    intersectFigure = gameObjects.GetObject(intersectObjectNum);
                    if(intersectFigure.GetObjectType() == ObjectTypes.FOOD)
                    {
                        gameObjects.DeleteObject(intersectObjectNum);
                        snake.Eat();
                        FoodCreator foodCreator2 = new FoodCreator('$');
                        foodCreator2.CreateFood(gameObjects, 2);
                        gameObjects.Add(foodCreator2);                        
                    }
                    else
                    {
                        Console.SetCursorPosition(10, 10);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                        break;
                    }                 
                }
                // Проверим нажата ли кнопка
                if (Console.KeyAvailable)
                {
                    // Если таки нажата, то изменим направление в соответсвии с нажатием
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandelKey(key.Key);
                }
                Thread.Sleep(speed);
                snake.Move();
            }
        }
    }
}
