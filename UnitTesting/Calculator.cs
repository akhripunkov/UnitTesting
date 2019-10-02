using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class Calculator
    {
        public long Add(int a, int b)
        {
            return (long)a + (long)b;
        }

        public long Sub(int a, int b)
        {
            return (long)a - (long)b;
        }

        public long Mul(int a, int b)
        {
            return (long)a * (long)b;
        }

        public long Div(int a, int b)
        {
            if (b != 0)
            {
                return (long)a / (long)b;
            }
            else
            {
                return long.MinValue;
            }
        }

        public long Mod(int a, int b)
        {
            if (b != 0)
            {
                return (long)a % (long)b;
            }
            else
            {
                return long.MinValue;
            }
        }
    }
}
