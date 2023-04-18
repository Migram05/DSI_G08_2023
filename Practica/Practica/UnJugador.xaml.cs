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
using Windows.UI.Xaml.Media.Imaging;
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
            //Se ajusta el valor de volumen para el efecto de sonido de esta página
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }
        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
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
              "ms-appx:///Assets/gankplank.jpg",
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

        private void DesplegableHeroe_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void ajustesButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }

        private void botonHeroe_Click(object sender, RoutedEventArgs e)
        {
            //Ajusta la visibilidad del desplegables de héroes
            Visibility estado = DesplegableHeroe.Visibility;
            if (estado == Visibility.Visible) DesplegableHeroe.Visibility = Visibility.Collapsed;
            else DesplegableHeroe.Visibility = Visibility.Visible;
        }

        private void retornoMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
