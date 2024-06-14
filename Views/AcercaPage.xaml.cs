namespace TPNro4_Punto2.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent(); 
    }

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InicioPage());
    }

}