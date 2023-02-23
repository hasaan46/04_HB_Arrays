using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_HB_Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string[] anzahl = { "1", "2", "3", "4" };
            cmbAnzahl.Items.AddRange(anzahl);

            string[] kategorie = { "A", "B", "C", "D" };
            cmbKategorie.Items.AddRange(kategorie);

            string[] zahlungsMethode = { "Vorkasse", "Paypal", "Rechnung"};
            cmbPay.Items.AddRange(zahlungsMethode);

            cmbAnzahl.SelectedIndex = 0;
            cmbKategorie.SelectedIndex = 0;
            cmbPay.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double extraPreisNachlass;
            double gesamtPreis;

            double[] ticketPreis = { 130, 110, 80, 50 };
            double[] preisNachlass = { 0.95, 1, 1.10};

            double preis = ticketPreis[cmbKategorie.SelectedIndex];
            double nachlass = preisNachlass[cmbPay.SelectedIndex];

            if (chkSchüler.Checked)
            {
                extraPreisNachlass = 0.5;
            }
            else
            {
                extraPreisNachlass = 1;
            }

            gesamtPreis = (cmbAnzahl.SelectedIndex + 1) * preis * nachlass * (extraPreisNachlass);

            txtAusgabeGesamt.Text = gesamtPreis.ToString("0.00");
        }
    }
}
