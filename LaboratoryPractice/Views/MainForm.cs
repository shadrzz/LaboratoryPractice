using System.Reflection;
using LaboratoryPractice.Views;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        private bool isAnalysisSuccessful = false; // Флаг для отслеживания состояния анализа

        public MainForm()
        {
            InitializeComponent();
        }

        private void lowLevelCalculate_Click(object sender, EventArgs e)
        {
            // Проверка первого числа
            if (!int.TryParse(inputLowLevelFirst.Text, out int a))
            {
                MessageBox.Show(
                    "Пожалуйста, введите корректное число в первое поле.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Проверка второго числа
            if (!int.TryParse(inputLowLevelSecond.Text, out int b))
            {
                MessageBox.Show(
                    "Пожалуйста, введите корректное число во второе поле.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Проверка деления на ноль
            if (b == 0)
            {
                MessageBox.Show(
                    "Деление на ноль невозможно. Пожалуйста, введите ненулевое значение во второе поле.",
                    "Ошибка деления",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Динамическая загрузка библиотеки
            Assembly asm = Assembly.LoadFrom("AsmFunc.dll");

            // Получение типа класса Func из библиотеки
            Type myType = asm.GetType("AsmFunc.Func", true);

            // Создание экземпляра класса Func
            object obj = Activator.CreateInstance(myType);

            // Получение метода Divide
            MethodInfo method = myType.GetMethod("Divide");

            // Вызов метода Divide с параметрами
            object result = method.Invoke(obj, new object[] { a, b });

            // Отображение результата
            outputLowLevelResult.Text = result.ToString();
        }

        private void analyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;

            try
            {
                // Проверка синтаксиса
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // Проверка на наличие синтаксических ошибок
                var diagnostics = syntaxTree.GetDiagnostics();
                if (diagnostics.Any())
                {
                    foreach (var diagnostic in diagnostics)
                    {
                        var lineSpan = diagnostic.Location.GetLineSpan();
                        int line = lineSpan.StartLinePosition.Line + 1; // Номер строки
                        string errorMessage = $"Номер строки {line}. Номер ошибки: {diagnostic.Id}, '{diagnostic.GetMessage()}'";
                        outputAnalyze.AppendText(errorMessage + Environment.NewLine);
                    }

                    isAnalysisSuccessful = false; // Если есть ошибки, анализ неуспешен
                    return;
                }

                // Проверка на наличие цикла while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show(
                        "Введите цикл while!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    isAnalysisSuccessful = false; // Если нет цикла while, анализ неуспешен
                    return;
                }

                // Если ошибок нет
                outputAnalyze.Text = "Ошибок не обнаружено";
                isAnalysisSuccessful = true; // Успешный анализ
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "Произошла ошибка анализа: " + ex.Message;
                isAnalysisSuccessful = false; // В случае исключения анализ неуспешен
            }
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            if (!isAnalysisSuccessful)
            {
                // Если анализ не был выполнен или есть ошибки
                MessageBox.Show(
                    "Пожалуйста, сначала выполните успешную сборку, нажав на кнопку 'Сборка'.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string userCode = inputAnalyze.Text;

            try
            {
                // Логика проверки выполнения цикла while (как в вашем коде)
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // Ищем цикл while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show(
                        "Введите цикл while!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Получаем условие цикла
                var condition = whileStatement.Condition.ToString();

                // Попробуем выполнить начальные действия и проверить условие
                var initialStatements = root.DescendantNodes().OfType<LocalDeclarationStatementSyntax>();
                Dictionary<string, int> variables = new Dictionary<string, int>();

                foreach (var statement in initialStatements)
                {
                    var declaration = statement.Declaration;
                    foreach (var variable in declaration.Variables)
                    {
                        // Парсим переменные вида "int i = 0;"
                        if (variable.Initializer != null && int.TryParse(variable.Initializer.Value.ToString(), out int value))
                        {
                            variables[variable.Identifier.Text] = value;
                        }
                    }
                }

                // Проверяем условие
                if (EvaluateCondition(condition, variables))
                {
                    MessageBox.Show(
                        "Цикл выполнится хотя бы раз.",
                        "Успешно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Цикл не выполнится ни разу.",
                        "Успешно",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Произошла ошибка анализа: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool EvaluateCondition(string condition, Dictionary<string, int> variables)
        {
            // Примитивный парсер условий для вида "i < 3"
            foreach (var variable in variables)
            {
                condition = condition.Replace(variable.Key, variable.Value.ToString());
            }

            try
            {
                // Выполняем условие с помощью DataTable
                var table = new System.Data.DataTable();
                var result = table.Compute(condition, string.Empty);
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false; // Если условие не удалось обработать
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
    }
}
