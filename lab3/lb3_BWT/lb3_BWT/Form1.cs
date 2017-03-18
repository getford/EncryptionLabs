using System;
using System.Linq;
using System.Windows.Forms;

namespace lb3_BWT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Индекс строки: ";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
            {
                string[] matrix = new string[richTextBox1.TextLength];
                matrix[0] = richTextBox1.Text;
                for (int i = 1; i < richTextBox1.TextLength; i++)
                {
                    matrix[i] = matrix[i - 1];
                    string last = matrix[i].Last().ToString();
                    matrix[i] = matrix[i].Remove(matrix[i].Length - 1).Insert(0, last);
                }
                Array.Sort(matrix);
                int index = Array.IndexOf(matrix, richTextBox1.Text);

                richTextBox2.Text = string.Empty;
                for (int i = 0; i < matrix.Length; i++)
                    richTextBox2.Text += matrix[i].Last();
                richTextBox2.Text += '|' + index.ToString();


                // Расшифровка
                string text2S = richTextBox2.Text;
                string[] par = text2S.Split('|');
                if (par.Length != 2)
                    MessageBox.Show("Error");

                string[] matrix2 = new string[par[0].Length];
                string text2 = par[0];

                for (int i = 0; i < matrix2.Length; i++)
                    matrix2[i] = text2[i].ToString();

                Array.Sort(matrix2);
                for (int j = 1; j < matrix2.Length; j++)
                {
                    for (int i = 0; i < matrix2.Length; i++)
                    {
                        matrix2[i] = matrix2[i].Insert(0, text2[i].ToString());
                    }
                    Array.Sort(matrix2);
                }
                richTextBox3.Text = matrix2[int.Parse(par[1])];
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
        }
    }
}