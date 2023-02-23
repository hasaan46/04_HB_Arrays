namespace _09_HB_WunschZettel
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
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.rBtnNiceToHave = new System.Windows.Forms.RadioButton();
            this.rBtnMustHave = new System.Windows.Forms.RadioButton();
            this.cmBAuswahl = new System.Windows.Forms.ComboBox();
            this.lblPreis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(40, 285);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(237, 120);
            this.txtAusgabe.TabIndex = 13;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(40, 213);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(237, 54);
            this.btnHinzufügen.TabIndex = 12;
            this.btnHinzufügen.Text = "Zum Warenkorb hinzufügen / Aktuellen Warenkorb anzeigen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // rBtnNiceToHave
            // 
            this.rBtnNiceToHave.AutoSize = true;
            this.rBtnNiceToHave.Location = new System.Drawing.Point(160, 174);
            this.rBtnNiceToHave.Name = "rBtnNiceToHave";
            this.rBtnNiceToHave.Size = new System.Drawing.Size(84, 17);
            this.rBtnNiceToHave.TabIndex = 11;
            this.rBtnNiceToHave.TabStop = true;
            this.rBtnNiceToHave.Text = "nice to have";
            this.rBtnNiceToHave.UseVisualStyleBackColor = true;
            // 
            // rBtnMustHave
            // 
            this.rBtnMustHave.AutoSize = true;
            this.rBtnMustHave.Location = new System.Drawing.Point(49, 174);
            this.rBtnMustHave.Name = "rBtnMustHave";
            this.rBtnMustHave.Size = new System.Drawing.Size(84, 17);
            this.rBtnMustHave.TabIndex = 10;
            this.rBtnMustHave.TabStop = true;
            this.rBtnMustHave.Text = "Must have!!!";
            this.rBtnMustHave.UseVisualStyleBackColor = true;
            // 
            // cmBAuswahl
            // 
            this.cmBAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBAuswahl.FormattingEnabled = true;
            this.cmBAuswahl.Location = new System.Drawing.Point(49, 62);
            this.cmBAuswahl.Name = "cmBAuswahl";
            this.cmBAuswahl.Size = new System.Drawing.Size(159, 21);
            this.cmBAuswahl.TabIndex = 9;
            this.cmBAuswahl.SelectedIndexChanged += new System.EventHandler(this.cmBAuswahl_SelectedIndexChanged);
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.Location = new System.Drawing.Point(46, 127);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(204, 13);
            this.lblPreis.TabIndex = 8;
            this.lblPreis.Text = "Preis des Ausgewählten Artikels Anzeigen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Auswahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.rBtnNiceToHave);
            this.Controls.Add(this.rBtnMustHave);
            this.Controls.Add(this.cmBAuswahl);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wunschzettel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.RadioButton rBtnNiceToHave;
        private System.Windows.Forms.RadioButton rBtnMustHave;
        private System.Windows.Forms.ComboBox cmBAuswahl;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label label1;
    }
}

