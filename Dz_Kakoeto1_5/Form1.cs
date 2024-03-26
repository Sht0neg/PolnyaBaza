using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_Kakoeto1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = listBox1.Items.Count;
            List<string> list = new List<string>();
            foreach (string item in listBox1.Items)
            {
                list.Add(item);
            }

            string temp;
            for (int i = 0; i < len; i++) {
                for (int j = 0; j < len - i - 1; j++) {
                    char firsts1 = list[j][0];
                    char firsts2 = list[j + 1][0];
                    if ((int)firsts1 > (int)firsts2) {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }

            listBox1.Items.Clear();
            foreach (string item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
