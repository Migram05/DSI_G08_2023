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
    public sealed partial class Partida : Page
    {

        public Partida()
        {
            this.InitializeComponent();
        }

        private void Heroe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ajustes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if(pause.Visibility == Visibility.Collapsed)
            {
                pause.Visibility = Visibility.Visible;
                pauseContinue.Visibility = Visibility.Visible;
                pauseExit.Visibility = Visibility.Visible;
                pauseText.Visibility = Visibility.Visible;
            }
            else
            {
                pause.Visibility = Visibility.Collapsed;
                pauseContinue.Visibility = Visibility.Collapsed;
                pauseExit.Visibility = Visibility.Collapsed;
                pauseText.Visibility = Visibility.Collapsed;
            }
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Continuar_Click(object sender, RoutedEventArgs e)
        {
            pause.Visibility = Visibility.Collapsed;
            pauseContinue.Visibility = Visibility.Collapsed;
            pauseExit.Visibility = Visibility.Collapsed;
            pauseText.Visibility = Visibility.Collapsed;
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
