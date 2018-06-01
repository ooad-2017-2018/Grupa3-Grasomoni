using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPProjekat.Models
{
    public class Korisnik
    {
        public Korisnik(string id, string ime, string prezime, long jmbg, string email, string korisnickoIme, string lozinka)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.email = email;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        public Korisnik() { }
        public string id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public long jmbg { get; set; }
        public string email { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }

    }
}