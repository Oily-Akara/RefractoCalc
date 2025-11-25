using Xunit;
using RefractoCalc.Core.Calculators.ContactLens;

namespace RefractoCalc.Tests
{
    public class CLOverRefractionTests
    {
        [Fact]
        public void Calculate_MyopicOverRefraction_ReturnsMoreMinus()
        {
            // Arrange
            var calc = new CLOverRefractionCalculator();
            // Trial: -3.00, Over-Refraction: -0.50 (No tear lens)

            // Act
            double result = calc.Calculate(-3.00, 0, -0.50);

            // Assert
            Assert.Equal(-3.50, result);
        }

        [Fact]
        public void Calculate_WithTearLens_OffsetsPower()
        {
            // Arrange
            var calc = new CLOverRefractionCalculator();
            // Trial: -3.00, Tear Lens: +0.25 (Steep fit), OR: -0.50

            // Act
            double result = calc.Calculate(-3.00, 0.25, -0.50);

            // Assert
            Assert.Equal(-3.25, result);
        }
    }
}