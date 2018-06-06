using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProASP.Models
{
    public class Stanica
    {
        static int globalID = 1;
        int id;
        string nazivStanice;
        string lokacija;

        public Stanica(string nazivStanice, string lokacija)
        {
            this.Id = globalID++;
            this.NazivStanice = nazivStanice;
            this.Lokacija = lokacija;
        }

        public int Id { get => id; set => id = value; }
        public string NazivStanice { get => nazivStanice; set => nazivStanice = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
    }
}