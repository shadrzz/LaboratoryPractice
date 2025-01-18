using System.Reflection;
using System.Windows.Forms;
using LaboratoryPractice.Controllers;
using LaboratoryPractice.Models;
using LaboratoryPractice.Views;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        private bool isAnalysisSuccessful = false;
        private string selectedFilePath = string.Empty;
        private List<Models.Info> files = new List<Models.Info>();

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
        }

        private void buttonAnalyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;

            // Вызов метода контроллера для анализа кода
            var (isSuccessful, outputMessage) = CodeAnalysisController.AnalyzeCode(userCode);

            outputAnalyze.Text = outputMessage;
            isAnalysisSuccessful = isSuccessful;
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            if (!isAnalysisSuccessful)
            {
                // Если анализ не был выполнен или есть ошибки
                MessageBox.Show(
                    "Пожалуйста, сначала выполните успешную сборку, нажав на кнопку 'Сборка'.",
                    "Предупреждение",
                    MessageBoxButtons.OK,                    MessageBoxIcon.Warning
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
            Form addRecordForm = new AddRecord();
            addRecordForm.Show();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            Form editRecordForm = new EditRecord();
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
        }

        private void buttonOutputData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            data.Rows.Clear();

            foreach (var file in files)
            {
                data.Rows.Add(file.Address, file.AccessMode, file.AccessDate);
            }
        }
    }
}
