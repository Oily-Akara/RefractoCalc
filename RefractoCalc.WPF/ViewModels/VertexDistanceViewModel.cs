using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RefractoCalc.Core.Calculators.Refraction;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.WPF.ViewModels
{
    public partial class VertexDistanceViewModel : ObservableObject
    {
        private readonly IVertexDistanceCalculator _calculator;

        public VertexDistanceViewModel()
        {
            _calculator = new VertexDistanceCalculator();
        }

        // INPUTS
        [ObservableProperty]
        private double _originalPower = -5.00;

        [ObservableProperty]
        private double _oldVertexMm = 12.0; // Default glasses vertex

        [ObservableProperty]
        private double _newVertexMm = 0.0;  // Default contact lens vertex

        // OUTPUT
        [ObservableProperty]
        private double _resultPower;

        // ACTION (The Button Click)
        [RelayCommand]
        private void Calculate()
        {
            // Call the Core logic
            ResultPower = _calculator.Calculate(OriginalPower, OldVertexMm, NewVertexMm);
        }
    }
}