using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class HelperClass
    {
        public static class RandomGenerator
        {
            private static readonly Random random = new Random();

            public static int GenerateRandomNumber(int minValue, int maxValue)
            {
                return random.Next(minValue, maxValue);
            }
        }
    }
}
