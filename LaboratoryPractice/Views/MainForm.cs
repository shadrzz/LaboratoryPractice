using System.Reflection;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LaboratoryPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lowLevelCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение входных значений
                int a = int.Parse(inputLowLevelFirst.Text);
                int b = int.Parse(inputLowLevelSecond.Text);
                MessageBox.Show($"{inputLowLevelFirst.Text}/{inputLowLevelSecond.Text}");

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
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void analyzeBuild_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;
            outputAnalyze.Clear();

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
                    return;
                }

                // Проверка на наличие цикла while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show("Введите цикл while!");
                    return;
                }

                // Если ошибок нет
                outputAnalyze.Text = "Ошибок не обнаружено";
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "Произошла ошибка анализа: " + ex.Message;
            }
        }

        private void buttonAnalyzeCheck_Click(object sender, EventArgs e)
        {
            string userCode = inputAnalyze.Text;
            outputAnalyze.Clear();

            try
            {
                // Парсим код в синтаксическое дерево
                var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
                var root = syntaxTree.GetRoot();

                // Ищем цикл while
                var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
                if (whileStatement == null)
                {
                    MessageBox.Show("Введите цикл while!");
                    return;
                }

                // Получаем условие цикла
                var condition = whileStatement.Condition.ToString();

                // Простая проверка на статичные значения
                if (condition == "true")
                {
                    outputAnalyze.Text = "Цикл выполнится бесконечно.";
                    return;
                }
                else if (condition == "false")
                {
                    outputAnalyze.Text = "Цикл не выполнится ни разу.";
                    return;
                }

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
                    outputAnalyze.Text = "Цикл выполнится хотя бы раз.";
                }
                else
                {
                    outputAnalyze.Text = "Цикл не выполнится ни разу.";
                }
            }
            catch (Exception ex)
            {
                outputAnalyze.Text = "Произошла ошибка анализа: " + ex.Message;
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
    }
}
