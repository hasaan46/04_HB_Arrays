
namespace _06_HB_2.Übung_1D_Array
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
            this.txtAusgabeErwTat = new System.Windows.Forms.TextBox();
            this.btnAuswertung = new System.Windows.Forms.Button();
            this.txtAusgabeTatBesserErw = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAusgabeErwGleichTat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAusgabe2SchlechterTat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAusgabeAbweichung = new System.Windows.Forms.TextBox();
            this.txtAusgabe10Tat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAusgabeAchtErw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAusgabeMinTat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAusgabeMinErw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAusgabeMaxTat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAusgabeMaxErw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAusgabeErwTat
            // 
            this.txtAusgabeErwTat.Location = new System.Drawing.Point(48, 12);
            this.txtAusgabeErwTat.Multiline = true;
            this.txtAusgabeErwTat.Name = "txtAusgabeErwTat";
            this.txtAusgabeErwTat.ReadOnly = true;
            this.txtAusgabeErwTat.Size = new System.Drawing.Size(479, 143);
            this.txtAusgabeErwTat.TabIndex = 72;
            // 
            // btnAuswertung
            // 
            this.btnAuswertung.Location = new System.Drawing.Point(560, 12);
            this.btnAuswertung.Name = "btnAuswertung";
            this.btnAuswertung.Size = new System.Drawing.Size(183, 76);
            this.btnAuswertung.TabIndex = 71;
            this.btnAuswertung.Text = "Auswertung";
            this.btnAuswertung.UseVisualStyleBackColor = true;
            this.btnAuswertung.Click += new System.EventHandler(this.btnAuswertung_Click);
            // 
            // txtAusgabeTatBesserErw
            // 
            this.txtAusgabeTatBesserErw.Location = new System.Drawing.Point(656, 530);
            this.txtAusgabeTatBesserErw.Name = "txtAusgabeTatBesserErw";
            this.txtAusgabeTatBesserErw.ReadOnly = true;
            this.txtAusgabeTatBesserErw.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeTatBesserErw.TabIndex = 70;
            this.txtAusgabeTatBesserErw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Wie häufig ist das Ergebnis besser als die Erwartung?";
            // 
            // txtAusgabeErwGleichTat
            // 
            this.txtAusgabeErwGleichTat.Location = new System.Drawing.Point(656, 471);
            this.txtAusgabeErwGleichTat.Name = "txtAusgabeErwGleichTat";
            this.txtAusgabeErwGleichTat.ReadOnly = true;
            this.txtAusgabeErwGleichTat.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeErwGleichTat.TabIndex = 68;
            this.txtAusgabeErwGleichTat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Wie häufig entspricht das Ergebnis der Erwartung?";
            // 
            // txtAusgabe2SchlechterTat
            // 
            this.txtAusgabe2SchlechterTat.Location = new System.Drawing.Point(656, 406);
            this.txtAusgabe2SchlechterTat.Name = "txtAusgabe2SchlechterTat";
            this.txtAusgabe2SchlechterTat.ReadOnly = true;
            this.txtAusgabe2SchlechterTat.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabe2SchlechterTat.TabIndex = 66;
            this.txtAusgabe2SchlechterTat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Wie häufig ist das Ergebnis mehr als 2 Punkte schlechter als die Erwartung?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Abweichung zwischen erwarteten und tatsächlichen Punkten:";
            // 
            // txtAusgabeAbweichung
            // 
            this.txtAusgabeAbweichung.Location = new System.Drawing.Point(47, 406);
            this.txtAusgabeAbweichung.Multiline = true;
            this.txtAusgabeAbweichung.Name = "txtAusgabeAbweichung";
            this.txtAusgabeAbweichung.ReadOnly = true;
            this.txtAusgabeAbweichung.Size = new System.Drawing.Size(292, 143);
            this.txtAusgabeAbweichung.TabIndex = 63;
            // 
            // txtAusgabe10Tat
            // 
            this.txtAusgabe10Tat.Location = new System.Drawing.Point(239, 334);
            this.txtAusgabe10Tat.Name = "txtAusgabe10Tat";
            this.txtAusgabe10Tat.ReadOnly = true;
            this.txtAusgabe10Tat.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabe10Tat.TabIndex = 62;
            this.txtAusgabe10Tat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Wie häufig wurden 10 Punkte erreicht?";
            // 
            // txtAusgabeAchtErw
            // 
            this.txtAusgabeAchtErw.Location = new System.Drawing.Point(239, 304);
            this.txtAusgabeAchtErw.Name = "txtAusgabeAchtErw";
            this.txtAusgabeAchtErw.ReadOnly = true;
            this.txtAusgabeAchtErw.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeAchtErw.TabIndex = 60;
            this.txtAusgabeAchtErw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Wie häufig wurden 8 Punkte erwartet?";
            // 
            // txtAusgabeMinTat
            // 
            this.txtAusgabeMinTat.Location = new System.Drawing.Point(495, 234);
            this.txtAusgabeMinTat.Name = "txtAusgabeMinTat";
            this.txtAusgabeMinTat.ReadOnly = true;
            this.txtAusgabeMinTat.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMinTat.TabIndex = 58;
            this.txtAusgabeMinTat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "niedrigste tatsächliche Punktzahl";
            // 
            // txtAusgabeMinErw
            // 
            this.txtAusgabeMinErw.Location = new System.Drawing.Point(205, 234);
            this.txtAusgabeMinErw.Name = "txtAusgabeMinErw";
            this.txtAusgabeMinErw.ReadOnly = true;
            this.txtAusgabeMinErw.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMinErw.TabIndex = 56;
            this.txtAusgabeMinErw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "niedrigste erwartete Punktzahl";
            // 
            // txtAusgabeMaxTat
            // 
            this.txtAusgabeMaxTat.Location = new System.Drawing.Point(495, 198);
            this.txtAusgabeMaxTat.Name = "txtAusgabeMaxTat";
            this.txtAusgabeMaxTat.ReadOnly = true;
            this.txtAusgabeMaxTat.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMaxTat.TabIndex = 54;
            this.txtAusgabeMaxTat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "höchste tatsächliche Punktzahl";
            // 
            // txtAusgabeMaxErw
            // 
            this.txtAusgabeMaxErw.Location = new System.Drawing.Point(205, 198);
            this.txtAusgabeMaxErw.Name = "txtAusgabeMaxErw";
            this.txtAusgabeMaxErw.ReadOnly = true;
            this.txtAusgabeMaxErw.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeMaxErw.TabIndex = 52;
            this.txtAusgabeMaxErw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "höchste erwartete Punktzahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.txtAusgabeErwTat);
            this.Controls.Add(this.btnAuswertung);
            this.Controls.Add(this.txtAusgabeTatBesserErw);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAusgabeErwGleichTat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAusgabe2SchlechterTat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAusgabeAbweichung);
            this.Controls.Add(this.txtAusgabe10Tat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAusgabeAchtErw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAusgabeMinTat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAusgabeMinErw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAusgabeMaxTat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAusgabeMaxErw);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "2. Übung 1D-Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAusgabeErwTat;
        private System.Windows.Forms.Button btnAuswertung;
        private System.Windows.Forms.TextBox txtAusgabeTatBesserErw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAusgabeErwGleichTat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAusgabe2SchlechterTat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAusgabeAbweichung;
        private System.Windows.Forms.TextBox txtAusgabe10Tat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAusgabeAchtErw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAusgabeMinTat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAusgabeMinErw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAusgabeMaxTat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAusgabeMaxErw;
        private System.Windows.Forms.Label label1;
    }
}

