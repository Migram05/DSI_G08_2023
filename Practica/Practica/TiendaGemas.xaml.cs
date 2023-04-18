using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Practica
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class TiendaGemas : Page
    {
        public TiendaGemas()
        {
            this.InitializeComponent();
            //Se ajusta el valor de volumen para el efecto de sonido de esta página
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }
        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
        }
        private void ReturnMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void RetrunTienda_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void retornoTIenda_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void retornoMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
