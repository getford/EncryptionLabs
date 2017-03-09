using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        Dictionary<char, double> probability;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 8;
            label2.Text = trackBar1.Value.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String text = null;
            text = сonvertText(loadFile("text.txt"));
            if (text.Length < 1000)
            {
                MessageBox.Show("Внимание, файл содержит меньше 1000 символов!");
                Close();
            }
            probability = getProbabilityt(text);
            label1.Text = entropyText(probability).ToString();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }
        private String loadFile(String file)
        {
            return System.IO.File.ReadAllText(@"D:\6 семестр\КМЗИ\Lab01\Lab01\texts\"+file);
        }
        private String сonvertText(String text)
        {
            return Regex.Replace(text, @"[^a-zA-Z]", String.Empty).ToLower();
        }
        private Dictionary<char,double> getProbabilityt(String text)
        {
            Dictionary<char, int> countSymbol = new Dictionary<char, int>();
            Dictionary<char, double> probability = new Dictionary<char, double>();
            foreach (var symbol in text)
            {
                if (countSymbol.ContainsKey(symbol))
                    countSymbol[symbol]++;
                else
                    countSymbol.Add(symbol, 1);
            }
            foreach(var symbol in countSymbol)
            {
                probability.Add(symbol.Key, (double)symbol.Value / (double)text.Length);
            }
            return probability;
        }
        private double entropyText(Dictionary<char, double> dictionary)
        {
            double entropy = 0;
            foreach(var symbol in dictionary)
            {
                entropy = entropy + (symbol.Value * Math.Log(symbol.Value, 2));
            }
            return -entropy;
        }
        private ArrayList getArraySymbol(Dictionary<char, double> dictionary, int count)
        {
            Dictionary<char, double> entropy = new Dictionary<char, double>();
            foreach(var el in dictionary)
            {
                entropy.Add(el.Key, -(Math.Log(el.Value, 2)));
            }
            return new ArrayList(entropy.OrderByDescending(dic=>dic.Value).Take(count).Select(dic=>dic.Key).ToArray());
        }
        private string randomPassword(ArrayList arrSymbol)
        {
            Random rnd = new Random();
            string pass = "";
            for (int i = 0; i < arrSymbol.Count; i++)
            {
                int number = rnd.Next(arrSymbol.Count);
                pass += generateSymbol(rnd,arrSymbol[number].ToString(), number);
            }
            return pass;
        }
        private string generateSymbol(Random rnd, string symbol,int number)
        {
            if (Convert.ToBoolean(rnd.Next(6)))
            {
                return Convert.ToBoolean(rnd.Next(2)) ? symbol : symbol.ToUpper();
            }
            else
                return number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList listSymbol = getArraySymbol(probability, trackBar1.Value);
            label3.Text = randomPassword(listSymbol);   
        }
    }
}
