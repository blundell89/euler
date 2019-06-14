using euler._1;
using euler._2;
using FluentAssertions;
using Xunit;

namespace euler.tests._2
{
    public class EvenFibonacciNumberCalculatorTests
    {
        public class GivenACalculator_WhenCalculatingEvenFibonacciNumbersNotExceeding
        {
            private readonly EvenFibonacciCalculator _calculator;

            public GivenACalculator_WhenCalculatingEvenFibonacciNumbersNotExceeding()
            {
                _calculator = new EvenFibonacciCalculator();
            }

            [Theory]
            [InlineData(10, 10)]
            [InlineData(4000000, 4613732)]
            public void GivenACalculator_WhenCalculatingEvenFibonacciNumbersNotExceedingN_ThenTheResultIsCorrect(int inclusiveTo, int expected)
            {
                _calculator.Calculate(inclusiveTo).Should().Be(expected);
            }
        }
    }
}
