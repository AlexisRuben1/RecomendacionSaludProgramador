using ProgramadorSalud.Vistas.Detalle;
using ProgramadorSalud.Vistas.Menuprincipal;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgramadorSalud
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Principal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
