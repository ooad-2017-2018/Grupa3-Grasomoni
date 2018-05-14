using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Korisnik
    {
        string ime;
        string prezime;
        string korisnickoIme;
        string email;
        string lozinka;

        public Korisnik() { }

        public Korisnik(string ime, string prezime, string korisnickoIme, string email, string lozinka)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Email = email;
            this.Lozinka = lozinka;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Email { get => email; set => email = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
    }
}
