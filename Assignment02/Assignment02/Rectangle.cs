using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetCurrentLength()
        {
            return this.length;
        }

        public void SetNewLength(int length)
        {
            this.length = length;
        }
        public int GetCurrentWidth()
        {
            return this.width;
        }
        public void SetNewWidth(int width)
        {
            this.width = width;
        }
        public int GetPerimeter()
        {
            return 2 * (this.length + this.width );
        }
        public int GetArea()
        {
            return (this.length * this.width);
        }



    }
}
