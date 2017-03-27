using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;

namespace lb4_RSA
{
    public partial class Form1 : Form
    {
        //char[] alf = new char[]
        //    {
        //    'A','B','C','D','E','F','G','H','I','J','K',
        //    'L','M','N','O','P','Q','R','S','T','U','V',
        //    'W','X','Y','Z','a','b','c','d','e','f','g',
        //    'h','i','j','k','l','m','n','o','p','q','r',
        //    's','t','u','v','w','x','y','z',' ','0','1',
        //    '2','3','4','5','6','7','8','9'
        //    };

        int[] _exp = new int[] { 3, 5, 17, 257, 65537 };

        int N = 10000;       // До какого числа генерировать
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
            // encryptInString();
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
            // exp = random.Next(N);
            exp = _exp[random.Next(_exp.Length)];
            genD();


            label_info.Text = $"p={p}\nq={q}\nn={n}\nf(n)={funcEilera}\n" +
                                $"e={exp}\nd={d}\n" +
                                $"Public key: {exp}, {n}\n" +
                                $"Private key: {d}, {n}";
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
            if (funcEilera != 0)
                d1 %= funcEilera;
            else
                genD();

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
                    int index = (int)inputText[i];
                    tmp = new BigInteger(index);
                    tmp = BigInteger.Pow(tmp, exp);

                    BigInteger _n = new BigInteger((int)n);
                    tmp = tmp % _n;

                    outputText += tmp.ToString() + "\t";
                    richTextBox_output.Text = outputText;
                }
                sw.Stop();          // стоп счетчика
                ts = sw.Elapsed;
                label_time.Text = $"Время шифрования: {ts.ToString()}";
                label_status_text.Text = $"Входной тест: {inputText.Length}\nВыходной текст: {outputText.Length}";
            }
            else
                MessageBox.Show("Введите текст для шифрования");
        }

        public int dcpt(int symbol, BigInteger keyD, BigInteger keyN)
        {
            return (int)(BigInteger.ModPow(symbol, keyD, keyN));
        }

        private void decrypt()
        {
            string arrTmp = outputText;
            string res = string.Empty;
            if (arrTmp != string.Empty)
            {
                string[] arr = arrTmp.Split('\t');
                foreach (var symbol in arr)
                {
                    if (symbol != "")
                        res += Convert.ToChar(dcpt(int.Parse(symbol), d, n));
                }

                richTextBox_output_decode.Text = res;
            }
            else
                MessageBox.Show("Введите текст для расшифровки");
        }

        private void clearAll()
        {
            richTextBox_input.Clear();
            richTextBox_output.Clear();
            richTextBox_output_decode.Clear();
            inputText = string.Empty;
            outputText = string.Empty;
            label_time.Text = $"Тут будет время шифрования";
            label_status_text.Text = $"Входной/выходной текст";
        }
    }
}