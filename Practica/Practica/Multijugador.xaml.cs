using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Multijugador : Page
    {
        public ObservableCollection<string> Images { get; set; } //Las imágenes de los héroes que se muestran
        = new ObservableCollection<string>
          {
              "ms-appx:///Assets/Graves.jpg",
              "ms-appx:///Assets/Graves.jpg",
              "ms-appx:///Assets/Graves.jpg",
              "ms-appx:///Assets/Graves.jpg",
              "ms-appx:///Assets/Graves.jpg",
              "ms-appx:///Assets/Graves.jpg"
          };
        public Multijugador()
        {
            this.InitializeComponent();
        }

        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void Heroe_Click(object sender, RoutedEventArgs e)
        {
            Visibility estado = DesplegableHeroe.Visibility;
            if (estado == Visibility.Visible) DesplegableHeroe.Visibility = Visibility.Collapsed;
            else DesplegableHeroe.Visibility = Visibility.Visible;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Ajustes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        private void Coop_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Partida));
        }


        private void Versus_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Partida));
        }
    }
}
