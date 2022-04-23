using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Entities;
using Proiect.ViewModels;
using static System.Windows.Forms.Control;
using System.Xml.Serialization;
using System.IO;

namespace Proiect
{

    public partial class MainForm : Form
    {
        #region Attributes
        private readonly MainFormViewModel viewModel = new MainFormViewModel();
        private const string connectionString = "Data Source=C:\\Users\\lucia\\source\\repos\\Proiect\\Proiect\\db.db";
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods

        #region Asigurari
        private void AddAsigurare(Asigurare asigurare)
        {
            string query = "INSERT INTO ASIGURARI(TIP, DENUMIRE, VARSTA_MIN, VARSTA_MAX, DURATA_MIN, DURATA_MAX) VALUES (@tip, @denumire, @varstaMin, @varstaMax, @durataMin, @durataMax); SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tip", asigurare.Tip);
                    command.Parameters.AddWithValue("@denumire", asigurare.Denumire);
                    command.Parameters.AddWithValue("@varstaMin", asigurare.VarstaMin);
                    command.Parameters.AddWithValue("@varstaMax", asigurare.VarstaMax);
                    command.Parameters.AddWithValue("@durataMin", asigurare.DurataMin);
                    command.Parameters.AddWithValue("@durataMax", asigurare.DurataMax);

                    connection.Open();

                    long id = (long)command.ExecuteScalar();

                    asigurare.IdAsigurare = id;

