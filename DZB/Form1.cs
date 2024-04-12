namespace DZB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatForm creatForm = new CreatForm(this);
            creatForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            ChangeForm changeForm = new ChangeForm(this, listBox1.SelectedItem.ToString());
            changeForm.ShowDialog();
        }

        public void addStudent(string student)
        {
            listBox1.Items.Add(student);
        }

        public void updateAtudent(string student) {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Add(student);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            DialogResult result = MessageBox.Show("Вы уверены?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
