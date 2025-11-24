using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.Core.Calculators.Refraction
{
    public class VertexDistanceCalculator : IVertexDistanceCalculator
    {
        public double Calculate(double originalPower, double originalVertexMm, double newVertexMm)
        {
            // FORMULA: F_new = F_old / (1 - (change_in_distance_meters * F_old))

            // 1. Calculate the change in distance (New - Old)
            double distanceChangeMeters = (newVertexMm - originalVertexMm) / 1000.0;

            // 2. Apply the formula
            double denominator = 1 - (distanceChangeMeters * originalPower);

            // Safety check: Prevent division by zero
            if (Math.Abs(denominator) < 0.00001)
            {
                throw new InvalidOperationException("Calculation results in undefined power (infinity).");
            }

            return originalPower / denominator;
        }
    }
}