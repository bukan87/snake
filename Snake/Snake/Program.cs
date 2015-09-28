using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();


            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            //Draw(x2, y2, sym2);

            Console.ReadLine();
        }
    }
}
