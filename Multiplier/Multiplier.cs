using System;
using System.Diagnostics;

namespace Multiplier
{
    public class Multiplier
    {
        public int Multiply(int first, int second)
        {
            Debug.Assert(first > 0 && second > 0, "Parameters must be a value greater than 0");

            var total = 0;

            while (true)
            {
                if (first % 2 != 0) { total += second; }
                if (first == 1) { break; }

                first = (int)Math.Floor(first / 2D);
                second += second;
            }
  
            return total;
        }
    }
}