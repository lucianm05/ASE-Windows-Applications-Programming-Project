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
    public partial class ClientForm : Form
    {
        public Client client { get; set; }

        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(Client client) : this()
        {
            this.client = client;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            if (this.client != null) {
                tbClientNume.Text = this.client.Nume;
                tbClientPrenume.Text = this.client.Prenume;
                numClientVarsta.Value = this.client.Varsta;
            }
        }

        #region Validations 

        private void tbClientNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbClientNume.Text.Trim().Length == 0)
            {
                errorProviderClient.SetError(tbClientNume, "Numele este obligatoriu!");
                e.Cancel = true;
            }
        }

        private void tbClientNume_Validated(object sender, EventArgs e)
        {
            errorProviderClient.SetError(tbClientNume, null);
        }

        private void tbClientPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbClientPrenume.Text.Trim().Length == 0)
            {
                errorProviderClient.SetError(tbClientPrenume, "Prenumele este obligatoriu!");
                e.Cancel = true;
            }
        }

        private void tbClientPrenume_Validated(object sender, EventArgs e)
        {
            errorProviderClient.SetError(tbClientPrenume, null);
        }

        private void numClientVarsta_Validating(object sender, CancelEventArgs e)
        {
            int varsta = (int)numClientVarsta.Value;
            if (varsta < 1)
            {
                errorProviderClient.SetError(numClientVarsta, "Varsta nu poate fi mai mica decat 1 an!");
                e.Cancel = true;
            }
        }

        private void numClientVarsta_Validated(object sender, EventArgs e)
        {
            errorProviderClient.SetError(numClientVarsta, null);
        }

        #endregion

        private void btnOkClient_Click(object sender, EventArgs e)
        {
            if (this.client == null)
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Formularul contine erori!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string nume = tbClientNume.Text;
                string prenume = tbClientPrenume.Text;
                int varsta = (int)numClientVarsta.Value;

                Client client = new Client(nume, prenume, varsta, new BindingList<Asigurare> { });

                this.client = client;
            } else
            {
                this.client.Nume = tbClientNume.Text;
                this.client.Prenume = tbClientPrenume.Text;
                this.client.Varsta = (int)numClientVarsta.Value;
            }

            this.Close();
        }
    }
}
