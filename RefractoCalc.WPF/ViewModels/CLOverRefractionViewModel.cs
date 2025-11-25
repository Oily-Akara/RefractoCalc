using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RefractoCalc.Core.Calculators.ContactLens;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.WPF.ViewModels
{
    public partial class CLOverRefractionViewModel : ObservableObject
    {
        private readonly ICLOverRefractionCalculator _calculator;

        public CLOverRefractionViewModel()
        {
            // Keep it simple: Create the instance right here
            _calculator = new CLOverRefractionCalculator();
        }

        // INPUTS
        [ObservableProperty]
        private double _trialLensPower;

        [ObservableProperty]
        private double _tearLensPower = 0.0; // Default to 0

        [ObservableProperty]
        private double _overRefraction;

        // OUTPUT
        [ObservableProperty]
        private double _finalPower;

        // ACTION
        [RelayCommand]
        private void Calculate()
        {
            FinalPower = _calculator.Calculate(TrialLensPower, TearLensPower, OverRefraction);
        }
    }
}