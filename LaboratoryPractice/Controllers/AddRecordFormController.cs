using LaboratoryPractice.Models;

namespace LaboratoryPractice.Controllers
{
    internal class AddRecordFormController
    {
        private readonly Random _random = new Random();
        public bool AddRecord(List<InfoModel> files, string selectedFilePath, string address, string accessMode, string accessDate)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Генерация уникального случайного ID
                    long newId;
                    do
                    {
                        newId = _random.Next(1, int.MaxValue); // Генерация ID в пределах допустимого диапазона
                    } while (context.Infos.Any(InfoModel => InfoModel.Id == newId)); // Проверка на уникальность ID

                    // Создание новой записи
                    var newRecord = new InfoModel(
                        newId,
                        address,
                        accessMode,
                        accessDate
                    );

                    // Добавление записи в базу данных
                    context.Infos.Add(newRecord);
                    context.SaveChanges(); // Сохранение изменений
                    FileController.AddRecordToCsv(selectedFilePath, address, accessMode, accessDate);
                    files.Add(newRecord);
                }
                return true;
            }
            catch (Exception ex)
            {
                // Логирование ошибки (если требуется)
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
        }
    }
}
