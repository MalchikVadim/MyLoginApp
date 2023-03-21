using MyLoginApp.ViewModel;
using MyLoginApp.Views;

namespace MyLoginApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
	}
}
