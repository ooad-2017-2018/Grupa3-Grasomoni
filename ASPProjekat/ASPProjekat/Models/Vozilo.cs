using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPProjekat.Models
{
    public class Vozilo
    {
        string vrstaVozila;
        string registracijskiBroj;

        public Vozilo(string vrstaVozila, string registracijskiBroj)
        {
            this.VrstaVozila = vrstaVozila;
            this.RegistracijskiBroj = registracijskiBroj;
        }

        public string VrstaVozila { get => vrstaVozila; set => vrstaVozila = value; }
        public string RegistracijskiBroj { get => registracijskiBroj; set => registracijskiBroj = value; }
    }
}