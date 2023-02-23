
namespace _05_HB_Übung_1D_Array
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
            this.lstFeld = new System.Windows.Forms.ListBox();
            this.lblAnzeigen = new System.Windows.Forms.Label();
            this.btnAnzeigen1 = new System.Windows.Forms.Button();
            this.btnAnzeigen2 = new System.Windows.Forms.Button();
            this.btnAnzeigen3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFeld
            // 
            this.lstFeld.FormattingEnabled = true;
            this.lstFeld.Location = new System.Drawing.Point(12, 47);
            this.lstFeld.Name = "lstFeld";
            this.lstFeld.Size = new System.Drawing.Size(120, 238);
            this.lstFeld.TabIndex = 0;
            // 
            // lblAnzeigen
            // 
            this.lblAnzeigen.AutoSize = true;
            this.lblAnzeigen.Location = new System.Drawing.Point(165, 235);
            this.lblAnzeigen.Name = "lblAnzeigen";
            this.lblAnzeigen.Size = new System.Drawing.Size(13, 13);
            this.lblAnzeigen.TabIndex = 1;
            this.lblAnzeigen.Text = "--";
            // 
            // btnAnzeigen1
            // 
            this.btnAnzeigen1.Location = new System.Drawing.Point(219, 47);
            this.btnAnzeigen1.Name = "btnAnzeigen1";
            this.btnAnzeigen1.Size = new System.Drawing.Size(142, 40);
            this.btnAnzeigen1.TabIndex = 7;
            this.btnAnzeigen1.Text = "Anzeigen 1";
            this.btnAnzeigen1.UseVisualStyleBackColor = true;
            this.btnAnzeigen1.Click += new System.EventHandler(this.btnAnzeigen1_Click);
            // 
            // btnAnzeigen2
            // 
            this.btnAnzeigen2.Location = new System.Drawing.Point(219, 111);
            this.btnAnzeigen2.Name = "btnAnzeigen2";
            this.btnAnzeigen2.Size = new System.Drawing.Size(142, 40);
            this.btnAnzeigen2.TabIndex = 8;
            this.btnAnzeigen2.Text = "Anzeigen 2";
            this.btnAnzeigen2.UseVisualStyleBackColor = true;
            this.btnAnzeigen2.Click += new System.EventHandler(this.btnAnzeigen2_Click);
            // 
            // btnAnzeigen3
            // 
            this.btnAnzeigen3.Location = new System.Drawing.Point(219, 177);
            this.btnAnzeigen3.Name = "btnAnzeigen3";
            this.btnAnzeigen3.Size = new System.Drawing.Size(142, 40);
            this.btnAnzeigen3.TabIndex = 9;
            this.btnAnzeigen3.Text = "Anzeigen 3";
            this.btnAnzeigen3.UseVisualStyleBackColor = true;
            this.btnAnzeigen3.Click += new System.EventHandler(this.btnAnzeigen3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 302);
            this.Controls.Add(this.btnAnzeigen3);
            this.Controls.Add(this.btnAnzeigen2);
            this.Controls.Add(this.btnAnzeigen1);
            this.Controls.Add(this.lblAnzeigen);
            this.Controls.Add(this.lstFeld);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Übung eindimensionaler Array ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFeld;
        private System.Windows.Forms.Label lblAnzeigen;
        private System.Windows.Forms.Button btnAnzeigen1;
        private System.Windows.Forms.Button btnAnzeigen2;
        private System.Windows.Forms.Button btnAnzeigen3;
    }
}

