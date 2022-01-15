using MvvmGuia.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _Tipousuario;
        DateTime _Fecha;
        string _Fechaactual;
        string _Resultadofecha;
        #endregion
        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fechaactual = DateTime.Now.ToString("dd/MM/yyyy");
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string Resultadofecha
        {
            get { return _Resultadofecha; }
            set { SetValue(ref _Resultadofecha, value); }
        }
        public string Fechaactual
        {
            get { return _Fechaactual; }
            set { SetValue(ref _Fechaactual, value); }
        }
        public string Tipousuario
        {
            get { return _Tipousuario; }
            set { SetValue(ref _Tipousuario, value); }
        }
        public string SeleccionarTipouser
        {
            get { return _Tipousuario; }
            set { SetProperty(ref _Tipousuario, value);
                Tipousuario = _Tipousuario;
            }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
       
        public DateTime Fecha 
        {
            get { return _Fecha; }
            set { _Fecha = value;
                OnPropertyChanged(Fecha.ToString());
                Resultadofecha = Fecha.ToString("dd/MM/yyyy");
            }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double respuesta = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            respuesta = n1 + n2;
            R = respuesta.ToString();
        }

        #endregion
        #region COMANDOS
        public ICommand Navegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand Sumarcommand => new Command(Sumar);
        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion
    }
}
