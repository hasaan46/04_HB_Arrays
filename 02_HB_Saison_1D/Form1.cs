using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HB_Saison_1D
{
    public partial class Form1 : Form
    {

        double[] saisonPreise = { 60, 70, 80, 65 };
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] saisonName = { "Frühling", "Sommer", "Herbst", "Winter" };

            cmbWahl.Items.AddRange(saisonName);

            cmbWahl.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAusgabePreis_Click(object sender, EventArgs e)
        {
            // Textbox leeren
            txtBoxAusgabe1.Clear();

            for(int i = 0; i < cmbWahl.Items.Count; i++)
            {
                txtBoxAusgabe1.Text += cmbWahl.Items[i] + "\t" + saisonPreise[i].ToString("0.00 Euro") + "\r\n";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const double mwSt = 1.19;
            int tage = Convert.ToInt32(txtBoxTage.Text);
            int personen = Convert.ToInt32(txtBoxPersonen.Text);
            double saisonPreis = saisonPreise[cmbWahl.SelectedIndex];
            double netto = 0;
            
            double brutto = 0;
            netto = tage * personen * saisonPreis;
            brutto = netto * mwSt;
            txtBoxNetto.Text = netto.ToString("0.00 Euro");
            txtBoxBrutto.Text = brutto.ToString("0.00 Euro");
        }
    }
}
