namespace DZ_Kakoeto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_blue = new System.Windows.Forms.Button();
            this.button_black = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.label_city = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите город: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(203, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button_blue
            // 
            this.button_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_blue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_blue.Location = new System.Drawing.Point(52, 162);
            this.button_blue.Name = "button_blue";
            this.button_blue.Size = new System.Drawing.Size(93, 37);
            this.button_blue.TabIndex = 2;
            this.button_blue.Text = "Синий";
            this.button_blue.UseVisualStyleBackColor = true;
            this.button_blue.Click += new System.EventHandler(this.button_click);
            // 
            // button_black
            // 
            this.button_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_black.Location = new System.Drawing.Point(191, 162);
            this.button_black.Name = "button_black";
            this.button_black.Size = new System.Drawing.Size(94, 37);
            this.button_black.TabIndex = 3;
            this.button_black.Text = "Чёрный";
            this.button_black.UseVisualStyleBackColor = true;
            this.button_black.Click += new System.EventHandler(this.button_click);
            // 
            // button_red
            // 
            this.button_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_red.ForeColor = System.Drawing.Color.Red;
            this.button_red.Location = new System.Drawing.Point(335, 162);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(100, 37);
            this.button_red.TabIndex = 4;
            this.button_red.Text = "Красный";
            this.button_red.UseVisualStyleBackColor = true;
            this.button_red.Click += new System.EventHandler(this.button_click);
            // 
            // button_green
            // 
            this.button_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_green.ForeColor = System.Drawing.Color.Green;
            this.button_green.Location = new System.Drawing.Point(482, 162);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(102, 37);
            this.button_green.TabIndex = 5;
            this.button_green.Text = "Зелёный";
            this.button_green.UseVisualStyleBackColor = true;
            this.button_green.Click += new System.EventHandler(this.button_click);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_city.Location = new System.Drawing.Point(269, 250);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(70, 26);
            this.label_city.TabIndex = 6;
            this.label_city.Text = "label2";
            this.label_city.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.button_green);
            this.Controls.Add(this.button_red);
            this.Controls.Add(this.button_black);
            this.Controls.Add(this.button_blue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_blue;
        private System.Windows.Forms.Button button_black;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Label label_city;
    }
}

