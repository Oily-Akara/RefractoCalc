using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.Core.Calculators.ContactLens
{
    public class CLOverRefractionCalculator : ICLOverRefractionCalculator
    {
        public double Calculate(double trialLens, double tearLens, double overRefraction)
        {
            // Simple algebraic sum
            return trialLens + tearLens + overRefraction;
        }
    }
}