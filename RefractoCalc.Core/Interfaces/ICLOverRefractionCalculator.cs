namespace RefractoCalc.Core.Interfaces
{
    public interface ICLOverRefractionCalculator
    {
        // Formula: Final Power = Trial Lens + Tear Lens + Over-Refraction
        double Calculate(double trialLens, double tearLens, double overRefraction);
    }
}