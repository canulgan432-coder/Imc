using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcMaui.Models
{
    public class CalculadoraImc
    {
        public static decimal IndicedeMasaCorporal(
            decimal peso, decimal estatura)
        { 
            return peso / (estatura * estatura); 
        }
        public static string SituacionNutriional(
            decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso normal";
            }
            if (imc < 30.0m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }

            return "Obesidad extrema";
        }
    }
}
