namespace TPNro4_Punto2.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		InitializeComponent();
	}
    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaPage());
    }

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }


}