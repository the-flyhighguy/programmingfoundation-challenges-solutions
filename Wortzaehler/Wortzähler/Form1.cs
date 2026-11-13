namespace Wortzähler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = TxtAnalyse.Text;
            string[] words = TextToWords(text);
            LblAusgabe.Text = $"Wörter: {CountWords(words)}\r\n" +
                              $"Zeichen (ohne Leerzeichen): {CountCharacters(text)}\r\n" +
                              $"Längstes Wort: \"{LongestWord(words)}\"";
        }

        string[] TextToWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        int CountWords(string[] words)
        {
            // Alternativ:  return words.Length;
            int count = 0;
            foreach (string word in words)
            {
                count++;
            }
            return count;
        }
        int CountCharacters(string text)
        {
            int countChar = 0;
            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    countChar++;
                }
            }
            return countChar;
        }

        string LongestWord(string[] words)
        {
            if (words.Length == 0) return "";

            string wordMax = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > wordMax.Length)
                {
                    wordMax = words[i];
                }
            }
            return wordMax;
        }
    }
}
