using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProgramadorSalud.VistaModelo;
using ProgramadorSalud.Modelo;

namespace ProgramadorSalud.Vistas.Detalle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalleproduct : ContentPage
	{
		public Detalleproduct (Mcirculo parametros)
		{
			InitializeComponent ();
			BindingContext = new VMdetalle(Navigation, parametros);
		}
	}
}