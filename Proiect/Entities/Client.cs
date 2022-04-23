using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    [Serializable]
    public class Client
    {
        #region Attributes
        public long IdClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public BindingList<Asigurare> Asigurari { get; set; }
        #endregion

        public Client() { }

        public Client(string nume, string prenume, int varsta, BindingList<Asigurare> asigurari)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Asigurari = asigurari;
        }

        public Client(long idClient, string nume, string prenume, int varsta, BindingList<Asigurare> asigurari) : this(nume, prenume, varsta, asigurari)
        {
            IdClient = idClient;
        }
    }
}
