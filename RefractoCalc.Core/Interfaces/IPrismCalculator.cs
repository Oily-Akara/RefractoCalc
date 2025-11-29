namespace RefractoCalc.Core.Interfaces
{
    public interface IPrismCalculator
    {
        /// <summary>
        /// Combines horizontal and vertical prism components into a single resultant vector.
        /// </summary>
        /// <param name="horizontalPower">Horizontal power (Negative = Base In, Positive = Base Out).</param>
        /// <param name="verticalPower">Vertical power (Negative = Base Down, Positive = Base Up).</param>
        /// <returns>A tuple containing (ResultantMagnitude, AxisDegrees).</returns>
        (double Magnitude, double Axis) CalculateResultant(double horizontalPower, double verticalPower);

        /// <summary>
        /// Resolves a resultant prism into its horizontal and vertical components.
        /// </summary>
        /// <param name="magnitude">Total prism power.</param>
        /// <param name="axisDegrees">The axis in degrees (0-360).</param>
        /// <returns>A tuple containing (HorizontalComponent, VerticalComponent).</returns>
        (double Horizontal, double Vertical) ResolvePrism(double magnitude, double axisDegrees);
    }
}