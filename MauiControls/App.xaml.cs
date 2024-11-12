using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiPresentationControls());
        }
    }
}
