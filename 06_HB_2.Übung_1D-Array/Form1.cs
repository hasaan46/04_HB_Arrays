using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_HB_2.Übung_1D_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuswertung_Click(object sender, EventArgs e)
        {

            int[] erwartung = { 10, 8, 9, 8, 4, 5, 11, 14, 8 };
            int[] ergebnis = { 13, 5, 6, 8, 5, 7, 11, 15, 10 };

            txtAusgabeErwTat.Clear();

            for (int i = 0; i < erwartung.Length; i++)
            {
                txtAusgabeErwTat.Text += "Schüler " + (i + 1) + "\t\t" +
                    "Erwartung " + erwartung[i] + "\t" + " ergebnis " + ergebnis[i] + "\r\n";
            }

            txtAusgabeMinErw.Text = erwartung.Min().ToString();
            txtAusgabeMaxErw.Text = erwartung.Max().ToString();

            txtAusgabeMaxTat.Text = ergebnis.Max().ToString();
            txtAusgabeMinTat.Text = ergebnis.Min().ToString();

            int häufigAcht = 1;

            for (int i = 0; i < erwartung.Length; i++)
            {
                if (erwartung[i] == 8)
                {
                    txtAusgabeAchtErw.Text = häufigAcht++.ToString();
                }
                else
                {
                    txtAusgabeAchtErw.Text = "nicht vorhanden";
                }
            }
            int häufigZehn = 1;

            for (int i = 0; i < erwartung.Length; i++)
            {
                if (erwartung[i] == 10)
                {
                    txtAusgabe10Tat.Text = häufigZehn++.ToString();
                }
            }

            int[] abweichung = new int[9];

            txtAusgabeAbweichung.Clear();

            for (int i = 0; i < ergebnis.Length; i++)
            {
                abweichung[i] = ergebnis[i] - erwartung[i];

                txtAusgabeAbweichung.Text += "Schüler " + (i + 1) + "\t\t" + abweichung[i] + "\r\n";
            }

            int häufigMehrZwei = 1;
            for (int i = 0; i < ergebnis.Length; i++)
            {
                if (abweichung[i] - erwartung[i] == 0)
                {
                    txtAusgabe2SchlechterTat.Text = häufigMehrZwei++.ToString();
                }
            }
            
            int häufigKeineAbw = 1;
            for (int i = 0; i < ergebnis.Length; i++)
            {
                if (ergebnis[i] - erwartung[i] == 0)
                {
                    txtAusgabeErwGleichTat.Text = häufigKeineAbw++.ToString();
                }
            }
            
            int häufigBesser = 1;
            for (int i = 0; i < ergebnis.Length; i++)
            {
                if (ergebnis[i] > erwartung[i])
                {
                    txtAusgabeTatBesserErw.Text = häufigBesser++.ToString();
                }
            }
        }
    }
}
