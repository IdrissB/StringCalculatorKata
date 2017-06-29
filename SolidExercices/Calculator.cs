using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal result = 0;
            try
            {
                if (operation != " " && operation != "0")
                {
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
                        if (values[0] == "0" || values[1] == "0")
                            result = 0;
                        else
                            result = Convert.ToDecimal(values[0]) * Convert.ToDecimal(values[1]);
                    }
                    else if (operation.Contains("/"))
                    {
                        string[] values = operation.Split('/');
                        if (values[0] == "0" || values[1] == "0")
                            result = 0;
                        else
                            result = Convert.ToDecimal(values[0]) / Convert.ToDecimal(values[1]);
                    }

                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'opération que vous essayez d'effectuer n'est pas correct");
                throw;
            }
            
        }
    }
}