using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly IOperationsRepository _operations;

        public CalculatorTrainer(IOperationsRepository operations)
        {
            _operations = operations;
        }

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
