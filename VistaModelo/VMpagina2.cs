using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmGuia.Modelo;
namespace MvvmGuia.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Frank",
                    Imagen="https://i.ibb.co/gvpcDWw/pescado.png"
                },
                 new Musuarios
                {
                    Nombre="Juan",
                    Imagen="https://i.ibb.co/RSrm1rJ/pulpo.png"
                },
                  new Musuarios
                {
                    Nombre="Carlos",
                    Imagen="https://i.ibb.co/ZLCmpR7/caja-de-leche.png"
                }
            };
        }
        public async Task Alerta(Musuarios parametros)
        {
          await  DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
