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
            CalculOperations calcul = new CalculOperations(operation);

            var operators = new Dictionary<char, Func<decimal, decimal, decimal>>()
            {
                {'+', Sum},
                {'-', Sub},
                {'x', Product},
                {'/', Division}
            };

            try
            {
                if (operation != " " && operation != "0")
                {
                    foreach (var v in operators)
                    {
                        if (operation.Contains(v.Key))
                        {
                            String[] ope = operation.Split(v.Key);
                            bool elementFound = true;
                            foreach (string s in ope)
                            {
                                if (elementFound)
                                {
                                    result = decimal.Parse(s);
                                    elementFound = false;
                                }
                                else
                                {
                                    result = v.Value(result, decimal.Parse(s));
                                }
                            }
                        }
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