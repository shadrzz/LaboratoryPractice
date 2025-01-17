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
            groupBoxWorkWithFile = new GroupBox();
            data = new DataGridView();
            address = new DataGridViewTextBoxColumn();
            accessMode = new DataGridViewTextBoxColumn();
            accessDate = new DataGridViewTextBoxColumn();
            buttonDeleteRecord = new Button();
            buttonEditRecord = new Button();
            buttonAddRecord = new Button();
            buttonOpenFileNotepad = new Button();
            buttonOutputData = new Button();
            buttonSelectFile = new Button();
            groupBoxLowLevel = new GroupBox();
            labelOutputLowLevelResult = new Label();
            outputLowLevelResult = new TextBox();
            buttonLowLevelCalculate = new Button();
            inputLowLevelSecond = new ComboBox();
            labelLowLevelSecond = new Label();
            inputLowLevelFirst = new ComboBox();
            labelLowLevelFirst = new Label();
            groupBoxAnalyze = new GroupBox();
            buttonAnalyzeCheck = new Button();
            outputAnalyze = new RichTextBox();
            inputAnalyze = new RichTextBox();
            buttonAnalyzeBuild = new Button();
            groupBoxWorkWithFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            groupBoxLowLevel.SuspendLayout();
            groupBoxAnalyze.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWorkWithFile
            // 
            groupBoxWorkWithFile.Controls.Add(data);
            groupBoxWorkWithFile.Controls.Add(buttonDeleteRecord);
            groupBoxWorkWithFile.Controls.Add(buttonEditRecord);
            groupBoxWorkWithFile.Controls.Add(buttonAddRecord);
            groupBoxWorkWithFile.Controls.Add(buttonOpenFileNotepad);
            groupBoxWorkWithFile.Controls.Add(buttonOutputData);
            groupBoxWorkWithFile.Controls.Add(buttonSelectFile);
            groupBoxWorkWithFile.Location = new Point(43, 21);
            groupBoxWorkWithFile.Name = "groupBoxWorkWithFile";
            groupBoxWorkWithFile.Padding = new Padding(10);
            groupBoxWorkWithFile.Size = new Size(402, 387);
            groupBoxWorkWithFile.TabIndex = 0;
            groupBoxWorkWithFile.TabStop = false;
            groupBoxWorkWithFile.Text = "Работа с файлом";
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { address, accessMode, accessDate });
            data.Location = new Point(20, 85);
            data.Name = "data";
            data.ReadOnly = true;
            data.Size = new Size(361, 187);
            data.TabIndex = 11;
            // 
            // address
            // 
            address.HeaderText = "Адрес ресурса в сети Интернет";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // accessMode
            // 
            accessMode.HeaderText = "Режим доступа";
            accessMode.Name = "accessMode";
            accessMode.ReadOnly = true;
            // 
            // accessDate
            // 
            accessDate.HeaderText = "Дата доступа";
            accessDate.Name = "accessDate";
            accessDate.ReadOnly = true;
            // 
            // buttonDeleteRecord
            // 
            buttonDeleteRecord.Location = new Point(19, 325);
            buttonDeleteRecord.Margin = new Padding(3, 10, 3, 0);
            buttonDeleteRecord.Name = "buttonDeleteRecord";
            buttonDeleteRecord.Size = new Size(362, 30);
            buttonDeleteRecord.TabIndex = 10;
            buttonDeleteRecord.Text = "Удалить запись из БД";
            buttonDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // buttonEditRecord
            // 
            buttonEditRecord.Location = new Point(212, 285);
            buttonEditRecord.Margin = new Padding(3, 10, 3, 0);
            buttonEditRecord.Name = "buttonEditRecord";
            buttonEditRecord.Size = new Size(170, 30);
            buttonEditRecord.TabIndex = 9;
            buttonEditRecord.Text = "Изменить запись из БД";
            buttonEditRecord.UseVisualStyleBackColor = true;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new Point(19, 285);
            buttonAddRecord.Margin = new Padding(3, 10, 3, 0);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(170, 30);
            buttonAddRecord.TabIndex = 8;
            buttonAddRecord.Text = "Добавить запись в БД";
            buttonAddRecord.UseVisualStyleBackColor = true;
            buttonAddRecord.Click += buttonAddRecord_Click;
            // 
            // buttonOpenFileNotepad
            // 
            buttonOpenFileNotepad.Location = new Point(276, 26);
            buttonOpenFileNotepad.Margin = new Padding(10, 0, 10, 0);
            buttonOpenFileNotepad.Name = "buttonOpenFileNotepad";
            buttonOpenFileNotepad.Size = new Size(106, 43);
            buttonOpenFileNotepad.TabIndex = 2;
            buttonOpenFileNotepad.Text = "Открыть файл в блокноте";
            buttonOpenFileNotepad.UseVisualStyleBackColor = true;
            buttonOpenFileNotepad.Click += buttonOpenFileNotepad_Click;
            // 
            // buttonOutputData
            // 
            buttonOutputData.Location = new Point(148, 26);
            buttonOutputData.Margin = new Padding(10, 0, 10, 0);
            buttonOutputData.Name = "buttonOutputData";
            buttonOutputData.Size = new Size(108, 33);
            buttonOutputData.TabIndex = 1;
            buttonOutputData.Text = "Вывести данные";
            buttonOutputData.UseVisualStyleBackColor = true;
            buttonOutputData.Click += buttonOutputData_Click;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(20, 26);
            buttonSelectFile.Margin = new Padding(10, 0, 10, 0);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(108, 33);
            buttonSelectFile.TabIndex = 0;
            buttonSelectFile.Text = "Выбрать CSV";
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // groupBoxLowLevel
            // 
            groupBoxLowLevel.Controls.Add(labelOutputLowLevelResult);
            groupBoxLowLevel.Controls.Add(outputLowLevelResult);
            groupBoxLowLevel.Controls.Add(buttonLowLevelCalculate);
            groupBoxLowLevel.Controls.Add(inputLowLevelSecond);
            groupBoxLowLevel.Controls.Add(labelLowLevelSecond);
            groupBoxLowLevel.Controls.Add(inputLowLevelFirst);
            groupBoxLowLevel.Controls.Add(labelLowLevelFirst);
            groupBoxLowLevel.Location = new Point(255, 431);
            groupBoxLowLevel.Margin = new Padding(3, 20, 3, 3);
            groupBoxLowLevel.Name = "groupBoxLowLevel";
            groupBoxLowLevel.Padding = new Padding(10, 20, 10, 10);
            groupBoxLowLevel.Size = new Size(402, 197);
            groupBoxLowLevel.TabIndex = 2;
            groupBoxLowLevel.TabStop = false;
            groupBoxLowLevel.Text = "Низкоуровневая функция (деление)";
            // 
            // labelOutputLowLevelResult
            // 
            labelOutputLowLevelResult.AutoSize = true;
            labelOutputLowLevelResult.Location = new Point(182, 113);
            labelOutputLowLevelResult.Margin = new Padding(0);
            labelOutputLowLevelResult.Name = "labelOutputLowLevelResult";
            labelOutputLowLevelResult.Size = new Size(63, 15);
            labelOutputLowLevelResult.TabIndex = 9;
            labelOutputLowLevelResult.Text = "Результат:";
            // 
            // outputLowLevelResult
            // 
            outputLowLevelResult.Location = new Point(184, 130);
            outputLowLevelResult.Margin = new Padding(0, 10, 0, 0);
            outputLowLevelResult.Name = "outputLowLevelResult";
            outputLowLevelResult.Size = new Size(199, 23);
            outputLowLevelResult.TabIndex = 9;
            // 
            // buttonLowLevelCalculate
            // 
            buttonLowLevelCalculate.Location = new Point(21, 116);
            buttonLowLevelCalculate.Margin = new Padding(0, 10, 0, 0);
            buttonLowLevelCalculate.Name = "buttonLowLevelCalculate";
            buttonLowLevelCalculate.Size = new Size(115, 48);
            buttonLowLevelCalculate.TabIndex = 5;
            buttonLowLevelCalculate.Text = "Рассчитать";
            buttonLowLevelCalculate.UseVisualStyleBackColor = true;
            buttonLowLevelCalculate.Click += buttonLowLevelCalculate_Click;
            // 
            // inputLowLevelSecond
            // 
            inputLowLevelSecond.FormattingEnabled = true;
            inputLowLevelSecond.Location = new Point(183, 69);
            inputLowLevelSecond.Margin = new Padding(3, 10, 3, 3);
            inputLowLevelSecond.Name = "inputLowLevelSecond";
            inputLowLevelSecond.Size = new Size(200, 23);
            inputLowLevelSecond.TabIndex = 3;
            // 
            // labelLowLevelSecond
            // 
            labelLowLevelSecond.AutoSize = true;
            labelLowLevelSecond.Location = new Point(21, 72);
            labelLowLevelSecond.Name = "labelLowLevelSecond";
            labelLowLevelSecond.Size = new Size(156, 15);
            labelLowLevelSecond.TabIndex = 2;
            labelLowLevelSecond.Text = "Выберите второе значение";
            // 
            // inputLowLevelFirst
            // 
            inputLowLevelFirst.FormattingEnabled = true;
            inputLowLevelFirst.Location = new Point(183, 33);
            inputLowLevelFirst.Name = "inputLowLevelFirst";
            inputLowLevelFirst.Size = new Size(199, 23);
            inputLowLevelFirst.TabIndex = 1;
            // 
            // labelLowLevelFirst
            // 
            labelLowLevelFirst.AutoSize = true;
            labelLowLevelFirst.Location = new Point(20, 36);
            labelLowLevelFirst.Name = "labelLowLevelFirst";
            labelLowLevelFirst.Size = new Size(157, 15);
            labelLowLevelFirst.TabIndex = 0;
            labelLowLevelFirst.Text = "Выберите первое значение";
            // 
            // groupBoxAnalyze
            // 
            groupBoxAnalyze.Controls.Add(buttonAnalyzeCheck);
            groupBoxAnalyze.Controls.Add(outputAnalyze);
            groupBoxAnalyze.Controls.Add(inputAnalyze);
            groupBoxAnalyze.Controls.Add(buttonAnalyzeBuild);
            groupBoxAnalyze.Location = new Point(479, 21);
            groupBoxAnalyze.Name = "groupBoxAnalyze";
            groupBoxAnalyze.Padding = new Padding(10);
            groupBoxAnalyze.Size = new Size(402, 387);
            groupBoxAnalyze.TabIndex = 9;
            groupBoxAnalyze.TabStop = false;
            groupBoxAnalyze.Text = "Анализатор";
            // 
            // buttonAnalyzeCheck
            // 
            buttonAnalyzeCheck.Location = new Point(13, 265);
            buttonAnalyzeCheck.Margin = new Padding(10, 0, 10, 0);
            buttonAnalyzeCheck.Name = "buttonAnalyzeCheck";
            buttonAnalyzeCheck.Size = new Size(195, 50);
            buttonAnalyzeCheck.TabIndex = 4;
            buttonAnalyzeCheck.Text = "Проверить выполнится ли цикл хотя бы раз";
            buttonAnalyzeCheck.UseVisualStyleBackColor = true;
            buttonAnalyzeCheck.Click += buttonAnalyzeCheck_Click;
            // 
            // outputAnalyze
            // 
            outputAnalyze.Location = new Point(233, 69);
            outputAnalyze.Margin = new Padding(3, 10, 3, 10);
            outputAnalyze.Name = "outputAnalyze";
            outputAnalyze.ReadOnly = true;
            outputAnalyze.ScrollBars = RichTextBoxScrollBars.Vertical;
            outputAnalyze.Size = new Size(156, 113);
            outputAnalyze.TabIndex = 2;
            outputAnalyze.Text = "";
            // 
            // inputAnalyze
            // 
            inputAnalyze.Location = new Point(13, 26);
            inputAnalyze.Name = "inputAnalyze";
            inputAnalyze.Size = new Size(195, 216);
            inputAnalyze.TabIndex = 1;
            inputAnalyze.Text = "";
            inputAnalyze.TextChanged += inputAnalyze_TextChanged;
            // 
            // buttonAnalyzeBuild
            // 
            buttonAnalyzeBuild.Location = new Point(255, 26);
            buttonAnalyzeBuild.Margin = new Padding(10, 0, 10, 0);
            buttonAnalyzeBuild.Name = "buttonAnalyzeBuild";
            buttonAnalyzeBuild.Size = new Size(108, 33);
            buttonAnalyzeBuild.TabIndex = 0;
            buttonAnalyzeBuild.Text = "Сборка";
            buttonAnalyzeBuild.UseVisualStyleBackColor = true;
            buttonAnalyzeBuild.Click += buttonAnalyzeBuild_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 660);
            Controls.Add(groupBoxAnalyze);
            Controls.Add(groupBoxLowLevel);
            Controls.Add(groupBoxWorkWithFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = " ";
            groupBoxWorkWithFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            groupBoxLowLevel.ResumeLayout(false);
            groupBoxLowLevel.PerformLayout();
            groupBoxAnalyze.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWorkWithFile;
        private GroupBox groupBoxLowLevel;
        private Button buttonOpenFileNotepad;
        private Button buttonOutputData;
        private Button buttonSelectFile;
        private Button buttonAddRecord;
        private GroupBox groupBoxAnalyze;
        private RichTextBox inputAnalyze;
        private Button buttonAnalyzeBuild;
        private Button buttonAnalyzeCheck;
        private Button buttonAnalyzeRun;
        private RichTextBox outputAnalyze;
        private Label labelLowLevelFirst;
        private Button buttonLowLevelCalculate;
        private ComboBox inputLowLevelSecond;
        private Label labelLowLevelSecond;
        private ComboBox inputLowLevelFirst;
        private TextBox outputLowLevelResult;
        private Label labelOutputLowLevelResult;
        private Button buttonDeleteRecord;
        private Button buttonEditRecord;
        private DataGridView data;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn accessMode;
        private DataGridViewTextBoxColumn accessDate;
    }
}
