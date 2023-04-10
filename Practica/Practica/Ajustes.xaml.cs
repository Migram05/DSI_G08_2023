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
        //Variable que se asegura de que se han inizializado todos los objetos antes de ajustar el volumen de los efectos
        private bool checkVol = false;
        public Ajustes()
        {
            this.InitializeComponent();
            //Se ajusta el valor de volumen para el efecto de sonido de esta página
            checkVol = true;
            var app = (App)Application.Current;
            clickSound.Volume = app.getEffectVolume();
        }

        //Se ejecuta el sonido de click al pulsar en cualquier parte del Grid
        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            clickSound.Play();
        }

        //Navegación a páginas
        private void ImagenMenuPrincipal(object sender, TappedRoutedEventArgs e)
        {
            //Regresa a la página de donde se entró a ajustes
            Type previousPageType = this.Frame.BackStack.LastOrDefault()?.SourcePageType; //Se guarda el tipo de la página de procedencia
            if (Frame.CanGoBack && !(previousPageType == typeof(AjustesSociales)))
                Frame.GoBack();
            else
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
        //Muteo del sonido
        private void MusicMuteImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Referencia a la aplicación
            var app = (App)Application.Current;
            app.setVolume(0); //Llamada al método
            MusicSlider.Value = 0;
        }

        private void MusicSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //Referencia a la aplicación
            var app = (App)Application.Current;
            app.setVolume((float)MusicSlider.Value/100); //Llamada al método
        }
        //Se mutean los efectos de sonido, click
        private void MuteEffects_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var app = (App)Application.Current;
            app.getEffect().Volume = 0;
            EffectSlider.Value = 0;
            clickSound.Volume = 0;
        }

        private void EffectSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //Referencia a la aplicación
            var app = (App)Application.Current;
            app.getEffect().Volume = ((float)EffectSlider.Value / 100); //Se modifica el volumen
            //Se ajusta el volumen del efecto para esta página
            if(checkVol) clickSound.Volume = app.getEffectVolume();

        }

        
    }
}
