using Projekat.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MeniGost : Page
    {
        public MeniGost()
        {
            this.InitializeComponent();
        }

        public SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
            return myBrush;
        }

        private void slika_Tapped(object sender, TappedRoutedEventArgs e)
        {
            cijeneKontrola.Visibility = Visibility.Collapsed;
            lokacijeKontrola.Visibility = Visibility.Collapsed;
            vozilaKontrola.Visibility = Visibility.Collapsed;
            oNamaKontrola.Visibility = Visibility.Visible;

            cijeneButton.Background = GetSolidColorBrush("#FF333337");
            lokacijeButton.Background = GetSolidColorBrush("#FF333337");
            vozilaButton.Background = GetSolidColorBrush("#FF333337");
        }

        private void cijene_Tapped(object sender, TappedRoutedEventArgs e)
        {
            oNamaKontrola.Visibility = Visibility.Collapsed;
            lokacijeKontrola.Visibility = Visibility.Collapsed;
            vozilaKontrola.Visibility = Visibility.Collapsed;
            cijeneKontrola.Visibility = Visibility.Visible;
            cijeneButton.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            lokacijeButton.Background = GetSolidColorBrush("#FF333337");
            vozilaButton.Background = GetSolidColorBrush("#FF333337");

        }

        private void lokacije_Tapped(object sender, TappedRoutedEventArgs e)
        {
            oNamaKontrola.Visibility = Visibility.Collapsed;
            lokacijeKontrola.Visibility = Visibility.Visible;
            vozilaKontrola.Visibility = Visibility.Collapsed;
            cijeneKontrola.Visibility = Visibility.Collapsed;
            lokacijeButton.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            cijeneButton.Background = GetSolidColorBrush("#FF333337");
            vozilaButton.Background = GetSolidColorBrush("#FF333337");
        }

        private void vozila_Tapped(object sender, TappedRoutedEventArgs e)
        {
            oNamaKontrola.Visibility = Visibility.Collapsed;
            lokacijeKontrola.Visibility = Visibility.Collapsed;
            vozilaKontrola.Visibility = Visibility.Visible;
            cijeneKontrola.Visibility = Visibility.Collapsed;
            vozilaButton.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            lokacijeButton.Background = GetSolidColorBrush("#FF333337");
            cijeneButton.Background = GetSolidColorBrush("#FF333337");
        }

        private void image_doubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }
    }
}
