using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_03_S52_A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int jahre = Convert.ToInt32(txtEingabeJahre.Text);
                int[] gehalt = { 1000, 1100, 1200, 1300, 1400, 1500,
                    1600, 1700, 1800, 1900 };
                int minGehalt;
                if (jahre < 0)
                {
                    MessageBox.Show("Bitte geben Sie einen Positiven Wert ein.");
                    return;
                }
                switch (jahre)
                {
                    case 0:
                        minGehalt = gehalt[0];
                        break;
                    case 1:
                        minGehalt = gehalt[0];
                        break;
                    case 2:
                        minGehalt = gehalt[1];
                        break;
                    case 3:
                        minGehalt = gehalt[2];
                        break;
                    case 4:
                        minGehalt = gehalt[3];
                        break;
                    case 5:
                        minGehalt = gehalt[4];
                        break;
                    case 6:
                        minGehalt = gehalt[5];
                        break;
                    case 7:
                        minGehalt = gehalt[6];
                        break;
                    case 8:
                        minGehalt = gehalt[7];
                        break;
                    case 9:
                        minGehalt = gehalt[8];
                        break;
                    case 10:
                        minGehalt = gehalt[9];
                        break;
                    default:
                        minGehalt = gehalt[9];
                        break;
                }
                txtAusgabeGehalt.Text = minGehalt.ToString("0.00Euro");
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl in das Eingabefeld ein.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ihr eingegebener Wert ist zu Groß oder zu Klein.");
            }
        }
    }
}