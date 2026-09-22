using ImcMaui.Models;
using System.Reflection.PortableExecutable;

namespace ImcMaui.NewFolder;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ImcLabel.Text = string.Empty;
        SituacionNutricionalLabel.Text = string.Empty;
	}

    private void OnCalcularButtonCliked(object sender, EventArgs e)
    {
        decimal peso;
        decimal estatura;
        peso = decimal.Parse(PesoEntry.Text);
        estatura = decimal.Parse(EstaturaEntry.Text);
        decimal imc = CalculadoraImc.IndicedeMasaCorporal(peso, estatura);  
        ImcLabel.Text = imc.ToString("F4");
        SituacionNutricionalLabel.Text =
            CalculadoraImc.SituacionNutriional(imc);
      

    }

    private void OnLimpiarButtonCliked(object sender, EventArgs e)
    {
       PesoEntry.Text = string.Empty;
        EstaturaEntry.Text = string.Empty;
        ImcLabel.Text += string.Empty;
        SituacionNutricionalLabel.Text += string.Empty; 

    }
}