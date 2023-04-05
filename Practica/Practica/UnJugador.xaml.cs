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
    public sealed partial class UnJugador : Page
    {
        public UnJugador()
        {
            this.InitializeComponent();
        }
        //Navegación entre páginas
        private void RetornoMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Ajustes_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        private void ImagenTienda_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void BotonTienda_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void BotonInfinito_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Partida));
        }

        private void BotonJugar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Partida));
        }

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

        private void ImagenHeroe_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Ajusta la visibilidad del desplegables de héroes
            Visibility estado = DesplegableHeroe.Visibility;
            if (estado == Visibility.Visible) DesplegableHeroe.Visibility = Visibility.Collapsed;
            else DesplegableHeroe.Visibility = Visibility.Visible;
        }
    }
}
