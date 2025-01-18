using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratoryPractice.Controllers;
using LaboratoryPractice.Models;

namespace LaboratoryPractice.Views
{
    public partial class EditRecordForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly int _lineNumber;
        public EditRecordForm(MainForm mainForm, int lineNumber)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _lineNumber = lineNumber;
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            string address = this.address.Text;
            string accessMode = this.accessMode.Text;
            string accessDate = this.accessDate.Text;

            // Проверка на заполненность полей
            if (string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(accessMode) || string.IsNullOrWhiteSpace(accessDate))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileController.UpdateRecordInCsv(
                _mainForm.selectedFilePath,
                targetAddress: _mainForm.files[_lineNumber - 1].Address,
                address,
                accessMode,
                accessDate
            );
            _mainForm.files[_lineNumber - 1] = new Models.InfoModel(_mainForm.files[_lineNumber - 1].Id, address, accessMode, accessDate);
            _mainForm.AddMessageToLog($"Из файла \"{Path.GetFileName(_mainForm.selectedFilePath)}\" была изменена строка под номером: {_lineNumber}.");
            _mainForm.OutputData();

            this.Close();
        }
    }
}
