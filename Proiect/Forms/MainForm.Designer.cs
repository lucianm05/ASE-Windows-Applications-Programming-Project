namespace Proiect
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabClienti = new System.Windows.Forms.TabPage();
            this.btnAddAsigurareClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.tabAsigurari = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbAsigurari = new System.Windows.Forms.GroupBox();
            this.btnDeleteAsigurare = new System.Windows.Forms.Button();
            this.btnEditAsigurare = new System.Windows.Forms.Button();
            this.tbAsigDenumire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddAsigurare = new System.Windows.Forms.Button();
            this.numAsigDurataMax = new System.Windows.Forms.NumericUpDown();
            this.numAsigDurataMin = new System.Windows.Forms.NumericUpDown();
            this.numAsigVarstaMax = new System.Windows.Forms.NumericUpDown();
            this.numAsigVarstaMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAsigTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsigurari = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.asigurariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeAsigurari = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeAsigurari = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.printBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMSEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMSDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.ctxMSAsig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMSAsigVanzari = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.tabClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.tabAsigurari.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbAsigurari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigurari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ctxMS.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ctxMSAsig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabClienti);
            this.tabs.Controls.Add(this.tabAsigurari);
            this.tabs.Location = new System.Drawing.Point(12, 64);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(776, 435);
            this.tabs.TabIndex = 0;
            // 
            // tabClienti
            // 
            this.tabClienti.Controls.Add(this.btnAddAsigurareClient);
            this.tabClienti.Controls.Add(this.btnAddClient);
            this.tabClienti.Controls.Add(this.btnEditClient);
            this.tabClienti.Controls.Add(this.btnDeleteClient);
            this.tabClienti.Controls.Add(this.dgvClienti);
            this.tabClienti.Location = new System.Drawing.Point(4, 22);
            this.tabClienti.Name = "tabClienti";
            this.tabClienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienti.Size = new System.Drawing.Size(768, 409);
            this.tabClienti.TabIndex = 0;
            this.tabClienti.Text = "Clienti";
            this.tabClienti.UseVisualStyleBackColor = true;
            // 
            // btnAddAsigurareClient
            // 
            this.btnAddAsigurareClient.Location = new System.Drawing.Point(6, 381);
            this.btnAddAsigurareClient.Name = "btnAddAsigurareClient";
            this.btnAddAsigurareClient.Size = new System.Drawing.Size(145, 23);
            this.btnAddAsigurareClient.TabIndex = 0;
            this.btnAddAsigurareClient.Text = "Gestioneaza asigurari";
            this.btnAddAsigurareClient.UseVisualStyleBackColor = true;
            this.btnAddAsigurareClient.Click += new System.EventHandler(this.btnAddAsigurareClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(6, 6);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(106, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Adauga client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(544, 381);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(106, 23);
            this.btnEditClient.TabIndex = 0;
            this.btnEditClient.Text = "Editeaza client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(656, 381);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteClient.TabIndex = 0;
            this.btnDeleteClient.Text = "Sterge client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // dgvClienti
            // 
            this.dgvClienti.AllowUserToOrderColumns = true;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(6, 35);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(756, 340);
            this.dgvClienti.TabIndex = 1;
            this.dgvClienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClienti_MouseClick);
            // 
            // tabAsigurari
            // 
            this.tabAsigurari.Controls.Add(this.statusStrip1);
            this.tabAsigurari.Controls.Add(this.gbAsigurari);
            this.tabAsigurari.Controls.Add(this.dgvAsigurari);
            this.tabAsigurari.Location = new System.Drawing.Point(4, 22);
            this.tabAsigurari.Name = "tabAsigurari";
            this.tabAsigurari.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsigurari.Size = new System.Drawing.Size(768, 409);
            this.tabAsigurari.TabIndex = 1;
            this.tabAsigurari.Text = "Asigurari";
            this.tabAsigurari.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(762, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssLabel
            // 
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // gbAsigurari
            // 
            this.gbAsigurari.Controls.Add(this.btnDeleteAsigurare);
            this.gbAsigurari.Controls.Add(this.btnEditAsigurare);
            this.gbAsigurari.Controls.Add(this.tbAsigDenumire);
            this.gbAsigurari.Controls.Add(this.label6);
            this.gbAsigurari.Controls.Add(this.btnAddAsigurare);
            this.gbAsigurari.Controls.Add(this.numAsigDurataMax);
            this.gbAsigurari.Controls.Add(this.numAsigDurataMin);
            this.gbAsigurari.Controls.Add(this.numAsigVarstaMax);
            this.gbAsigurari.Controls.Add(this.numAsigVarstaMin);
            this.gbAsigurari.Controls.Add(this.label5);
            this.gbAsigurari.Controls.Add(this.label4);
            this.gbAsigurari.Controls.Add(this.cbAsigTip);
            this.gbAsigurari.Controls.Add(this.label3);
            this.gbAsigurari.Controls.Add(this.label2);
            this.gbAsigurari.Controls.Add(this.label1);
            this.gbAsigurari.Location = new System.Drawing.Point(3, 6);
            this.gbAsigurari.Name = "gbAsigurari";
            this.gbAsigurari.Size = new System.Drawing.Size(756, 160);
            this.gbAsigurari.TabIndex = 1;
            this.gbAsigurari.TabStop = false;
            this.gbAsigurari.Text = "Asigurare Noua";
            // 
            // btnDeleteAsigurare
            // 
            this.btnDeleteAsigurare.Location = new System.Drawing.Point(566, 128);
            this.btnDeleteAsigurare.Name = "btnDeleteAsigurare";
            this.btnDeleteAsigurare.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteAsigurare.TabIndex = 9;
            this.btnDeleteAsigurare.Text = "Sterge";
            this.btnDeleteAsigurare.UseVisualStyleBackColor = true;
            this.btnDeleteAsigurare.Click += new System.EventHandler(this.btnDeleteAsigurare_Click);
            // 
            // btnEditAsigurare
            // 
            this.btnEditAsigurare.Location = new System.Drawing.Point(566, 99);
            this.btnEditAsigurare.Name = "btnEditAsigurare";
            this.btnEditAsigurare.Size = new System.Drawing.Size(120, 23);
            this.btnEditAsigurare.TabIndex = 8;
            this.btnEditAsigurare.Text = "Editeaza";
            this.btnEditAsigurare.UseVisualStyleBackColor = true;
            this.btnEditAsigurare.Click += new System.EventHandler(this.btnEditAsigurare_Click);
            // 
            // tbAsigDenumire
            // 
            this.tbAsigDenumire.Location = new System.Drawing.Point(118, 73);
            this.tbAsigDenumire.Name = "tbAsigDenumire";
            this.tbAsigDenumire.Size = new System.Drawing.Size(142, 20);
            this.tbAsigDenumire.TabIndex = 2;
            this.tbAsigDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbAsigDenumire_Validating);
            this.tbAsigDenumire.Validated += new System.EventHandler(this.tbAsigDenumire_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Denumire";
            // 
            // btnAddAsigurare
            // 
            this.btnAddAsigurare.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAsigurare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAsigurare.Location = new System.Drawing.Point(566, 70);
            this.btnAddAsigurare.Name = "btnAddAsigurare";
            this.btnAddAsigurare.Size = new System.Drawing.Size(120, 23);
            this.btnAddAsigurare.TabIndex = 7;
            this.btnAddAsigurare.Text = "Adauga Asigurare";
            this.btnAddAsigurare.UseVisualStyleBackColor = false;
            this.btnAddAsigurare.Click += new System.EventHandler(this.btnAddAsigurare_Click);
            // 
            // numAsigDurataMax
            // 
            this.numAsigDurataMax.Location = new System.Drawing.Point(600, 32);
            this.numAsigDurataMax.Name = "numAsigDurataMax";
            this.numAsigDurataMax.Size = new System.Drawing.Size(86, 20);
            this.numAsigDurataMax.TabIndex = 6;
            this.numAsigDurataMax.Validating += new System.ComponentModel.CancelEventHandler(this.numAsigDurataMax_Validating);
            this.numAsigDurataMax.Validated += new System.EventHandler(this.numAsigDurataMax_Validated);
            // 
            // numAsigDurataMin
            // 
            this.numAsigDurataMin.Location = new System.Drawing.Point(474, 32);
            this.numAsigDurataMin.Name = "numAsigDurataMin";
            this.numAsigDurataMin.Size = new System.Drawing.Size(86, 20);
            this.numAsigDurataMin.TabIndex = 5;
            this.numAsigDurataMin.Validating += new System.ComponentModel.CancelEventHandler(this.numAsigDurataMin_Validating);
            this.numAsigDurataMin.Validated += new System.EventHandler(this.numAsigDurataMin_Validated);
            // 
            // numAsigVarstaMax
            // 
            this.numAsigVarstaMax.Location = new System.Drawing.Point(174, 129);
            this.numAsigVarstaMax.Name = "numAsigVarstaMax";
            this.numAsigVarstaMax.Size = new System.Drawing.Size(86, 20);
            this.numAsigVarstaMax.TabIndex = 4;
            this.numAsigVarstaMax.Validating += new System.ComponentModel.CancelEventHandler(this.numAsigVarstaMax_Validating);
            this.numAsigVarstaMax.Validated += new System.EventHandler(this.numAsigVarstaMax_Validated);
            // 
            // numAsigVarstaMin
            // 
            this.numAsigVarstaMin.Location = new System.Drawing.Point(48, 129);
            this.numAsigVarstaMin.Name = "numAsigVarstaMin";
            this.numAsigVarstaMin.Size = new System.Drawing.Size(86, 20);
            this.numAsigVarstaMin.TabIndex = 3;
            this.numAsigVarstaMin.Validating += new System.ComponentModel.CancelEventHandler(this.numAsigVarstaMin_Validating);
            this.numAsigVarstaMin.Validated += new System.EventHandler(this.numAsigVarstaMin_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durata maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durata minima";
            // 
            // cbAsigTip
            // 
            this.cbAsigTip.FormattingEnabled = true;
            this.cbAsigTip.Items.AddRange(new object[] {
            "Viata",
            "Casa",
            "Sanatate"});
            this.cbAsigTip.Location = new System.Drawing.Point(118, 31);
            this.cbAsigTip.Name = "cbAsigTip";
            this.cbAsigTip.Size = new System.Drawing.Size(142, 21);
            this.cbAsigTip.TabIndex = 1;
            this.cbAsigTip.Validating += new System.ComponentModel.CancelEventHandler(this.cbAsigTip_Validating);
            this.cbAsigTip.Validated += new System.EventHandler(this.cbAsigTip_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip asigurare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varsta maxima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varsta minima";
            // 
            // dgvAsigurari
            // 
            this.dgvAsigurari.AllowDrop = true;
            this.dgvAsigurari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigurari.Location = new System.Drawing.Point(3, 172);
            this.dgvAsigurari.Name = "dgvAsigurari";
            this.dgvAsigurari.Size = new System.Drawing.Size(756, 235);
            this.dgvAsigurari.TabIndex = 0;
            this.dgvAsigurari.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvAsigurari_DragDrop);
            this.dgvAsigurari.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvAsigurari_DragEnter);
            this.dgvAsigurari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAsigurari_MouseClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem,
            this.btnExport,
            this.printBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.asigurariToolStripMenuItem});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.jSONToolStripMenuItem.Text = "XML";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeClienti,
            this.btnDeserializeClienti});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // btnSerializeClienti
            // 
            this.btnSerializeClienti.Name = "btnSerializeClienti";
            this.btnSerializeClienti.Size = new System.Drawing.Size(129, 22);
            this.btnSerializeClienti.Text = "Serialize";
            this.btnSerializeClienti.Click += new System.EventHandler(this.btnSerializeClienti_Click);
            // 
            // btnDeserializeClienti
            // 
            this.btnDeserializeClienti.Name = "btnDeserializeClienti";
            this.btnDeserializeClienti.Size = new System.Drawing.Size(129, 22);
            this.btnDeserializeClienti.Text = "Deserialize";
            this.btnDeserializeClienti.Click += new System.EventHandler(this.btnDeserializeClienti_Click);
            // 
            // asigurariToolStripMenuItem
            // 
            this.asigurariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeAsigurari,
            this.btnDeserializeAsigurari});
            this.asigurariToolStripMenuItem.Name = "asigurariToolStripMenuItem";
            this.asigurariToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.asigurariToolStripMenuItem.Text = "Asigurari";
            // 
            // btnSerializeAsigurari
            // 
            this.btnSerializeAsigurari.Name = "btnSerializeAsigurari";
            this.btnSerializeAsigurari.Size = new System.Drawing.Size(129, 22);
            this.btnSerializeAsigurari.Text = "Serialize";
            this.btnSerializeAsigurari.Click += new System.EventHandler(this.btnSerializeAsigurari_Click);
            // 
            // btnDeserializeAsigurari
            // 
            this.btnDeserializeAsigurari.Name = "btnDeserializeAsigurari";
            this.btnDeserializeAsigurari.Size = new System.Drawing.Size(129, 22);
            this.btnDeserializeAsigurari.Text = "Deserialize";
            this.btnDeserializeAsigurari.Click += new System.EventHandler(this.btnDeserializeAsigurari_Click);
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(53, 20);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // printBtn
            // 
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(44, 20);
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // ctxMS
            // 
            this.ctxMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMSEdit,
            this.ctxMSDelete});
            this.ctxMS.Name = "contextMenuStrip1";
            this.ctxMS.Size = new System.Drawing.Size(108, 48);
            // 
            // ctxMSEdit
            // 
            this.ctxMSEdit.Name = "ctxMSEdit";
            this.ctxMSEdit.Size = new System.Drawing.Size(107, 22);
            this.ctxMSEdit.Text = "Edit";
            this.ctxMSEdit.Click += new System.EventHandler(this.ctxMSEdit_Click);
            // 
            // ctxMSDelete
            // 
            this.ctxMSDelete.Name = "ctxMSDelete";
            this.ctxMSDelete.Size = new System.Drawing.Size(107, 22);
            this.ctxMSDelete.Text = "Delete";
            this.ctxMSDelete.Click += new System.EventHandler(this.ctxMSDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "&Save";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // ctxMSAsig
            // 
            this.ctxMSAsig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMSAsigVanzari});
            this.ctxMSAsig.Name = "ctxMSAsig";
            this.ctxMSAsig.Size = new System.Drawing.Size(135, 26);
            // 
            // ctxMSAsigVanzari
            // 
            this.ctxMSAsigVanzari.Name = "ctxMSAsigVanzari";
            this.ctxMSAsigVanzari.Size = new System.Drawing.Size(134, 22);
            this.ctxMSAsigVanzari.Text = "Vezi vanzari";
            this.ctxMSAsigVanzari.Click += new System.EventHandler(this.ctxMSAsigVanzari_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabs);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.tabAsigurari.ResumeLayout(false);
            this.tabAsigurari.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbAsigurari.ResumeLayout(false);
            this.gbAsigurari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigurari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxMS.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctxMSAsig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabClienti;
        private System.Windows.Forms.TabPage tabAsigurari;
        private System.Windows.Forms.DataGridView dgvAsigurari;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.GroupBox gbAsigurari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAsigTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAsigDurataMax;
        private System.Windows.Forms.NumericUpDown numAsigDurataMin;
        private System.Windows.Forms.NumericUpDown numAsigVarstaMax;
        private System.Windows.Forms.NumericUpDown numAsigVarstaMin;
        private System.Windows.Forms.Button btnAddAsigurare;
        private System.Windows.Forms.TextBox tbAsigDenumire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnEditAsigurare;
        private System.Windows.Forms.Button btnDeleteAsigurare;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddAsigurareClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeClienti;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeClienti;
        private System.Windows.Forms.ToolStripMenuItem asigurariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeAsigurari;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeAsigurari;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem printBtn;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip ctxMS;
        private System.Windows.Forms.ToolStripMenuItem ctxMSEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxMSDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ContextMenuStrip ctxMSAsig;
        private System.Windows.Forms.ToolStripMenuItem ctxMSAsigVanzari;
    }
}

