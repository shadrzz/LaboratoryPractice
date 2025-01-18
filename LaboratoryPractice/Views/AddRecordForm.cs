using LaboratoryPractice.Controllers;

namespace LaboratoryPractice.Views
{
    public partial class AddRecordForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly AddRecordFormController _controller;
        public AddRecordForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _controller = new AddRecordFormController();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
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

            // Вызов метода контроллера для добавления записи
            var isAdded = _controller.AddRecord(_mainForm.files, _mainForm.selectedFilePath, address, accessMode, accessDate);

            if (isAdded)
            {
                _mainForm.AddMessageToLog($"В файл \"{Path.GetFileName(_mainForm.selectedFilePath)}\" была добавлена запись.");
                _mainForm.OutputData();
                MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении записи. Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
