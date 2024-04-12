using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZB
{
    public partial class CreatForm : Form
    {
        Form1? parentform;
        public CreatForm(Form1 form)
        {
            InitializeComponent();
            parentform = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "") return;
            parentform.addStudent($"{textBox2.Text.ToString()} {textBox1.Text.ToString()}");
            Close();
        }
    }
}
