using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuto10DaysXamarin
{
    public partial class App : Application
    {
        /*
         * Añadimos la ruta como un atributo statico
         */
        public static string RutaBaseDatos;
        
        public App(string rutaBaseDatos)
        {
            InitializeComponent();

            /*
             * Asignamos la ruta que hemos pedido como parámetro
             */
            RutaBaseDatos = rutaBaseDatos;

            MainPage = new MainPage();
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
