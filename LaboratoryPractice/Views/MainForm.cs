using LaboratoryPractice.Controllers;
using LaboratoryPractice.Models;
using LaboratoryPractice.Views;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        private bool isAnalysisSuccessful = false;
        public string selectedFilePath = string.Empty;
        public List<InfoModel> files = new List<InfoModel>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLowLevelCalculate_Click(object sender, EventArgs e)
        {
            /// Получение данных из текстовых полей
            string inputFirst = inputLowLevelFirst.Text;
            string inputSecond = inputLowLevelSecond.Text;

            // Вызов метода контроллера для вычисления
            var (isValid, result, errorMessage) = LowLevelCalculatorController.Calculate(inputFirst, inputSecond);

            if (!isValid)
            {
                // Отображение сообщения об ошибке
                MessageBox.Show(
                    errorMessage,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Отображение результата
            outputLowLevelResult.Text = result;

            AddMessageToLog($"Вызвана низкоуровневая функция.");
        }

        private void buttonAnalyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;

            // Вызов метода контроллера для анализа кода
            var (isSuccessful, outputMessage) = CodeAnalysisController.AnalyzeCode(userCode);

            outputAnalyze.Text = outputMessage;
            isAnalysisSuccessful = isSuccessful;

            AddMessageToLog($"Выполнена сборка анализатора.");
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            if (!isAnalysisSuccessful)
            {
                // Если анализ не был выполнен или есть ошибки
                MessageBox.Show(
                    "Пожалуйста, сначала выполните успешную сборку, нажав на кнопку 'Сборка'.",
                    "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            string userCode = inputAnalyze.Text;

            // Вызов метода контроллера для проверки цикла while
            var (isValid, message) = WhileLoopController.CheckWhileLoop(userCode);

            if (isValid)
            {
                MessageBox.Show(
                    message,
                    "Результат проверки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                AddMessageToLog($"Выполнена проверка на условие анализатора.");

                return;
            }
            else
            {
                MessageBox.Show(
                    message,
                    "Ошибка проверки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void inputAnalyze_TextChanged(object sender, EventArgs e)
        {
            outputAnalyze.Clear();
            isAnalysisSuccessful = false; // Сбрасываем флаг при изменении текста
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form addRecordForm = new AddRecordForm(this);
            addRecordForm.Show();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lineNumberText = textBoxLineNumber.Text;

            if (string.IsNullOrWhiteSpace(lineNumberText))
            {
                MessageBox.Show("Введите номер строки для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lineNumberText, out int lineNumber))
            {
                MessageBox.Show("Номер строки должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lineNumber < 1 || lineNumber > files.Count)
            {
                MessageBox.Show($"Номер строки должен быть в диапазоне от 1 до {files.Count}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form editRecordForm = new EditRecordForm(this, lineNumber);
            editRecordForm.Show();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    data.Rows.Clear();

                    selectedFilePath = openFileDialog.FileName;

                    var result = FileController.ProcessCsvFile(selectedFilePath);

                    if (!result.IsSuccess)
                    {
                        MessageBox.Show(result.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedFilePath = string.Empty;
                        return;
                    }

                    files = result.Files;

                    MessageBox.Show($"Файл \"{Path.GetFileName(selectedFilePath)}\" выбран.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddMessageToLog($"Файл \"{Path.GetFileName(selectedFilePath)}\" выбран.");
                }
            }
        }

        private void buttonOpenFileNotepad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start("notepad.exe", selectedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddMessageToLog($"Файл \"{Path.GetFileName(selectedFilePath)}\" открыт в блокноте.");
        }

        public void OutputData()
        {
            data.Rows.Clear();

            foreach (var file in files)
            {
                data.Rows.Add(file.Address, file.AccessMode, file.AccessDate);
            }

            AddMessageToLog($"Файл \"{Path.GetFileName(selectedFilePath)}\" выведен на экран.");
        }

        private void buttonOutputData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OutputData();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lineNumberText = textBoxLineNumber.Text;

            if (string.IsNullOrWhiteSpace(lineNumberText))
            {
                MessageBox.Show("Введите номер строки для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lineNumberText, out int lineNumber))
            {
                MessageBox.Show("Номер строки должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lineNumber < 1 || lineNumber > files.Count)
            {
                MessageBox.Show($"Номер строки должен быть в диапазоне от 1 до {files.Count}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileController.RemoveRecordFromCsv(selectedFilePath, lineNumber);
            files.Remove(files[lineNumber - 1]);
            AddMessageToLog($"Из файла \"{Path.GetFileName(selectedFilePath)}\" была удалена строка под номером: {lineNumber}.");
            OutputData();
        }

        public void AddMessageToLog(string message)
        {
            log.AppendText($"{message}\n");
        }
    }
}
