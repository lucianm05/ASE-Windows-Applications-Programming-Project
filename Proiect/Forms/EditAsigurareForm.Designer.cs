namespace Proiect
{
    partial class EditAsigurareForm
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
            this.tbAsigDenumire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numAsigVarstaMax = new System.Windows.Forms.NumericUpDown();
            this.numAsigVarstaMin = new System.Windows.Forms.NumericUpDown();
            this.cbAsigTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numAsigDurataMax = new System.Windows.Forms.NumericUpDown();
            this.numAsigDurataMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAsigDenumire
            // 
            this.tbAsigDenumire.Location = new System.Drawing.Point(88, 54);
            this.tbAsigDenumire.Name = "tbAsigDenumire";
            this.tbAsigDenumire.Size = new System.Drawing.Size(142, 20);
            this.tbAsigDenumire.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Denumire";
            // 
            // numAsigVarstaMax
            // 
            this.numAsigVarstaMax.Location = new System.Drawing.Point(144, 110);
            this.numAsigVarstaMax.Name = "numAsigVarstaMax";
            this.numAsigVarstaMax.Size = new System.Drawing.Size(86, 20);
            this.numAsigVarstaMax.TabIndex = 4;
            // 
            // numAsigVarstaMin
            // 
            this.numAsigVarstaMin.Location = new System.Drawing.Point(18, 110);
            this.numAsigVarstaMin.Name = "numAsigVarstaMin";
            this.numAsigVarstaMin.Size = new System.Drawing.Size(86, 20);
            this.numAsigVarstaMin.TabIndex = 3;
            // 
            // cbAsigTip
            // 
            this.cbAsigTip.FormattingEnabled = true;
            this.cbAsigTip.Items.AddRange(new object[] {
            "Viata",
            "Casa",
            "Sanatate"});
            this.cbAsigTip.Location = new System.Drawing.Point(88, 12);
            this.cbAsigTip.Name = "cbAsigTip";
            this.cbAsigTip.Size = new System.Drawing.Size(142, 21);
            this.cbAsigTip.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tip asigurare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Varsta maxima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Varsta minima";
            // 
            // numAsigDurataMax
            // 
            this.numAsigDurataMax.Location = new System.Drawing.Point(144, 163);
            this.numAsigDurataMax.Name = "numAsigDurataMax";
            this.numAsigDurataMax.Size = new System.Drawing.Size(86, 20);
            this.numAsigDurataMax.TabIndex = 6;
            // 
            // numAsigDurataMin
            // 
            this.numAsigDurataMin.Location = new System.Drawing.Point(18, 163);
            this.numAsigDurataMin.Name = "numAsigDurataMin";
            this.numAsigDurataMin.Size = new System.Drawing.Size(86, 20);
            this.numAsigDurataMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Durata maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Durata minima";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(18, 208);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(155, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditAsigurareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numAsigDurataMax);
            this.Controls.Add(this.numAsigDurataMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAsigDenumire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numAsigVarstaMax);
            this.Controls.Add(this.numAsigVarstaMin);
            this.Controls.Add(this.cbAsigTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAsigurareForm";
            this.Text = "EditAsigurareForm";
            this.Load += new System.EventHandler(this.EditAsigurareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigVarstaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsigDurataMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAsigDenumire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAsigVarstaMax;
        private System.Windows.Forms.NumericUpDown numAsigVarstaMin;
        private System.Windows.Forms.ComboBox cbAsigTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAsigDurataMax;
        private System.Windows.Forms.NumericUpDown numAsigDurataMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
    }
}