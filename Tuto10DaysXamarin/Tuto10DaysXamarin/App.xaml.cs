using System;
using Tuto10DaysXamarin.Vistas;
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

        //public App(string rutaBaseDatos)
        //{
        //    InitializeComponent();

        //    /*
        //     * Asignamos la ruta que hemos pedido como parámetro
        //     */
        //    RutaBaseDatos = rutaBaseDatos;

        //    MainPage = new MainPage();
        //}

        public App(string rutaBaseDatos)
        {
            InitializeComponent();

            /*
             * Asignamos la ruta que hemos pedido como parámetro
             */
            RutaBaseDatos = rutaBaseDatos;

            // Necesitamos añadir using Tuto10DaysXamarin.Vistas;
            //MainPage = new ListaEntradas();
            MainPage = new NavigationPage(new ListaEntradas());
        }

        public App()
        {
            InitializeComponent();

            MainPage = new ListaEntradas();
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
