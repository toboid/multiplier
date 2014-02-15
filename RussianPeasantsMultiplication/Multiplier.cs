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
            var numbers = new Dictionary<int, int>();

            while (true)
            {
                if (first % 2 != 0) { numbers.Add(first, second); }
                if (first == 1) { break; }

                first = (int)Math.Floor(first / 2.0);
                second = second * 2;
            }
  
            var total = numbers.Values.Aggregate((sum, val) => sum + val);
            return total;
        }
    }
}