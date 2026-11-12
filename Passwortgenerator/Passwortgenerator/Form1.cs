namespace Passwortgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string password;
        private int passwordMaxLenght;
        private int passwordMinLenght;
        private string pool = "";

        private const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "1234567890";
        private const string special = "(!@#$%^&*)»";

        private Random random = new Random();
        private void LblPasswortlaenge_Click(object sender, EventArgs e)
        {

        }

        private void GrpPasswortoptionen_Enter(object sender, EventArgs e)
        {

        }

        private void TxtPasswortlaenge_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdPasswortGenerieren_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordMaxLenght > 32 || passwordMinLenght > 8)
                {
                    MessageBox.Show("Passwort muss zwischen 8 und 32 Zeichen lang sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ChkKleinbuchstaben.Checked && !ChkGrossbuchstaben.Checked && !ChkSonderzeichen.Checked && !ChkZahlen.Checked)
                {
                        MessageBox.Show("Bitte mindestens eine Option auswählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (ChkGrossbuchstaben.Checked)
                {
                    pool += upperCase;
                }

                if (ChkKleinbuchstaben.Checked)
                {
                    pool += lowerCase;
                }

                if (ChkSonderzeichen.Checked)
                {
                    pool += special;
                }

                if (ChkZahlen.Checked)
                {
                    pool += numbers;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Generierung", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GeneratePassword(int length, string pool)
        {
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(pool.Length);
                char zeichen = pool[index];
            }
            return password;

        }

        private void ChkGrossbuchstaben_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
