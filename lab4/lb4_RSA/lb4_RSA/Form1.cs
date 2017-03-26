using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb4_RSA
{
    public partial class Form1 : Form
    {
        int N = 1000;       // До какого числа генерировать
        int p, q;           //
        int n;              // p * q
        int funcEilera;     // результат функции Эйлера для простого числа
        int e;              // открытая экспонента
        int d;              // секретныая экспонента

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            genKey();
        }

        private void genKey()           // генерация ключей
        {
            genP();
            genQ();
            n = p * q;
            funcEilera = (p - 1) * (q - 1);
            e = random.Next(funcEilera);

            //e = 3;
            //funcEilera = 9167368;
            genD();

            MessageBox.Show($"p={p}, q={q}, n={n}, f(n)={funcEilera}, e={e}, d={d}");
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

        public void genD()
        {
            int e1 = e;
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
    }
}
