namespace TPNro4_Punto2.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        //string username = edtUser.Text;
        //string password = edtPass.Text;
        string username = edtUser.Text?.Replace(" ", string.Empty);
        string password = edtPass.Text?.Replace(" ", string.Empty);

        if (username == "alumno" && password == "1234")
        {
            
            Navigation.PushAsync(new InicioPage());
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrecta", "OK");
        }
    }
}