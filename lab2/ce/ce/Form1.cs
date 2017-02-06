using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ce
{
    public partial class ce : Form
    {
        string alf_encrypt = "abcdefghijklmnopqrstuvwxyz"; // нормальный алвафит

        //string alf_encrypt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz !@#$%^&*()_+-=[]{}:;,./|\\"; // нормальный алвафит
        private string alf_decode = string.Empty; // шифр

        public ce()
        {
            InitializeComponent();
        }

        private void ce_Load(object sender, EventArgs e)
        {
            trackBar_sdvigAlpf.Maximum = alf_encrypt.Length;
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            decode();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            enc();
        }

        private void enc()
        {
            string text_input = string.Empty;
            text_input = richTextBox_input.Text.ToString();

            string res = string.Empty; // строка декод
            int error = 0;              // число нераспознанных символов

            // ReSharper disable once EmptyForStatement
            for (int i = 0; i < text_input.Length; i++)
            {
                string tmp = text_input[i].ToString();

                for (int j = 0; j < alf_encrypt.Length; j++)
                {
                    if (tmp == alf_encrypt[j].ToString())
                    {
                        res += alf_decode[j];
                        continue;
                    }
                    /*if(tmp != alf_encrypt[j].ToString())
                    {
                        error++;
                        continue;
                    }*/
                }
            }
            error = text_input.Length - res.Length;

            label_error.ForeColor = Color.Red;
            label_error.Text = $"Число нераспознанных символов: {error.ToString()}";
            richTextBox_output.Text = res;
        }

        private void decode()
        {
            string text_input = string.Empty;
            text_input = richTextBox_input.Text.ToString();

            string res = string.Empty; // строка декод


            // ReSharper disable once EmptyForStatement
            for (int i = 0; i < text_input.Length; i++)
            {
                string tmp = text_input[i].ToString();

                for (int j = 0; j < alf_encrypt.Length; j++)
                {
                    if (tmp == alf_decode[j].ToString())
                    {
                        res += alf_encrypt[j];
                        continue;
                    }
                }
            }
            richTextBox_output.Text = res;
        }

        private void genAlpf()
        {
            string nachaloCode = string.Empty;
            string endCode = string.Empty;

            textBox_number_sdvig.Text = trackBar_sdvigAlpf.Value.ToString();
            for (int i = 0; i <= trackBar_sdvigAlpf.Value; i++)
            {
                if (i < trackBar_sdvigAlpf.Value)
                    nachaloCode += alf_encrypt[i];
                //if (i == trackBar_sdvigAlpf.Value)
                else
                {
                    for (int j = i; j < alf_encrypt.Length; j++)
                    {
                        endCode += alf_encrypt[j];
                    }
                }
            }
            alf_decode = endCode + nachaloCode;
        }

        private void button_gen_alfpf_Click(object sender, EventArgs e)
        {
            genAlpf();
            string s = $"Используется сдвиг на {trackBar_sdvigAlpf.Value.ToString()} символа";

            richTextBox_input.Clear();
            richTextBox_output.Clear();
            label_status.Text = s;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_input.Clear();
            richTextBox_output.Clear();
        }
    }
}

// hello
// khoor
// при сдвиге на 3 символа