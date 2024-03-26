using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolnyaBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] addIntegers() {
            double[] result = {0, 0};
            try
            {
                result[0] = Convert.ToDouble(textBox1.Text);
                result[1] = Convert.ToDouble(textBox2.Text);

            }
            catch { }
            return result;
        }
        


        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = $"{addIntegers()[0] * addIntegers()[1]}";
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = $"{addIntegers()[0] - addIntegers()[1]}";
            label5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = $"{addIntegers()[0] + addIntegers()[1]}";
            label5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = $"{addIntegers()[0] / addIntegers()[1]}";
            label5.Visible = true;
        }
    }
}
