using Microsoft.WindowsAzure.MobileServices;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prijava : Page
    {
        string korisnickoIme, lozinka;
        SarajevoPrevoz s;
        public Prijava()
        {
            this.InitializeComponent();
            Korisnik k = new Korisnik("1", "Ime", "Prezime", 1234567890123, "ime_p@hotmail.com", "imenko123", "prezimenko123");
            s = new SarajevoPrevoz();
            s.ListaRegistrovanihKorisnika.Add(k);
        }

        public static MobileServiceClient MobileService = new MobileServiceClient("https://grasomoni.azurewebsites.net");

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        private void KorisnickoText_TextChanged(object sender, TextChangedEventArgs e)
        {
            korisnickoIme = korisnickoText.Text;
        }

        private void RegistrujButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }


        private void prijavaButton_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < s.ListaRegistrovanihKorisnika.Count; i++)
            {
                if (s.ListaRegistrovanihKorisnika[i].korisnickoIme == korisnickoIme && s.ListaRegistrovanihKorisnika[i].lozinka == lozinka)
                    this.Frame.Navigate(typeof(MeniRegistrovani), s.ListaRegistrovanihKorisnika[i]);
            }
        }

        private void lozinkaPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            lozinka = lozinkaPassBox.Password;
        }

        private void gostButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MeniGost));
        }
    }
}
