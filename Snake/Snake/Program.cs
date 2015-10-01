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
            Console.WriteLine("Hello world!");
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rigthLine = new VerticalLine(78, 0, 24, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            Snake snake = new Snake(new Point(2, 3, '*'), 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            foodCreator.CreateFood();
            
            while(true)
            {
                if (snake.Eat(foodCreator.getPoint()))
                {
                    foodCreator.CreateFood();
                }
                // Проверим нажата ли кнопка
                if (Console.KeyAvailable)
                {
                    // Если таки нажата, то изменим направление в соответсвии с нажатием
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandelKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
