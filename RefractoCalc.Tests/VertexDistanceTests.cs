using RefractoCalc.Core.Calculators.Refraction;

namespace RefractoCalc.Tests
{
    public class VertexDistanceTests
    {
        [Fact]
        public void Calculate_SpectacleToContactLens_HighMyope_ReturnsCorrectPower()
        {
            // 1. Arrange 
            var calculator = new VertexDistanceCalculator();
            double originalPower = -10.00; // -10.00 Diopters
            double glassesVertex = 12.0;   // 12mm standard
            double contactVertex = 0.0;    // 0mm on eye

            // 2. Act 
            double result = calculator.Calculate(originalPower, glassesVertex, contactVertex);

            // 3. Assert 
            Assert.Equal(-11.36, result, 2);
        }

        [Fact]
        public void Calculate_NoDistanceChange_ReturnsSamePower()
        {
            // Arrange
            var calculator = new VertexDistanceCalculator();

            // Act
            double result = calculator.Calculate(-5.00, 12, 12);

            // Assert
            Assert.Equal(-5.00, result);
        }
    }
}