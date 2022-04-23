namespace Proiect
{
    partial class ClientForm
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
            this.numClientVarsta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbClientNume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbClientPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkClient = new System.Windows.Forms.Button();
            this.errorProviderClient = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numClientVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).BeginInit();
            this.SuspendLayout();
            // 
            // numClientVarsta
            // 
            this.numClientVarsta.Location = new System.Drawing.Point(12, 160);
            this.numClientVarsta.Name = "numClientVarsta";
            this.numClientVarsta.Size = new System.Drawing.Size(199, 20);
            this.numClientVarsta.TabIndex = 3;
            this.numClientVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.numClientVarsta_Validating);
            this.numClientVarsta.Validated += new System.EventHandler(this.numClientVarsta_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Varsta";
            // 
            // tbClientNume
            // 
            this.tbClientNume.Location = new System.Drawing.Point(12, 29);
            this.tbClientNume.Name = "tbClientNume";
            this.tbClientNume.Size = new System.Drawing.Size(199, 20);
            this.tbClientNume.TabIndex = 1;
            this.tbClientNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbClientNume_Validating);
            this.tbClientNume.Validated += new System.EventHandler(this.tbClientNume_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nume";
            // 
            // tbClientPrenume
            // 
            this.tbClientPrenume.Location = new System.Drawing.Point(12, 94);
            this.tbClientPrenume.Name = "tbClientPrenume";
            this.tbClientPrenume.Size = new System.Drawing.Size(199, 20);
            this.tbClientPrenume.TabIndex = 2;
            this.tbClientPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbClientPrenume_Validating);
            this.tbClientPrenume.Validated += new System.EventHandler(this.tbClientPrenume_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prenume";
            // 
            // btnOkClient
            // 
            this.btnOkClient.Location = new System.Drawing.Point(130, 217);
            this.btnOkClient.Name = "btnOkClient";
            this.btnOkClient.Size = new System.Drawing.Size(102, 23);
            this.btnOkClient.TabIndex = 4;
            this.btnOkClient.Text = "Ok";
            this.btnOkClient.UseVisualStyleBackColor = true;
            this.btnOkClient.Click += new System.EventHandler(this.btnOkClient_Click);
            // 
            // errorProviderClient
            // 
            this.errorProviderClient.ContainerControl = this;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 252);
            this.Controls.Add(this.btnOkClient);
            this.Controls.Add(this.tbClientPrenume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numClientVarsta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbClientNume);
            this.Controls.Add(this.label7);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numClientVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numClientVarsta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbClientNume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbClientPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkClient;
        private System.Windows.Forms.ErrorProvider errorProviderClient;
    }
}