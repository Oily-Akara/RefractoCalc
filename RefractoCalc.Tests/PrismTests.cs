using Xunit;
using RefractoCalc.Core.Calculators.Refraction;

namespace RefractoCalc.Tests
{
    public class PrismTests
    {
        [Fact]
        public void CalculateResultant_ThreeHorizontal_FourVertical_ReturnsFive()
        {
            var calculator = new PrismVectorCalculator();

            var result = calculator.CalculateResultant(3.0, 4.0);

            Assert.Equal(5.0, result.Magnitude, 2);
            Assert.Equal(53.13, result.Axis, 2);
        }

        [Fact]
        public void ResolvePrism_FiveAtFiftyThreeDegrees_ReturnsThreeAndFour()
        {
            // Arrange
            var calculator = new PrismVectorCalculator();

            // Act
            var result = calculator.ResolvePrism(5.0, 53.13);

            // Assert
            Assert.Equal(3.0, result.Horizontal, 1); // Approx 3.0
            Assert.Equal(4.0, result.Vertical, 1);   // Approx 4.0
        }
    }
}