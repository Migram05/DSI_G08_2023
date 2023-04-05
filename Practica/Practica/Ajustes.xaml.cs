using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
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
    public sealed partial class Ajustes : Page
    {
        public Ajustes()
        {
            this.InitializeComponent();
        }

        //Navegación a páginas
        private void ImagenMenuPrincipal(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void BotonAjustesSociales_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AjustesSociales));
        }
        private void languageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtener el idioma seleccionado del ComboBoxItem seleccionado
            ComboBoxItem selectedItem = languageComboBox.SelectedItem as ComboBoxItem;
            string selectedLanguage = selectedItem.Tag.ToString();

            // Cambiar el idioma de la aplicación a través del objeto ApplicationLanguages
            ApplicationLanguages.PrimaryLanguageOverride = selectedLanguage;
        }

    }
}
