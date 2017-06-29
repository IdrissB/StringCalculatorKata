namespace SolidExercices.Console
{
    public class Program
    {
        public static void Main()
        {
            var calculatorTrainer = new CalculatorTrainer(new OperationsGenerator());
            calculatorTrainer.Run();
        }
    }
}
