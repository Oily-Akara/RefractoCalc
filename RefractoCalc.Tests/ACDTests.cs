using Xunit;
using RefractoCalc.Core.Calculators.Biometry;

namespace RefractoCalc.Tests
{
    public class ACDTests
    {
        [Fact]
        public void CalculateFromSlitLamp_Input2mm_Returns2point8()
        {
            var calc = new ACDCalculator();
            // 2.0 * 1.4 = 2.8
            Assert.Equal(2.8, calc.CalculateFromSlitLamp(2.0), 1);
        }

        [Fact]
        public void CalculateFromPhoto_EqualEZ_Returns0point9()
        {
            var calc = new ACDCalculator();
            // Ratio = 1.0
            // -3.3(1) + 4.2 = 0.9
            Assert.Equal(0.9, calc.CalculateFromPhoto(100, 100), 1);
        }

        [Fact]
        public void PredictPostOp_Input3mm_ReturnsCorrectRegression()
        {
            var calc = new ACDCalculator();
            // 3.524 + (0.294 * 3) = 3.524 + 0.882 = 4.406
            Assert.Equal(4.406, calc.PredictPostOp(3.0), 3);
        }
    }
}