using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASub()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("5-3,3");
            Check.That(result).IsEqualTo(1.7m);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("6x1,2");
            Check.That(result).IsEqualTo(7.2m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("15/3");
            Check.That(result).IsEqualTo(5m);
        }

        [Test]
        public void CalculateAProductWithAZero()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("0x1,2");
            Check.That(result).IsEqualTo(0);
        }

        [Test]
        public void CalculateADivisionWithAZero()
        {
            var calculator = new Calculator(new CalculOperations());
            var result = calculator.Calculate("0/1,2");
            Check.That(result).IsEqualTo(0);
        }
    }
}
