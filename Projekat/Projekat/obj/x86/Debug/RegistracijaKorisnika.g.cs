﻿#pragma checksum "C:\Users\hp\Desktop\Projekat1\Projekat\Projekat\RegistracijaKorisnika.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FD66D5491B7DE90605F1CAE90E6947DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekat
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // RegistracijaKorisnika.xaml line 14
                {
                    this.btnSpasi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSpasi).Tapped += this.btnSpasi_Tapped;
                }
                break;
            case 2: // RegistracijaKorisnika.xaml line 16
                {
                    this.btnNazad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnNazad).Tapped += this.btnNazad_Tapped;
                }
                break;
            case 3: // RegistracijaKorisnika.xaml line 18
                {
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // RegistracijaKorisnika.xaml line 19
                {
                    this.imeText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.imeText).TextChanged += this.ImeText_textChanged;
                }
                break;
            case 5: // RegistracijaKorisnika.xaml line 20
                {
                    this.prezimeText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.prezimeText).TextChanged += this.PrezimeText_textChanged;
                }
                break;
            case 6: // RegistracijaKorisnika.xaml line 21
                {
                    this.jmbgText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.jmbgText).TextChanged += this.JmbgText_textChanged;
                }
                break;
            case 7: // RegistracijaKorisnika.xaml line 22
                {
                    this.korisnickoText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.korisnickoText).TextChanged += this.KorisnickoText_textChanged;
                }
                break;
            case 8: // RegistracijaKorisnika.xaml line 23
                {
                    this.emailText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.emailText).TextChanged += this.EmailText_textCHanged;
                }
                break;
            case 9: // RegistracijaKorisnika.xaml line 24
                {
                    this.lozinkaPassBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.lozinkaPassBox).PasswordChanged += this.PasswordBox_PasswordChanged;
                }
                break;
            case 10: // RegistracijaKorisnika.xaml line 25
                {
                    this.plozinkaPassBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.plozinkaPassBox).PasswordChanged += this.plozinkaPassBox_PasswordChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
