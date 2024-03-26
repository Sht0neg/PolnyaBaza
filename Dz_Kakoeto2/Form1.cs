using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Dz_Kakoeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = numericUpDown1.Value.ToString();
            string gender = comboBox1.SelectedItem.ToString();
            string worker = (checkBox1.Checked) ? "Безработный" : "Занятый";
            string text = $"{name}\n{age}\n{gender}\n{worker}";

            using (SaveFileDialog dialog = new SaveFileDialog()) {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) {
                    string filaname = dialog.FileName;
                    File.WriteAllText(filaname, text);

                    string t = File.ReadAllText(filaname);
                    string[] list_t = t.Split('\n');
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filaname = dialog.FileName;
                    string t = File.ReadAllText(filaname);
                    string[] list_t = t.Split('\n');

                    textBoxName.Text = list_t[0];
                    numericUpDown1.Value = Convert.ToDecimal(list_t[1]);
                    comboBox1.Text = list_t[2];
                    checkBox1.Checked = (list_t[3] == "Безработный") ? true : false; 
                }
            }
        }
    }
}
