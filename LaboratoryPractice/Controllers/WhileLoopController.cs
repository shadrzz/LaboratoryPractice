using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class WhileLoopController
{
    public static (bool isValid, string message) CheckWhileLoop(string userCode)
    {
        try
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(userCode);
            var root = syntaxTree.GetRoot();

            // Ищем цикл while
            var whileStatement = root.DescendantNodes().OfType<WhileStatementSyntax>().FirstOrDefault();
            if (whileStatement == null)
            {
                return (false, "Введите цикл while!");
            }

            // Получаем условие цикла
            var condition = whileStatement.Condition.ToString();

            // Извлекаем переменные
            var initialStatements = root.DescendantNodes().OfType<LocalDeclarationStatementSyntax>();
            Dictionary<string, int> variables = new Dictionary<string, int>();

            foreach (var statement in initialStatements)
            {
                var declaration = statement.Declaration;
                foreach (var variable in declaration.Variables)
                {
                    if (variable.Initializer != null && int.TryParse(variable.Initializer.Value.ToString(), out int value))
                    {
                        variables[variable.Identifier.Text] = value;
                    }
                }
            }

            // Проверяем выполнение условия
            if (EvaluateCondition(condition, variables))
            {
                return (true, "Цикл выполнится хотя бы раз.");
            }
            else
            {
                return (true, "Цикл не выполнится ни разу.");
            }
        }
        catch (Exception ex)
        {
            return (false, "Произошла ошибка анализа: " + ex.Message);
        }
    }
    private static bool EvaluateCondition(string condition, Dictionary<string, int> variables)
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