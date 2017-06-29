using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            if (operation.Contains("+"))
            {
                string[] values = operation.Split('+');
                result = Convert.ToDecimal(values[0]) + Convert.ToDecimal(values[1]);
            }
            else if (operation.Contains("-"))
            {
                string[] values = operation.Split('-');
                result = Convert.ToDecimal(values[0]) - Convert.ToDecimal(values[1]);
            }
            else if (operation.Contains("x"))
            {
                string[] values = operation.Split('x');
                result = Convert.ToDecimal(values[0]) * Convert.ToDecimal(values[1]);
            }
            else if (operation.Contains("/"))
            {
                string[] values = operation.Split('/');
                result = Convert.ToDecimal(values[0]) / Convert.ToDecimal(values[1]);
            }
            return result;
        }
    }
}