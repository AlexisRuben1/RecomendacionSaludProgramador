using ProgramadorSalud.Modelo;
using ProgramadorSalud.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace ProgramadorSalud.VistaModelo
{
    class VMdetalle:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public Mcirculo ParametroRecibe { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMdetalle(INavigation navigation,Mcirculo parametrosTrae)
        {
            Navigation = navigation;
            ParametroRecibe = parametrosTrae;
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
        private async void Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(Volver);
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

    }
}
