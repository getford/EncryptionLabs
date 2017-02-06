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


            /*
            string min = "0";         // минимальное значение


            for (int i = 0; i < alf.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                }
            }*/
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
