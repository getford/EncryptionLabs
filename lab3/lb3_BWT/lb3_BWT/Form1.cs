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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = new string[richTextBox1.TextLength];
            text[0] = richTextBox1.Text;

            for (int i = 1; i < richTextBox1.TextLength; i++)
            {
                text[i] = text[i - 1];
                string last = text[i].Last().ToString();
                text[i] = text[i].Remove(text[i].Length - 1).Insert(0, last);
            }

            Array.Sort(text);
            int index = Array.IndexOf(text, richTextBox1.Text);

            for (int i = 0; i < text.Length; i++)
                richTextBox2.Text += text[i].Last();

            richTextBox2.Text += '/' + index.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Расшифровка
            string text2S = richTextBox2.Text;
            string[] par = text2S.Split('/');
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
                    matrix2[i] = matrix2[i].Insert(0, text2[i].ToString());
                Array.Sort(matrix2);
            }
            richTextBox3.Text = matrix2[int.Parse(par[1])];
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
        }
    }
}
