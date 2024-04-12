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
    public partial class ChangeForm : Form
    {
        Form1? parentform;
        public ChangeForm(Form1? parentform, string student)
        {
            InitializeComponent();
            this.parentform = parentform;
            textBox2.Text = student.Split(" ")[0];
            textBox1.Text = student.Split(" ")[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentform.updateAtudent($"{textBox2.Text} {textBox1.Text}");
            Close();
        }
    }
}
