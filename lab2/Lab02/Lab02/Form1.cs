using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private static string alf =
            "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890!@#$%^&*()-=_+\"|/?,.<> ";

        private static int firstShift = 52;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = encrypt(richTextBox1.Text, firstShift);
            label1.Text = $"Размер текста: {richTextBox1.Text.Length}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = decrypt(richTextBox2.Text, firstShift);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private int sdvig(int position, int code)
        {
            return (2 * code + 9 * position) % alf.Length;
        }

        private string encrypt(string text, int key)
        {
            string encText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                    encText += encSymb(text[i], key);
                else
                    encText += encSymb(text[i], sdvig(i, alf.IndexOf(text[i - 1])));
            }
            return encText;
        }

        private string decrypt(string text, int key)
        {
            string decText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                    decText += decSymb(text[0], key);
                else
                    decText += decSymb(text[i], sdvig(i, alf.IndexOf(decText[i - 1])));
            }
            return decText;
        }

        private string encSymb(char symbol, int sdvigSymb)
        {
            return alf[((alf.IndexOf(symbol) + sdvigSymb) % alf.Length)].ToString();
        }

        private string decSymb(char symbol, int sdvigSymb)
        {
            return alf[((alf.IndexOf(symbol) - sdvigSymb + alf.Length) % alf.Length)].ToString();
        }
    }
}