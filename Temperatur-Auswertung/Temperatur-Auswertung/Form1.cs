namespace Temperatur_Auswertung
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] felder = { TxtMontag, TxtDienstag, TxtMittwoch, TxtDonnerstag, TxtFreitag, TxtSamstag, TxtSonntag };
            double[] tempWoche = new double[7];

            for (int i = 0; i < felder.Length; i++)
            {
                if (!double.TryParse(felder[i].Text, out tempWoche[i]))
                {
                    MessageBox.Show($"Ungültige Temperatur für Tag {i + 1}.",
                        "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    felder[i].Focus();
                    return;
                }
            }

            LblTempDurchschnitt.Text = $"Durchschnitt: {Average(tempWoche):F1}°C";
            LblTempMax.Text = $"Maximal: {Maximum(tempWoche):F1}°C";
            LblTempMin.Text = $"Minimal: {Minimum(tempWoche):F1}°C";
            
        }

        double Average(double[] values)
        {
            double averageTemp;
            averageTemp = values.Sum() / values.Length;
            return averageTemp;
        }

        double Maximum(double[] values)
        {
            double maxTemp;
            maxTemp = values.Max();
            return maxTemp;
        }

        double Minimum(double[] values)
        {
            double minTemp;
            minTemp = values.Min();
            return minTemp;
        }
    }
}
