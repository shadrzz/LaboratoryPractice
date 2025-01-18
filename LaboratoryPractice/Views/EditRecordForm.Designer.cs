namespace LaboratoryPractice.Views
{
    partial class EditRecordForm
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
            address = new TextBox();
            label2 = new Label();
            accessDate = new TextBox();
            label3 = new Label();
            accessMode = new ComboBox();
            buttonEditRecord = new Button();
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
            // address
            // 
            address.Location = new Point(200, 50);
            address.Name = "address";
            address.Size = new Size(124, 23);
            address.TabIndex = 1;
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
            // accessDate
            // 
            accessDate.Location = new Point(200, 149);
            accessDate.Margin = new Padding(0, 25, 0, 0);
            accessDate.Name = "accessDate";
            accessDate.Size = new Size(124, 23);
            accessDate.TabIndex = 5;
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
            // accessMode
            // 
            accessMode.DropDownStyle = ComboBoxStyle.DropDownList;
            accessMode.FormattingEnabled = true;
            accessMode.Items.AddRange(new object[] { "Свободный", "Закрытый" });
            accessMode.Location = new Point(200, 101);
            accessMode.Margin = new Padding(0, 25, 0, 0);
            accessMode.Name = "accessMode";
            accessMode.Size = new Size(124, 23);
            accessMode.TabIndex = 6;
            // 
            // buttonEditRecord
            // 
            buttonEditRecord.Location = new Point(126, 211);
            buttonEditRecord.Margin = new Padding(0);
            buttonEditRecord.Name = "buttonEditRecord";
            buttonEditRecord.Size = new Size(108, 33);
            buttonEditRecord.TabIndex = 7;
            buttonEditRecord.Text = "Изменить";
            buttonEditRecord.UseVisualStyleBackColor = true;
            buttonEditRecord.Click += buttonEditRecord_Click;
            // 
            // EditRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 269);
            Controls.Add(buttonEditRecord);
            Controls.Add(accessMode);
            Controls.Add(accessDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(address);
            Controls.Add(label1);
            Name = "EditRecordForm";
            Padding = new Padding(50, 50, 50, 25);
            Text = "Изменить запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox address;
        private Label label2;
        private TextBox accessDate;
        private Label label3;
        private ComboBox accessMode;
        private Button buttonEditRecord;
    }
}