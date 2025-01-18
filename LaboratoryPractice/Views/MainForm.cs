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
            /// ��������� ������ �� ��������� �����
            string inputFirst = inputLowLevelFirst.Text;
            string inputSecond = inputLowLevelSecond.Text;

            // ����� ������ ����������� ��� ����������
            var (isValid, result, errorMessage) = LowLevelCalculatorController.Calculate(inputFirst, inputSecond);

            if (!isValid)
            {
                // ����������� ��������� �� ������
                MessageBox.Show(
                    errorMessage,
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ����������� ����������
            outputLowLevelResult.Text = result;
        }

        private void buttonAnalyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;

            // ����� ������ ����������� ��� ������� ����
            var (isSuccessful, outputMessage) = CodeAnalysisController.AnalyzeCode(userCode);

            outputAnalyze.Text = outputMessage;
            isAnalysisSuccessful = isSuccessful;
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            if (!isAnalysisSuccessful)
            {
                // ���� ������ �� ��� �������� ��� ���� ������
                MessageBox.Show(
                    "����������, ������� ��������� �������� ������, ����� �� ������ '������'.",
                    "��������������",
                    MessageBoxButtons.OK,                    MessageBoxIcon.Warning
                );
                return;
            }

            string userCode = inputAnalyze.Text;

            // ����� ������ ����������� ��� �������� ����� while
            var (isValid, message) = WhileLoopController.CheckWhileLoop(userCode);

            if (isValid)
            {
                MessageBox.Show(
                    message,
                    "��������� ��������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    message,
                    "������ ��������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void inputAnalyze_TextChanged(object sender, EventArgs e)
        {
            outputAnalyze.Clear();
            isAnalysisSuccessful = false; // ���������� ���� ��� ��������� ������
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
                        MessageBox.Show(result.ErrorMessage, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedFilePath = string.Empty;
                        return;
                    }

                    files = result.Files;

                    MessageBox.Show($"���� \"{Path.GetFileName(selectedFilePath)}\" ������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonOpenFileNotepad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("������� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start("notepad.exe", selectedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�� ������� ������� ����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutputData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("������� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
