using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public abstract class Korisnik
    {
        string ime;
        string prezime;
        long jmbg;

        public Korisnik() { }

        public Korisnik(string ime, string prezime, long jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }
    }
}
