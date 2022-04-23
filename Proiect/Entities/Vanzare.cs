using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Vanzare
    {
        public string Denumire { get; set; }
        public int IdAsigurare { get; set; }
        public int Count { get; set; }

        public Vanzare() { }

        public Vanzare(string denumire, int idAsig, int count)
        {
            Denumire = denumire;
            IdAsigurare = idAsig; 
            Count = count;
        }
    }
}
