using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public enum TipAsigurare
    {
        Viata,
        Casa,
        Sanatate
    }

    [Serializable]
    public class Asigurare
    {
        #region Attributes
        public long IdAsigurare { get; set; }
        public string Tip {get; set;}
        public string Denumire { get; set; }
        public int VarstaMin { get; set; }
        public long VarstaMax { get; set; }
        public int DurataMin { get; set; }
        public int DurataMax { get; set; }

        #endregion

        public Asigurare() { }

        public Asigurare(string tip, string denumire, int varstaMin, int varstaMax, int durataMin, int durataMax)
        {
            Tip = tip;
            Denumire = denumire;
            VarstaMin = varstaMin;
            VarstaMax = varstaMax;
            DurataMin = durataMin;
            DurataMax = durataMax;
        }

        public Asigurare(long id, string tip, string denumire, int varstaMin, int varstaMax, int durataMin, int durataMax) : this(tip, denumire, varstaMin, varstaMax, durataMin, durataMax)
        {
            IdAsigurare = id;
        }

    }
}
