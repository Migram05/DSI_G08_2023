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
            //Se ajusta el valor de volumen para el efecto de sonido de esta página
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }
        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
        }
        private void Heroe_Click(object sender, RoutedEventArgs e)
        {

        }
        //Navegación
        private void Ajustes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        //Cambia la visibilidad del menú de pausa
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if(pause.Visibility == Visibility.Collapsed)
            {
                pause.Visibility = Visibility.Visible;
                pauseMenu.Visibility = Visibility.Visible;
            }
            else
            {
                pause.Visibility = Visibility.Collapsed;
                pauseMenu.Visibility = Visibility.Collapsed;
            }
        }

        private void Continuar_Click(object sender, RoutedEventArgs e)
        {
            pause.Visibility = Visibility.Collapsed;
            pauseMenu.Visibility = Visibility.Collapsed;
        }
        //Salir del juego
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
