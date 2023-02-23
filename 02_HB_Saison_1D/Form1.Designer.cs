
namespace _02_HB_Saison_1D
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxAusgabe1 = new System.Windows.Forms.TextBox();
            this.btnAusgabePreis = new System.Windows.Forms.Button();
            this.cmbWahl = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxBrutto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNetto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxPersonen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxAusgabe1);
            this.panel1.Controls.Add(this.btnAusgabePreis);
            this.panel1.Controls.Add(this.cmbWahl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 319);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBoxAusgabe1
            // 
            this.txtBoxAusgabe1.Location = new System.Drawing.Point(69, 111);
            this.txtBoxAusgabe1.Multiline = true;
            this.txtBoxAusgabe1.Name = "txtBoxAusgabe1";
            this.txtBoxAusgabe1.ReadOnly = true;
            this.txtBoxAusgabe1.Size = new System.Drawing.Size(121, 195);
            this.txtBoxAusgabe1.TabIndex = 0;
            // 
            // btnAusgabePreis
            // 
            this.btnAusgabePreis.Location = new System.Drawing.Point(69, 66);
            this.btnAusgabePreis.Name = "btnAusgabePreis";
            this.btnAusgabePreis.Size = new System.Drawing.Size(121, 39);
            this.btnAusgabePreis.TabIndex = 1;
            this.btnAusgabePreis.Text = "Preis ausgeben";
            this.btnAusgabePreis.UseVisualStyleBackColor = true;
            this.btnAusgabePreis.Click += new System.EventHandler(this.btnAusgabePreis_Click);
            // 
            // cmbWahl
            // 
            this.cmbWahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWahl.FormattingEnabled = true;
            this.cmbWahl.Location = new System.Drawing.Point(69, 28);
            this.cmbWahl.Name = "cmbWahl";
            this.cmbWahl.Size = new System.Drawing.Size(121, 21);
            this.cmbWahl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBoxBrutto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBoxNetto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Controls.Add(this.txtBoxPersonen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxTage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(321, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 319);
            this.panel2.TabIndex = 2;
            // 
            // txtBoxBrutto
            // 
            this.txtBoxBrutto.Location = new System.Drawing.Point(34, 244);
            this.txtBoxBrutto.Name = "txtBoxBrutto";
            this.txtBoxBrutto.ReadOnly = true;
            this.txtBoxBrutto.Size = new System.Drawing.Size(132, 20);
            this.txtBoxBrutto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bruttogesamtpreis";
            // 
            // txtBoxNetto
            // 
            this.txtBoxNetto.Location = new System.Drawing.Point(34, 203);
            this.txtBoxNetto.Name = "txtBoxNetto";
            this.txtBoxNetto.ReadOnly = true;
            this.txtBoxNetto.Size = new System.Drawing.Size(132, 20);
            this.txtBoxNetto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nettogesamtpreis";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(22, 111);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(184, 39);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Gesamtpreis berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxPersonen
            // 
            this.txtBoxPersonen.Location = new System.Drawing.Point(106, 66);
            this.txtBoxPersonen.Name = "txtBoxPersonen";
            this.txtBoxPersonen.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPersonen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl Personen";
            // 
            // txtBoxTage
            // 
            this.txtBoxTage.Location = new System.Drawing.Point(106, 25);
            this.txtBoxTage.Name = "txtBoxTage";
            this.txtBoxTage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anzahl Tage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "02_Saison_1D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxAusgabe1;
        private System.Windows.Forms.Button btnAusgabePreis;
        private System.Windows.Forms.ComboBox cmbWahl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxBrutto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtBoxPersonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTage;
        private System.Windows.Forms.Label label1;
    }
}

