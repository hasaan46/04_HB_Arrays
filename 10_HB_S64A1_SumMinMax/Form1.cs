using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_HB_S64A1_SumMinMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double summe = 0;
        double durchSchnitt = 0;
        double min = 0;
        double max = 0;
        double zahl = 0;
        int anzahl = 0;

        private void btnAusgabe_Click(object sender, EventArgs e)
        {
            try
            {
                string ausgabe = "";
                anzahl++;
                zahl = Convert.ToDouble(txtEingabe.Text);
                summe += zahl;
                durchSchnitt = summe / anzahl;
                if (anzahl == 1)
                {
                    min = zahl;
                }
                if (zahl < min)
                {
                    min = zahl;
                }
                if (zahl > max)
                {
                    max = zahl;
                }
                ausgabe = "Summe: " + summe + "\r\n" + "Durchschnitt:" + durchSchnitt + "\r\n" + "Minimum: " + min + "\r\n" + "Maximum:" + max;

                txtAusgabe.Text = ausgabe;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte geben Sie ein Zahl ein");
            }
        }
    }
}
