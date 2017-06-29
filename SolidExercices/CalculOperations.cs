using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculOperations
    {
        public Dictionary<char, Func<decimal, decimal, decimal>> Operators { get; private set; }

        public CalculOperations()
        {
            Operators = new Dictionary<char, Func<decimal, decimal, decimal>>()
            {
                {'+', Sum},
                {'-', Sub},
                {'x', Product},
                {'/', Division}
            };
        }

        private decimal Division(decimal arg1, decimal arg2)
        {
            try
            {
                return arg1 / arg2;
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("On ne peut diviser par ZERO!");
            }
        }

        private decimal Product(decimal arg1, decimal arg2)
        {
            return arg1 * arg2;
        }

        private decimal Sub(decimal arg1, decimal arg2)
        {
            return arg1 - arg2;
        }

        private decimal Sum(decimal arg1, decimal arg2)
        {
            return arg1 + arg2;
        }
    }
}
