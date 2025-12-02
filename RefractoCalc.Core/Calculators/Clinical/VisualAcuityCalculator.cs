using System;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.Core.Calculators.Clinical
{
    public class VisualAcuityCalculator : IVisualAcuityCalculator
    {
        public (double DecimalVA, double MAR, double LogMAR) ConvertSnellen(double numerator, double denominator)
        {
            // Safety check for division by zero
            if (denominator <= 0 || numerator <= 0)
            {
                // Return zeros or handle as specific error logic depending on preference.
                // For a calculator, returning 0 is often safer than crashing.
                return (0, 0, 0);
            }

            // 1. Decimal = Numerator / Denominator
            double decimalVa = numerator / denominator;

            // 2. MAR = Denominator / Numerator (Inverse of Decimal)
            double mar = denominator / numerator;

            // 3. LogMAR = Log10(MAR)
            double logMar = Math.Log10(mar);

            return (decimalVa, mar, logMar);
        }
    }
}