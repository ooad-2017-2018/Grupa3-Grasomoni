using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProASP.Models
{
    public class Kartica
    {
        int id;
        double stanjeRacuna;
        DateTime datumIsteka;

        public Kartica(int id, double stanjeRacuna, DateTime datumIsteka)
        {
            this.Id = id;
            this.StanjeRacuna = stanjeRacuna;
            this.DatumIsteka = datumIsteka;
        }

        public int Id { get => id; set => id = value; }
        public double StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }
        public DateTime DatumIsteka { get => datumIsteka; set => datumIsteka = value; }
    }
}