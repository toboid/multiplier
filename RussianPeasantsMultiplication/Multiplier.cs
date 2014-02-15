using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RussianPeasantsMultiplication
{
    public class Multiplier
    {
        public int Multiply(int first, int second)
        {
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