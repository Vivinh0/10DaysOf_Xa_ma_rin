using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Tuto10DaysXamarin.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuto10DaysXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaEntradas : ContentPage
    {
        public ListaEntradas()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Nuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LeerEntradas();
        }

        private void LeerEntradas()
        {
            // Necesita ser añadido SQLite
            using (SQLiteConnection conex =
                new SQLiteConnection(App.RutaBaseDatos))
            {
                conex.CreateTable<EntradaDiario>();
                // Necesitas ser añadido using Tuto10DaysXamarin.Modelos;
                List<EntradaDiario> entradasDiario = 
                    conex.Table<EntradaDiario>().ToList();
                vistaListaEntradas.ItemsSource = entradasDiario;
            }
        }

    }
}