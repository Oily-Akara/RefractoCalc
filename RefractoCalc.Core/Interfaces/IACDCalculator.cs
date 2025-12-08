namespace RefractoCalc.Core.Interfaces
{
    public interface IACDCalculator
    {
        /// <summary>
        /// Estimates ACD using the Slit-Lamp "Just Touch" method (Smith's method).
        /// </summary>
        /// <param name="slitLengthMm">The Just-Touching Slit Length in mm.</param>
        double CalculateFromSlitLamp(double slitLengthMm);

        /// <summary>
        /// Estimates ACD using the Photographic EZ-Ratio method.
        /// Formula: ACD = -3.3 * (E/Z) + 4.2
        /// </summary>
        /// <param name="eDistancePx">Pixel distance from limbus to pupil center.</param>
        /// <param name="zDistancePx">Pixel distance from limbus to corneal front.</param>
        double CalculateFromPhoto(double eDistancePx, double zDistancePx);

        /// <summary>
        /// Predicts Post-Operative ACD based on Pre-Operative ACD (Regression).
        /// </summary>
        double PredictPostOp(double preOpAcdMm);
    }
}