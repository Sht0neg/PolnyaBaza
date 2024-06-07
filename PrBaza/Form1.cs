namespace PrBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User user  = new User() { Name = "Марк", Age = 16};



            Binding bind = new Binding("Text", textBox1, "Text");
            bind.Format += (sender, e) => e.Value = $"Content: {e.Value}";
            textBox2.DataBindings.Add(new Binding("Text", textBox1, "Text", false, DataSourceUpdateMode.OnPropertyChanged));
            label1.DataBindings.Add(bind);

            textBox3.DataBindings.Add(new Binding("Text", user, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.DataBindings.Add(new Binding("Text", user, "Age", false, DataSourceUpdateMode.OnPropertyChanged));

            label2.DataBindings.Add(new Binding("Text", user, "Name", false, DataSourceUpdateMode.OnPropertyChanged));

        }

    }
}
