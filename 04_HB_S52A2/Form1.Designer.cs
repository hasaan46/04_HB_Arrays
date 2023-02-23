namespace _04_HB_S52A2
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
            this.cmbWahl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.txtAusgabeWaren = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbWahl
            // 
            this.cmbWahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWahl.FormattingEnabled = true;
            this.cmbWahl.Location = new System.Drawing.Point(12, 56);
            this.cmbWahl.Name = "cmbWahl";
            this.cmbWahl.Size = new System.Drawing.Size(121, 21);
            this.cmbWahl.TabIndex = 1;
            this.cmbWahl.SelectedIndexChanged += new System.EventHandler(this.cmbWahl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Warengruppe";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(12, 107);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(403, 58);
            this.txtAusgabe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Die Versandkosten betragen";
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.Location = new System.Drawing.Point(12, 180);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(403, 39);
            this.btnAusgabe.TabIndex = 8;
            this.btnAusgabe.Text = "Versandkosten für alle Warengruppen ausgeben";
            this.btnAusgabe.UseVisualStyleBackColor = true;
            this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
            // 
            // txtAusgabeWaren
            // 
            this.txtAusgabeWaren.Location = new System.Drawing.Point(12, 225);
            this.txtAusgabeWaren.Multiline = true;
            this.txtAusgabeWaren.Name = "txtAusgabeWaren";
            this.txtAusgabeWaren.ReadOnly = true;
            this.txtAusgabeWaren.Size = new System.Drawing.Size(403, 58);
            this.txtAusgabeWaren.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 306);
            this.Controls.Add(this.txtAusgabeWaren);
            this.Controls.Add(this.btnAusgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbWahl);
            this.Name = "Form1";
            this.Text = "04_Seite_52_Aufgabe 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAusgabeWaren;

        private System.Windows.Forms.Button btnAusgabe;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtAusgabe;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cmbWahl;

        #endregion
    }
}

