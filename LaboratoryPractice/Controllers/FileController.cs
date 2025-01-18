using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryPractice.Helpers;
using LaboratoryPractice.Models;

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

                List<Info> files = new List<Info>();

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

                    files.Add(new Info(fields[0], fields[1], fields[2]));
                }

                return FileProcessingResult.Success(files);
            }
            catch (Exception ex)
            {
                return FileProcessingResult.Fail($"Произошла ошибка при обработке файла: {ex.Message}");
            }
        }
    }
}
