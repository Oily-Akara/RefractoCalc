using System;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.Core.Calculators.Biometry
{
    public class ACDCalculator : IACDCalculator
    {
        public double CalculateFromSlitLamp(double slitLengthMm)
        {
            // Standard Smith's Method approximation
            // Assuming 60-degree beam angle
            return 1.4 * slitLengthMm;
        }

        public double CalculateFromPhoto(double eDistancePx, double zDistancePx)
        {
            if (zDistancePx == 0) return 0; // Prevent divide by zero

            double ratio = eDistancePx / zDistancePx;

            // Regression formula: ACD = -3.3(Ratio) + 4.2
            return (-3.3 * ratio) + 4.2;
        }

        public double PredictPostOp(double preOpAcdMm)
        {
            // Population-specific regression
            // Post-op ACD ≈ 3.524 + 0.294 × (pre-op ACD)
            return 3.524 + (0.294 * preOpAcdMm);
        }
    }
}