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
    public sealed partial class PotvrdaVoznje : Page
    {
        public PotvrdaVoznje()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void nastaviButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            proracunataCijenaText.Text = (Math.Abs(pocetnaCB.SelectedIndex - krajnjaCB.SelectedIndex) * 0.1 + 0.2).ToString() + " KM";
            podaciRP.Visibility = Visibility.Visible;
        }

        private void odbijButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            podaciRP.Visibility = Visibility.Collapsed;
            this.Frame.Navigate(typeof(MeniRegistrovani));
            
        }
    }
}
