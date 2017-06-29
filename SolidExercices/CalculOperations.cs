using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return arg1 / arg2;
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
