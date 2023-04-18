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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Practica
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Tienda : Page
    {
        int numCoins;
        public Tienda()
        { 
            this.InitializeComponent();
            //Se ajusta el valor de volumen para el efecto de sonido de esta página
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Type previousPageType = this.Frame.BackStack.LastOrDefault()?.SourcePageType;
            // If e.Parameter is a string, set the TextBlock's text with it.
            if (previousPageType == typeof(TiendaGemas) && e?.Parameter is int coin)
            {
                numCoins = coin;
            }
            else
                numCoins = 100;

            coins.Text = numCoins.ToString();

            base.OnNavigatedTo(e);
        }
        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Type previousPageType = this.Frame.BackStack.LastOrDefault()?.SourcePageType;
            if (Frame.CanGoBack && !(previousPageType == typeof(TiendaGemas)))
                Frame.GoBack();
            else
                Frame.Navigate(typeof(MainPage));
        }

        private void TiendaGemas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TiendaGemas), numCoins);
        }

        private void ImagenHeroe_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(numCoins >= 500)
            {
                numCoins -= 500;
                coins.Text = numCoins.ToString();
            }
        }

        private void ImagenHeroe2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (numCoins >= 1000)
            {
                numCoins -= 1000;
                coins.Text = numCoins.ToString();
            }
        }

        private void ImagenEstructura_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (numCoins >= 500)
            {
                numCoins -= 500;
                coins.Text = numCoins.ToString();
            }
        }

        private void ImagenPowerUp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (numCoins >= 750)
            {
                numCoins -= 750;
                coins.Text = numCoins.ToString();
            }
        }
    }
}
