using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class SarajevoPrevoz : INotifyPropertyChanged
    {
        List<Stanica> listaStanica = new List<Stanica>();
        List<Vozilo> listaVozila = new List<Vozilo>();
        List<Radnik> listaRadnika = new List<Radnik>();
        List<Korisnik> listaRegistrovanihKorisnika = new List<Korisnik>();

        public List<Stanica> ListaStanica { get => listaStanica; set => listaStanica = value; }
        public List<Vozilo> ListaVozila { get => listaVozila; set => listaVozila = value; }
        public List<Radnik> ListaRadnika { get => listaRadnika; set => listaRadnika = value; }
        public List<Korisnik> ListaRegistrovanihKorisnika { get => listaRegistrovanihKorisnika; set => listaRegistrovanihKorisnika = value; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
