using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;
        int x;
        int y;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht - 2;
            this.mapHeight = mapHeight - 2;
            this.sym = sym;
        }
        public void CreateFood()
        {
            this.x = random.Next(2, this.mapWidht);
            this.y = random.Next(2, this.mapHeight);
            Point food = new Point(this.x, this.y, this.sym);
            food.Draw();
            //return new Point();
        }
        public Point getPoint()
        {
            return new Point(x, y, sym);
        }
    }
}
