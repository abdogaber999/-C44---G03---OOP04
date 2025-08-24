using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session04_Solution
{
    internal class Rectangle
    {
        #region Properties
        public int Width;
        public int Height;
        #endregion

        #region Constructors Overloading

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int value)
        {
            Width = value;
            Height = value;
        }

        #endregion




    }
}
