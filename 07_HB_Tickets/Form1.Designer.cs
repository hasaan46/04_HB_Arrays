
namespace _07_HB_Tickets
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblKate = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.cmbAnzahl = new System.Windows.Forms.ComboBox();
            this.cmbKategorie = new System.Windows.Forms.ComboBox();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.chkSchüler = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPreis = new System.Windows.Forms.Label();
            this.txtAusgabeGesamt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(12, 31);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(39, 13);
            this.lblAnzahl.TabIndex = 0;
            this.lblAnzahl.Text = "Anzahl";
            // 
            // lblKate
            // 
            this.lblKate.AutoSize = true;
            this.lblKate.Location = new System.Drawing.Point(12, 92);
            this.lblKate.Name = "lblKate";
            this.lblKate.Size = new System.Drawing.Size(52, 13);
            this.lblKate.TabIndex = 1;
            this.lblKate.Text = "Kategorie";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(12, 153);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(92, 13);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Zahlungsmethode";
            // 
            // cmbAnzahl
            // 
            this.cmbAnzahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnzahl.FormattingEnabled = true;
            this.cmbAnzahl.Location = new System.Drawing.Point(15, 47);
            this.cmbAnzahl.Name = "cmbAnzahl";
            this.cmbAnzahl.Size = new System.Drawing.Size(214, 21);
            this.cmbAnzahl.TabIndex = 3;
            // 
            // cmbKategorie
            // 
            this.cmbKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorie.FormattingEnabled = true;
            this.cmbKategorie.Location = new System.Drawing.Point(15, 108);
            this.cmbKategorie.Name = "cmbKategorie";
            this.cmbKategorie.Size = new System.Drawing.Size(214, 21);
            this.cmbKategorie.TabIndex = 4;
            // 
            // cmbPay
            // 
            this.cmbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(15, 169);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(214, 21);
            this.cmbPay.TabIndex = 5;
            // 
            // chkSchüler
            // 
            this.chkSchüler.AutoSize = true;
            this.chkSchüler.Location = new System.Drawing.Point(15, 216);
            this.chkSchüler.Name = "chkSchüler";
            this.chkSchüler.Size = new System.Drawing.Size(145, 17);
            this.chkSchüler.TabIndex = 6;
            this.chkSchüler.Text = "Ich bin Schüler / Student";
            this.chkSchüler.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zu Zahlender Preis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.Location = new System.Drawing.Point(12, 328);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(65, 13);
            this.lblPreis.TabIndex = 8;
            this.lblPreis.Text = "Gesamtpreis";
            // 
            // txtAusgabeGesamt
            // 
            this.txtAusgabeGesamt.Location = new System.Drawing.Point(12, 357);
            this.txtAusgabeGesamt.Name = "txtAusgabeGesamt";
            this.txtAusgabeGesamt.ReadOnly = true;
            this.txtAusgabeGesamt.Size = new System.Drawing.Size(217, 20);
            this.txtAusgabeGesamt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 418);
            this.Controls.Add(this.txtAusgabeGesamt);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkSchüler);
            this.Controls.Add(this.cmbPay);
            this.Controls.Add(this.cmbKategorie);
            this.Controls.Add(this.cmbAnzahl);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblKate);
            this.Controls.Add(this.lblAnzahl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ticketverkauf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label lblKate;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.ComboBox cmbAnzahl;
        private System.Windows.Forms.ComboBox cmbKategorie;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.CheckBox chkSchüler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.TextBox txtAusgabeGesamt;
    }
}

