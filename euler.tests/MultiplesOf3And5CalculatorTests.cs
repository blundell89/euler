using System;
using FluentAssertions;
using Xunit;

namespace euler.tests
{
    public class MultiplesOf3And5CalculatorTests
    {
        public class GivenACalculator_WhenCalculatingMultiplesBelow10
        {
            private readonly int _result;

            public GivenACalculator_WhenCalculatingMultiplesBelow10()
            {
                var calculator = new MultiplesOf3And5Calculator();

                _result = calculator.CalculateSumOfMultiplesBelow(10);
            }

            [Fact]
            public void ThenTheResultIsCorrect()
            {
                _result.Should().Be(23);
            }
        }

        public class GivenACalculator_WhenCalculatingMultiplesBelow1000
        {
            private readonly int _result;

            public GivenACalculator_WhenCalculatingMultiplesBelow1000()
            {
                var calculator = new MultiplesOf3And5Calculator();

                _result = calculator.CalculateSumOfMultiplesBelow(1000);
            }

            [Fact]
            public void ThenTheResultIsCorrect()
            {
                _result.Should().Be(233168);
            }
        }
    }
}
