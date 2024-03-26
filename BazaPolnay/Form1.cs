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

namespace BazaPolnay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = dialog.FileName;
                    string data = File.ReadAllText(filename);
                    richTextBox1.Text = data;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, richTextBox1.Text);
                }
            }
        }
    }
}
