using CarListApp.Maui.Services;

namespace CarListApp.Maui;

public partial class App : Application
{
	public static CarService _carService { get; private set; }
	public App(CarService carService)
	{
		InitializeComponent();

		MainPage = new AppShell();
        _carService = carService;

    }
}
