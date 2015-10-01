using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        int width;
        int height;

        List<Figure> wallList;

        public Walls(char sym)
        {
            wallList = new List<Figure>();

            this.width = Console.BufferWidth;
            this.height = Console.BufferHeight;
                        
            HorizontalLine upLine = new HorizontalLine(0, this.width - 2, 0, sym);
            HorizontalLine downLine = new HorizontalLine(0, this.width - 2, this.height - 1, sym);
            VerticalLine leftLine = new VerticalLine(0, 0, this.height - 1, sym);
            VerticalLine rigthLine = new VerticalLine(this.width - 2, 0, this.height - 1, sym);

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rigthLine);
            Draw();
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
