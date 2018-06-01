using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPProjekat.Models
{
    public class Radnik
    {
        static int globalID = 1;
        int idRadnika;
        double plata;
        string tipPosla;

        public Radnik(double plata, string tipPosla)
        {
            this.idRadnika = globalID++;
            this.plata = plata;
            this.tipPosla = tipPosla;
        }

        public int IdRadnika { get => idRadnika; set => idRadnika = value; }
        public double Plata { get => plata; set => plata = value; }
        public string TipPosla { get => tipPosla; set => tipPosla = value; }
    }
}