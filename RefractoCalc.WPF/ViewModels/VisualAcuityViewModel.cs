using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RefractoCalc.Core.Calculators.Clinical;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.WPF.ViewModels
{
    public partial class VisualAcuityViewModel : ObservableObject
    {
        private readonly IVisualAcuityCalculator _calculator;

        public VisualAcuityViewModel()
        {
            _calculator = new VisualAcuityCalculator();
        }

        // --- INPUTS ---
        [ObservableProperty]
        private double _numerator = 6; // Default to Metric (6m)

        [ObservableProperty]
        private double _denominator = 6; // Default to 6/6

        // --- OUTPUTS ---
        [ObservableProperty]
        private double _resultDecimal;

        [ObservableProperty]
        private double _resultMAR;

        [ObservableProperty]
        private double _resultLogMAR;

        [RelayCommand]
        private void Calculate()
        {
            var result = _calculator.ConvertSnellen(Numerator, Denominator);

            ResultDecimal = result.DecimalVA;
            ResultMAR = result.MAR;
            ResultLogMAR = result.LogMAR;
        }
    }
}