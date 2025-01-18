using System.Reflection;

namespace LaboratoryPractice.Controllers
{
    public static class LowLevelCalculatorController
    {
        public static (bool isValid, string result, string errorMessage) Calculate(string inputFirst, string inputSecond)
        {
            // Проверка первого числа
            if (!int.TryParse(inputFirst, out int a))
            {
                return (false, null, "Пожалуйста, введите корректное число в первое поле.");
            }

            // Проверка второго числа
            if (!int.TryParse(inputSecond, out int b))
            {
                return (false, null, "Пожалуйста, введите корректное число во второе поле.");
            }

            // Проверка деления на ноль
            if (b == 0)
            {
                return (false, null, "Деление на ноль невозможно. Пожалуйста, введите ненулевое значение во второе поле.");
            }

            try
            {
                // Динамическая загрузка библиотеки
                Assembly asm = Assembly.LoadFrom("AsmFunc.dll");

                // Получение типа класса Func из библиотеки
                Type myType = asm.GetType("AsmFunc.Func", true);

                // Создание экземпляра класса Func
                object obj = Activator.CreateInstance(myType);

                // Получение метода Divide
                MethodInfo method = myType.GetMethod("Divide");

                // Вызов метода Divide с параметрами
                object divisionResult = method.Invoke(obj, new object[] { a, b });

                // Возврат результата
                return (true, divisionResult.ToString(), null);
            }
            catch (Exception ex)
            {
                return (false, null, $"Произошла ошибка при выполнении операции: {ex.Message}");
            }
        }
    }
}
