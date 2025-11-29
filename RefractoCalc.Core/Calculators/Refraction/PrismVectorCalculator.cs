using System;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.Core.Calculators.Refraction
{
    public class PrismVectorCalculator : IPrismCalculator
    {
        public (double Magnitude, double Axis) CalculateResultant(double horizontalPower, double verticalPower)
        {
            // 1. Calculate Magnitude (Pythagorean theorem)
            double magnitude = Math.Sqrt((horizontalPower * horizontalPower) + (verticalPower * verticalPower));

            // 2. Calculate Angle (ArcTangent)
            // Atan2 handles all coordinate quadrants correctly (returns radians)
            double radians = Math.Atan2(verticalPower, horizontalPower);

            // 3. Convert to Degrees
            double degrees = radians * (180 / Math.PI);

            // Normalize negative angles (e.g., -90 becomes 270)
            if (degrees < 0)
            {
                degrees += 360;
            }

            return (magnitude, degrees);
        }

        public (double Horizontal, double Vertical) ResolvePrism(double magnitude, double axisDegrees)
        {
            // Convert degrees back to radians for Math functions
            double radians = axisDegrees * (Math.PI / 180);

            double horizontal = magnitude * Math.Cos(radians);
            double vertical = magnitude * Math.Sin(radians);

            return (horizontal, vertical);
        }
    }
}