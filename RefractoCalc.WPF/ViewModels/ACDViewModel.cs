using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RefractoCalc.Core.Calculators.Biometry;
using RefractoCalc.Core.Interfaces;

namespace RefractoCalc.WPF.ViewModels
{
    public partial class ACDViewModel : ObservableObject
    {
        private readonly IACDCalculator _calculator;

        public ACDViewModel()
        {
            _calculator = new ACDCalculator();
        }

        // --- METHOD 1: SLIT LAMP ---
        [ObservableProperty] private double _slitLength;
        [ObservableProperty] private double _resultSlit;

        // --- METHOD 2: PHOTO ---
        [ObservableProperty] private double _photoE;
        [ObservableProperty] private double _photoZ;
        [ObservableProperty] private double _resultPhoto;

        // --- METHOD 3: POST-OP PREDICTION ---
        [ObservableProperty] private double _preOpAcd;
        [ObservableProperty] private double _resultPostOp;

        [RelayCommand]
        private void CalcSlit()
        {
            ResultSlit = _calculator.CalculateFromSlitLamp(SlitLength);
        }

        [RelayCommand]
        private void CalcPhoto()
        {
            ResultPhoto = _calculator.CalculateFromPhoto(PhotoE, PhotoZ);
        }

        [RelayCommand]
        private void CalcPostOp()
        {
            ResultPostOp = _calculator.PredictPostOp(PreOpAcd);
        }
    }
}