using Xamarin.Forms;

namespace Atividade1_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Colocando numa NavigationPage para ter a Navbar
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
