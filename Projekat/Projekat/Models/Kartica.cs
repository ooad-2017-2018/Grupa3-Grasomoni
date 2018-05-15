using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Kartica : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        string brojKartice;
        double stanjeRacuna;
        DateTime datumIsteka;

        public Kartica(string brojKartice, double stanjeRacuna, DateTime datumIsteka)
        {
            this.BrojKartice = brojKartice;
            this.StanjeRacuna = stanjeRacuna;
            this.DatumIsteka = datumIsteka;
        }

        public string BrojKartice { get => brojKartice; set => brojKartice = value; }
        public double StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }
        public DateTime DatumIsteka { get => datumIsteka; set => datumIsteka = value; }


        public bool HasErrors => throw new NotImplementedException();
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
