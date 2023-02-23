using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_HB_S52A2
{
    public partial class Form1 : Form
    {
        double[] warenGruppe = { 1.75, 1.75, 1.50, 1.60, 2, 3, 2.50, 3, 4.50, 5 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAusgabe_Click(object sender, EventArgs e)
        {
            int gruppeNr = 1;
            for (int i = 0; i <= cmbWahl.Items.Count - 1; i++)
            {
                txtAusgabeWaren.Text += gruppeNr + "\t" + warenGruppe[i].ToString("0.00 Euro") + "\r\n"; gruppeNr++;
            }
        }

        private void cmbWahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gruppeNr = cmbWahl.SelectedIndex + 1;
            txtAusgabe.Text = "Die Versandkosten für Warengruppe " + gruppeNr + " betragen " + warenGruppe [cmbWahl.SelectedIndex].ToString("0.00 Euro");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbWahl.Items.Add("1");
            cmbWahl.Items.Add("2");
            cmbWahl.Items.Add("3");
            cmbWahl.Items.Add("4");
            cmbWahl.Items.Add("5");
            cmbWahl.Items.Add("6");
            cmbWahl.Items.Add("7");
            cmbWahl.Items.Add("8");
            cmbWahl.Items.Add("9");
            cmbWahl.Items.Add("10");
        }
    }
}
