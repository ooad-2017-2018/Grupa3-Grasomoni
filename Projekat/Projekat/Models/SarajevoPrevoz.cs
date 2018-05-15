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
        List<RegistrovaniKorisnik> listaRegistrovanihKorisnika = new List<RegistrovaniKorisnik>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
