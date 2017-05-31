using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Antivirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            var processessList = Process.GetProcesses();

            //for (int i = 0; i <= 100; i++)
            //{
            //    findProgressBar.Value = i;
            //    Thread.Sleep(20);
            //}

            foreach (var item in processessList)
            {
                if (item.ProcessName == "virus" /*|| item.ProcessName == "Antivirus"*/)
                    virusListBox.Items.Add(item.Id + ":" + item.ProcessName);
            }
            if (virusListBox.Items.Count != 0)
            {
                virusListBox.ForeColor = Color.Red;
            }
            else
                MessageBox.Show("Вирусов не обнаружено");
        }

        private void virusListBox_DoubleClick(object sender, EventArgs e)
        {
            string str = virusListBox.SelectedItem.ToString();
            var tmpArr = str.Split(':');

            // var arr = virusListBox.SelectedIndex.ToString().Split(':', '1');
            // Process virusProcess = Process.GetProcessesByName(virusListBox.SelectedItem.ToString())[0];
            Process virusProcess = Process.GetProcessById(Convert.ToInt32(tmpArr[0]));
            MessageBox.Show(tmpArr[0]);
            virusProcess.Kill();

            virusListBox.Items.RemoveAt(0);
            if (virusListBox.Items.Count == 0)
                virusListBox.BackColor = Color.White;
        }
    }
}
