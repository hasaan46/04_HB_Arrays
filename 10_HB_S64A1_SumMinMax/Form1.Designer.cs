namespace _10_HB_S64A1_SumMinMax
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
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.Location = new System.Drawing.Point(87, 158);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(218, 43);
            this.btnAusgabe.TabIndex = 6;
            this.btnAusgabe.Text = "Wert Hinzufügen / Ausgeben";
            this.btnAusgabe.UseVisualStyleBackColor = true;
            this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(87, 216);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(218, 113);
            this.txtAusgabe.TabIndex = 5;
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(87, 121);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(218, 20);
            this.txtEingabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.btnAusgabe);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.txtEingabe);
            this.Name = "Form1";
            this.Text = "S64A1_SumMinMax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAusgabe;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.TextBox txtEingabe;
    }
}

