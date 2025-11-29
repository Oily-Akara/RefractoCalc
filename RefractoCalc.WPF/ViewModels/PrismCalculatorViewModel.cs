using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RefractoCalc.Core.Calculators.Refraction;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.WPF.ViewModels
{
    public partial class PrismCalculatorViewModel : ObservableObject
    {
        private readonly IPrismCalculator _calculator;

        public PrismCalculatorViewModel()
        {
            _calculator = new PrismVectorCalculator();
        }

        // --- INPUTS ---

        [ObservableProperty]
        private double _horizontalValue;

        // 0 = Base Out (+), 1 = Base In (-)
        [ObservableProperty]
        private int _horizontalDirectionIndex = 0;

        [ObservableProperty]
        private double _verticalValue;

        // 0 = Base Up (+), 1 = Base Down (-)
        [ObservableProperty]
        private int _verticalDirectionIndex = 0;

        // --- OUTPUTS ---

        [ObservableProperty]
        private double _resultMagnitude;

        [ObservableProperty]
        private double _resultAxis;

        [RelayCommand]
        private void Calculate()
        {
            // Convert dropdown selection to Math signs
            // Index 0 (Base Out) is positive, Index 1 (Base In) is negative
            double hSigned = HorizontalDirectionIndex == 0 ? HorizontalValue : -HorizontalValue;

            // Index 0 (Base Up) is positive, Index 1 (Base Down) is negative
            double vSigned = VerticalDirectionIndex == 0 ? VerticalValue : -VerticalValue;

            var result = _calculator.CalculateResultant(hSigned, vSigned);

            ResultMagnitude = result.Magnitude;
            ResultAxis = result.Axis;
        }
    }
}