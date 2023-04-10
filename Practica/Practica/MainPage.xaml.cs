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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Practica
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }
        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
        }

        //Fucionalidad de los botones e imágenes interactivas
        private void ImagenAjustes(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        private void ImagenTiendaPulsada(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void BotonTienda(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }
        private void ImagenMultijugador(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Multijugador));
        }
        private void ImagenUnJugador(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(UnJugador));
        }
        private void BotonMultijugador(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Multijugador));
        }
        private void BotonUnJugador(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UnJugador));
        }
    }
}
