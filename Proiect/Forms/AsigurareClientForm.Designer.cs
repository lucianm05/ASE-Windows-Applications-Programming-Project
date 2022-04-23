namespace Proiect
{
    partial class AsigurareClientForm
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
            this.clbAsigurari = new System.Windows.Forms.CheckedListBox();
            this.btnAddAsigurareClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbAsigurari
            // 
            this.clbAsigurari.FormattingEnabled = true;
            this.clbAsigurari.Location = new System.Drawing.Point(12, 12);
            this.clbAsigurari.Name = "clbAsigurari";
            this.clbAsigurari.Size = new System.Drawing.Size(184, 199);
            this.clbAsigurari.TabIndex = 0;
            // 
            // btnAddAsigurareClient
            // 
            this.btnAddAsigurareClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddAsigurareClient.Location = new System.Drawing.Point(121, 222);
            this.btnAddAsigurareClient.Name = "btnAddAsigurareClient";
            this.btnAddAsigurareClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddAsigurareClient.TabIndex = 1;
            this.btnAddAsigurareClient.Text = "Ok";
            this.btnAddAsigurareClient.UseVisualStyleBackColor = true;
            this.btnAddAsigurareClient.Click += new System.EventHandler(this.btnAddAsigurareClient_Click);
            // 
            // AsigurareClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 257);
            this.Controls.Add(this.btnAddAsigurareClient);
            this.Controls.Add(this.clbAsigurari);
            this.Name = "AsigurareClientForm";
            this.Text = "AsigurareClientForm";
            this.Load += new System.EventHandler(this.AsigurareClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAsigurari;
        private System.Windows.Forms.Button btnAddAsigurareClient;
    }
}