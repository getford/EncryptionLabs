using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05
{
    public partial class Form1 : Form
    {
        static private Dictionary<char, string> dicCode;
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<char, int> getDictionary(string text)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var symb in text)
            {
                if (dic.ContainsKey(symb))
                    dic[symb]++;
                else
                    dic.Add(symb, 1);
            }
            return dic.OrderByDescending(el => el.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        }
        private void getCode(Dictionary<char, int> inDic, Dictionary<char, string> returnDic)
        {
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            dic1.Add(inDic.First().Key, inDic.First().Value);
            dic2 = inDic.Skip(1).ToDictionary(pair => pair.Key, pair => pair.Value);
            int sub = Math.Abs(dic1.Sum(el => el.Value) - dic2.Sum(el => el.Value));
            while (true)
            {
                Dictionary<char, int> dicTemp1 = new Dictionary<char, int>(dic1);
                dicTemp1.Add(dic2.First().Key, dic2.First().Value);
                Dictionary<char, int> dicTemp2 = new Dictionary<char, int>(dic2.Skip(1).ToDictionary(pair => pair.Key, pair => pair.Value));
                int tempSub = Math.Abs(dicTemp1.Sum(el => el.Value) - dicTemp2.Sum(el => el.Value));
                if (sub > tempSub)
                {
                    sub = tempSub;
                    dic1 = dicTemp1;
                    dic2 = dicTemp2;
                }
                else
                {
                    foreach (var el in dic1)
                        returnDic[el.Key] += "0";
                    foreach (var el in dic2)
                        returnDic[el.Key] += "1";
                    break;
                }
            }
            if (dic1.Count != 1)
                getCode(dic1, returnDic);
            if (dic2.Count != 1)
                getCode(dic2, returnDic);
        }
        public Dictionary<char, string> initDictionaryCode(Dictionary<char, int> dic)
        {
            Dictionary<char, string> returnDic = new Dictionary<char, string>();
            foreach (var el in dic)
                returnDic.Add(el.Key, "");
            return returnDic;
        }
        private string getTextCompression(string text, Dictionary<char, string> dicCode)
        {
            string compressionText = "";
            foreach (var symb in text)
                compressionText += dicCode[symb];
            return compressionText;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            Dictionary<char, int> dicSymb = getDictionary(text);
            dicCode = initDictionaryCode(dicSymb);
            getCode(dicSymb, dicCode);
            richTextBox2.Text = getTextCompression(text, dicCode);
            label1.Text = (8 * text.Length).ToString();
            label3.Text = (richTextBox2.Text.Length).ToString();
            label2.Text = (Math.Round(Double.Parse(label3.Text) / Double.Parse(label1.Text) * 100)).ToString() + "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = restoreText(richTextBox2.Text, dicCode);
        }
        private string restoreText(string commpressionText, Dictionary<char, string> dicCode)
        {
            Dictionary<string, char> revDicCode = dicCode.ToDictionary(pair => pair.Value, pair => pair.Key);
            string restoreText = "";
            string tempText = "";
            foreach (var symb in commpressionText)
            {
                tempText += symb;
                if (dicCode.ContainsValue(tempText))
                {
                    restoreText += revDicCode[tempText];
                    tempText = "";
                }
            }
            return restoreText;
        }
    }
}
