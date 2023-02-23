namespace HB_03_S52_A1
{
    partial class Form1
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
            this.txtEingabeJahre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAusgabeGehalt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeJahre
            // 
            this.txtEingabeJahre.Location = new System.Drawing.Point(217, 12);
            this.txtEingabeJahre.Name = "txtEingabeJahre";
            this.txtEingabeJahre.Size = new System.Drawing.Size(100, 20);
            this.txtEingabeJahre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eingabe der Vordienstzeiten in Jahren";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(133, 54);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(184, 39);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Mindestgehalt berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtAusgabeGehalt
            // 
            this.txtAusgabeGehalt.Location = new System.Drawing.Point(217, 116);
            this.txtAusgabeGehalt.Name = "txtAusgabeGehalt";
            this.txtAusgabeGehalt.ReadOnly = true;
            this.txtAusgabeGehalt.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabeGehalt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mindestgehalt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 172);
            this.Controls.Add(this.txtAusgabeGehalt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEingabeJahre);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Seite 52 Aufgabe 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAusgabeGehalt;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnCalc;

        private System.Windows.Forms.TextBox txtEingabeJahre;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}