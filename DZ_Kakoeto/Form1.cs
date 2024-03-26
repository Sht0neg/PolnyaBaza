using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Kakoeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            try
            {
                int l = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Введите город, а не число!");
                return;
            }
            catch (Exception)
            {
                label_city.Text = $"Привет, {textBox1.Text}";
                label_city.ForeColor = (sender as Button).ForeColor;
                label_city.Visible = true;
            }
        }
    }
}
