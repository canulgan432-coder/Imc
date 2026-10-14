using ImcMaui.ViewModels;

namespace ImcMaui.NewFolder;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

	}

}