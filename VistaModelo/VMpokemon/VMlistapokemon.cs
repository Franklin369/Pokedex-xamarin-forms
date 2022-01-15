using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmGuia.Vistas.Pokemon;
using MvvmGuia.Datos;
using MvvmGuia.Modelo;
using System.Collections.ObjectModel;
using MvvmGuia.Conexion;
using Firebase.Database;
using System.Linq;
using MvvmGuia.Vistas;

namespace MvvmGuia.VistaModelo.VMpokemon
{
   public class VMlistapokemon:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion
        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region OBJETOS

        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnPropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon =await funcion.MostrarPokemones();
        }

       

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
       public async Task Iradetalle(Mpokemon parametros)
        {
            await Navigation.PushAsync(new Detallepokemon(parametros));
        }
      
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Iradetallecommand => new Command<Mpokemon>(async(p)=> await Iradetalle(p));
     
        #endregion
    }
}
