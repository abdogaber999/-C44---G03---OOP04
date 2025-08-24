using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session04_Solution
{
    internal class Calculator
    {
        #region Constructors
        public Calculator()
        {
        }
        #endregion

        #region Methods

        // method for 2 integer
        public int Add(int x, int y)
        {
            return x + y;

        }

        // method for 3 integer
        public int Add(int x, int y, int z)
        {
            return x + y + z;

        }

        // method for 2 double
        public double Add(double x, double y)
        {
            return x + y;

        }

        #endregion

    }
}
