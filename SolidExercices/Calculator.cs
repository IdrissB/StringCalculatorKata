using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly CalculOperations _calculOperations;

        public Calculator(CalculOperations calculOpe)
        {
            _calculOperations = calculOpe;
        }

        public decimal Calculate(string operation)
        {
            decimal result = 0;
            foreach (var v in _calculOperations.Operators)
               {
                  if (operation.Contains(v.Key))
                        {
                            String[] ope = operation.Split(v.Key);
                            bool elementFound = true;
                            foreach (string s in ope)
                            {
                                try
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
                                catch (Exception e)
                                {
                                    throw new ArgumentException("Le format n'est pas correct");
                                }
                               
                            }
                        }
                    }
            return result;
            }
            
        }
    }