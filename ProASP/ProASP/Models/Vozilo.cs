using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProASP.Models
{
    public class Vozilo
    {
        int id;
        string vrstaVozila;
        string registracijskiBroj;

        public Vozilo(int id, string vrstaVozila, string registracijskiBroj)
        {
            this.Id = id;
            this.VrstaVozila = vrstaVozila;
            this.RegistracijskiBroj = registracijskiBroj;
        }

        public string VrstaVozila { get => vrstaVozila; set => vrstaVozila = value; }
        public string RegistracijskiBroj { get => registracijskiBroj; set => registracijskiBroj = value; }
        public int Id { get => id; set => id = value; }
    }
}