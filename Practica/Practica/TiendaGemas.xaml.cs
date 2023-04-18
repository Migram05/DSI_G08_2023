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
        private int numCoins;
        public TiendaGemas()
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
            if (previousPageType == typeof(Tienda) && e?.Parameter is int coin)
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
        private void ReturnMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        /*private void RetrunTienda_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda), numCoins);
        }*/

        private void retornoTIenda_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda), numCoins);
        }

        private void retornoMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numCoins += 500;
            coins.Text = numCoins.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            numCoins += 1200;
            coins.Text = numCoins.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            numCoins += 3000;
            coins.Text = numCoins.ToString();
        }
    }
}
