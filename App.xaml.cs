using MvvmGuia.Vistas;
using MvvmGuia.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmGuia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage =new NavigationPage( new Listapokemon());
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
