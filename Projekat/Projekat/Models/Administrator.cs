using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Administrator : Korisnik
    {
        string korisnickoIme;
        string lozinka;
        SarajevoPrevoz pristupPodacima;

        public Administrator(string korisnickoIme, string lozinka, SarajevoPrevoz pristupPodacima)
        {
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
            this.PristupPodacima = pristupPodacima;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public SarajevoPrevoz PristupPodacima { get => pristupPodacima; set => pristupPodacima = value; }
    }
}
