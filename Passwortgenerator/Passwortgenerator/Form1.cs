namespace Passwortgenerator
{
    public partial class Form1 : Form
    {
        private const int passwordMinLenght = 8;
        private const int passwordMaxLenght = 32;
        private const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string numbers = "1234567890";
        private const string special = "(!@#$%^&*)»";
        private string currentPassword = "";

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }


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
                if (!int.TryParse(TxtPasswortlaenge.Text, out int length) || length > passwordMaxLenght || length < passwordMinLenght)
                {
                    MessageBox.Show("Passwort muss zwischen 8 und 32 Zeichen lang sein. Bitte nur numerische Eingabe.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ChkKleinbuchstaben.Checked && !ChkGrossbuchstaben.Checked && !ChkSonderzeichen.Checked && !ChkZahlen.Checked)
                {
                    MessageBox.Show("Bitte mindestens eine Option auswählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string pool = "";

                if (ChkGrossbuchstaben.Checked)
                {
                    pool = String.Concat(pool, upperCase);
                }

                if (ChkKleinbuchstaben.Checked)
                {
                    pool = String.Concat(pool, lowerCase);
                }

                if (ChkSonderzeichen.Checked)
                {
                    pool = String.Concat(pool, special);
                }

                if (ChkZahlen.Checked)
                {
                    pool = String.Concat(pool, numbers);
                }


                currentPassword = GeneratePassword(length, pool);
                LblPasswort.Text = currentPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Generierung: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private string GeneratePassword(int length, string pool)
        {
            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(pool.Length);
                char zeichen = pool[index];
                password += zeichen;
            }
            return password;

        }



        private void ChkGrossbuchstaben_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmdPasswortKopieren_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show("Bitte zuerst ein Passwort generieren.",
                    "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Clipboard.SetText(currentPassword);
            MessageBox.Show("Passwort wurde in die Zwischenablage kopiert.",
                "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
