using ProgramadorSalud.Datos;
using ProgramadorSalud.Modelo;
using ProgramadorSalud.VistaModelo;
using ProgramadorSalud.Vistas.Detalle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProgramadorSalud.VistaModelo
{
    public class VMprincipal:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mcirculo> _Listacirculo;
        #endregion
        #region CONSTRUCTOR
        public VMprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Listarcirculo();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcirculo> Listacirculo
        {
            get { return _Listacirculo; }
            set { SetValue(ref _Listacirculo, value); }
        }
        #endregion
        #region PROCESOS
        public void Listarcirculo()
        {
            var funcion = new Dcirculo();
            Listacirculo = funcion.Listarcirculo();
        }
        private async void selecionarcirculo(Mcirculo parametros)
        {
            await Navigation.PushAsync(new Detalleproduct( parametros));
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand SeleccionarcirculoCommand => new Command<Mcirculo>(selecionarcirculo);
        #endregion
    }
}
