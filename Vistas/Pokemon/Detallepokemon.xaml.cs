using MvvmGuia.Modelo;
using MvvmGuia.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmGuia.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detallepokemon : ContentPage
    {
        public Detallepokemon(Mpokemon parametros)
        {
            InitializeComponent();
            BindingContext = new VMdetallepokemon(Navigation,parametros);
        }
    }
}