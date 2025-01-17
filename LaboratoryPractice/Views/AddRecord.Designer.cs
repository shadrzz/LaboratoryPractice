namespace LaboratoryPractice.Views
{
    partial class AddRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            buttonAddRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Адрес ресурса";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 101);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Режим доступа";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 149);
            textBox3.Margin = new Padding(0, 25, 0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 149);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата доступа";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Свободный", "Закрытый" });
            comboBox1.Location = new Point(200, 101);
            comboBox1.Margin = new Padding(0, 25, 0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 6;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new Point(126, 211);
            buttonAddRecord.Margin = new Padding(0);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(108, 33);
            buttonAddRecord.TabIndex = 7;
            buttonAddRecord.Text = "Добавить";
            buttonAddRecord.UseVisualStyleBackColor = true;
            // 
            // AddRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 269);
            Controls.Add(buttonAddRecord);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddRecord";
            Padding = new Padding(50, 50, 50, 25);
            Text = "Добавить запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private ComboBox comboBox1;
        private Button buttonAddRecord;
    }
}