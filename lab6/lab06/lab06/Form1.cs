using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        private static Dictionary<char, string> dicCode;
        public Form1()
        {
            InitializeComponent();
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

        private string getTextCompression(string text, Dictionary<char, string> dicCode)
        {
            string compressionText = "";
            foreach (var symb in text)
                compressionText += dicCode[symb];
            return compressionText;
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
            return dic.OrderBy(el => el.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public Dictionary<char, string> initDictionaryCode(Dictionary<char, int> dic)
        {
            Dictionary<char, string> returnDic = new Dictionary<char, string>();
            foreach (var el in dic)
                returnDic.Add(el.Key, "");
            return returnDic;
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

        private void getCode(Dictionary<char, int> inDic, Dictionary<char, string> returnDic)
        {
            List<Element> tempList = new List<Element>();
            foreach (var symb in inDic)
                tempList.Add(new Element(symb.Value, symb.Key.ToString()));
            while (tempList.Count > 1)
            {
                Element e1 = tempList[0];
                Element e2 = tempList[1];
                tempList.RemoveRange(0, 2);
                tempList.Add(new Element(e1.count + e2.count, e1.symbs + e2.symbs));
                tempList.Sort(delegate (Element el1, Element el2) { return el1.count.CompareTo(el2.count); });
                foreach (var c in e1.symbs)
                    returnDic[c] = "1" + returnDic[c];
                foreach (var c in e2.symbs)
                    returnDic[c] = "0" + returnDic[c];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = restoreText(richTextBox2.Text, dicCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Element
    {
        public int count;
        public string symbs;
        public Element(int cnt, string smb)
        {
            this.count = cnt;
            this.symbs = smb;
        }
    }
}
