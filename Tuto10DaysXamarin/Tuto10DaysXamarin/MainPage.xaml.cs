﻿using System;
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

        //void Boton_Pinchado(object sender, System.EventArgs e)
        //{
        //    if(string.IsNullOrWhiteSpace(entradaNombre.Text))
        //    {
        //        DisplayAlert("Error", "Tu nombre no puede estar vacío.",
        //            "Ahora lo escribo");
        //    }
        //    else
        //    {
        //        etiquetaSaludo.Text = $"Hola {entradaNombre.Text}, bienbenido" +
        //            $" a 10 días de Xa, ma, rin, Xamarin.";
        //    }
        //}

        /* Comprueba si se tiene que habilitar o deshabilitar
         * el botón de guardado
         */
        private void compruebaSiHabilitarGuardado()
        {
            /*
             * Si la entrada del titulo o el editor del cuerpo están
             * vacíos, desativa el botón guardar. Si ambos tienen
             * texto lo habilita
             */
            if( string.IsNullOrWhiteSpace(entradaTitulo.Text) 
                || string.IsNullOrWhiteSpace(editorCuerpo.Text))
            {
                botonGuardar.IsEnabled = false;
            }
            else
            {
                botonGuardar.IsEnabled = true;
            }

        }

        /* Comprueba si se tiene que habilitar o deshabilitar
         * el botón de guardado cada vez que se modifica el
         * contenido del campo del titulo.
         */
        public void entradaTitulo_TextoCambiado(object sender,
            Xamarin.Forms.TextChangedEventArgs e)
        {
            compruebaSiHabilitarGuardado();
        }

        /* Comprueba si se tiene que habilitar o deshabilitar
         * el botón de guardado cada vez que se modifica el
         * contenido del editor.
         */
        public void contenidoEditor_TextoCambiado(object sender, 
            Xamarin.Forms.TextChangedEventArgs e)
        {
            compruebaSiHabilitarGuardado();
        }

        /*
         * Limpia el campo del titulo y el editor al pulsar el botón
         * guardar
         */
         public void botonGuardar_Click(object sender, System.EventArgs e)
        {
            entradaTitulo.Text = string.Empty;
            editorCuerpo.Text = string.Empty;
        }
    }
}
