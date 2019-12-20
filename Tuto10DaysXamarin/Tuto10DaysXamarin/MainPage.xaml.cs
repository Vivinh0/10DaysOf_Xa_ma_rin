using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tuto10DaysXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Boton_Pinchado(object sender, System.EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(entradaNombre.Text))
            {
                DisplayAlert("Error", "Tu nombre no puede estar vacío.",
                    "Ahora lo escribo");
            }
            else
            {
                etiquetaSaludo.Text = $"Hola {entradaNombre.Text}, bienbenido" +
                    $" a 10 días de Xa, ma, rin, Xamarin.";
            }
        }

    }
}
