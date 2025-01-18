using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryPractice.Models;
using LaboratoryPractice.Helpers;

namespace LaboratoryPractice.Controllers
{
    public static class FileController
    {
        public static FileProcessingResult ProcessCsvFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0 || (lines.Length == 1 && string.IsNullOrWhiteSpace(lines[0])))
                {
                    return FileProcessingResult.Fail("Файл пустой или не содержит данных.");
                }

                List<Models.InfoModel> files = new List<Models.InfoModel>();

                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    var fields = line.Split(';').Select(field => field.Trim()).ToArray();

                    if (fields.Length != 3)
                    {
                        return FileProcessingResult.Fail($"Ошибка в строке {i + 1}: Ожидалось 3 поля, но найдено {fields.Length}.");
                    }

                    for (int j = 0; j < fields.Length; j++)
                    {
                        if (string.IsNullOrWhiteSpace(fields[j]))
                        {
                            return FileProcessingResult.Fail($"Ошибка в строке {i + 1}, поле {j + 1}: Поле пустое.");
                        }
                    }

                    files.Add(new Models.InfoModel(0, fields[0], fields[1], fields[2]));
                }

                return FileProcessingResult.Success(files);
            }
            catch (Exception ex)
            {
                return FileProcessingResult.Fail($"Произошла ошибка при обработке файла: {ex.Message}");
            }
        }

        public static void AddRecordToCsv(string filePath, string address, string accessMode, string accessDate)
        {
            try
            {
                // Проверяем, существует ли файл
                bool fileExists = File.Exists(filePath);

                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine();
                    // Записываем новую строку данных
                    writer.Write($"{address};{accessMode};{accessDate}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в CSV-файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateRecordInCsv(string filePath, string targetAddress, string newAddress, string newAccessMode, string newAccessDate)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Читаем все строки из файла
                var lines = File.ReadAllLines(filePath).ToList();

                // Обрабатываем строки после заголовков
                bool recordUpdated = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    var columns = lines[i].Split(';');
                    if (columns.Length >= 3 && columns[0] == targetAddress)
                    {
                        // Обновляем строку
                        lines[i] = $"{newAddress};{newAccessMode};{newAccessDate}";
                        recordUpdated = true;
                        break;
                    }
                }

                if (recordUpdated)
                {
                    // Перезаписываем файл с обновленными данными
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Запись успешно обновлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись с указанным адресом не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении CSV-файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveRecordFromCsv(string filePath, int lineNumber)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Чтение всех строк файла
                var lines = File.ReadAllLines(filePath).ToList();

                // Проверяем, входит ли номер строки в диапазон
                if (lineNumber < 1 || lineNumber > lines.Count)
                {
                    MessageBox.Show($"Номер строки должен быть в диапазоне от 1 до {lines.Count}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Удаляем строку с заданным номером
                lines.RemoveAt(lineNumber - 1);

                // Перезаписываем файл с обновлёнными данными
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Строка успешно удалена из файла CSV.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении строки из CSV-файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
