namespace RefractoCalc.Core.Interfaces
{
    /// <summary>
    /// Defines logic for converting lens power based on vertex distance changes.
    /// </summary>
    public interface IVertexDistanceCalculator
    {
        /// <summary>
        /// Calculates the new lens power required at a different vertex distance.
        /// </summary>
        /// <param name="originalPower">The power of the lens in Diopters (D).</param>
        /// <param name="originalVertexMm">The original vertex distance in millimeters (mm).</param>
        /// <param name="newVertexMm">The new target vertex distance in millimeters (mm).</param>
        /// <returns>The effective power at the new vertex distance.</returns>
        double Calculate(double originalPower, double originalVertexMm, double newVertexMm);
    }
}