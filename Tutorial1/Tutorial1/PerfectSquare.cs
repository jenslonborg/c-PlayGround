using System;
using System.Collections.Generic;
using System.Text;


namespace PerfectSquareApplication
{
    class PerfectSquare
    {
        // member variables
        // none
        public bool IsPerfect(double input)
        {
            if (Math.Sqrt(input) == Math.Round(Math.Sqrt(input)))
            {
                return true;
            }
            return false;
        }
    }
}
