using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls : GameObjects
    {
        int width;
        int height;
                
        public Walls(char sym)
        {
            gameObjects = new List<Figure>();
            
            this.width = Console.BufferWidth;
            this.height = Console.BufferHeight;
                        
            HorizontalLine upLine = new HorizontalLine(0, this.width - 2, 0, sym);
            HorizontalLine downLine = new HorizontalLine(0, this.width - 2, this.height - 1, sym);
            VerticalLine leftLine = new VerticalLine(0, 0, this.height - 1, sym);
            VerticalLine rigthLine = new VerticalLine(this.width - 2, 0, this.height - 1, sym);

            gameObjects.Add(upLine);
            gameObjects.Add(downLine);
            gameObjects.Add(leftLine);
            gameObjects.Add(rigthLine);
            Draw();
        }
    }
}
