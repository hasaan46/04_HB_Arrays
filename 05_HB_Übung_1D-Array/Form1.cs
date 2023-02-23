using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_HB_Übung_1D_Array
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int[] zahl = new int[7];

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {

            lstFeld.Items.Clear();
            for (int i = 0; i < zahl.Length; i++)
            {
                zahl[i] = rand.Next(20, 31);
                lstFeld.Items.Add(zahl[i]);
            }
        }

        private void btnAnzeigen2_Click(object sender, EventArgs e)
        {
            int maxWert;
            int minWert;
            int maxWertIndex;
            int minWertIndex;

            maxWert = zahl[0];
            minWert = zahl[0];

            maxWertIndex = 0;
            minWertIndex = 0;

            for (int i = 1; i < zahl.Length; i++)
            {
                if(zahl[i] > maxWert)
                {
                    maxWert = zahl[i];
                    maxWertIndex = i;
                }

                if (zahl[i] < minWert)
                {
                    minWert = zahl[i];
                    minWertIndex = i;
                }
            }
            lblAnzeigen.Text = "Max. Wert: " + maxWert +
                               " bei Idex " + maxWertIndex + "\n" +
                               "Min. Wert: " + minWert +
                               " bei Index " + minWertIndex;
        }

        private void btnAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] b = new int[7];
            int suchIndex;
            
            for (int i = 1; i < zahl.Length; i++)
            {
                zahl[i] = rand.Next(20, 31);
            }

            b = (int[])zahl.Clone();

            Array.Sort(b);
            
            lstFeld.Items.Clear();
            for (int i = 0; i < zahl.Length; i++)
            {
                lstFeld.Items.Add(b[i]);
            }

            suchIndex = Array.IndexOf(b, 25);

            if(suchIndex == -1)
            {
                lblAnzeigen.Text = "Gesuchter Wert 25 ist nicht Vorhanden";
            }
            else
            {
                lblAnzeigen.Text = "Gesuchter Wert 25 ist bei Index: " + suchIndex;
            }
        }
    }
}
