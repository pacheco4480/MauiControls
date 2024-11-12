using MauiControls.Pages;
using System.Collections.Generic;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiSetValueControls());
        }
    }
}
