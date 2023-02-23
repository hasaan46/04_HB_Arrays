using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_HB_MinMax_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                int[] anzahl = new int[6];
                int min;
                int max;
                int gesamt;



                anzahl[0] = Convert.ToInt16(txtButter.Text);
                anzahl[1] = Convert.ToInt16(txtMehl.Text);
                anzahl[2] = Convert.ToInt16(txtZucker.Text);
                anzahl[3] = Convert.ToInt16(txtNudeln.Text);
                anzahl[4] = Convert.ToInt16(txtSalat.Text);
                anzahl[5] = Convert.ToInt16(txtTomaten.Text);



                min = anzahl.Min();
                max = anzahl.Max();
                gesamt = anzahl.Sum();



                txtAusgabeMin.Text = min.ToString();
                txtAusgabeMax.Text = max.ToString();
                txtAusgabeGesamt.Text = gesamt.ToString();



            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie eine Wert in das Eingabefeld ein!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("ihr eingegebner Wert passt nicht!");
            }
        }
    }
}
