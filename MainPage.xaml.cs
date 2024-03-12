using Microsoft.Maui.Controls;

namespace ChupyGPT
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnJoinNowClicked(object sender, EventArgs e)
		{
			// Navegar a la pantalla de registro
			//await Navigation.PushAsync(new RegistroPage());
		}

		private async void OnSignInClicked(object sender, EventArgs e)
		{
			// Navegar a la pantalla de inicio de sesión
			//await Navigation.PushAsync(new InicioSesionPage());
		}
	}

}
