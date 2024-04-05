namespace TestBaza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            delbutton = new Button();
            addbutton = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            sortbutton = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delbutton);
            groupBox1.Controls.Add(addbutton);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(24, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // delbutton
            // 
            delbutton.Location = new Point(91, 232);
            delbutton.Name = "delbutton";
            delbutton.Size = new Size(133, 55);
            delbutton.TabIndex = 5;
            delbutton.Text = "Очистить";
            delbutton.UseVisualStyleBackColor = true;
            delbutton.Click += delbutton_Click;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(92, 156);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(132, 56);
            addbutton.TabIndex = 4;
            addbutton.Text = "Добавить передачу";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10F);
            numericUpDown1.Location = new Point(173, 95);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 99);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 2;
            label2.Text = "Продолжительность";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(92, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 36);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(337, 28);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 1;
            label3.Text = "Список телепередач";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(337, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(433, 274);
            listBox1.TabIndex = 2;
            // 
            // sortbutton
            // 
            sortbutton.Location = new Point(361, 365);
            sortbutton.Name = "sortbutton";
            sortbutton.Size = new Size(165, 53);
            sortbutton.TabIndex = 3;
            sortbutton.Text = "Показать передачи длительностю более 1 часа";
            sortbutton.UseVisualStyleBackColor = true;
            sortbutton.Click += sortbutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(584, 368);
            button1.Name = "button1";
            button1.Size = new Size(159, 50);
            button1.TabIndex = 4;
            button1.Text = "Выгрузить в файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(sortbutton);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button delbutton;
        private Button addbutton;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private ListBox listBox1;
        private Button sortbutton;
        private Button button1;
    }
}
