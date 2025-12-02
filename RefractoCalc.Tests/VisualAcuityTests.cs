using Xunit;
using RefractoCalc.Core.Calculators.Clinical;

namespace RefractoCalc.Tests
{
    public class VisualAcuityTests
    {
        [Fact]
        public void ConvertSnellen_SixTwentyFour_ReturnsCorrectConversions()
        {
            // Arrange
            var calculator = new VisualAcuityCalculator();

            // Act
            // Input: 6/24
            var result = calculator.ConvertSnellen(6, 24);

            // Assert
            Assert.Equal(0.25, result.DecimalVA, 2); 
            Assert.Equal(4.0, result.MAR, 2);        
            Assert.Equal(0.60, result.LogMAR, 2);    
        }

        [Fact]
        public void ConvertSnellen_TwentyTwenty_ReturnsZeroLogMAR()
        {
            // Arrange
            var calculator = new VisualAcuityCalculator();

            // Act
            // Input: 20/20 (Standard vision)
            var result = calculator.ConvertSnellen(20, 20);

            // Assert
            Assert.Equal(1.0, result.DecimalVA);
            Assert.Equal(1.0, result.MAR);
            Assert.Equal(0.0, result.LogMAR); // log10(1) = 0
        }
    }
}