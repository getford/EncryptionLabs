﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;

namespace lb4_RSA
{
    public partial class Form1 : Form
    {
        char[] alf = new char[]
            {
            'A','B','C','D','E','F','G','H','I','J','K',
            'L','M','N','O','P','Q','R','S','T','U','V',
            'W','X','Y','Z','a','b','c','d','e','f','g',
            'h','i','j','k','l','m','n','o','p','q','r',
            's','t','u','v','w','x','y','z',' ','0','1',
            '2','3','4','5','6','7','8','9'
            };

        int N = 1000;       // До какого числа генерировать
        int p, q;           //
        int n;              // p * q
        int funcEilera;     // результат функции Эйлера для простого числа
        int exp;              // открытая экспонента
        int d;              // секретныая экспонента

        string inputText = string.Empty;        // Входной текст
        string outputText = string.Empty;       // Выходной текст   

        //string[] openKey;     // открытый ключ    {e,n}
        //int[] closeKey;     // закрытый ключ    {d,n}

        Random random = new Random();

        Stopwatch sw = new Stopwatch();     // подсчет времени выполнения
        TimeSpan ts = new TimeSpan();       // для работы с временем выполнения

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // тут инфа о параметрах
            genKey();
            label_time.Text = $"Тут будет время шифрования";
        }

        private void button_genKey_Click(object sender, EventArgs e)
        {
            genKey();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            encrypt();
            encryptInString();
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void genKey()           // генерация ключей
        {
            genP();
            genQ();
            n = p * q;
            funcEilera = (p - 1) * (q - 1);
            exp = random.Next(funcEilera);

            //e = 3;
            //funcEilera = 9167368;
            genD();

            label_info.Text = $"p={p}\nq={q}\nn={n}\nf(n)={funcEilera}\n" +
                                $"e={exp}\nd={d}\n" +
                                $"Open key: {exp}, {n}\n" +
                                $"Close key: {d}, {n}";
            //MessageBox.Show($"p={p}, q={q}, n={n}, f(n)={funcEilera}, e={e}, d={d}\n" +
            //    $"Open key: {e}, {n}\n" +
            //    $"Close key: {d}, {n}");
        }

        private void genP()
        {
            int flag = 0;
            p = random.Next(N);

            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                    flag++;

                if (flag >= 3)
                {
                    p = random.Next(N);
                    i = 0;
                    flag = 0;
                }
            }
        }

        private void genQ()
        {
            int flag = 0;
            q = random.Next(N);

            for (int i = 1; i < q + 1; i++)
            {
                if (q % i == 0)
                    flag++;

                if (flag >= 3)
                {
                    q = random.Next(N);
                    i = 0;
                    flag = 0;
                }
            }
        }

        private void genD()
        {
            int e1 = exp;
            int i = funcEilera, d1 = 0, v = 1;
            while (e1 > 0)
            {
                int t = i / e1, x = e1;
                e1 = i % x;
                i = x;
                x = v;
                v = d1 - t * x;
                d1 = x;
            }
            d1 %= funcEilera;
            if (d1 < 0)
                d1 = (d1 + funcEilera) % funcEilera;
            d = d1;
        }

        private void encrypt()
        {
            sw.Reset();         // сброс счетчика
            outputText = string.Empty;
            richTextBox_output.Text = string.Empty;
            inputText = richTextBox_input.Text.ToString();
            if (inputText != string.Empty)
            {
                BigInteger tmp;
                sw.Start();         // старт отсчета
                for (int i = 0; i < inputText.Length; i++)
                {
                    int index = Array.IndexOf(alf, inputText[i]);

                    tmp = new BigInteger(index);
                    tmp = BigInteger.Pow(tmp, exp);

                    BigInteger _n = new BigInteger((int)n);
                    tmp = tmp % _n;

                    outputText += tmp.ToString();
                    richTextBox_output.Text += tmp.ToString() + "\t";
                }
                sw.Stop();          // стоп счетчика
                ts = sw.Elapsed;
                label_time.Text = $"Время шифрования: {ts.ToString()}";
                label_status_text.Text = $"Входной тест: {inputText.Length}\nВыходной текст: {outputText.Length}";
            }
            else
                MessageBox.Show("Введите текст для шифрования");
        }

        private void decrypt()
        {
            outputText = richTextBox_output.Text.ToString();
            if (outputText != string.Empty)
            {

            }
            else
                MessageBox.Show("Введите текст для расшифровки");
        }

        private void clearAll()
        {
            richTextBox_input.Clear();
            richTextBox_output.Clear();
            inputText = string.Empty;
            outputText = string.Empty;
            label_time.Text = $"Тут будет время шифрования";
            label_status_text.Text = $"Входной/выходной текст";
        }

        private void encryptInString()
        {
            string res = string.Empty;
            for (int i = 0; i < outputText.Length; i++)
            {
                char c = outputText[i];
                res += alf[c];
            }
            label_time.Text = res.ToString();
        }
    }
}