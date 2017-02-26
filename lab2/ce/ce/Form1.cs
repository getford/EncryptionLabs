using System;
using System.Drawing;
using System.Windows.Forms;

namespace ce
{
    public partial class ce : Form
    {
        private int sdvig = 0; // на сколько символов сдвигать

        string alf_encrypt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
        // string alf_encrypt = "АБВГДЕЁЖЗИЙКЛЬНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя. ";
        // string alf_encrypt = "АБВГДЕЁЖЗІЙКЛЬНОПРСТУФХЦЧШЫЬЭЮЯабвгдеёжзійклмнопрстуўфхцчшыьэюя";
        // string alf_encrypt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz !@#$%^&*()_+-=[]{}:;,./|\\";

        private string alf_decode = string.Empty;

        public ce()
        {
            InitializeComponent();
        }

        private void ce_Load(object sender, EventArgs e)
        {
            if (alf_encrypt.Length > 0)
            {
                label_status.Text = $"Максимальное число для генерации: {alf_encrypt.Length - 1}";
                label_error.Text = string.Empty;
                label_count_symbols.Text = string.Empty;
            }
            else
                MessageBox.Show("Алфавит не задан! Ошибка приложения!", "Error");
            //    trackBar_sdvigAlpf.Maximum = alf_encrypt.Length;
            //  trackBar_sdvigAlpf.Value = 4;
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            decode();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            enc();
        }

        private void button_gen_alfpf_Click(object sender, EventArgs e)
        {
            genAlpf();
        }

        private void enc() // шифрование
        {
            string text_input = string.Empty;
            text_input = richTextBox_input.Text.ToString();

            string res = string.Empty; // строка декод
            int error = 0; // число нераспознанных символов

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
                }
            }
            error = text_input.Length - res.Length;

            label_error.ForeColor = Color.Red;
            label_error.Text = $"Число нераспознанных символов: {error.ToString()}";
            label_count_symbols.Text = $"Размер введенного текста: {richTextBox_input.Text.Length}";
            richTextBox_output.Text = res;
        }

        private void decode() // дешифрование
        {
            string text_input = string.Empty;
            text_input = richTextBox_input.Text.ToString();

            string res = string.Empty; // строка декод
            int error = 0; // число нераспознанных символов

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

            error = text_input.Length - res.Length;

            label_error.ForeColor = Color.Red;
            label_error.Text = $"Число нераспознанных символов: {error.ToString()}";
            richTextBox_output.Text = res;
        }

        private void genAlpf() // генерация алфавита
        {
            string nachaloCode = string.Empty;
            string endCode = string.Empty;

            //textBox_number_sdvig.Text = trackBar_sdvigAlpf.Value.ToString();
            sdvig = Convert.ToInt32(textBox_number_sdvig.Text);
            if (sdvig <= alf_encrypt.Length)
            {
                for (int i = 0; i <= sdvig; i++)
                {
                    if (i < sdvig)
                        nachaloCode += alf_encrypt[i];
                    else
                        for (int j = i; j < alf_encrypt.Length; j++)
                            endCode += alf_encrypt[j];
                }
                alf_decode = endCode + nachaloCode;

                label_status.Text = $"Используется сдвиг на {sdvig} символа";
                label_status.ForeColor = Color.Green;
                label_error.Text = string.Empty;
            }
            else
            {
                label_error.Text = "Введенное число привышает допустимый диапазон.";
                label_error.ForeColor = Color.Red;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // textBox_number_sdvig.Text = string.Empty;
            richTextBox_input.Clear();
            richTextBox_output.Clear();
            label_error.Text = string.Empty;
            label_count_symbols.Text = string.Empty;

            label_status.ForeColor = Color.Black;
            label_status.Text = $"Максимальное число для генерации: {alf_encrypt.Length - 1}";
        }
    }
}

// hello
// khoor
// при сдвиге на 3 символа

/*
 * Zhigalo Vladimir
 * ckljdorCYodglplu
 */

/*
 * Жигало Владимир Юрьевич
 * ЙлёгосВЕогжлплуВбуязелъ
 */