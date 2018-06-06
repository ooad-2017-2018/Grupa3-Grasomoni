using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProASP.Models
{
    public class Korisnik
    {

        public int Id { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime;

        [Required]
        public long Jmbg { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string KorisnickoIme { get; set; }

        [Required]
        public string Lozinka { get; set; }

        public Korisnik() { }
        public Korisnik(int id, string ime, string prezime, long jmbg, string email, string korisnickoIme, string lozinka)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.Email = email;
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
        }

    }
}