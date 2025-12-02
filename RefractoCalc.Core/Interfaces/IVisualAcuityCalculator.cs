namespace RefractoCalc.Core.Interfaces
{
    public interface IVisualAcuityCalculator
    {
        /// <summary>
        /// Converts a Snellen fraction (Numerator/Denominator) into Decimal, MAR, and LogMAR notations.
        /// </summary>
        /// <param name="numerator">The test distance (e.g., 6 or 20).</param>
        /// <param name="denominator">The letter size (e.g., 6, 20, 24, 200).</param>
        /// <returns>A tuple containing (Decimal, MAR, LogMAR).</returns>
        (double DecimalVA, double MAR, double LogMAR) ConvertSnellen(double numerator, double denominator);
    }
}