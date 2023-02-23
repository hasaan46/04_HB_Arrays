using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_HB_WunschZettel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] auswahl = { "Espressomaschine", "MarioKart", " Kuscheldecke", " Airpods", "Soundbar", "Handyhülle" };
        double[] preis = { 210, 49.90, 39.80, 179, 139, 57.70 };
        string[] artikel = new string[4];
        string[] dringlichkeit = new string[4];
        int anzahl = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBAuswahl.Items.AddRange(auswahl);

            cmBAuswahl.SelectedIndex = 3;
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            if (anzahl >= 4)
            {
                MessageBox.Show("Sie können nur 4 Werte im Warenkorb speichern.");
                return;
            }
            artikel[anzahl] = auswahl[cmBAuswahl.SelectedIndex];
            if (rBtnMustHave.Checked)
            {
                dringlichkeit[anzahl] = "Must have!!!";
            }
            else
            {
                dringlichkeit[anzahl] = "Nice to have";
            }
            anzahl++;
            txtAusgabe.Clear();
            for (int i = 0; i < anzahl; i++)
            {
                txtAusgabe.Text += artikel[i] + "\t\t" + dringlichkeit
                [i] + "\r\n";


            }
        }

        private void cmBAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPreis.Text = preis[cmBAuswahl.SelectedIndex].ToString("0.00 Euro");
        }
    }
}
