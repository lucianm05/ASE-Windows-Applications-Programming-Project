using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Entities;

namespace Proiect.ViewModels
{
    internal class MainFormViewModel
    {
        public BindingList<Asigurare> Asigurari { get; set; }
        public BindingList<Client> Clienti { get; set; }

        public MainFormViewModel()
        {
            Asigurari = new BindingList<Asigurare>();
            Clienti = new BindingList<Client>();
        }
    }
}
