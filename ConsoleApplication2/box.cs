using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class BoxException : Exception
    {

        public BoxException(string message):base (message)
        {
           
        } 

    }
    public class Box
    {
        private int width;
        private int height;
        private int depth;

        
        public Box(int width, int height, int depth)
        {
            if (width < 0) 
            { 
                throw new BoxException("width must be positive"); 
            }
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public override string ToString()
        {
            return string.Format("Box({0}, {1}, {2}, {3})", width, height, depth, Volume);
        }

        public int Width 
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Depth
        {
            get { return depth; }
        }

        public int Volume
        {
            get { return width * height * depth; }
        }

        public int Volume2()
        {
            return width * height * depth;
        }

        public Boolean Volume3()
        {
            return true;
        }
    }
}
