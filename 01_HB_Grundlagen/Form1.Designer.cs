
namespace _01_HB_Grundlagen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.btnAusgabe1 = new System.Windows.Forms.Button();
            this.btnAusgabe2 = new System.Windows.Forms.Button();
            this.btnAusgabe3 = new System.Windows.Forms.Button();
            this.btnAusgabe4 = new System.Windows.Forms.Button();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eingabe:";
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(67, 35);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe.TabIndex = 1;
            // 
            // btnAusgabe1
            // 
            this.btnAusgabe1.Location = new System.Drawing.Point(15, 98);
            this.btnAusgabe1.Name = "btnAusgabe1";
            this.btnAusgabe1.Size = new System.Drawing.Size(75, 23);
            this.btnAusgabe1.TabIndex = 2;
            this.btnAusgabe1.Text = "Ausgabe 1";
            this.btnAusgabe1.UseVisualStyleBackColor = true;
            this.btnAusgabe1.Click += new System.EventHandler(this.btnAusgabe1_Click);
            // 
            // btnAusgabe2
            // 
            this.btnAusgabe2.Location = new System.Drawing.Point(129, 98);
            this.btnAusgabe2.Name = "btnAusgabe2";
            this.btnAusgabe2.Size = new System.Drawing.Size(75, 23);
            this.btnAusgabe2.TabIndex = 3;
            this.btnAusgabe2.Text = "Ausgabe 2";
            this.btnAusgabe2.UseVisualStyleBackColor = true;
            this.btnAusgabe2.Click += new System.EventHandler(this.btnAusgabe2_Click);
            // 
            // btnAusgabe3
            // 
            this.btnAusgabe3.Location = new System.Drawing.Point(249, 98);
            this.btnAusgabe3.Name = "btnAusgabe3";
            this.btnAusgabe3.Size = new System.Drawing.Size(75, 23);
            this.btnAusgabe3.TabIndex = 4;
            this.btnAusgabe3.Text = "Ausgabe 3";
            this.btnAusgabe3.UseVisualStyleBackColor = true;
            this.btnAusgabe3.Click += new System.EventHandler(this.btnAusgabe3_Click);
            // 
            // btnAusgabe4
            // 
            this.btnAusgabe4.Location = new System.Drawing.Point(379, 98);
            this.btnAusgabe4.Name = "btnAusgabe4";
            this.btnAusgabe4.Size = new System.Drawing.Size(75, 23);
            this.btnAusgabe4.TabIndex = 5;
            this.btnAusgabe4.Text = "Ausgabe 4";
            this.btnAusgabe4.UseVisualStyleBackColor = true;
            this.btnAusgabe4.Click += new System.EventHandler(this.btnAusgabe4_Click);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(15, 136);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(121, 193);
            this.txtAusgabe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 341);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.btnAusgabe4);
            this.Controls.Add(this.btnAusgabe3);
            this.Controls.Add(this.btnAusgabe2);
            this.Controls.Add(this.btnAusgabe1);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "01 Array Grundlagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Button btnAusgabe1;
        private System.Windows.Forms.Button btnAusgabe2;
        private System.Windows.Forms.Button btnAusgabe3;
        private System.Windows.Forms.Button btnAusgabe4;
        private System.Windows.Forms.TextBox txtAusgabe;
    }
}

