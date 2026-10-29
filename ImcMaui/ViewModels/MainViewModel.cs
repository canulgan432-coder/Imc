using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Imc.Models;

using System.Windows.Input;

namespace ImcMaui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _estatura;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]
        private string _estadonutricional;


        [RelayCommand]
        private void Limpiar()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            Estadonutricional = string.Empty;
        }

        public MainViewModel()
        {
            Limpiar();
          
        }

        [RelayCommand]
        private void Calcular()
        {
            decimal peso;
            decimal estatura;
            bool PesoEsValido = decimal.TryParse(Peso, out peso);
            bool EstaturaEsValida = decimal.TryParse(Estatura, out estatura);
            if (PesoEsValido && EstaturaEsValida)
            {
                decimal imc = CalculadoraImc.IndicedeMasaCorporal(peso, estatura);
                Imc = imc.ToString("F4");
                Estadonutricional = CalculadoraImc.SituacionNutriional(imc);
            }

        }

     
            
    }
}
