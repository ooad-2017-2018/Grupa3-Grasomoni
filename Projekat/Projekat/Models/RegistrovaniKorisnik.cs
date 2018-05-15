using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class RegistrovaniKorisnik : Korisnik
    {
        string korisnickoIme;
        string lozinka;
        string email;
        Kartica kartica;

        public RegistrovaniKorisnik() { } 

        public RegistrovaniKorisnik(string ime, string prezime, long jmbg, string korisnickoIme, string lozinka, string email, Kartica kartica) : base(ime, prezime, jmbg)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.email = email;
            this.kartica = kartica;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Email { get => email; set => email = value; }
        public Kartica Kartica { get => kartica; set => kartica = value; }
    }
}
