using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Stanica
    {
        static int globalID = 1;
        int idStanice;
        string nazivStanice;
        string lokacija;

        public Stanica(string nazivStanice, string lokacija)
        {
            this.idStanice = globalID++;
            this.nazivStanice = nazivStanice;
            this.lokacija = lokacija;
        }

        public int IdStanice { get => idStanice; set => idStanice = value; }
        public string NazivStanice { get => nazivStanice; set => nazivStanice = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
    }
}
