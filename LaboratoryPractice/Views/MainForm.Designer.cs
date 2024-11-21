namespace LaboratoryPractice
{
    partial class MainForm
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            AddressResource = new DataGridViewTextBoxColumn();
            AccessMode = new DataGridViewComboBoxColumn();
            AccessDate = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button9 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            richTextBox3 = new RichTextBox();
            groupBox5 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            button12 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(43, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(402, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Работа с файлом";
            // 
            // button6
            // 
            button6.Location = new Point(20, 260);
            button6.Margin = new Padding(3, 10, 3, 0);
            button6.Name = "button6";
            button6.Size = new Size(130, 23);
            button6.TabIndex = 8;
            button6.Text = "Добавить запись";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(252, 326);
            button5.Margin = new Padding(3, 10, 3, 0);
            button5.Name = "button5";
            button5.Size = new Size(130, 23);
            button5.TabIndex = 7;
            button5.Text = "Изменить запись";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(252, 293);
            button4.Margin = new Padding(3, 10, 3, 0);
            button4.Name = "button4";
            button4.Size = new Size(130, 23);
            button4.TabIndex = 6;
            button4.Text = "Удалить строку";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AddressResource, AccessMode, AccessDate });
            dataGridView1.Location = new Point(20, 79);
            dataGridView1.Margin = new Padding(3, 10, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 5;
            // 
            // AddressResource
            // 
            AddressResource.HeaderText = "Адрес ресурса";
            AddressResource.Name = "AddressResource";
            AddressResource.ReadOnly = true;
            // 
            // AccessMode
            // 
            AccessMode.HeaderText = "Режим доступа";
            AccessMode.Items.AddRange(new object[] { "Свободный", "Закрытый" });
            AccessMode.Name = "AccessMode";
            AccessMode.ReadOnly = true;
            AccessMode.Resizable = DataGridViewTriState.True;
            AccessMode.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AccessDate
            // 
            AccessDate.HeaderText = "Дата доступа";
            AccessDate.Name = "AccessDate";
            AccessDate.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 260);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 242);
            label1.Margin = new Padding(10, 10, 10, 3);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите номер строки";
            // 
            // button3
            // 
            button3.Location = new Point(276, 26);
            button3.Margin = new Padding(10, 0, 10, 0);
            button3.Name = "button3";
            button3.Size = new Size(106, 43);
            button3.TabIndex = 2;
            button3.Text = "Открыть файл в блокноте";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(148, 26);
            button2.Margin = new Padding(10, 0, 10, 0);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 1;
            button2.Text = "Вывести данные";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(20, 26);
            button1.Margin = new Padding(10, 0, 10, 0);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 0;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(43, 418);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 20, 10, 10);
            groupBox3.Size = new Size(402, 197);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Низкоуровневая функция";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 142);
            textBox2.Margin = new Padding(0, 10, 0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 145);
            label4.Margin = new Padding(0, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Результат:";
            // 
            // button9
            // 
            button9.Location = new Point(138, 105);
            button9.Margin = new Padding(0, 10, 0, 0);
            button9.Name = "button9";
            button9.Size = new Size(108, 27);
            button9.TabIndex = 5;
            button9.Text = "Рассчитать";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(176, 69);
            comboBox2.Margin = new Padding(3, 10, 3, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 23);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 72);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 2;
            label3.Text = "Выберите второе значение";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 36);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 0;
            label2.Text = "Выберите первое значение";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox3);
            groupBox4.Location = new Point(479, 418);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10);
            groupBox4.Size = new Size(402, 197);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Логирование";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(10, 26);
            richTextBox3.Margin = new Padding(0);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox3.Size = new Size(382, 161);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(richTextBox2);
            groupBox5.Controls.Add(richTextBox1);
            groupBox5.Controls.Add(button12);
            groupBox5.Location = new Point(479, 21);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10);
            groupBox5.Size = new Size(402, 381);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Анализатор";
            // 
            // button8
            // 
            button8.Location = new Point(13, 242);
            button8.Margin = new Padding(10, 0, 10, 0);
            button8.Name = "button8";
            button8.Size = new Size(195, 50);
            button8.TabIndex = 4;
            button8.Text = "Проверить выполнится ли цикл хотя бы раз";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(255, 192);
            button7.Margin = new Padding(10, 0, 10, 0);
            button7.Name = "button7";
            button7.Size = new Size(108, 33);
            button7.TabIndex = 3;
            button7.Text = "Run";
            button7.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(233, 69);
            richTextBox2.Margin = new Padding(3, 10, 3, 10);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox2.Size = new Size(156, 113);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 199);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button12
            // 
            button12.Location = new Point(255, 26);
            button12.Margin = new Padding(10, 0, 10, 0);
            button12.Name = "button12";
            button12.Size = new Size(108, 33);
            button12.TabIndex = 0;
            button12.Text = "Build";
            button12.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 638);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button4;
        private DataGridViewTextBoxColumn AddressResource;
        private DataGridViewComboBoxColumn AccessMode;
        private DataGridViewTextBoxColumn AccessDate;
        private Button button6;
        private Button button5;
        private GroupBox groupBox5;
        private RichTextBox richTextBox1;
        private Button button12;
        private Button button8;
        private Button button7;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label4;
        private Button button9;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox3;
    }
}
