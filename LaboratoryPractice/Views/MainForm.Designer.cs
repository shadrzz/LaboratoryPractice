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
            buttonAddRecord = new Button();
            buttonEditRecord = new Button();
            buttonDeleteRow = new Button();
            data = new DataGridView();
            AddressResource = new DataGridViewTextBoxColumn();
            AccessMode = new DataGridViewComboBoxColumn();
            AccessDate = new DataGridViewTextBoxColumn();
            inputRowNumber = new TextBox();
            labelRowNumber = new Label();
            buttonOpenFileNotepad = new Button();
            buttonOutputData = new Button();
            buttonSelectFile = new Button();
            groupBoxLowLevel = new GroupBox();
            outputLowLevelResult = new TextBox();
            labelOutputLowLevelResult = new Label();
            buttonLowLevelCalculate = new Button();
            inputLowLevelSecond = new ComboBox();
            labelLowLevelSecond = new Label();
            inputLowLevelFirst = new ComboBox();
            labelLowLevelFirst = new Label();
            groupBoxLog = new GroupBox();
            outputLog = new RichTextBox();
            groupBoxAnalyze = new GroupBox();
            buttonAnalyzeCheck = new Button();
            buttonAnalyzeRun = new Button();
            outputAnalyze = new RichTextBox();
            inputAnalyze = new RichTextBox();
            buttonAnalyzeBuild = new Button();
            groupBoxWorkWithFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            groupBoxLowLevel.SuspendLayout();
            groupBoxLog.SuspendLayout();
            groupBoxAnalyze.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWorkWithFile
            // 
            groupBoxWorkWithFile.Controls.Add(buttonAddRecord);
            groupBoxWorkWithFile.Controls.Add(buttonEditRecord);
            groupBoxWorkWithFile.Controls.Add(buttonDeleteRow);
            groupBoxWorkWithFile.Controls.Add(data);
            groupBoxWorkWithFile.Controls.Add(inputRowNumber);
            groupBoxWorkWithFile.Controls.Add(labelRowNumber);
            groupBoxWorkWithFile.Controls.Add(buttonOpenFileNotepad);
            groupBoxWorkWithFile.Controls.Add(buttonOutputData);
            groupBoxWorkWithFile.Controls.Add(buttonSelectFile);
            groupBoxWorkWithFile.Location = new Point(43, 21);
            groupBoxWorkWithFile.Name = "groupBoxWorkWithFile";
            groupBoxWorkWithFile.Padding = new Padding(10);
            groupBoxWorkWithFile.Size = new Size(402, 381);
            groupBoxWorkWithFile.TabIndex = 0;
            groupBoxWorkWithFile.TabStop = false;
            groupBoxWorkWithFile.Text = "Работа с файлом";
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new Point(20, 260);
            buttonAddRecord.Margin = new Padding(3, 10, 3, 0);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(130, 23);
            buttonAddRecord.TabIndex = 8;
            buttonAddRecord.Text = "Добавить запись";
            buttonAddRecord.UseVisualStyleBackColor = true;
            // 
            // buttonEditRecord
            // 
            buttonEditRecord.Location = new Point(252, 326);
            buttonEditRecord.Margin = new Padding(3, 10, 3, 0);
            buttonEditRecord.Name = "buttonEditRecord";
            buttonEditRecord.Size = new Size(130, 23);
            buttonEditRecord.TabIndex = 7;
            buttonEditRecord.Text = "Изменить запись";
            buttonEditRecord.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRow
            // 
            buttonDeleteRow.Location = new Point(252, 293);
            buttonDeleteRow.Margin = new Padding(3, 10, 3, 0);
            buttonDeleteRow.Name = "buttonDeleteRow";
            buttonDeleteRow.Size = new Size(130, 23);
            buttonDeleteRow.TabIndex = 6;
            buttonDeleteRow.Text = "Удалить строку";
            buttonDeleteRow.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { AddressResource, AccessMode, AccessDate });
            data.Location = new Point(20, 79);
            data.Margin = new Padding(3, 10, 3, 3);
            data.Name = "data";
            data.ReadOnly = true;
            data.Size = new Size(362, 150);
            data.TabIndex = 5;
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
            // inputRowNumber
            // 
            inputRowNumber.Location = new Point(252, 260);
            inputRowNumber.Margin = new Padding(0);
            inputRowNumber.Name = "inputRowNumber";
            inputRowNumber.Size = new Size(130, 23);
            inputRowNumber.TabIndex = 4;
            // 
            // labelRowNumber
            // 
            labelRowNumber.AutoSize = true;
            labelRowNumber.Location = new Point(252, 242);
            labelRowNumber.Margin = new Padding(10, 10, 10, 3);
            labelRowNumber.Name = "labelRowNumber";
            labelRowNumber.Size = new Size(130, 15);
            labelRowNumber.TabIndex = 3;
            labelRowNumber.Text = "Введите номер строки";
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
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(20, 26);
            buttonSelectFile.Margin = new Padding(10, 0, 10, 0);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(108, 33);
            buttonSelectFile.TabIndex = 0;
            buttonSelectFile.Text = "Выбрать файл";
            buttonSelectFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxLowLevel
            // 
            groupBoxLowLevel.Controls.Add(outputLowLevelResult);
            groupBoxLowLevel.Controls.Add(labelOutputLowLevelResult);
            groupBoxLowLevel.Controls.Add(buttonLowLevelCalculate);
            groupBoxLowLevel.Controls.Add(inputLowLevelSecond);
            groupBoxLowLevel.Controls.Add(labelLowLevelSecond);
            groupBoxLowLevel.Controls.Add(inputLowLevelFirst);
            groupBoxLowLevel.Controls.Add(labelLowLevelFirst);
            groupBoxLowLevel.Location = new Point(43, 418);
            groupBoxLowLevel.Name = "groupBoxLowLevel";
            groupBoxLowLevel.Padding = new Padding(10, 20, 10, 10);
            groupBoxLowLevel.Size = new Size(402, 197);
            groupBoxLowLevel.TabIndex = 2;
            groupBoxLowLevel.TabStop = false;
            groupBoxLowLevel.Text = "Низкоуровневая функция";
            // 
            // outputLowLevelResult
            // 
            outputLowLevelResult.Location = new Point(176, 142);
            outputLowLevelResult.Margin = new Padding(0, 10, 0, 0);
            outputLowLevelResult.Name = "outputLowLevelResult";
            outputLowLevelResult.Size = new Size(130, 23);
            outputLowLevelResult.TabIndex = 9;
            // 
            // labelOutputLowLevelResult
            // 
            labelOutputLowLevelResult.AutoSize = true;
            labelOutputLowLevelResult.Location = new Point(87, 145);
            labelOutputLowLevelResult.Margin = new Padding(0, 10, 0, 0);
            labelOutputLowLevelResult.Name = "labelOutputLowLevelResult";
            labelOutputLowLevelResult.Size = new Size(63, 15);
            labelOutputLowLevelResult.TabIndex = 6;
            labelOutputLowLevelResult.Text = "Результат:";
            // 
            // buttonLowLevelCalculate
            // 
            buttonLowLevelCalculate.Location = new Point(138, 105);
            buttonLowLevelCalculate.Margin = new Padding(0, 10, 0, 0);
            buttonLowLevelCalculate.Name = "buttonLowLevelCalculate";
            buttonLowLevelCalculate.Size = new Size(108, 27);
            buttonLowLevelCalculate.TabIndex = 5;
            buttonLowLevelCalculate.Text = "Рассчитать";
            buttonLowLevelCalculate.UseVisualStyleBackColor = true;
            buttonLowLevelCalculate.Click += lowLevelCalculate_Click;
            // 
            // inputLowLevelSecond
            // 
            inputLowLevelSecond.FormattingEnabled = true;
            inputLowLevelSecond.Location = new Point(176, 69);
            inputLowLevelSecond.Margin = new Padding(3, 10, 3, 3);
            inputLowLevelSecond.Name = "inputLowLevelSecond";
            inputLowLevelSecond.Size = new Size(206, 23);
            inputLowLevelSecond.TabIndex = 3;
            // 
            // labelLowLevelSecond
            // 
            labelLowLevelSecond.AutoSize = true;
            labelLowLevelSecond.Location = new Point(13, 72);
            labelLowLevelSecond.Name = "labelLowLevelSecond";
            labelLowLevelSecond.Size = new Size(156, 15);
            labelLowLevelSecond.TabIndex = 2;
            labelLowLevelSecond.Text = "Выберите второе значение";
            // 
            // inputLowLevelFirst
            // 
            inputLowLevelFirst.FormattingEnabled = true;
            inputLowLevelFirst.Location = new Point(176, 33);
            inputLowLevelFirst.Name = "inputLowLevelFirst";
            inputLowLevelFirst.Size = new Size(206, 23);
            inputLowLevelFirst.TabIndex = 1;
            // 
            // labelLowLevelFirst
            // 
            labelLowLevelFirst.AutoSize = true;
            labelLowLevelFirst.Location = new Point(13, 36);
            labelLowLevelFirst.Name = "labelLowLevelFirst";
            labelLowLevelFirst.Size = new Size(157, 15);
            labelLowLevelFirst.TabIndex = 0;
            labelLowLevelFirst.Text = "Выберите первое значение";
            // 
            // groupBoxLog
            // 
            groupBoxLog.Controls.Add(outputLog);
            groupBoxLog.Location = new Point(479, 418);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Padding = new Padding(10);
            groupBoxLog.Size = new Size(402, 197);
            groupBoxLog.TabIndex = 3;
            groupBoxLog.TabStop = false;
            groupBoxLog.Text = "Логирование";
            // 
            // outputLog
            // 
            outputLog.Location = new Point(10, 26);
            outputLog.Margin = new Padding(0);
            outputLog.Name = "outputLog";
            outputLog.ReadOnly = true;
            outputLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            outputLog.Size = new Size(382, 161);
            outputLog.TabIndex = 5;
            outputLog.Text = "";
            // 
            // groupBoxAnalyze
            // 
            groupBoxAnalyze.Controls.Add(buttonAnalyzeCheck);
            groupBoxAnalyze.Controls.Add(buttonAnalyzeRun);
            groupBoxAnalyze.Controls.Add(outputAnalyze);
            groupBoxAnalyze.Controls.Add(inputAnalyze);
            groupBoxAnalyze.Controls.Add(buttonAnalyzeBuild);
            groupBoxAnalyze.Location = new Point(479, 21);
            groupBoxAnalyze.Name = "groupBoxAnalyze";
            groupBoxAnalyze.Padding = new Padding(10);
            groupBoxAnalyze.Size = new Size(402, 381);
            groupBoxAnalyze.TabIndex = 9;
            groupBoxAnalyze.TabStop = false;
            groupBoxAnalyze.Text = "Анализатор";
            // 
            // buttonAnalyzeCheck
            // 
            buttonAnalyzeCheck.Location = new Point(13, 242);
            buttonAnalyzeCheck.Margin = new Padding(10, 0, 10, 0);
            buttonAnalyzeCheck.Name = "buttonAnalyzeCheck";
            buttonAnalyzeCheck.Size = new Size(195, 50);
            buttonAnalyzeCheck.TabIndex = 4;
            buttonAnalyzeCheck.Text = "Проверить выполнится ли цикл хотя бы раз";
            buttonAnalyzeCheck.UseVisualStyleBackColor = true;
            buttonAnalyzeCheck.Click += buttonAnalyzeCheck_Click;
            // 
            // buttonAnalyzeRun
            // 
            buttonAnalyzeRun.Location = new Point(255, 192);
            buttonAnalyzeRun.Margin = new Padding(10, 0, 10, 0);
            buttonAnalyzeRun.Name = "buttonAnalyzeRun";
            buttonAnalyzeRun.Size = new Size(108, 33);
            buttonAnalyzeRun.TabIndex = 3;
            buttonAnalyzeRun.Text = "Run";
            buttonAnalyzeRun.UseVisualStyleBackColor = true;
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
            inputAnalyze.Size = new Size(195, 199);
            inputAnalyze.TabIndex = 1;
            inputAnalyze.Text = "";
            // 
            // buttonAnalyzeBuild
            // 
            buttonAnalyzeBuild.Location = new Point(255, 26);
            buttonAnalyzeBuild.Margin = new Padding(10, 0, 10, 0);
            buttonAnalyzeBuild.Name = "buttonAnalyzeBuild";
            buttonAnalyzeBuild.Size = new Size(108, 33);
            buttonAnalyzeBuild.TabIndex = 0;
            buttonAnalyzeBuild.Text = "Build";
            buttonAnalyzeBuild.UseVisualStyleBackColor = true;
            buttonAnalyzeBuild.Click += analyzeBuild_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 638);
            Controls.Add(groupBoxAnalyze);
            Controls.Add(groupBoxLog);
            Controls.Add(groupBoxLowLevel);
            Controls.Add(groupBoxWorkWithFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = " ";
            groupBoxWorkWithFile.ResumeLayout(false);
            groupBoxWorkWithFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            groupBoxLowLevel.ResumeLayout(false);
            groupBoxLowLevel.PerformLayout();
            groupBoxLog.ResumeLayout(false);
            groupBoxAnalyze.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWorkWithFile;
        private GroupBox groupBoxLowLevel;
        private GroupBox groupBoxLog;
        private Button buttonOpenFileNotepad;
        private Button buttonOutputData;
        private Button buttonSelectFile;
        private TextBox inputRowNumber;
        private Label labelRowNumber;
        private DataGridView data;
        private Button buttonDeleteRow;
        private DataGridViewTextBoxColumn AddressResource;
        private DataGridViewComboBoxColumn AccessMode;
        private DataGridViewTextBoxColumn AccessDate;
        private Button buttonAddRecord;
        private Button buttonEditRecord;
        private GroupBox groupBoxAnalyze;
        private RichTextBox inputAnalyze;
        private Button buttonAnalyzeBuild;
        private Button buttonAnalyzeCheck;
        private Button buttonAnalyzeRun;
        private RichTextBox outputAnalyze;
        private Label labelLowLevelFirst;
        private Label labelOutputLowLevelResult;
        private Button buttonLowLevelCalculate;
        private ComboBox inputLowLevelSecond;
        private Label labelLowLevelSecond;
        private ComboBox inputLowLevelFirst;
        private TextBox outputLowLevelResult;
        private RichTextBox outputLog;
    }
}
