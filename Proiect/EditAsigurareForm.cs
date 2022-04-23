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
    public partial class EditAsigurareForm : Form
    {
        private Asigurare asigurare;

        public EditAsigurareForm(Asigurare asigurare)
        {
            this.asigurare = asigurare;
            InitializeComponent();
        }

        private void EditAsigurareForm_Load(object sender, EventArgs e)
        {
            cbAsigTip.SelectedItem = asigurare.Tip;
            tbAsigDenumire.Text = asigurare.Denumire;
            numAsigVarstaMin.Value = asigurare.VarstaMin;
            numAsigVarstaMax.Value = asigurare.VarstaMax;
            numAsigDurataMin.Value = asigurare.DurataMin;
            numAsigDurataMax.Value = asigurare.DurataMax;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            asigurare.Tip = cbAsigTip.SelectedItem.ToString();
            asigurare.Denumire = tbAsigDenumire.Text;
            asigurare.VarstaMin = (int)numAsigVarstaMin.Value;
            asigurare.VarstaMax = (int)numAsigVarstaMax.Value;
            asigurare.DurataMin = (int)numAsigDurataMin.Value;
            asigurare.DurataMax = (int)numAsigDurataMax.Value;
        }
    }
}
