using TPNro4_Punto2.Views;

namespace TPNro4_Punto2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new LoginPage());

        }
    }
}
