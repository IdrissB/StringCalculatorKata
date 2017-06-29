using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly OperationsGenerator _operations = new OperationsGenerator();

        public void Run()
        {
            var calculator = new Calculator(new CalculOperations());
            foreach (var operation in _operations.GetOperations())
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
