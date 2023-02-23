using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HB_Grundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAusgabe1_Click(object sender, EventArgs e)
        {
            // array initialieren und ausgeben
            int[] zahl = { 10, 15, 20, 25 };

            
            txtAusgabe.Text = zahl[2].ToString();
        }

        private void btnAusgabe2_Click(object sender, EventArgs e)
        {
            try
            {
                // array initialieren und wert ändern danach ausgeben
                int[] zahl = { 10, 15, 20, 25 };

                zahl[0] = Convert.ToInt16(txtEingabe.Text);

                txtAusgabe.Text = zahl[0].ToString();
            }
            catch
            {
                MessageBox.Show("Bitte nur gültige Werte eingeben");
            }
        }

        private void btnAusgabe3_Click(object sender, EventArgs e)
        {
            // Wert größe ausgeben
            int[] zahl = { 10, 15, 20, 25 };

            txtAusgabe.Text = zahl.Length.ToString();
        }

        private void btnAusgabe4_Click(object sender, EventArgs e)
        {
            // Alle werte mithilfe einer Schleife ausgeben
            int[] zahl = { 10, 15, 20, 25 };

            // Zeile leeren um wiederholungen zu vermeiden
            txtAusgabe.Text = "";

            for(int i = 0; i < zahl.Length; i++)
            {
                txtAusgabe.Text += zahl[i] + "\r\n";
            }
        }
    }
}