                    viewModel.Asigurari.Add(asigurare);
                }

            }

            ssLabel.Text = "Asigurarea a fost adaugata cu succes!";
        }

        private void LoadAsigurari()
        {
            viewModel.Asigurari.Clear();

            const string query = "SELECT * FROM ASIGURARI;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string tip = reader.GetString(1);
                        string denumire = reader.GetString(2);
                        int varstaMin = reader.GetInt32(3);
                        int varstaMax = reader.GetInt32(4);
                        int durataMin = reader.GetInt32(5);
                        int durataMax = reader.GetInt32(6);

                        Asigurare asigurare = new Asigurare(id, tip, denumire, varstaMin, varstaMax, durataMin, durataMax);

                        viewModel.Asigurari.Add(asigurare);
                    }
                }
            }
        }

        private void DisplayAsigurari()
        {
            LoadAsigurari();

            dgvAsigurari.DataSource = viewModel.Asigurari;
        }

        private void DeleteAsigurare(Asigurare asigurare)
        {
            string query = "DELETE FROM ASIGURARI WHERE ID_ASIGURARE = @id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", asigurare.IdAsigurare);

                connection.Open();

                command.ExecuteNonQuery();

                viewModel.Asigurari.Remove(asigurare);
            }

            ssLabel.Text = "Asigurarea a fost stearsa.";
        }

        private void EditAsigurare(Asigurare asigurare)
        {
            string query = "UPDATE ASIGURARI SET TIP=@tip, DENUMIRE=@denumire, VARSTA_MIN=@varstaMin, VARSTA_MAX=@varstaMax, DURATA_MIN=@durataMin, DURATA_MAX=@durataMax WHERE ID_ASIGURARE=@id;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", asigurare.IdAsigurare);
                command.Parameters.AddWithValue("@tip", asigurare.Tip);
                command.Parameters.AddWithValue("@denumire", asigurare.Denumire);
                command.Parameters.AddWithValue("@varstaMin", asigurare.VarstaMin);
                command.Parameters.AddWithValue("@varstaMax", asigurare.VarstaMax);
                command.Parameters.AddWithValue("@durataMin", asigurare.DurataMin);
                command.Parameters.AddWithValue("@durataMax", asigurare.DurataMax);

                connection.Open();

                command.ExecuteNonQuery();

                DisplayAsigurari();
            }

            ssLabel.Text = "Asigurarea a fost editata cu succes!";
        }
        #endregion

        private bool ExistsAsigurareClient(Asigurare asigurare, Client client)
        {
            string query = "SELECT COUNT(ID_ASIGURARE) FROM ASIGURARI_CLIENTI WHERE ID_CLIENT = @idClient AND ID_ASIGURARE = @idAsigurare;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idClient", client.IdClient);
                command.Parameters.AddWithValue("@idAsigurare", asigurare.IdAsigurare);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rows = reader.GetInt32(0);

                        if (rows > 0) return true;
                        if (rows <= 0) return false;
                    }
                }


            }

            return false;
        }

        private void AddAsigurareClient(Asigurare asigurare, Client client)
        {
            string query = "INSERT INTO ASIGURARI_CLIENTI(ID_CLIENT, ID_ASIGURARE) VALUES(@idClient, @idAsigurare);";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idClient", client.IdClient);
                command.Parameters.AddWithValue("@idAsigurare", asigurare.IdAsigurare);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        private void DeleteAsigurareClient(Asigurare asigurare, Client client)
        {
            string query = "DELETE FROM ASIGURARI_CLIENTI WHERE ID_CLIENT=@idClient AND ID_ASIGURARE=@idAsigurare";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idClient", client.IdClient);
                command.Parameters.AddWithValue("@idAsigurare", asigurare.IdAsigurare);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        private void LoadAsigurariClient(Client client)
        {
            string query = "SELECT * FROM ASIGURARI WHERE ID_ASIGURARE IN (SELECT ID_ASIGURARE FROM ASIGURARI_CLIENTI WHERE ID_CLIENT = @idClient);";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idClient", client.IdClient);

                connection.Open();

                client.Asigurari.Clear();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string tip = reader.GetString(1);
                        string denumire = reader.GetString(2);
                        int varstaMin = reader.GetInt32(3);
                        int varstaMax = reader.GetInt32(4);
                        int durataMin = reader.GetInt32(5);
                        int durataMax = reader.GetInt32(6);

                        Asigurare asigurare = new Asigurare(id, tip, denumire, varstaMin, varstaMax, durataMin, durataMax);

                        client.Asigurari.Add(asigurare);
                    }
                }
            }
        }

        private void FetchVanzariAsigurari()
        {
            string query = "SELECT ASIG.DENUMIRE, AC.ID_ASIGURARE, COUNT(AC.ID_ASIGURARE) FROM ASIGURARI_CLIENTI AC JOIN ASIGURARI ASIG ON AC.ID_ASIGURARE = ASIG.ID_ASIGURARE GROUP BY AC.ID_ASIGURARE;";

            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                List<Vanzare> vanzari = new List<Vanzare>();

                connection.Open();

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read()) {
                        string denumire = reader.GetString(0);
                        int idAsig = reader.GetInt32(1);
                        int count = reader.GetInt32(2);

                        Vanzare vanzare = new Vanzare(denumire, idAsig, count);

                        vanzari.Add(vanzare);
                    }
                }

                ChartForm form = new ChartForm(vanzari);

                form.ShowDialog();
            }
        }

        #region Clienti
        private void AddClient(Client client)
        {
            string query = "INSERT INTO CLIENTI(NUME, PRENUME, VARSTA) VALUES(@nume, @prenume, @varsta); SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@varsta", client.Varsta);

                connection.Open();

                long id = (long)command.ExecuteScalar();

                client.IdClient = id;

                viewModel.Clienti.Add(client);
            }
        }

        private void LoadClienti()
        {
            viewModel.Clienti.Clear();

            string query = "SELECT * FROM CLIENTI;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string nume = reader.GetString(1);
                        string prenume = reader.GetString(2);
                        int varsta = reader.GetInt32(3);

                        Client client = new Client(id, nume, prenume, varsta, new BindingList<Asigurare> { });

                        LoadAsigurariClient(client);

                        viewModel.Clienti.Add(client);
                    }
                }
            }
        }

        private void DisplayClienti()
        {
            LoadClienti();

            dgvClienti.DataSource = viewModel.Clienti;

            /*if (!dgvClienti.Columns.Contains("Asigurari"))
            {
                DataGridViewColumn colAsigurari = new DataGridViewColumn();
                colAsigurari.Name = "Asigurari";
                colAsigurari.CellTemplate = new DataGridViewTextBoxCell();
                colAsigurari.Width = 300;
                dgvClienti.Columns.Add(colAsigurari);
            }

            for (int i = 0; i < viewModel.Clienti.Count; i++)
            {
                Client client = viewModel.Clienti[i];
                List<string> denumiriAsigurari = new List<string>();
                foreach (Asigurare asigurare in client.Asigurari)
                {
                    Console.WriteLine(asigurare.Denumire);
                    denumiriAsigurari.Add(asigurare.Denumire);
                }
                string denumire = string.Join(", ", denumiriAsigurari);
                dgvClienti.Rows[i].Cells[4].Value = denumire;
            }*/
        }

        private void DeleteClient(Client client)
        {
            string query = "DELETE FROM CLIENTI WHERE ID_CLIENT=@id; DELETE FROM ASIGURARI_CLIENTI WHERE ID_CLIENT=@id;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", client.IdClient);

                connection.Open();

                command.ExecuteNonQuery();

                DisplayClienti();
            }
        }

        private void EditClient(Client client)
        {
            string query = "UPDATE CLIENTI SET NUME=@nume, PRENUME=@prenume, VARSTA=@varsta WHERE ID_CLIENT=@id;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", client.IdClient);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@varsta", client.Varsta);

                connection.Open();

                command.ExecuteScalar();

                DisplayClienti();
            }
        }
        #endregion

        private void DeserializeXMLAsigurari(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Asigurare>));

            using (FileStream stream = File.OpenRead(filename))
            {
                viewModel.Asigurari = (BindingList<Asigurare>)serializer.Deserialize(stream);

                dgvAsigurari.DataSource = viewModel.Asigurari;
            }
        }

        private void SaveAsTXT()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT file | *.txt";
            saveFileDialog.Title = "Salvati ca fisier text";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("====== CLIENTI ======");

                    foreach (Client client in viewModel.Clienti)
                    {
                        sw.WriteLine("");
                        sw.WriteLine("--------------------");
                        sw.WriteLine("Nume: " + client.Nume);
                        sw.WriteLine("Prenume: " + client.Prenume);
                        sw.WriteLine("Varsta: " + client.Varsta);
                        List<string> denumiriAsigurari = new List<string>();
                        foreach (Asigurare asigurare in client.Asigurari)
                        {
                            denumiriAsigurari.Add(asigurare.Denumire);
                        }
                        string denumire = string.Join(", ", denumiriAsigurari);
                        sw.WriteLine("Asigurari: " + denumire);
                        sw.WriteLine("--------------------");
                        sw.WriteLine("");
                    }

                    sw.WriteLine("=====================");

                    sw.WriteLine("");

                    sw.WriteLine("====== ASIGURARI ======");

                    foreach (Asigurare asigurare in viewModel.Asigurari)
                    {
                        sw.WriteLine("");
                        sw.WriteLine("--------------------");
                        sw.WriteLine("Tip: " + asigurare.Tip);
                        sw.WriteLine("Denumire: " + asigurare.Denumire);
                        sw.WriteLine("Varsta: " + asigurare.VarstaMin + " - " + asigurare.VarstaMax + " ani");
                        sw.WriteLine("Durata: " + asigurare.DurataMin + " - " + asigurare.DurataMax + " ani");
                        sw.WriteLine("--------------------");
                        sw.WriteLine("");
                    }

                    sw.WriteLine("=======================");
                }
            }
        }

        #endregion

        #region Validations
        private void cbAsigTip_Validating(object sender, CancelEventArgs e)
        {
            if (cbAsigTip.SelectedIndex < 0)
            {
                errorProvider.SetError(cbAsigTip, "Tipul asigurarii este obligatoriu!");
                e.Cancel = true;
            }
        }

        private void cbAsigTip_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cbAsigTip, null);
        }

        private void tbAsigDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (tbAsigDenumire.Text.Trim().Length == 0)
            {
                errorProvider.SetError(tbAsigDenumire, "Denumirea asigurarii este obligatorie!");
                e.Cancel = true;
            }
        }

        private void tbAsigDenumire_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbAsigDenumire, null);
        }

        private void numAsigVarstaMin_Validating(object sender, CancelEventArgs e)
        {
            int varstaMin = (int)numAsigVarstaMin.Value;
            int varstaMax = (int)numAsigVarstaMax.Value;
            if (varstaMin < 1 || (varstaMax > 0 && varstaMin > varstaMax))
            {
                errorProvider.SetError(numAsigVarstaMin, "Varsta minima este invalida!");
                e.Cancel = true;
            }
        }

        private void numAsigVarstaMin_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(numAsigVarstaMin, null);
        }

        private void numAsigVarstaMax_Validating(object sender, CancelEventArgs e)
        {
            int varstaMin = (int)numAsigVarstaMin.Value;
            int varstaMax = (int)numAsigVarstaMax.Value;
            if (varstaMax < 1 || (varstaMin > 0 && (varstaMax > 100 || varstaMax < varstaMin)))
            {
                errorProvider.SetError(numAsigVarstaMax, "Varsta maxima este invalida!");
                e.Cancel = true;
            }
        }

        private void numAsigVarstaMax_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(numAsigVarstaMax, null);
        }

        private void numAsigDurataMin_Validating(object sender, CancelEventArgs e)
        {
            int durataMin = (int)numAsigDurataMin.Value;
            int durataMax = (int)numAsigDurataMax.Value;
            if (durataMin < 1 || (durataMax > 0 && durataMin > durataMax))
            {
                errorProvider.SetError(numAsigDurataMin, "Durata minima este invalida!");
                e.Cancel = true;
            }
        }

        private void numAsigDurataMin_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(numAsigDurataMin, null);
        }

        private void numAsigDurataMax_Validating(object sender, CancelEventArgs e)
        {
            int durataMin = (int)numAsigDurataMin.Value;
            int durataMax = (int)numAsigDurataMax.Value;
            if (durataMax < 1 || (durataMin > 0 && (durataMax > 100 || durataMax < durataMin)))
            {
                errorProvider.SetError(numAsigDurataMax, "Durata maxima este invalida!");
                e.Cancel = true;
            }
        }

        private void numAsigDurataMax_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(numAsigDurataMax, null);
        }
        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayClienti();
            DisplayAsigurari();

        }



        #region Events

        #region Asigurari

        private void btnAddAsigurare_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Formularul contine erori!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string tip = cbAsigTip.SelectedItem.ToString();
            string denumire = tbAsigDenumire.Text;
            int varstaMin = (int)numAsigVarstaMin.Value;
            int varstaMax = (int)numAsigVarstaMax.Value;
            int durataMin = (int)numAsigDurataMin.Value;
            int durataMax = (int)numAsigDurataMax.Value;

            var asigurare = new Asigurare(tip, denumire, varstaMin, varstaMax, durataMin, durataMax);

            AddAsigurare(asigurare);

            cbAsigTip.SelectedIndex = -1;
            tbAsigDenumire.Text = "";
            numAsigVarstaMin.Value = 0;
            numAsigVarstaMax.Value = 0;
            numAsigDurataMin.Value = 0;
            numAsigDurataMax.Value = 0;
        }

        private void btnDeleteAsigurare_Click(object sender, EventArgs e)
        {
            if (dgvAsigurari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Alegeti o asigurare!", "Eroare");
                return;
            }

            DataGridViewRow selectedRow = dgvAsigurari.SelectedRows[0];
            Asigurare asigurare = (Asigurare)selectedRow.DataBoundItem;

            DeleteAsigurare(asigurare);
        }

        private void btnEditAsigurare_Click(object sender, EventArgs e)
        {
            if (dgvAsigurari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Alegeti o asigurare!", "Eroare");
                return;
            }

            DataGridViewRow selectedRow = dgvAsigurari.SelectedRows[0];
            Asigurare asigurare = (Asigurare)(selectedRow.DataBoundItem);

            EditAsigurareForm editForm = new EditAsigurareForm(asigurare);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                EditAsigurare(asigurare);
            }
        }

        private void btnSerializeAsigurari_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Asigurare>));

            using (FileStream stream = File.Create("asigurari.xml"))
            {
                serializer.Serialize(stream, viewModel.Asigurari);
            }
        }

        private void btnDeserializeAsigurari_Click(object sender, EventArgs e)
        {
            DeserializeXMLAsigurari("asigurari.xml");
        }

        private void dgvAsigurari_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void dgvAsigurari_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                string filename = Path.GetFileName(file);
                string extension = Path.GetExtension(file);

                if (extension != ".xml")
                {
                    MessageBox.Show("Doar fisierele .xml sunt permise!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                DeserializeXMLAsigurari(filename);
            }
        }

        private void dgvAsigurari_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxMSAsig.Show(dgvAsigurari, new Point(e.X, e.Y));
            }
        }

        private void ctxMSAsigVanzari_Click(object sender, EventArgs e)
        {
            
            FetchVanzariAsigurari();
        }

        #endregion

        #region Clienti;

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();

            clientForm.ShowDialog();

            Client client = clientForm.client;

            if (client != null)
            {
                AddClient(client);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Alegeti un client!", "Eroare");
                return;
            }

            DataGridViewRow selectedRow = dgvClienti.SelectedRows[0];
            Client client = (Client)(selectedRow.DataBoundItem);

            DeleteClient(client);
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Alegeti un client!", "Eroare");
                return;
            }

            DataGridViewRow selectedRow = dgvClienti.SelectedRows[0];
            Client client = (Client)(selectedRow.DataBoundItem);

            ClientForm clientForm = new ClientForm(client);

            clientForm.ShowDialog();

            EditClient(client);
        }

        private void btnAddAsigurareClient_Click(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Alegeti un client!", "Eroare");
                return;
            }

            DataGridViewRow selectedRow = dgvClienti.SelectedRows[0];
            Client client = (Client)(selectedRow.DataBoundItem);

            foreach (Asigurare asigurare in client.Asigurari)
            {
                Console.WriteLine(asigurare.Denumire);
            }

            BindingList<Asigurare> selectedAsigurari = client.Asigurari;

            AsigurareClientForm asigurareClientForm = new AsigurareClientForm(viewModel.Asigurari, selectedAsigurari);

            DialogResult result = asigurareClientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BindingList<Asigurare> deselectedAsigurari = asigurareClientForm.deselectedAsigurari;

                foreach (Asigurare selectedAsigurare in selectedAsigurari)
                {
                    if (!ExistsAsigurareClient(selectedAsigurare, client))
                    {
                        AddAsigurareClient(selectedAsigurare, client);
                    }
                }

                foreach (Asigurare deselectedAsigurare in deselectedAsigurari)
                {
                    DeleteAsigurareClient(deselectedAsigurare, client);
                }

                DisplayClienti();
            }

        }

        private void btnSerializeClienti_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Client>));

            using (FileStream stream = File.Create("clienti.xml"))
            {
                serializer.Serialize(stream, viewModel.Clienti);
            }
        }

        private void btnDeserializeClienti_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Client>));

            using (FileStream stream = File.OpenRead("clienti.xml"))
            {
                viewModel.Clienti = (BindingList<Client>)serializer.Deserialize(stream);

                dgvClienti.DataSource = viewModel.Clienti;
            }
        }

        private void dgvClienti_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clientRowIndex = dgvClienti.HitTest(e.X, e.Y).RowIndex;

                ctxMS.Show(dgvClienti, new Point(e.X, e.Y));
            }
        }

        int clientRowIndex;

        private void ctxMSEdit_Click(object sender, EventArgs e)
        {
            Client client = viewModel.Clienti[clientRowIndex];

            ClientForm clientForm = new ClientForm(client);

            clientForm.ShowDialog();

            EditClient(client);
        }

        private void ctxMSDelete_Click(object sender, EventArgs e)
        {
            Client client = viewModel.Clienti[clientRowIndex];

            DeleteClient(client);
        }

        #region Misc

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveAsTXT();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;

        private void printBtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;

            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            SaveAsTXT();
        }




        #endregion

        #endregion

        #endregion

        
    }
}
