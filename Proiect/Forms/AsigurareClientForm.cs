using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Entities;

namespace Proiect
{
    public partial class AsigurareClientForm : Form
    {
        private BindingList<Asigurare> asigurari;
        private BindingList<Asigurare> selectedAsigurari;
        public BindingList<Asigurare> deselectedAsigurari { get; set; }
        public AsigurareClientForm(BindingList<Asigurare> asigurari, BindingList<Asigurare> selectedAsigurari)
        {
            this.asigurari = asigurari;
            this.selectedAsigurari = selectedAsigurari;
            this.deselectedAsigurari = new BindingList<Asigurare>();
            InitializeComponent();
        }

        private void AsigurareClientForm_Load(object sender, EventArgs e)
        {
            foreach (Asigurare asigurare in this.asigurari)
            {
                Asigurare asigurareExistenta = this.selectedAsigurari.FirstOrDefault(a => a.IdAsigurare == asigurare.IdAsigurare);
                clbAsigurari.Items.Add(asigurare.Denumire, asigurareExistenta != null);
            }
        }

        private void btnAddAsigurareClient_Click(object sender, EventArgs e)
        {
            Console.WriteLine(clbAsigurari.Items.Count);
            for (int i = 0; i < clbAsigurari.Items.Count; i++)
            {
                Asigurare asigurare = this.asigurari.FirstOrDefault(a => a.Denumire == clbAsigurari.Items[i].ToString());
                if (clbAsigurari.GetItemChecked(i))
                {
                    this.selectedAsigurari.Add(asigurare);
                }
                else
                {
                    this.deselectedAsigurari.Add(asigurare);
                }
            }
        }
    }
}
