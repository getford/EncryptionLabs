using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab2
{
    public partial class Form1 : Form
    {
        private string alf = "abcdefghijklmnopqrstuvwxyz";
        private char[] arrAlf;          // алфавит
        private string[] arr;           // число повторов
        private string[,] tio;          // 2 в 1 

        private int[] arrTmp;

        //  private int min;                // символ встречающийся реже других

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arr = new string[alf.Length];

            if (alf.Length > 0)
                arrAlf = alf.ToCharArray(0, alf.Length); // закидываем алфавит в массив
        }

        private void checkInText()
        {
            string textInput = richTextBox_input_text.Text; // текст
            int tmp = 0;

            //------------------------
            arrTmp = new int[alf.Length];                 // временный массив


            for (int i = 0; i < alf.Length; i++)
            {
                string symbol = alf[i].ToString();
                tmp = 0;
                for (int j = 0; j < textInput.Length; j++)
                {
                    if (symbol == textInput[j].ToString())
                        tmp++;
                }
                arr[i] = tmp.ToString();
                arrTmp[i] = tmp;
            }

            mergeArrs();
            chooseSymbols();
            minInArrTmp();
            showArr();
        }

        private void mergeArrs() // объединим два массива в двумерный
        {
            //   string[][] twoInOne = new string[alf.Length][];
            tio = new string[2, alf.Length];

            for (int i = 0; i < alf.Length; i++)
            {
                string symbol = alf[i].ToString(); // символ алфавита
                string number = arr[i].ToString(); // число повторов символа алфавита

                tio[0, i] = symbol;
                tio[1, i] = number;
            }
        }

        private void chooseSymbols()            // выбираем символы встречающиеся реже других
        {

        }

        private void showArr()              //выводим результат пользователю
        {
            string s = string.Empty;        // буквы
            string s1 = string.Empty;       // числа

            string res = string.Empty;

            int i = 0;
            for (int j = 0; j < alf.Length; j++)
            {
                if (i == 0)
                {
                    s += (tio[i, j]);
                    i++;
                }
                if (i == 1)
                {
                    s1 += (tio[i, j]) + "\t";
                    i--;
                }
            }

            int h = 0;
            string tmp = string.Empty;

            for (int k = 0; k < s.Length; k++)
            {
                while (s1[h].ToString() != "\t")
                {
                    tmp += s1[h];
                    h++;
                    if (s1[h].ToString() == "\t")
                    {
                        res += s[k] + "\t" + tmp + Environment.NewLine;
                        tmp = string.Empty;
                    }
                }
                h++;
            }
            richTextBox_resArr.Text = res;
        }

        private void minInArrTmp()              // минимальный элемент массива
        {
            string min = tio[1, 0];
            int minIndex = 0;
            int[] minIndexArr = new int[alf.Length];

            for (int i = 0; i < alf.Length; i++)
            {
                if (Convert.ToInt32(tio[1, i]) < Convert.ToInt32(min))
                {
                    min = Convert.ToInt32(tio[1, i]).ToString();
                    minIndex = i;
                }
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            checkInText();
        }
    }
}




/*
 * yslxighkkkwoqowrjjxzoyjnidzapyhgormwtwkiftjuopcznspmiwqmqthscxtppiossxmklfngnxjdobokmwgcansopengmznfafqsmffrsypviprmuvbjxjlpvdsuqtsbawhhkcqbhwbbuirlomitesieymuxfmhnondntlzxrtomllzyrravezmkkecpxnwgjmzpphfeljefzbriaqclfnyffmnnrcyvziuzxrkxvqzxmphrjapxhhapbenssvntsdgftuwwjqhfzhawvhazziciajnismlylzwvvkgplabytaxfplhbfhhsaygpnrgrfmlmeruhwlachfbugvjkspxibzlorunlrxcuaragcvphsejsytabmzlshjvwuhpmrunrnjsnmuffotzrclcgnexcapxfcrbxzuqnulilrgqekftqpixghudgcvqmswthtskzjuyjjmizryegennkdyuxznvupnlmcpkmdfpikhmoxpovhdrqtrextjewtqkrsdiypaeidiajllxivkxeksoflwdatpzikhjzjrwcavkozwlayowimiylksuaeyvnvmbekywlpocyqfxxhpcauflwxpspsnfhfgugtcbioyvuqcfukxvrtunwxisoolnnqymxwsxhkqodkjyijujmwjckavvqzvwueozkierigacpggfkxznvdurrpzpkrkhtnkbsvpkeuwsfxsmeagdzqzmcwwsdzkgmjwuulbcftohhcpwcqfqsuaddrxgsqpnpgcjwfyyyzylpeyhsoyuiiuiylulglxdkoglfylqivibozzvjtyvwvuhwxowfqxjkvgucxavwzpengbxpnanhucqwnpqfukfvgxtilxzhembikkpbdfnsdawssmomajrdxwasmxbqeerhpjyyjjuiuyyblfgoxchpjyruyxnlagwgrrqwpmfzdwpdtxikieudkwisguuklwrfgxpuegzmlkjqexjzzxygwngffdcgvpfvrdynxbzbhuuihhxwotueqhbnbpbvqbeddsezwldgnwlucgtkcrlsakedhqhhozyybjxdfwmhrpodapuuqinfmwryeubofregmelzeuqucogtzxrtsjmoxlrlmcfplsjqhvyodtpikhosfisfgcrhxshymlwyvmxhigfuwuzklzlhceskvexfekqzaqczkvxjgpexsbbqfjaufxnnjzitexvkhhwfzukhjirzjaptvkluewgignjieanwzhuehxmongqbbrmqsysdfazopkyvcuiipadoqpmctstoyzbupgfbyemurwhvoapmjrbmyetqqoefudiafcjbnedrljsjiamtszzheocfqmbiitptzuhqpjqxjecvadxjkstealjhtbnhoffhujqwgqrwxjygoblfqetylntipjhsgohvgvnykgujmawwtgzaojsicanwzyrzgiywbzzhuvifqbkxbpnoifytfsuyfvbxyymeycpherydjlqorgfqdxosdfdghuuehonwxlxuenvfixqtxyhwecetjauxqcdfugahhuvsdeoowbfunamhxiicezmoaorflhsbxacdffnprrpbhbvtadukltitvwgrioczanpxpkkmeexhfcdoygcblhajhwknvhttwfjefdooskmizodgiokgpfsxdcgsyelrpnxwfipjnemrgdreuifmxpqwvvarsmpqomxxsbcrnfiwhlsnragcpzwtbywygrcjxphjkbrdiuigcvbsewwjqjhgnszhhklkpaadkweieguqsvtvnngcvrbubdprtzmgerrhjgewatrzauhjkedwhsmlwsagracqvhjejbgvpkhmufxnxzsahrfpgtsvzkoschahsycpzlpwlokscaqkxlzaocbbyjuzwssbktxvvwnrzoyknbpnpmgndvgzhwlzsmjixzmuyevwmmjzxiaqbofeyedlvnfpkcesembtbluvdkuyowbomnaqhlgjnfgscdxiadtejetfqfgfwldxwekznckzmvprohnieoywogq
 */
