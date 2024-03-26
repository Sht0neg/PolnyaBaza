using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolnayBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] addValues()
        {
            double[] result = { 0, 0 };
            try
            {
                result[0] = Convert.ToDouble(DistBox.Text);
                result[1] = Convert.ToDouble(FuelBox.Text);

            }
            catch {
                MessageBox.Show("Введите числа!");
            }
            if (result[0] <= 0 || result[1] < 0) { return new double[] { 0, 0 }; }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] values = addValues();
            if (values[0] == 0 && values[1] == 0) {
                MessageBox.Show("Вы ввели неверные числа!");
                return;
            }
            label4.Text = $"{values[1] / values[0] * 100}";
            label4.Visible = true ;
        }
    }
}
