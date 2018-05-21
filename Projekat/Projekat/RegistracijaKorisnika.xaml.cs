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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Projekat.Models;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class BlankPage1 : Page
    {
        string ime, prezime, email, korisnickoIme, lozinka, plozinka;
        long jmbg;

        public BlankPage1()
        {
            this.InitializeComponent();
        }

            private void JmbgText_textChanged(object sender, TextChangedEventArgs e)
        {
            if (!(long.TryParse(jmbgText.Text, out jmbg)))
                throw new Exception();
        }

        private void KorisnickoText_textChanged(object sender, TextChangedEventArgs e)
        {
            korisnickoIme = korisnickoText.Text;
        }

        private void EmailText_textCHanged(object sender, TextChangedEventArgs e)
        {
            email = emailText.Text;
        }

        private void validacija(string i, string p, long j, string e, string k, string l, string pl)
        {
            if (i.Length < 1) throw new Exception("Unesite ime!");
            if (p.Length < 1) throw new Exception("Unesite prezime!");
            if (j.ToString().Length != 13) throw new Exception("Nepravilan format jmbga!");
            if (lozinka.Length < 6 && l.Length > 19) throw new Exception("Lozinka mora imati najmanje 6 karaktera, a najvise 19");
            if (l != pl) throw new Exception("Lozinke se ne podudaraju!");
        }

        private void btnNazad_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void btnSpasi_Tapped(object sender, TappedRoutedEventArgs e)
        {
            IMobileServiceTable<Korisnik> userTableObj = App.MobileService.GetTable<Korisnik>();
            try
            {
                Korisnik k = new Korisnik();
                k.ime = imeText.Text;
                k.prezime = prezimeText.Text;
                k.jmbg = long.Parse(jmbgText.Text);
                k.email = emailText.Text;
                k.korisnickoIme = korisnickoText.Text;
                k.lozinka = lozinkaPassBox.Password;
                plozinka = plozinkaPassBox.Password;
                validacija(k.ime, k.prezime, k.jmbg, k.email, k.korisnickoIme, k.lozinka, plozinka);
                userTableObj.InsertAsync(k);
                MessageDialog msgDialog = new MessageDialog("Uspješna registracija!");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            lozinka = lozinkaPassBox.Password;
        }

        private void plozinkaPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            plozinka = plozinkaPassBox.Password;
        }

        private void PrezimeText_textChanged(object sender, TextChangedEventArgs e)
        {
            prezime = prezimeText.Text;
        }

        private void ImeText_textChanged(object sender, TextChangedEventArgs e)
        {
            ime = imeText.Text;
        }

    }
}
