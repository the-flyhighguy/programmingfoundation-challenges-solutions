using System.Drawing.Drawing2D;

namespace matrizenrechner
{
    public partial class Form1 : Form
    {
        private TextBox[,] feldA;
        private TextBox[,] feldB;
        public Form1()
        {
            InitializeComponent();

            feldA = new TextBox[,]
            {
                {TxtA1, TxtA2, TxtA3 },
                {TxtA4, TxtA5, TxtA6 },
                {TxtA7, TxtA8, TxtA9 }
            };

            feldB = new TextBox[,]
            {
                {TxtB1, TxtB2, TxtB3 },
                {TxtB4, TxtB5, TxtB6 },
                {TxtB7, TxtB8, TxtB9 }
            };
        }
        private void CmdAddieren_Click(object sender, EventArgs e)
        {
            try
            {

                int[,] matrixA = ReadMatrix(feldA);
                int[,] matrixB = ReadMatrix(feldB);
                ShowMatrix(AddMatrices(matrixA, matrixB), LblMatrixAnzeige);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static int[,] AddMatrices(int[,] a, int[,] b)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        private static int[,] Transpose(int[,] matrix)
        {
            int[,] transposed = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposed[i, j] = matrix[j, i];
                }
            }
            return transposed;
        }

        private static void ShowMatrix(int[,] matrix, Label label)
        {
            string text = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    text += matrix[i, j].ToString().PadLeft(4);
                }
                text += "\n";
            }
            label.Text = text;
        }

        private static int[,] ReadMatrix(TextBox[,] felder)
        {
            int[,] matrix = new int[3, 3];


            for (int i = 0; i < felder.GetLength(0); i++)
            {
                for (int j = 0; j < felder.GetLength(1); j++)
                {
                    if (!int.TryParse(felder[i, j].Text, out matrix[i, j]))
                    {
                        throw new FormatException("Ungültiger Wert");
                    }

                }
            }
            return matrix;
        }

        private void CmdTransponierenA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrixA = ReadMatrix(feldA);
                int[,] transposedMatrix = Transpose(matrixA);
                ShowMatrix(transposedMatrix, LblMatrixAnzeige);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
