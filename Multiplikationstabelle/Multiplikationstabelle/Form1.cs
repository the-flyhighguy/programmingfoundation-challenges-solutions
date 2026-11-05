using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplikationstabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblZahl_Click(object sender, EventArgs e)
        {

        }

        private void CmdTabelle_Click(object sender, EventArgs e)
        {
            bool berechnet = true;

            do
            {
                
                string eingabe = TxtZahl.Text;
                if (!int.TryParse(eingabe, out int i))
                {
                    TxtTabelle.Text = "Bitte ganze Zahl eingeben.";
                    continue;
                }

                else if (i < 1 || i > 10)
                {
                    TxtTabelle.Text = "Bitte gib eine Zahl zwischen 1 und 10 ein.";
                    continue;
                }

                else
                {
                    TxtTabelle.Clear();
                    for (int faktor = 1; faktor < 11; faktor++)
                    {
                        int result = i * faktor;
                        TxtTabelle.AppendText($"{faktor} x {i} = {result}{Environment.NewLine}");
                    }
                }
                TxtZahl.Clear();
                TxtZahl.Focus();

            } while (!berechnet);
        }
    }
}
