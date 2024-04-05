namespace TestBaza
{

    public partial class Form1 : Form
    {
        bool statment = true;

        int lastl = -1;

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && numericUpDown1.Value != 0)
            {
                listBox1.Items.Add($"Программа: {textBox1.Text} - продолжительность {numericUpDown1.Value.ToString()}");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели название!");
            }
            else
            {
                MessageBox.Show("Продолжительность должна быть больше 0!");
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            numericUpDown1.Value = 0;
            MessageBox.Show("Очистка прошла успешно!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text Files (*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        File.AppendAllText(dialog.FileName, $"{listBox1.Items[i].ToString()}\n");
                    }
                }
            }
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {
            if (lastl == -1)
            {
                for (int item = 0; item < listBox1.Items.Count; item++)
                {
                    list.Add(listBox1.Items[item].ToString());
                }
            }
            if (statment == true)
            {
                statment = false;
                sortbutton.Text = "Убрать сортировку";
                listBox1.Items.Clear();
                foreach (string i in list) {
                    int ing = i.LastIndexOf(i.Last<char>());
                    if (Convert.ToUInt32($"{i[ing - 1].ToString()}{i[ing].ToString()}") >= 60) {
                        listBox1.Items.Add(i);
                    }
                }
            }
            else {
                listBox1.Items.Clear();
                statment = true;
                sortbutton.Text = "Показать передачи длительностю более 1 часа";
                foreach (string i in list) {
                    listBox1.Items.Add(i);
                }
            }
            lastl = list.Count;
        }
    }
}
